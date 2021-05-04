using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public static class cUtilities
    {
        //BMI計算公式
        public static double CalculateBMI(double height, double weight)
        {
            return weight / Math.Pow((height / 100), 2);
        }
        //BMI範圍判斷
        public static string CheckBMI(double bmi,int min,int max)
        {
            if (bmi < min)
            {
                return "太瘦";
            }
            else if (bmi > max)
            {
                return "太胖";
            }
            else
            {
                return "適中";
            }
        }
    }
}
