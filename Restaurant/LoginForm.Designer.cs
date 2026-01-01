namespace System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PassPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UserNamePnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MotivationPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PassPnl.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.UserNamePnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.MotivationPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 120);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(56)))));
            this.panellogo.Controls.Add(this.LogoPictureBox);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogo.Location = new System.Drawing.Point(5, 125);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(374, 664);
            this.panellogo.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.Lime;
            this.LoginBtn.Location = new System.Drawing.Point(65, 460);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(574, 47);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.pictureBox3);
            this.panelLogin.Controls.Add(this.panel6);
            this.panelLogin.Controls.Add(this.LoginBtn);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.panel4);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(379, 125);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(694, 664);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PassPnl);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(252, 338);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 116);
            this.panel6.TabIndex = 8;
            // 
            // PassPnl
            // 
            this.PassPnl.Controls.Add(this.label4);
            this.PassPnl.Location = new System.Drawing.Point(3, 76);
            this.PassPnl.Name = "PassPnl";
            this.PassPnl.Size = new System.Drawing.Size(384, 32);
            this.PassPnl.TabIndex = 6;
            this.PassPnl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Invalid PassWord, Try Again";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.PassTextBox);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(384, 67);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(12, 63);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(360, 1);
            this.panel9.TabIndex = 2;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTextBox.BackColor = System.Drawing.Color.Black;
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PassTextBox.Location = new System.Drawing.Point(12, 24);
            this.PassTextBox.Multiline = true;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(360, 40);
            this.PassTextBox.TabIndex = 3;
            this.PassTextBox.Text = "Enter Password";
            this.PassTextBox.Click += new System.EventHandler(this.PassText_Click);
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.PassTextBox.Enter += new System.EventHandler(this.PassTextBox_Enter);
            this.PassTextBox.Leave += new System.EventHandler(this.PassTextBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UserNamePnl);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(252, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 116);
            this.panel4.TabIndex = 5;
            // 
            // UserNamePnl
            // 
            this.UserNamePnl.Controls.Add(this.label3);
            this.UserNamePnl.Location = new System.Drawing.Point(3, 76);
            this.UserNamePnl.Name = "UserNamePnl";
            this.UserNamePnl.Size = new System.Drawing.Size(384, 32);
            this.UserNamePnl.TabIndex = 6;
            this.UserNamePnl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invalid User Name, Try Again";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.UserNameTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 1);
            this.panel3.TabIndex = 2;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTextBox.BackColor = System.Drawing.Color.Black;
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 24);
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(360, 40);
            this.UserNameTextBox.TabIndex = 3;
            this.UserNameTextBox.Text = "Enter Username";
            this.UserNameTextBox.Click += new System.EventHandler(this.UserNameText_Click);
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            this.UserNameTextBox.Enter += new System.EventHandler(this.UserNameTextBox_Enter);
            this.UserNameTextBox.Leave += new System.EventHandler(this.UserNameTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(228, 160);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(259, 30);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Welcome To Stamina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(374, 664);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // MotivationPictureBox
            // 
            this.MotivationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MotivationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MotivationPictureBox.Image")));
            this.MotivationPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MotivationPictureBox.Name = "MotivationPictureBox";
            this.MotivationPictureBox.Size = new System.Drawing.Size(1068, 120);
            this.MotivationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MotivationPictureBox.TabIndex = 0;
            this.MotivationPictureBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(264, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "We provide best fitness and wellness services";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(423, 525);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 25);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dont have an account?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1078, 794);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panellogo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.PassPnl.ResumeLayout(false);
            this.PassPnl.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.UserNamePnl.ResumeLayout(false);
            this.UserNamePnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panel1;
        private Windows.Forms.Panel panellogo;
        private Windows.Forms.Button LoginBtn;
        private Windows.Forms.Panel panelLogin;
        private Windows.Forms.TextBox UserNameTextBox;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label labelLogin;
        private Windows.Forms.Panel panel2;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.Panel panel3;
        private Windows.Forms.Panel panel4;
        private Windows.Forms.Panel UserNamePnl;
        private Windows.Forms.Label label3;
        private Windows.Forms.Panel panel6;
        private Windows.Forms.Panel PassPnl;
        private Windows.Forms.Label label4;
        private Windows.Forms.Panel panel8;
        private Windows.Forms.Panel panel9;
        private Windows.Forms.TextBox PassTextBox;
        private Windows.Forms.PictureBox pictureBox2;
        private Windows.Forms.Label label5;
        private Windows.Forms.PictureBox LogoPictureBox;
        private Windows.Forms.PictureBox MotivationPictureBox;
        private Windows.Forms.PictureBox pictureBox3;
        private Windows.Forms.Label label2;
        private Windows.Forms.LinkLabel linkLabel1;
        private Windows.Forms.Label label6;
    }
}

