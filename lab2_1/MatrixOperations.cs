using System;
namespace lab2_1
{
	public partial class MyMatrix
    {
		public static MyMatrix operator +(MyMatrix m1, MyMatrix m2)
		{
			if (m1.getHeight() == m2.getHeight() && m1.getWidth() == m2.getWidth())
			{
				MyMatrix res = new MyMatrix();
				res.matrix = new double[m1.getHeight(), m1.getWidth()];
				for (int i = 0; i < m1.getHeight(); i++)
				{
					for (int j = 0; j < m1.getWidth(); j++)
					{
						res[i, j] = m1[i, j] + m2[i, j];
					}
				}
				return res;
			}
            throw new Exception("Matrices aren't the same sizes.");
        }

        public static MyMatrix operator *(MyMatrix m1, MyMatrix m2)
        {
            if (m1.getWidth() == m2.getHeight())
            {
                MyMatrix res = new MyMatrix();
                res.matrix = new double[m1.getWidth(), m2.getHeight()];
                for (int i = 0; i < m1.getHeight(); i++)
                {
                    for (int j = 0; j < m2.getWidth(); j++)
                    {
                        res[i, j] = 0;
                        for (int l = 0; l < m1.getWidth(); l++)
                        {
                            res[i, j] += m1[i, l] * m2[l, j];
                        }
                    }
                }
                return res;
            }
            throw new Exception("Impossible.");
        }

        private double[,] GetTransponedArray()
        {
            double[,] transp = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transp[j, i] = matrix[i, j];
                }
            }
            return transp;
        }

        private MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(GetTransponedCopy());
        }

        public void TransponeMe()
        {
            this.matrix = GetTransponedArray();
        }
    }
}

