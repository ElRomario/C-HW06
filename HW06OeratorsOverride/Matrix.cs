using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06OeratorsOverride
{
    internal class Matrix
    {

        private int[,] arr;
        public Matrix(int[,] arr)
        {
            this.arr = arr;
        }
        public int[,] Arr
        {
            get => arr;
        }
        static public Matrix operator +(Matrix a, Matrix b)
        {
            int[,] aArr = new int[a.arr.GetLength(0), a.arr.GetLength(1)];
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    aArr[i, j] = a.arr[i, j] + b.arr[i, j];
                }
            }
            Matrix sum_matrix = new Matrix(aArr);
            return sum_matrix;
        }

        static public Matrix operator -(Matrix a, Matrix b)
        {
            int[,] aArr = new int[a.arr.GetLength(0), a.arr.GetLength(1)];
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    aArr[i, j] = a.arr[i, j] - b.arr[i, j];
                }
            }
            Matrix minus_matrix = new Matrix(aArr);
            return minus_matrix;
        }

        static public Matrix operator --(Matrix a)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    a.arr[i, j] = a.arr[i, j] * -1;
                }
            }
            Matrix minus_matrix = new Matrix(a.arr);
            return minus_matrix;
        }

        static public Matrix operator *(Matrix a, int b)
        {
            int[,] aArr = new int[a.arr.GetLength(0), a.arr.GetLength(1)];
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    aArr[i, j] = a.arr[i, j] * b;
                }
            }
            Matrix multy_matrix = new Matrix(aArr);
            return multy_matrix;
        }

        static public Matrix operator *(Matrix a, Matrix b)
        {
            int[,] aArr = new int[a.arr.GetLength(0), a.arr.GetLength(1)];
            for (var i = 0; i < a.arr.GetLength(0); i++)
            {
                for (var j = 0; j < b.arr.GetLength(1); j++)
                {
                    aArr[i, j] = 0;

                    for (var k = 0; k < a.arr.GetLength(1); k++)
                    {
                        aArr[i, j] += a.arr[i, k] * b.arr[k, j];
                    }
                }
            }
            Matrix multy_matrix = new Matrix(aArr);
            return multy_matrix;
        }

        public void Show()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }

}

