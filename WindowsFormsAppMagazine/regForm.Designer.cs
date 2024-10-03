namespace WindowsFormsAppMagazine
{
    partial class regForm
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
            this.regButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox1 = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passVisibility = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(27, 263);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(148, 38);
            this.regButton.TabIndex = 0;
            this.regButton.Text = "reg";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regBtnClick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(23, 55);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(51, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(27, 81);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(148, 29);
            this.loginTextBox.TabIndex = 6;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passTextBox1
            // 
            this.passTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox1.Location = new System.Drawing.Point(27, 140);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(148, 29);
            this.passTextBox1.TabIndex = 7;
            this.passTextBox1.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(23, 114);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(91, 24);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "password";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // passTextBox2
            // 
            this.passTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox2.Location = new System.Drawing.Point(27, 198);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.Size = new System.Drawing.Size(148, 29);
            this.passTextBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "confirm your password";
            // 
            // passVisibility
            // 
            this.passVisibility.AutoSize = true;
            this.passVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passVisibility.Location = new System.Drawing.Point(27, 233);
            this.passVisibility.Name = "passVisibility";
            this.passVisibility.Size = new System.Drawing.Size(153, 24);
            this.passVisibility.TabIndex = 14;
            this.passVisibility.Text = "show passwords";
            this.passVisibility.UseVisualStyleBackColor = true;
            this.passVisibility.CheckedChanged += new System.EventHandler(this.passVisibility_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passVisibility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.regButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "regForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox1;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox passVisibility;
        private System.Windows.Forms.Label label2;
    }
}

