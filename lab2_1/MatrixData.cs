using System;
namespace lab2_1
{
    public partial class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix(MyMatrix previousMatrix)
        {
            matrix = previousMatrix.matrix;
        }

        public MyMatrix(double[,] array)
        {
            matrix = array;
        }

        public MyMatrix(double[][] jaggedArray)
        {

            int height = jaggedArray.GetLength(0);
            int width = jaggedArray[0].Length;

            for (int l = 1; l < height; l++)
            {
                if (jaggedArray[l].Length != width)
                {
                    throw new Exception("Array is not rectangular.");
                }
            }

            matrix = new double[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = jaggedArray[i][j];
                }
            }
        }

        public MyMatrix(string[] rows) : this(Array.ConvertAll(rows, s =>
        Array.ConvertAll(s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries), double.Parse)))
        {
            /*for (int i = 0; i < rows.Length; i++)
             {
                 int[] data = Array.ConvertAll(rows[i].Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries),double.Parse);
                 for (int j = 0; j < rows[i].Length; j++)
                 {
                     matrix[i, j] = data[j];
                 }
             }*/
        }

        public MyMatrix(string row)
        {
            new MyMatrix(row.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
        }


    }
}

