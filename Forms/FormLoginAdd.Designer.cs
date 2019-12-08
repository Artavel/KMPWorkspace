namespace WindowsFormsApp1.Forms
{
    partial class FormLoginAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginAdd));
            this.surnameField = new PlaceHolderTextBox();
            this.nameField = new PlaceHolderTextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.profField = new PlaceHolderTextBox();
            this.emailField = new PlaceHolderTextBox();
            this.passField = new PlaceHolderTextBox();
            this.usernameField = new PlaceHolderTextBox();
            this.pass2Field = new PlaceHolderTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.surnameField.ForeColor = System.Drawing.Color.Gray;
            this.surnameField.Location = new System.Drawing.Point(59, 153);
            this.surnameField.MaxLength = 50;
            this.surnameField.Name = "surnameField";
            this.surnameField.PlaceHolderText = "Фамилия";
            this.surnameField.Size = new System.Drawing.Size(186, 26);
            this.surnameField.TabIndex = 11;
            this.surnameField.Text = "Фамилия";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.nameField.ForeColor = System.Drawing.Color.Gray;
            this.nameField.Location = new System.Drawing.Point(59, 113);
            this.nameField.MaxLength = 50;
            this.nameField.Name = "nameField";
            this.nameField.PlaceHolderText = "Имя";
            this.nameField.Size = new System.Drawing.Size(186, 26);
            this.nameField.TabIndex = 12;
            this.nameField.Text = "Имя";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddUser.Location = new System.Drawing.Point(59, 444);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(186, 30);
            this.buttonAddUser.TabIndex = 9;
            this.buttonAddUser.Text = "Зарегистрироваться";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            this.buttonAddUser.MouseLeave += new System.EventHandler(this.buttonAddUser_MouseLeave);
            this.buttonAddUser.MouseHover += new System.EventHandler(this.buttonAddUser_MouseHover);
            // 
            // profField
            // 
            this.profField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.profField.ForeColor = System.Drawing.Color.Gray;
            this.profField.Location = new System.Drawing.Point(59, 193);
            this.profField.MaxLength = 50;
            this.profField.Name = "profField";
            this.profField.PlaceHolderText = "Должность";
            this.profField.Size = new System.Drawing.Size(186, 26);
            this.profField.TabIndex = 12;
            this.profField.Text = "Должность";
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.emailField.ForeColor = System.Drawing.Color.Gray;
            this.emailField.Location = new System.Drawing.Point(59, 295);
            this.emailField.MaxLength = 50;
            this.emailField.Name = "emailField";
            this.emailField.PlaceHolderText = "Рабочий Email";
            this.emailField.Size = new System.Drawing.Size(186, 26);
            this.emailField.TabIndex = 11;
            this.emailField.Text = "Рабочий Email";
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.passField.ForeColor = System.Drawing.Color.Gray;
            this.passField.Location = new System.Drawing.Point(59, 332);
            this.passField.MaxLength = 50;
            this.passField.Name = "passField";
            this.passField.PlaceHolderText = "Пароль";
            this.passField.Size = new System.Drawing.Size(186, 26);
            this.passField.TabIndex = 11;
            this.passField.Text = "Пароль";
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.usernameField.ForeColor = System.Drawing.Color.Gray;
            this.usernameField.Location = new System.Drawing.Point(59, 257);
            this.usernameField.MaxLength = 50;
            this.usernameField.Name = "usernameField";
            this.usernameField.PlaceHolderText = "Имя пользователя";
            this.usernameField.Size = new System.Drawing.Size(186, 26);
            this.usernameField.TabIndex = 11;
            this.usernameField.Text = "Имя пользователя";
            // 
            // pass2Field
            // 
            this.pass2Field.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic);
            this.pass2Field.ForeColor = System.Drawing.Color.Gray;
            this.pass2Field.Location = new System.Drawing.Point(59, 370);
            this.pass2Field.MaxLength = 50;
            this.pass2Field.Name = "pass2Field";
            this.pass2Field.PlaceHolderText = "Повторите пароль";
            this.pass2Field.Size = new System.Drawing.Size(186, 26);
            this.pass2Field.TabIndex = 11;
            this.pass2Field.Text = "Повторите пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SLS Group";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(300, 79);
            this.panelHeader.TabIndex = 13;
            // 
            // FormLoginAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 517);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pass2Field);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.profField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.buttonAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoginAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceHolderTextBox surnameField;
        private PlaceHolderTextBox nameField;
        private System.Windows.Forms.Button buttonAddUser;
        private PlaceHolderTextBox profField;
        private PlaceHolderTextBox emailField;
        private PlaceHolderTextBox passField;
        private PlaceHolderTextBox usernameField;
        private PlaceHolderTextBox pass2Field;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
    }
}