using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Lab1
{
    static class Matrixes
    {
        static public Complex[,] Summ(Complex[,] target1, Complex[,] target2)
        {
            int Size11 = target1.GetUpperBound(0) + 1, Size12 = target1.GetUpperBound(1) + 1, Size21 = target2.GetUpperBound(0) + 1, Size22 = target2.GetUpperBound(1) + 1;
            if (Size11 != Size21 || Size22 != Size12)
            {
                throw new Exception("Shit");
            }
            int i, j;
            Complex[,] result = new Complex[Size11, Size12];
            for (i = 0; i < Size11; i++)
            {
                for (j = 0; j < Size11; j++)
                {
                    result[i, j] = target1[i, j] + target2[i, j];
                }
            }
            return result;
        }

         static public Complex[,] Subs(Complex[,] target1, Complex[,] target2)
        {
            return (Summ(target1, MultByNumber(target2, -1)));
        }

        public static void DivString(Complex[][] target, int number, Complex Tar)
        {
            for (int i = 0; i < target[0].Length; i++)
            {
                target[number][i] *= 1.0 / (Tar);
            }
        }

        public static  void SwapString(Complex[][] target, int number1, int number2)
        {
            Complex c;
            for (int i = 0; i < target[0].Length; i++)
            {
                c = target[number1][i];
                target[number1][i] = target[number2][i];
                target[number2][i] = c;
            }
        }

        public static void SubString(Complex[][] target, int number1, int number2, Complex Mult)
        {
            for (int i = 0; i < target[0].Length; i++)
            {
                target[number1][i] -= Mult * target[number2][i];
            }
        }

        public static Complex GetDet(Complex[][] target)
        {
            Complex[][] temp = new Complex[target.Length][];
            int i, j;
            for (i = 0; i < target.Length; i++)
            {
                temp[i] = new Complex[target.Length];
            }
            for (i = 0; i < target.Length; i++)
            {
                for (j = 0; j < target.Length; j++)
                {
                    temp[i][j] = target[i][j];
                }
            }
                //pryamoi hod
                for (i = 0; i < temp.Length; i++)
                {
                    if (temp[i][i] == 0)
                    {
                        j = i + 1;
                        for (; j < temp.Length; j++)
                        {
                            if (temp[j][i] != 0)
                            {
                                SwapString(temp, j, i);
                                break;
                            }
                        }
                        if (j == temp.Length)
                        {
                            return 0;
                        }
                    }
                    // DivString(temp, i, temp[i][i]);
                    for (j = i + 1; j < temp.Length; j++)
                    {
                        SubString(temp, j, i, temp[j][i] / temp[i][i]);
                    }
                }
            //obratnii
            for (i = temp.Length - 1; i >= 0; i--)
            {
                for (j = i - 1; j >= 0; j--)
                {
                    SubString(temp, j, i, temp[j][i] / temp[i][i]);
                }
            }
            Complex result = 1;
            for (i = 0; i < temp.Length; i++)
            {
                result *= temp[i][i];
            }
            return result;
        }
        /// <summary>
        /// Умножает две матрицы
        /// </summary>
        /// <param name="target1">Первая матрица, размер Size1хSize3</param>
        /// <param name="target2">Втоаря матрица, размер Size3хSize2</param>
        /// <param name="Size1">Высота первой матрицы</param>
        /// <param name="Size2">Ширина второй матрицы</param>
        /// <param name="Size3">Ширина первой матрицы = высота второй</param>
        /// <returns></returns>
        public static Complex[,] Multiply(Complex[,] target1, Complex[,] target2)
        {
            Complex sum = 0;
            int Size3 = target2.GetUpperBound(0)+1;
            int Size1 = target1.GetUpperBound(0)+1;
            int Size2 = (int)(((double)target2.Length) / Size3); 
            Complex[,] result = new Complex[Size1, Size2];
            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size2; j++)
                {
                    sum = 0;
                    for (int k = 0; k < Size3; k++)
                    {
                        sum += target1[i,k] * target2[k,j];
                    }
                    //result[i][j] = sum;
                    result[i,j] = sum;
                }
            }
            return result;
        }

        public static Complex[,] MultByNumber(Complex[,] target,Complex num)
        {
            int Length1 = target.GetUpperBound(0) + 1;
            int Length2 = target.GetUpperBound(1) + 1;
            int i, j;
            Complex[,] result = new Complex[Length1,Length2];
            for (i = 0; i < Length1; i++)
            {
                for (j = 0; j < Length1; j++)
                {
                    result[i, j] = target[i, j] * num;
                }
            }
            return result;
        }

        public static Complex[,] GetReverse(Complex[,] target)
        {
            int Length = target.GetUpperBound(0) + 1;
            Complex[][] matrix = new Complex[Length][];
            for (int i = 0; i < Length; i++)
            {
                matrix[i] = new Complex[2 * Length];
            }
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        matrix[i][j] = (target[i,j]);
                    }
                }
            for (int i = 0; i < Length; i++)
            {
                matrix[i][i + Length] = 1;
            }
            Complex[] x = new Complex[Length];
            //pryamoi hod
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][i] == 0)
                {
                    int j = i + 1;
                    for (; j < matrix.Length; j++)
                    {
                        if (matrix[j][i] != 0)
                        {
                            SwapString(matrix, j, i);
                            //apString(matrixres, j, i);
                            break;
                        }
                    }
                    if (j == matrix.Length)
                    {
                        return new Complex[0, 0];
                    }
                }
                //DivString(matrixres, i, matrix[i][i]);
                DivString(matrix, i, matrix[i][i]);
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    //SubString(matrixres, matrix, j, i, matrix[j][i]);
                    SubString(matrix, j, i, matrix[j][i]);
                }
            }
            //obratnii
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    //SubString(matrixres, matrix, j, i, matrix[j][i]);
                    SubString(matrix, j, i, matrix[j][i]);
                }
            }

            Complex[,] result = new Complex[Length, Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    result[i,j] = matrix[i][j + matrix.Length];//Math.Round()???
                }
            }
            return result;
        }

        public static Complex[,] GetTransp(Complex[,] target, int Length1, int Length2)
        {
            Complex[,] result = new Complex[Length2, Length1];
            int i, j;
            for (i = 0; i < Length1; i++)
            {
                for (j = 0; j < Length2; j++)
                {
                    result[j, i] = target[i, j];
                }
            }
            return result;
        }

        public static Complex[][] GetMinor(Complex[][] target, int n1, int n2)
        {
            Complex[][] result = new Complex[target.Length-1][];
            int i, j;
            for (i = 0; i < target.Length-1; i++)
            {
                result[i] = new Complex[target.Length-1];
            }
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    result[i][j] = target[i][j];
                }
                for (j = n2 + 1; j < target.Length; j++)
                {
                    result[i][j-1] = target[i][j];
                }
            }
            for (i = n1+1; i < target.Length; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    result[i-1][j] = target[i][j];
                }
                for (j = n2 + 1; j < target.Length; j++)
                {
                    result[i-1][j - 1] = target[i][j];
                }
            }
            return result;
        }

        internal static int Multiply(Complex[,] p, int p_2, int DimNum, int DimNum_2)
        {
            throw new NotImplementedException();
        }

        public static Complex[,] TensorMult(Complex[,] target1, Complex[,] target2)
        {
            int i, j, k, l;
            int Size11 = target1.GetUpperBound(0) + 1, Size12 = target1.GetUpperBound(1) + 1, Size21 = target2.GetUpperBound(0) + 1, Size22 = target2.GetUpperBound(1) + 1;
            Complex[,] result = new Complex[Size11 * Size21, Size12 * Size22];
            for (i = 0; i < Size11; i++)
            {
                for (j = 0; j < Size12; j++)
                {
                    for (k = 0; k < Size21; k++)
                    {
                        for (l = 0; l < Size22; l++)
                        {
                            result[i * Size21 + k, j*Size22+l] = target1[i, j] * target2[k, l];
                        }
                    }
                }
            }
            return result;
        }
    }
}
