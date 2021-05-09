using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class cHuman
    {
        private iBMIChecker bmiChecker;
        public cHuman(double _height, double _weight,iBMIChecker _bmiChecker)
        {
            this.Height = _height;
            this.Weight = _weight;
            this.bmiChecker = _bmiChecker;
        }
        public double Height { get; set; } //身高
        public double Weight { get; set; } //體重
        //計算BMI
        public double CalCulateBMI() 
        {
            return Weight / Math.Pow(Height / 100, 2);
        }
        //檢查BMI範圍
        public string CheckBMI() 
        {
            return bmiChecker.CheckBMI(CalCulateBMI());
        }
    }
    public class cMale : iBMIChecker
    {
        public string CheckBMI(double bmi)
        {
            return cUtilities.CheckBMI(bmi, 20, 25);
        }
    }
    public class cFemale : iBMIChecker
    {
        public string CheckBMI(double bmi)
        {
            return cUtilities.CheckBMI(bmi, 18, 22);
        }
    }
}
