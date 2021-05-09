using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            double height = (double)nud_Height.Value; //身高轉double
            double weight = (double)nud_Weight.Value; //體重轉double
            int gender = int.Parse(pnl_Gender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString()); //1:男 0:女
            string result = "";
            double bmi;
            #region 身高體重為0防呆
            if (height == 0)
            {
                MessageBox.Show("請輸入身高");
                return;
            }
            if (weight == 0)
            {
                MessageBox.Show("請輸入體重");
                return;
            }
            #endregion

            bmi = cUtilities.CalculateBMI(height, weight); //計算BMI

            //依據性別判斷BMI
            switch (gender)
            {
                case 1:
                    result = cUtilities.CheckBMI(bmi, 20, 25);
                    break;
                case 0:
                    result = cUtilities.CheckBMI(bmi, 18, 22);
                    break;
            }
            //修改畫面顯示結果
            lbl_BMI_Show.Text = bmi.ToString();
            lbl_Result_Show.Text = result;

        }

        private void btn_Clac2_Click(object sender, EventArgs e)
        {
            double height = (double)nud_Height.Value; //身高轉double
            double weight = (double)nud_Weight.Value; //體重轉double
            int gender = int.Parse(pnl_Gender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString()); //1:男 0:女
            #region 身高體重為0防呆
            if (height == 0)
            {
                MessageBox.Show("請輸入身高");
                return;
            }
            if (weight == 0)
            {
                MessageBox.Show("請輸入體重");
                return;
            }
            #endregion

            //取得human實體
            cHuman human = (new cHumanFactory()).getHuman(height, weight, gender);

            //修改畫面顯示結果
            lbl_BMI_Show.Text = human.CalCulateBMI().ToString();
            lbl_Result_Show.Text = human.CheckBMI();
        }
    }
}
