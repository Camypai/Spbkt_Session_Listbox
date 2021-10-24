namespace Listbox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.task1Btn = new System.Windows.Forms.Button();
            this.task2Btn = new System.Windows.Forms.Button();
            this.task3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1Btn
            // 
            this.task1Btn.Location                =  new System.Drawing.Point(12, 66);
            this.task1Btn.Name                    =  "task1Btn";
            this.task1Btn.Size                    =  new System.Drawing.Size(125, 59);
            this.task1Btn.TabIndex                =  0;
            this.task1Btn.Text                    =  "Задание 1";
            this.task1Btn.UseVisualStyleBackColor =  true;
            this.task1Btn.Click                   += new System.EventHandler(this.task1Btn_Click);
            // 
            // task2Btn
            // 
            this.task2Btn.Location                =  new System.Drawing.Point(199, 66);
            this.task2Btn.Name                    =  "task2Btn";
            this.task2Btn.Size                    =  new System.Drawing.Size(125, 59);
            this.task2Btn.TabIndex                =  1;
            this.task2Btn.Text                    =  "Задание 2";
            this.task2Btn.UseVisualStyleBackColor =  true;
            this.task2Btn.Click                   += new System.EventHandler(this.task2Btn_Click);
            // 
            // task3Btn
            // 
            this.task3Btn.Location                =  new System.Drawing.Point(386, 66);
            this.task3Btn.Name                    =  "task3Btn";
            this.task3Btn.Size                    =  new System.Drawing.Size(125, 59);
            this.task3Btn.TabIndex                =  2;
            this.task3Btn.Text                    =  "Задание 3";
            this.task3Btn.UseVisualStyleBackColor =  true;
            this.task3Btn.Click                   += new System.EventHandler(this.task3Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(523, 196);
            this.Controls.Add(this.task3Btn);
            this.Controls.Add(this.task2Btn);
            this.Controls.Add(this.task1Btn);
            this.Name =  "Form1";
            this.Text =  "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button task3Btn;

        private System.Windows.Forms.Button task2Btn;
        private System.Windows.Forms.Button task1Btn;

        #endregion
    }
}