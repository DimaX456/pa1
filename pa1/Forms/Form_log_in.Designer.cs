namespace pa1
{
    partial class Form_log_in
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
            this.linkLabelReg = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonVisible = new System.Windows.Forms.Button();
            this.buttonNotVisible = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEnterNotLogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelReg
            // 
            this.linkLabelReg.AutoSize = true;
            this.linkLabelReg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelReg.Location = new System.Drawing.Point(161, 350);
            this.linkLabelReg.Name = "linkLabelReg";
            this.linkLabelReg.Size = new System.Drawing.Size(115, 15);
            this.linkLabelReg.TabIndex = 23;
            this.linkLabelReg.TabStop = true;
            this.linkLabelReg.Text = "Зарегистрироваться";
            this.linkLabelReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReg_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(17, 257);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(390, 45);
            this.buttonLogin.TabIndex = 22;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(16, 170);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(391, 34);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(92, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 20);
            this.textBoxPassword.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(92, 114);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(243, 20);
            this.textBoxUsername.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(116, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 105);
            this.panel1.TabIndex = 24;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(16, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(391, 40);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonVisible
            // 
            this.buttonVisible.Location = new System.Drawing.Point(342, 140);
            this.buttonVisible.Name = "buttonVisible";
            this.buttonVisible.Size = new System.Drawing.Size(21, 23);
            this.buttonVisible.TabIndex = 27;
            this.buttonVisible.Text = "В";
            this.buttonVisible.UseVisualStyleBackColor = true;
            this.buttonVisible.Click += new System.EventHandler(this.buttonVisible_Click);
            // 
            // buttonNotVisible
            // 
            this.buttonNotVisible.Location = new System.Drawing.Point(369, 140);
            this.buttonNotVisible.Name = "buttonNotVisible";
            this.buttonNotVisible.Size = new System.Drawing.Size(38, 23);
            this.buttonNotVisible.TabIndex = 28;
            this.buttonNotVisible.Text = "Не";
            this.buttonNotVisible.UseVisualStyleBackColor = true;
            this.buttonNotVisible.Click += new System.EventHandler(this.buttonNotVisible_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pa1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEnterNotLogIn
            // 
            this.buttonEnterNotLogIn.Location = new System.Drawing.Point(17, 309);
            this.buttonEnterNotLogIn.Name = "buttonEnterNotLogIn";
            this.buttonEnterNotLogIn.Size = new System.Drawing.Size(390, 38);
            this.buttonEnterNotLogIn.TabIndex = 29;
            this.buttonEnterNotLogIn.Text = "Войти как обычный пользователь";
            this.buttonEnterNotLogIn.UseVisualStyleBackColor = true;
            this.buttonEnterNotLogIn.Click += new System.EventHandler(this.buttonEnterNotLogIn_Click);
            // 
            // Form_log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 374);
            this.Controls.Add(this.buttonEnterNotLogIn);
            this.Controls.Add(this.buttonNotVisible);
            this.Controls.Add(this.buttonVisible);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelReg);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Form_log_in";
            this.Text = "Form_log_in";
            this.Load += new System.EventHandler(this.Form_log_in_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelReg;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonVisible;
        private System.Windows.Forms.Button buttonNotVisible;
        private System.Windows.Forms.Button buttonEnterNotLogIn;
    }
}