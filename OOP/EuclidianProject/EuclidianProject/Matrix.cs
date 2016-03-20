namespace EuclidianProject
{
    using System;
    using System.Collections.Generic;

    [VersionAttribute("2","8")]

    public class Matrix<T>//task 8
    {
        
        private T[,] matrix; //task 8
        private int rows;
        private int cols;

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (rows < 0 )
                {
                    throw new ArgumentException("Rows of matrix cannot be less than zero");
                }
                this.rows = value;
            }

        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (cols < 0 )
                {
                    throw new ArgumentException("Rows of matrix cannot be less than zero");
                }
                this.cols = value;
            }
        }

        private void Indexing(int row,int col)
        {
            if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Index you are trying to access is out of range!");
            }
        }

        public T this[int row,int col] ///indexer task 9
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        public Matrix(int row,int col)
        {
            if (row <= 0 || col <= 0)
            {
                throw new ArgumentException("Rols and cols of matrix cannot be equal to or less than Zero");
            }
            this.matrix = new T[this.Rows=row, this.Cols = col];


        }

        public static Matrix<T> operator +(Matrix<T> first,Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Matrices are not equal!");
            }
            var matrix = new Matrix<T>(first.Rows, second.Cols);

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < second.Cols; j++)
                {
                    dynamic firstTempValue = first[i, j];
                    dynamic secondTempValue = second[i, j];
                    matrix[i, j] = firstTempValue + secondTempValue;
                }
            }
            return matrix;
        } //task 10

        public static Matrix<T> operator -(Matrix<T> first,Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Matrices are not equal!");
            }
            var matrix = new Matrix<T>(first.Rows, second.Cols);
            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < second.Cols; j++)
                {
                    dynamic firstTempValue = first[i, j];
                    dynamic secondTempValue = second[i, j];
                    matrix[i, j] = firstTempValue - secondTempValue;
                }
            }
            return matrix;

        } // task 10

        public static Matrix<T> operator *(Matrix<T> first,Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Matrices are not equal!");
            }
            var matrix = new Matrix<T>(first.Rows, second.Cols);
            T tempValue;
            tempValue = (dynamic)0;
            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0;  j < second.Cols;  j++)
                {
                    for (int k = 0; k < first.Cols; k++)
                    {
                        dynamic firstValue = first[i, k];
                        dynamic secondValue = second[k, j];
                        tempValue += firstValue * secondValue;
                    }
                    matrix[i, j] = (dynamic)tempValue;
                }
            }
            return matrix;

        }//task 10

        public static bool operator true(Matrix<T> first)
        {
            bool containZero = false;

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    if (first[i,j].Equals(default(T)))
                    {
                        containZero = true;
                        break;
                    }   
                }
            }


            return containZero;

        }//task 10

        public static bool operator false(Matrix<T> first)
        {
            bool containZero = true;

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    if (first[i,j].Equals(default(T)))
                    {
                        containZero = false;
                    }
                    else
                    {
                        containZero = true;
                    }
                }
            }

            return containZero;


        }//task 10




    }
}





