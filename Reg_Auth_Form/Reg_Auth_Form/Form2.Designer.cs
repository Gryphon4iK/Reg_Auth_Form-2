namespace Reg_Auth_Form
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonSendPassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Войти в личный кабинет";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 94);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(351, 31);
            this.textBoxLog.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(12, 167);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(351, 31);
            this.textBoxPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(12, 222);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(351, 37);
            this.buttonLogIn.TabIndex = 8;
            this.buttonLogIn.Text = "Войти";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonSendPassword
            // 
            this.buttonSendPassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonSendPassword.FlatAppearance.BorderSize = 0;
            this.buttonSendPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendPassword.ForeColor = System.Drawing.Color.Blue;
            this.buttonSendPassword.Location = new System.Drawing.Point(238, 265);
            this.buttonSendPassword.Name = "buttonSendPassword";
            this.buttonSendPassword.Size = new System.Drawing.Size(125, 31);
            this.buttonSendPassword.TabIndex = 9;
            this.buttonSendPassword.Text = "Забыли пароль?";
            this.buttonSendPassword.UseVisualStyleBackColor = false;
            this.buttonSendPassword.Click += new System.EventHandler(this.buttonSendPassword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSendPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSendPassword;
        private System.Windows.Forms.Button button1;
    }
}