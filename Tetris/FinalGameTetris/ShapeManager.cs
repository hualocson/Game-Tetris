using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGameTetris
{
    class ShapeManager
    {
        private static Shape[] shapesArray;

        // static constructor : No need to manually initialize
        static ShapeManager()
        {
            // Create shapes add into the array.
            shapesArray = new Shape[]
                {
                    new Shape {
                        Width = 2,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Shape {
                        Width = 4,
                        Height = 1,
                        Dots = new int[,]
                        {
                            { 2, 2, 2, 2}
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 3, 0 },
                            { 3, 3, 3 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 0, 4 },
                            { 4, 4, 4 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 5, 0, 0 },
                            { 5, 5, 5 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 6, 6, 0 },
                            { 0, 6, 6 }
                        }
                    },
                    new Shape {
                        Width = 3,
                        Height = 2,
                        Dots = new int[,]
                        {
                            { 0, 7, 7 },
                            { 7, 7, 0 }
                        }
                    }
                };
        }
        private static void Shuffle(List<int> array)
        {
            Random rng = new Random();   // i.e., Java.util.Random.
            int n = array.Count;        // The number of items left to shuffle (loop invariant).
            while (n > 1)
            {
                int k = rng.Next(n);  // 0 <= k < n.
                n--;                     // n is now the last pertinent index;
                int temp = array[n];     // swap array[n] with array[k] (does nothing if k == n).
                array[n] = array[k];
                array[k] = temp;
            }
        }

        // Get a shape form the array in a random basis
        public static Shape GetRandomShape(int index)
        {
            var shape = shapesArray[index];
            Random rad = new Random();
            int turn = rad.Next(4);
            for (int i = 0; i < turn; i++)
                shape.turn();
            //Align Shape to Center
            shape.ShapeX = (Cons.canvasWidth - shape.Width) / 2;
            shape.ShapeY = -shape.Height;
            return shape;
        }

        public static List<int> generateBag()
        {
            List<int> arrIndex = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            Random random = new Random();
            arrIndex.Add(random.Next(7));
            arrIndex.Add(random.Next(7));
            Shuffle(arrIndex);
            return arrIndex;
        }
    }
}