namespace BillyardBallsWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.downLabel_2 = new System.Windows.Forms.Label();
            this.leftLabel_2 = new System.Windows.Forms.Label();
            this.rightLabel_2 = new System.Windows.Forms.Label();
            this.topLabel_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.Location = new System.Drawing.Point(12, 182);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(15, 16);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "0";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel.Location = new System.Drawing.Point(361, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(15, 16);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "0";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.Location = new System.Drawing.Point(787, 182);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(15, 16);
            this.rightLabel.TabIndex = 2;
            this.rightLabel.Text = "0";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel.Location = new System.Drawing.Point(361, 425);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(15, 16);
            this.downLabel.TabIndex = 3;
            this.downLabel.Text = "0";
            // 
            // downLabel_2
            // 
            this.downLabel_2.AutoSize = true;
            this.downLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel_2.Location = new System.Drawing.Point(408, 425);
            this.downLabel_2.Name = "downLabel_2";
            this.downLabel_2.Size = new System.Drawing.Size(15, 16);
            this.downLabel_2.TabIndex = 4;
            this.downLabel_2.Text = "0";
            // 
            // leftLabel_2
            // 
            this.leftLabel_2.AutoSize = true;
            this.leftLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel_2.Location = new System.Drawing.Point(12, 230);
            this.leftLabel_2.Name = "leftLabel_2";
            this.leftLabel_2.Size = new System.Drawing.Size(15, 16);
            this.leftLabel_2.TabIndex = 5;
            this.leftLabel_2.Text = "0";
            // 
            // rightLabel_2
            // 
            this.rightLabel_2.AutoSize = true;
            this.rightLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel_2.Location = new System.Drawing.Point(787, 230);
            this.rightLabel_2.Name = "rightLabel_2";
            this.rightLabel_2.Size = new System.Drawing.Size(15, 16);
            this.rightLabel_2.TabIndex = 6;
            this.rightLabel_2.Text = "0";
            // 
            // topLabel_2
            // 
            this.topLabel_2.AutoSize = true;
            this.topLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel_2.Location = new System.Drawing.Point(408, 9);
            this.topLabel_2.Name = "topLabel_2";
            this.topLabel_2.Size = new System.Drawing.Size(15, 16);
            this.topLabel_2.TabIndex = 7;
            this.topLabel_2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topLabel_2);
            this.Controls.Add(this.rightLabel_2);
            this.Controls.Add(this.leftLabel_2);
            this.Controls.Add(this.downLabel_2);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.leftLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label downLabel_2;
        private System.Windows.Forms.Label leftLabel_2;
        private System.Windows.Forms.Label rightLabel_2;
        private System.Windows.Forms.Label topLabel_2;
    }
}

