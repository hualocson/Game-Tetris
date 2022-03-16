using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGameTetris
{
    public partial class FGame : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        #region Properties
        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int[,] canvasDotArray;

        Bitmap workingBitmap;
        Graphics workingGraphics;

        Bitmap nextShapeBitmap;
        Graphics nextShapeGraphics;

        Shape currentShape;
        Shape nextShape;
        int currentX;
        int currentY;

        Timer timer;
        int score;
        int level;

        List<int> currentBag;

        public int Level { get => level; set => level = value; }
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
        #endregion

        #region Constructor
        public FGame()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            this.KeyPreview = true;
            this.KeyDown += FGame_KeyDown;
            timer = new Timer();
            timer.Interval = 300;
            timer.Tick += Timer_Tick;

            //set Font
            lbLevel.Font = lbNext.Font = lbScore.Font = new Font(Cons.newFont.Families[1], 24, FontStyle.Regular);
            btnMenu.Font = new Font(Cons.newFont.Families[0], 16, FontStyle.Regular);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var isMoveSuccess = moveShape(moveDown: 1);

            // if shape reached bottom or touched any other shapes
            if (!isMoveSuccess)
            {
                if (isGameOver())
                    return;

                // copy working image into canvas image
                canvasBitmap = new Bitmap(workingBitmap);

                updateCanvasDotArray();

                // get next shape
                currentShape = nextShape;
                nextShape = getNextShape();

                int rowsCount = countClearableRows();
                if (rowsCount != 0)
                {
                    this.score += calculateScore(rowsCount);
                    if (score >= 20 && score < 50)
                        updateLevel();
                    else if (score >= 50 && score < 100)
                        updateLevel();
                    else if (score >= 100 && score < 200)
                        updateLevel();
                    else if (score >= 200 && level >= 4)
                    {
                        updateLevel();
                        if (timer.Interval > 200)
                            timer.Interval -= rowsCount;
                    }
                    lbScore.Text = "Score: " + score;
                    sound.SoundLocation = Cons.ScoreSound;
                    sound.Play();
                    drawCanvas();
                }
            }
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            var verticalMove = 0;
            var horizontalMove = 0;

            //calculate the vertical and horizontal move values
            //based on the key pressed
            switch (e.KeyCode)
            {
                // move shape left
                case Keys.A:
                case Keys.Left:
                    sound.SoundLocation = Cons.HitBtnSound;
                    sound.Play();
                    if (timer.Enabled == false)
                        timer.Enabled = true;
                    verticalMove--;
                    break;

                // move shape right
                case Keys.D:
                case Keys.Right:
                    sound.SoundLocation = Cons.HitBtnSound;
                    sound.Play();
                    if (timer.Enabled == false)
                        timer.Enabled = true;
                    verticalMove++;
                    break;

                // move shape down faster
                case Keys.S:
                case Keys.Down:
                    sound.SoundLocation = Cons.HitBtnSound;
                    sound.Play();
                    if (timer.Enabled == false)
                        timer.Enabled = true;
                    horizontalMove++;
                    break;

                // rotate the shape clockwise
                case Keys.W:
                case Keys.Up:
                    sound.SoundLocation = Cons.TurnSound;
                    sound.Play();
                    if (timer.Enabled == false)
                        timer.Enabled = true;
                    currentShape.turn();
                    break;
                case Keys.P:
                    timer.Enabled = false;
                    //timer.Stop();
                    break;
                case Keys.O:
                    timer.Enabled = true;
                    //timer.Start();
                    break;
                default:
                    return;
            }

            var isMoveSuccess = moveShape(horizontalMove, verticalMove);

            // if the player was trying to rotate the shape, but
            // that move was not possible - rollback the shape
            if (!isMoveSuccess && (e.KeyCode == Keys.W || e.KeyCode == Keys.Up))
                currentShape.rollback();
        }
        #endregion

        #region Methods
        public void StartGame()
        {
            score = 0;
            loadCanvas();
            updateTimeInterval();
            timer.Start();

            lbLevel.Text = "Level: " + Level;
            lbScore.Text = "Score: " + score;
            currentBag = new List<int>();
            currentShape = getRandomCenterAlignShape();
            nextShape = getNextShape();
        }
        private void loadCanvas()
        {
            pctGameBoard.Height = Cons.canvasHeight * Cons.dotSize;
            pctGameBoard.Width = Cons.canvasWidth * Cons.dotSize;
            // Create Bitmap with gameboard's size
            canvasBitmap = new Bitmap(pctGameBoard.Width, pctGameBoard.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);

            // Initialize canvas dot array. by default all elements are zero
            canvasDotArray = new int[Cons.canvasWidth, Cons.canvasHeight];
            drawCanvas();
        }

        // returns if it reaches the bottom or touches any other blocks
        private bool moveShape(int moveDown = 0, int moveSide = 0)
        {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            // check if it reaches the bottom or side bar
            if (newX < 0 || newX + currentShape.Width > Cons.canvasWidth
                || newY + currentShape.Height > Cons.canvasHeight)
                return false;

            // check if it touches any other blocks 
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] != 0 && currentShape.Dots[j, i] != 0)
                        return false;
                }
            }

            currentX = newX;
            currentY = newY;

            drawShape();

            return true;
        }

        #region Get Shape
        private Shape getRandomCenterAlignShape()
        {

            if (currentBag.Count == 0 || currentBag == null)
                currentBag = ShapeManager.generateBag();

            var indexShape = currentBag[0];
            currentBag.RemoveAt(0);
            var shape = ShapeManager.GetRandomShape(indexShape);

            // Calculate the x and y values as if the shape lies in the center
            if (currentShape != null)
            {
                currentX = currentShape.ShapeX;
                currentY = currentShape.ShapeY;
            }

            return shape;
        }

        private Shape getNextShape()
        {
            var shape = getRandomCenterAlignShape();
            drawNextShape(shape);
            return shape;
        }
        #endregion

        #region Draw
        private void drawCanvas()
        {
            SolidBrush myBrush = new SolidBrush(ThemeColor.PrimaryColor);
            canvasGraphics = Graphics.FromImage(canvasBitmap);

            // Draw panel based on the updated array values
            for (int i = 0; i < Cons.canvasWidth; i++)
            {
                for (int j = 0; j < Cons.canvasHeight; j++)
                {
                    if (canvasDotArray[i, j] != 0)
                    {
                        myBrush.Color = ColorTranslator.FromHtml(ThemeColor.ShapeColor[canvasDotArray[i, j] - 1]);
                        canvasGraphics.FillRectangle(myBrush,
                                                     i * Cons.dotSize,
                                                     j * Cons.dotSize,
                                                     Cons.dotSize,
                                                     Cons.dotSize);

                        //Draw Border
                        canvasGraphics.DrawRectangle(new Pen(ThemeColor.PrimaryColor, 2),
                                                        i * Cons.dotSize + 1,
                                                        j * Cons.dotSize + 1,
                                                        Cons.dotSize - 2,
                                                        Cons.dotSize - 2);
                    }
                    else
                    {
                        myBrush.Color = ThemeColor.PrimaryColor;
                        canvasGraphics.FillRectangle(myBrush,
                                                     i * Cons.dotSize,
                                                     j * Cons.dotSize,
                                                     Cons.dotSize,
                                                     Cons.dotSize);
                    }

                }
            }

            pctGameBoard.Image = canvasBitmap;
        }

        private void drawShape()
        {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            SolidBrush myBrush = new SolidBrush(ThemeColor.PrimaryColor);

            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Dots[j, i] != 0)
                    {
                        myBrush.Color = ColorTranslator.FromHtml(ThemeColor.ShapeColor[currentShape.Dots[j, i] - 1]);
                        workingGraphics.FillRectangle(myBrush,
                                                      (currentX + i) * Cons.dotSize,
                                                      (currentY + j) * Cons.dotSize,
                                                      Cons.dotSize,
                                                      Cons.dotSize);
                        workingGraphics.DrawRectangle(new Pen(ThemeColor.PrimaryColor, 2),
                                                      (currentX + i) * Cons.dotSize + 1,
                                                      (currentY + j) * Cons.dotSize + 1,
                                                      Cons.dotSize - 2,
                                                      Cons.dotSize - 2);
                    }
                }
            }
            pctGameBoard.Image = workingBitmap;
        }

        private void drawNextShape(Shape shape)
        {
            // Codes to show the next shape in the side panel
            nextShapeBitmap = new Bitmap(6 * Cons.dotSize, 6 * Cons.dotSize);
            nextShapeGraphics = Graphics.FromImage(nextShapeBitmap);

            SolidBrush myBrush = new SolidBrush(ThemeColor.PrimaryColor);
            nextShapeGraphics.FillRectangle(myBrush, 0, 0, nextShapeBitmap.Width, nextShapeBitmap.Height);

            // Find the ideal position for the shape in the side panel
            var startX = (6 - shape.Width) / 2;
            var startY = (6 - shape.Height) / 2;

            for (int i = 0; i < shape.Height; i++)
            {
                for (int j = 0; j < shape.Width; j++)
                {
                    if (shape.Dots[i, j] != 0)
                    {
                        myBrush.Color = ColorTranslator.FromHtml(ThemeColor.ShapeColor[shape.Dots[i, j] - 1]);
                        nextShapeGraphics.FillRectangle(myBrush,
                                                    (startX + j) * Cons.dotSize,
                                                    (startY + i) * Cons.dotSize,
                                                    Cons.dotSize,
                                                    Cons.dotSize);
                        //Draw Border
                        nextShapeGraphics.DrawRectangle(new Pen(ThemeColor.PrimaryColor, 2),
                                                        (startX + j) * Cons.dotSize + 1,
                                                        (startY + i) * Cons.dotSize + 1,
                                                        Cons.dotSize - 2,
                                                        Cons.dotSize - 2);
                    }
                }
            }

            pctNextShape.Size = nextShapeBitmap.Size;
            pctNextShape.Image = nextShapeBitmap;
        }
        #endregion

        private void updateCanvasDotArray()
        {
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Dots[j, i] != 0)
                    {
                        canvasDotArray[currentX + i, currentY + j] = currentShape.Dots[j, i];
                    }
                }
            }
        }

        private bool isGameOver()
        {
            if (currentY < 0)
            {
                timer.Stop();
                sound.SoundLocation = Cons.GameOverSound;
                sound.Play();
                FMainMenu.UpdateState(true, false, false, true);
                FNotify messBox = new FNotify("Game Over", "Main Menu", "Play Again");
                messBox.ShowDialog();
                if (messBox.isOK)
                {
                    FMainMenu.UpdateState(false, false, false, true);
                    this.Close();
                }
                else
                {
                    level = 0;
                    FMainMenu.UpdateState(true, false, true, true);
                    StartGame();
                }
                return true;
            }
            return false;
        }

        #region Clear And Score
        private int calculateScore(int rowsCount)
        {
            return ((rowsCount * (rowsCount + 1)) / 2) * (Level + 1);
        }

        private int countClearableRows()
        {
            int rowsCount = 0;
            for (int i = 0; i < Cons.canvasHeight; i++)
            {
                int j;
                for (j = Cons.canvasWidth - 1; j >= 0; j--)
                {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1)
                {
                    rowsCount++;
                    if (Level >= 4 && timer.Interval >= 100)
                    {
                        timer.Interval -= 10;
                    }
                    // update the dot array based on the check
                    for (j = 0; j < Cons.canvasWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }

                        canvasDotArray[j, 0] = 0;
                    }
                }
            }
            return rowsCount;
        }
        #endregion

        #region Level
        private void updateTimeInterval()
        {
            switch (Level)
            {
                case 0:
                    timer.Interval = 800;
                    break;
                case 1:
                    timer.Interval = 750;
                    break;
                case 2:
                    timer.Interval = 700;
                    break;
                case 3:
                    timer.Interval = 600;
                    break;
                case 4:
                    timer.Interval = 500;
                    break;
                default:
                    if (timer.Interval >= 300)
                        timer.Interval = 300;
                    break;
            }
        }

        private void updateLevel()
        {
            if (Level < 5)
            {
                sound.SoundLocation = Cons.LevelUpSound;
                sound.PlaySync();
                Level++;
                lbLevel.Text = "Level: " + Level;
                updateTimeInterval();
            }
        }
        #endregion
        
        #endregion end Methods

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FMainMenu.UpdateState(false, false, false, true);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            sound.Stop();
            this.Hide();
            FMainMenu.UpdateState(false, FMainMenu.isPlayingGame, false, true);
        }
    }
}
