namespace TestWork
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.PrefixesBox = new System.Windows.Forms.TextBox();
            this.PrefixesText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(96, 82);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(246, 22);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(97, 188);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(246, 22);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(97, 331);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(16, 22);
            this.ResultText.TabIndex = 5;
            this.ResultText.Text = "-";
            this.ResultText.Click += new System.EventHandler(this.ResultText_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(164, 225);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(124, 44);
            this.ButtonResult.TabIndex = 6;
            this.ButtonResult.Text = "GetResult";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // PrefixesBox
            // 
            this.PrefixesBox.Location = new System.Drawing.Point(97, 134);
            this.PrefixesBox.Name = "PrefixesBox";
            this.PrefixesBox.Size = new System.Drawing.Size(245, 22);
            this.PrefixesBox.TabIndex = 7;
            // 
            // PrefixesText
            // 
            this.PrefixesText.AutoSize = true;
            this.PrefixesText.Location = new System.Drawing.Point(198, 115);
            this.PrefixesText.Name = "PrefixesText";
            this.PrefixesText.Size = new System.Drawing.Size(55, 16);
            this.PrefixesText.TabIndex = 8;
            this.PrefixesText.Text = "Prefixes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 394);
            this.Controls.Add(this.PrefixesText);
            this.Controls.Add(this.PrefixesBox);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.TextBox PrefixesBox;
        private System.Windows.Forms.Label PrefixesText;
    }
}

