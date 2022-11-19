using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    internal static class math
    {
        public static double ExpFunc(double val)
        {
            double tmp = 2.72;
            for(int i=0;i<val-1;i++)
            {
                tmp = tmp * 2.72;
            }
            return tmp;
        }
        public static double  ArcSin(double val)
        {
            return Math.Asin(val);
        }

        public static double Distance(Point a , Point b)
        {
            double dist = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
            return dist;
        }
        public static void TranspMatrix(ref int[,] arr1)
        {
            int[,] arrTmp = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)
                {
                    arrTmp[j,i] = arr1[i,j];
                }
            }
            arr1= arrTmp;
        }
    }  
}
