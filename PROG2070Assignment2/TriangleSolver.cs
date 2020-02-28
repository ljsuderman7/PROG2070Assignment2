using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int firstDimension, int secondDimension, int thirdDimension)
        {
            string triangleType = "";

            if (firstDimension + secondDimension < thirdDimension ||
                    thirdDimension + secondDimension < firstDimension ||
                    firstDimension + thirdDimension < secondDimension)
            {
                triangleType = "Those Dimensions don't form a valid triangle";
            }
            else if (firstDimension == secondDimension && firstDimension == thirdDimension && thirdDimension == secondDimension)
            {
                triangleType = "Equilateral";
            }
            else if (firstDimension == secondDimension || firstDimension == thirdDimension || secondDimension == thirdDimension)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            return triangleType;
        }
    }
}
