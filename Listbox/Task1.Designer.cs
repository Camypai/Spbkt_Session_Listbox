using System.ComponentModel;


namespace Listbox
{
    partial class Task1
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
            this.backBtn   = new System.Windows.Forms.Button();
            this.resultsLb = new System.Windows.Forms.ListBox();
            this.start     = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 12);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  0;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // resultsLb
            // 
            this.resultsLb.FormattingEnabled = true;
            this.resultsLb.Location          = new System.Drawing.Point(12, 48);
            this.resultsLb.Name              = "resultsLb";
            this.resultsLb.Size              = new System.Drawing.Size(776, 316);
            this.resultsLb.TabIndex          = 1;
            // 
            // start
            // 
            this.start.Location                =  new System.Drawing.Point(607, 370);
            this.start.Name                    =  "start";
            this.start.Size                    =  new System.Drawing.Size(181, 68);
            this.start.TabIndex                =  2;
            this.start.Text                    =  "Пуск";
            this.start.UseVisualStyleBackColor =  true;
            this.start.Click                   += new System.EventHandler(this.start_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.resultsLb);
            this.Controls.Add(this.backBtn);
            this.Name =  "Task1";
            this.Text =  "Task1";
            this.Load += new System.EventHandler(this.Task1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox resultsLb;

        private System.Windows.Forms.Button start;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}