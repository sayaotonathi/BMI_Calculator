using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class cHumanFactory
    {
        public cHuman getHuman(double height,double weight,int gender)
        {
            IBMIChecker bMIChecker =null;
            switch (gender)
            {
                case 1:
                    bMIChecker = new cMale();
                    break;
                case 0:
                    bMIChecker= new cFemale();
                    break;
            }
            return new cHuman(height, weight, bMIChecker);
        }
    }
}
