using System.ComponentModel;


namespace Listbox
{
    partial class Task3
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
            this.numbersLb = new System.Windows.Forms.ListBox();
            this.randomBtn = new System.Windows.Forms.Button();
            this.clearBtn  = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateTb  = new System.Windows.Forms.TextBox();
            this.startBtn  = new System.Windows.Forms.Button();
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
            // numbersLb
            // 
            this.numbersLb.FormattingEnabled = true;
            this.numbersLb.Location          = new System.Drawing.Point(12, 82);
            this.numbersLb.Name              = "numbersLb";
            this.numbersLb.Size              = new System.Drawing.Size(776, 264);
            this.numbersLb.TabIndex          = 1;
            // 
            // randomBtn
            // 
            this.randomBtn.Location                =  new System.Drawing.Point(652, 352);
            this.randomBtn.Name                    =  "randomBtn";
            this.randomBtn.Size                    =  new System.Drawing.Size(136, 86);
            this.randomBtn.TabIndex                =  2;
            this.randomBtn.Text                    =  "Заполнить случайными числами";
            this.randomBtn.UseVisualStyleBackColor =  true;
            this.randomBtn.Click                   += new System.EventHandler(this.randomBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location                =  new System.Drawing.Point(510, 352);
            this.clearBtn.Name                    =  "clearBtn";
            this.clearBtn.Size                    =  new System.Drawing.Size(136, 86);
            this.clearBtn.TabIndex                =  3;
            this.clearBtn.Text                    =  "Очистить";
            this.clearBtn.UseVisualStyleBackColor =  true;
            this.clearBtn.Click                   += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location                =  new System.Drawing.Point(368, 378);
            this.updateBtn.Name                    =  "updateBtn";
            this.updateBtn.Size                    =  new System.Drawing.Size(136, 60);
            this.updateBtn.TabIndex                =  4;
            this.updateBtn.Text                    =  "Изменить";
            this.updateBtn.UseVisualStyleBackColor =  true;
            this.updateBtn.Click                   += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location                =  new System.Drawing.Point(226, 352);
            this.deleteBtn.Name                    =  "deleteBtn";
            this.deleteBtn.Size                    =  new System.Drawing.Size(136, 86);
            this.deleteBtn.TabIndex                =  5;
            this.deleteBtn.Text                    =  "Удалить";
            this.deleteBtn.UseVisualStyleBackColor =  true;
            this.deleteBtn.Click                   += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateTb
            // 
            this.updateTb.Location = new System.Drawing.Point(368, 352);
            this.updateTb.Name     = "updateTb";
            this.updateTb.Size     = new System.Drawing.Size(136, 20);
            this.updateTb.TabIndex = 6;
            // 
            // startBtn
            // 
            this.startBtn.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location                =  new System.Drawing.Point(12, 352);
            this.startBtn.Name                    =  "startBtn";
            this.startBtn.Size                    =  new System.Drawing.Size(136, 86);
            this.startBtn.TabIndex                =  7;
            this.startBtn.Text                    =  "ПУСК";
            this.startBtn.UseVisualStyleBackColor =  true;
            this.startBtn.Click                   += new System.EventHandler(this.startBtn_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.updateTb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.numbersLb);
            this.Controls.Add(this.backBtn);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button startBtn;

        private System.Windows.Forms.Button  updateBtn;
        private System.Windows.Forms.Button  deleteBtn;
        private System.Windows.Forms.TextBox updateTb;

        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.ListBox numbersLb;

        private System.Windows.Forms.Button randomBtn;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button  button1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}