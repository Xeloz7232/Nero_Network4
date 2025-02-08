namespace Nero_Network4
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
            this.bGive = new System.Windows.Forms.Button();
            this.bCorrupt = new System.Windows.Forms.Button();
            this.bUntrain = new System.Windows.Forms.Button();
            this.pbSample = new System.Windows.Forms.PictureBox();
            this.bPic1 = new System.Windows.Forms.Button();
            this.bPic2 = new System.Windows.Forms.Button();
            this.bPic3 = new System.Windows.Forms.Button();
            this.bPic4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.bAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).BeginInit();
            this.SuspendLayout();
            // 
            // bGive
            // 
            this.bGive.Location = new System.Drawing.Point(10, 9);
            this.bGive.Margin = new System.Windows.Forms.Padding(2);
            this.bGive.Name = "bGive";
            this.bGive.Size = new System.Drawing.Size(80, 23);
            this.bGive.TabIndex = 0;
            this.bGive.Text = "Дать";
            this.bGive.UseVisualStyleBackColor = true;
            this.bGive.Click += new System.EventHandler(this.bGive_Click);
            // 
            // bCorrupt
            // 
            this.bCorrupt.Location = new System.Drawing.Point(10, 38);
            this.bCorrupt.Margin = new System.Windows.Forms.Padding(2);
            this.bCorrupt.Name = "bCorrupt";
            this.bCorrupt.Size = new System.Drawing.Size(80, 23);
            this.bCorrupt.TabIndex = 0;
            this.bCorrupt.Text = "Испортить";
            this.bCorrupt.UseVisualStyleBackColor = true;
            this.bCorrupt.Click += new System.EventHandler(this.bCorrupt_Click);
            // 
            // bUntrain
            // 
            this.bUntrain.Location = new System.Drawing.Point(10, 67);
            this.bUntrain.Margin = new System.Windows.Forms.Padding(2);
            this.bUntrain.Name = "bUntrain";
            this.bUntrain.Size = new System.Drawing.Size(80, 23);
            this.bUntrain.TabIndex = 0;
            this.bUntrain.Text = "Разобучить";
            this.bUntrain.UseVisualStyleBackColor = true;
            this.bUntrain.Click += new System.EventHandler(this.bUntrain_Click);
            // 
            // pbSample
            // 
            this.pbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSample.Location = new System.Drawing.Point(101, 14);
            this.pbSample.Margin = new System.Windows.Forms.Padding(2);
            this.pbSample.Name = "pbSample";
            this.pbSample.Size = new System.Drawing.Size(100, 100);
            this.pbSample.TabIndex = 1;
            this.pbSample.TabStop = false;
            // 
            // bPic1
            // 
            this.bPic1.Location = new System.Drawing.Point(210, 9);
            this.bPic1.Name = "bPic1";
            this.bPic1.Size = new System.Drawing.Size(75, 23);
            this.bPic1.TabIndex = 2;
            this.bPic1.Text = "Овен";
            this.bPic1.UseVisualStyleBackColor = true;
            this.bPic1.Click += new System.EventHandler(this.bPic1_Click);
            // 
            // bPic2
            // 
            this.bPic2.Location = new System.Drawing.Point(210, 38);
            this.bPic2.Name = "bPic2";
            this.bPic2.Size = new System.Drawing.Size(75, 23);
            this.bPic2.TabIndex = 2;
            this.bPic2.Text = "Рак";
            this.bPic2.UseVisualStyleBackColor = true;
            this.bPic2.Click += new System.EventHandler(this.bPic2_Click);
            // 
            // bPic3
            // 
            this.bPic3.Location = new System.Drawing.Point(210, 67);
            this.bPic3.Name = "bPic3";
            this.bPic3.Size = new System.Drawing.Size(75, 23);
            this.bPic3.TabIndex = 2;
            this.bPic3.Text = "Стрелец";
            this.bPic3.UseVisualStyleBackColor = true;
            this.bPic3.Click += new System.EventHandler(this.bPic3_Click);
            // 
            // bPic4
            // 
            this.bPic4.Location = new System.Drawing.Point(210, 96);
            this.bPic4.Name = "bPic4";
            this.bPic4.Size = new System.Drawing.Size(75, 23);
            this.bPic4.TabIndex = 2;
            this.bPic4.Text = "Весы";
            this.bPic4.UseVisualStyleBackColor = true;
            this.bPic4.Click += new System.EventHandler(this.bPic4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Location = new System.Drawing.Point(120, 123);
            this.label.MaximumSize = new System.Drawing.Size(166, 13);
            this.label.MinimumSize = new System.Drawing.Size(166, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Функционирование завершено";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bAuto
            // 
            this.bAuto.Location = new System.Drawing.Point(10, 94);
            this.bAuto.Margin = new System.Windows.Forms.Padding(2);
            this.bAuto.Name = "bAuto";
            this.bAuto.Size = new System.Drawing.Size(80, 23);
            this.bAuto.TabIndex = 0;
            this.bAuto.Text = "Авто-работа";
            this.bAuto.UseVisualStyleBackColor = true;
            this.bAuto.Click += new System.EventHandler(this.bAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 145);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPic4);
            this.Controls.Add(this.bPic3);
            this.Controls.Add(this.bPic2);
            this.Controls.Add(this.bPic1);
            this.Controls.Add(this.pbSample);
            this.Controls.Add(this.bAuto);
            this.Controls.Add(this.bUntrain);
            this.Controls.Add(this.bCorrupt);
            this.Controls.Add(this.bGive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGive;
        private System.Windows.Forms.Button bCorrupt;
        private System.Windows.Forms.Button bUntrain;
        private System.Windows.Forms.PictureBox pbSample;
        private System.Windows.Forms.Button bPic1;
        private System.Windows.Forms.Button bPic2;
        private System.Windows.Forms.Button bPic3;
        private System.Windows.Forms.Button bPic4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button bAuto;
    }
}

