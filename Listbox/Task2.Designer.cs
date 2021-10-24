using System.ComponentModel;


namespace Listbox
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fillRandomBtn = new System.Windows.Forms.Button();
            this.calcBtn       = new System.Windows.Forms.Button();
            this.zeroLbl       = new System.Windows.Forms.Label();
            this.negativeLbl   = new System.Windows.Forms.Label();
            this.positiveLbl   = new System.Windows.Forms.Label();
            this.label3        = new System.Windows.Forms.Label();
            this.label2        = new System.Windows.Forms.Label();
            this.label1        = new System.Windows.Forms.Label();
            this.numbersLb     = new System.Windows.Forms.ListBox();
            this.backBtn       = new System.Windows.Forms.Button();
            this.label4        = new System.Windows.Forms.Label();
            this.maxTb         = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fillRandomBtn
            // 
            this.fillRandomBtn.Location                =  new System.Drawing.Point(386, 351);
            this.fillRandomBtn.Name                    =  "fillRandomBtn";
            this.fillRandomBtn.Size                    =  new System.Drawing.Size(198, 66);
            this.fillRandomBtn.TabIndex                =  19;
            this.fillRandomBtn.Text                    =  "Заполнить массив случайными числами";
            this.fillRandomBtn.UseVisualStyleBackColor =  true;
            this.fillRandomBtn.Click                   += new System.EventHandler(this.fillRandomBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location                =  new System.Drawing.Point(590, 351);
            this.calcBtn.Name                    =  "calcBtn";
            this.calcBtn.Size                    =  new System.Drawing.Size(198, 66);
            this.calcBtn.TabIndex                =  18;
            this.calcBtn.Text                    =  "Посчитать";
            this.calcBtn.UseVisualStyleBackColor =  true;
            this.calcBtn.Click                   += new System.EventHandler(this.calcBtn_Click);
            // 
            // zeroLbl
            // 
            this.zeroLbl.Location = new System.Drawing.Point(154, 394);
            this.zeroLbl.Name     = "zeroLbl";
            this.zeroLbl.Size     = new System.Drawing.Size(100, 23);
            this.zeroLbl.TabIndex = 17;
            this.zeroLbl.Text     = "?";
            // 
            // negativeLbl
            // 
            this.negativeLbl.Location = new System.Drawing.Point(154, 371);
            this.negativeLbl.Name     = "negativeLbl";
            this.negativeLbl.Size     = new System.Drawing.Size(100, 23);
            this.negativeLbl.TabIndex = 16;
            this.negativeLbl.Text     = "?";
            // 
            // positiveLbl
            // 
            this.positiveLbl.Location = new System.Drawing.Point(154, 348);
            this.positiveLbl.Name     = "positiveLbl";
            this.positiveLbl.Size     = new System.Drawing.Size(100, 23);
            this.positiveLbl.TabIndex = 15;
            this.positiveLbl.Text     = "?";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 394);
            this.label3.Name     = "label3";
            this.label3.Size     = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 14;
            this.label3.Text     = "Нулевых чисел:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name     = "label2";
            this.label2.Size     = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 13;
            this.label2.Text     = "Отрицательных чисел:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 12;
            this.label1.Text     = "Положительных чител:";
            // 
            // numbersLb
            // 
            this.numbersLb.FormattingEnabled = true;
            this.numbersLb.Location          = new System.Drawing.Point(12, 133);
            this.numbersLb.Name              = "numbersLb";
            this.numbersLb.Size              = new System.Drawing.Size(776, 212);
            this.numbersLb.TabIndex          = 11;
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 33);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  10;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name     = "label4";
            this.label4.Size     = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 20;
            this.label4.Text     = "Введите количество чисел";
            // 
            // maxTb
            // 
            this.maxTb.Location = new System.Drawing.Point(171, 104);
            this.maxTb.Name     = "maxTb";
            this.maxTb.Size     = new System.Drawing.Size(100, 20);
            this.maxTb.TabIndex = 21;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maxTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fillRandomBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.zeroLbl);
            this.Controls.Add(this.negativeLbl);
            this.Controls.Add(this.positiveLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbersLb);
            this.Controls.Add(this.backBtn);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox maxTb;

        private System.Windows.Forms.Button  fillRandomBtn;
        private System.Windows.Forms.Button  calcBtn;
        private System.Windows.Forms.Label   zeroLbl;
        private System.Windows.Forms.Label   negativeLbl;
        private System.Windows.Forms.Label   positiveLbl;
        private System.Windows.Forms.Label   label3;
        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.Label   label1;
        private System.Windows.Forms.ListBox numbersLb;
        private System.Windows.Forms.Button  backBtn;
        private System.Windows.Forms.Label   label4;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}