using System;
using System.Text;
namespace lab2_1
{
    public partial class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix(MyMatrix previousMatrix)
        {
            matrix = (double[,])previousMatrix.matrix.Clone();
        }

        public MyMatrix(double[,] array)
        {
            matrix = (double[,])array.Clone();
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

        public MyMatrix(string row) : this(row.Split("\n", StringSplitOptions.RemoveEmptyEntries))
        {
            //new MyMatrix(row.Split("\n", StringSplitOptions.RemoveEmptyEntries));
        }

        public int Heigth
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int Width
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int getHeight()
        {
            return matrix.GetLength(0);
        }


        public int getWidth()
        {
            return matrix.GetLength(1);
        }

        public double this[int i, int j]
        {
            get
            {
                return this.matrix[i, j];
            }
            set
            {
                if (value <= double.MaxValue && value >= double.MinValue)
                    this.matrix[i, j] = value;
            }
        }

        public double getElement(int i, int j)
        {
            return matrix[i, j];
        }

        public void setElement(int i, int j, double value)
        {
            if (value <= double.MaxValue && value >= double.MinValue)
                matrix[i, j] = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j]}/t");
                }
                sb.Append("/n");
            }
            return sb.ToString();
        }
           
    }
}

