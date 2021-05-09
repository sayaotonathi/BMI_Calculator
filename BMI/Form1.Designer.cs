
namespace BMI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calc = new System.Windows.Forms.Button();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_BMI = new System.Windows.Forms.Label();
            this.lbl_BMI_Show = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_Result_Show = new System.Windows.Forms.Label();
            this.lbl_CM = new System.Windows.Forms.Label();
            this.lbl_KG = new System.Windows.Forms.Label();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.nud_Weight = new System.Windows.Forms.NumericUpDown();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.pnl_Gender = new System.Windows.Forms.Panel();
            this.btn_Clac2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Weight)).BeginInit();
            this.pnl_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(187, 317);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 0;
            this.btn_Calc.Text = "計算";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(74, 82);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(29, 12);
            this.lbl_Gender.TabIndex = 1;
            this.lbl_Gender.Text = "性別";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(74, 138);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(29, 12);
            this.lbl_Height.TabIndex = 2;
            this.lbl_Height.Text = "身高";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Location = new System.Drawing.Point(74, 183);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(29, 12);
            this.lbl_Weight.TabIndex = 3;
            this.lbl_Weight.Text = "體重";
            // 
            // lbl_BMI
            // 
            this.lbl_BMI.AutoSize = true;
            this.lbl_BMI.Location = new System.Drawing.Point(74, 230);
            this.lbl_BMI.Name = "lbl_BMI";
            this.lbl_BMI.Size = new System.Drawing.Size(39, 12);
            this.lbl_BMI.TabIndex = 4;
            this.lbl_BMI.Text = "BMI：";
            // 
            // lbl_BMI_Show
            // 
            this.lbl_BMI_Show.AutoSize = true;
            this.lbl_BMI_Show.Location = new System.Drawing.Point(135, 230);
            this.lbl_BMI_Show.Name = "lbl_BMI_Show";
            this.lbl_BMI_Show.Size = new System.Drawing.Size(11, 12);
            this.lbl_BMI_Show.TabIndex = 5;
            this.lbl_BMI_Show.Text = "0";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(74, 279);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(41, 12);
            this.lbl_Result.TabIndex = 6;
            this.lbl_Result.Text = "結果：";
            // 
            // lbl_Result_Show
            // 
            this.lbl_Result_Show.AutoSize = true;
            this.lbl_Result_Show.Location = new System.Drawing.Point(135, 279);
            this.lbl_Result_Show.Name = "lbl_Result_Show";
            this.lbl_Result_Show.Size = new System.Drawing.Size(53, 12);
            this.lbl_Result_Show.TabIndex = 7;
            this.lbl_Result_Show.Text = "尚未計算";
            // 
            // lbl_CM
            // 
            this.lbl_CM.AutoSize = true;
            this.lbl_CM.Location = new System.Drawing.Point(249, 138);
            this.lbl_CM.Name = "lbl_CM";
            this.lbl_CM.Size = new System.Drawing.Size(29, 12);
            this.lbl_CM.TabIndex = 8;
            this.lbl_CM.Text = "公分";
            // 
            // lbl_KG
            // 
            this.lbl_KG.AutoSize = true;
            this.lbl_KG.Location = new System.Drawing.Point(249, 183);
            this.lbl_KG.Name = "lbl_KG";
            this.lbl_KG.Size = new System.Drawing.Size(29, 12);
            this.lbl_KG.TabIndex = 9;
            this.lbl_KG.Text = "公斤";
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(123, 136);
            this.nud_Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(120, 22);
            this.nud_Height.TabIndex = 10;
            // 
            // nud_Weight
            // 
            this.nud_Weight.Location = new System.Drawing.Point(123, 181);
            this.nud_Weight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_Weight.Name = "nud_Weight";
            this.nud_Weight.Size = new System.Drawing.Size(120, 22);
            this.nud_Weight.TabIndex = 11;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Checked = true;
            this.rb_Male.Location = new System.Drawing.Point(14, 13);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(44, 16);
            this.rb_Male.TabIndex = 12;
            this.rb_Male.TabStop = true;
            this.rb_Male.Tag = "1";
            this.rb_Male.Text = "Man";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(64, 13);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(60, 16);
            this.rb_Female.TabIndex = 13;
            this.rb_Female.Tag = "0";
            this.rb_Female.Text = "Woman";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // pnl_Gender
            // 
            this.pnl_Gender.Controls.Add(this.rb_Female);
            this.pnl_Gender.Controls.Add(this.rb_Male);
            this.pnl_Gender.Location = new System.Drawing.Point(123, 67);
            this.pnl_Gender.Name = "pnl_Gender";
            this.pnl_Gender.Size = new System.Drawing.Size(155, 43);
            this.pnl_Gender.TabIndex = 14;
            // 
            // btn_Clac2
            // 
            this.btn_Clac2.Location = new System.Drawing.Point(187, 364);
            this.btn_Clac2.Name = "btn_Clac2";
            this.btn_Clac2.Size = new System.Drawing.Size(97, 23);
            this.btn_Clac2.TabIndex = 15;
            this.btn_Clac2.Text = "計算(查資料後)";
            this.btn_Clac2.UseVisualStyleBackColor = true;
            this.btn_Clac2.Click += new System.EventHandler(this.btn_Clac2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btn_Clac2);
            this.Controls.Add(this.pnl_Gender);
            this.Controls.Add(this.nud_Weight);
            this.Controls.Add(this.nud_Height);
            this.Controls.Add(this.lbl_KG);
            this.Controls.Add(this.lbl_CM);
            this.Controls.Add(this.lbl_Result_Show);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_BMI_Show);
            this.Controls.Add(this.lbl_BMI);
            this.Controls.Add(this.lbl_Weight);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.btn_Calc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Weight)).EndInit();
            this.pnl_Gender.ResumeLayout(false);
            this.pnl_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_BMI;
        private System.Windows.Forms.Label lbl_BMI_Show;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_Result_Show;
        private System.Windows.Forms.Label lbl_CM;
        private System.Windows.Forms.Label lbl_KG;
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.NumericUpDown nud_Weight;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Panel pnl_Gender;
        private System.Windows.Forms.Button btn_Clac2;
    }
}

