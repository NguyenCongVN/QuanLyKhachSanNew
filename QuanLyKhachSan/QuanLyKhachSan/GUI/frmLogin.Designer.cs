namespace QuanLyKhachSan.GUI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_Login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.chk_savedAcc = new Guna.UI.WinForms.GunaMediumCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // btn_Login
            // 
            this.btn_Login.AnimationHoverSpeed = 0.07F;
            this.btn_Login.AnimationSpeed = 0.03F;
            this.btn_Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btn_Login.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.BorderSize = 2;
            this.btn_Login.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Login.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Login.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Login.CheckedImage = null;
            this.btn_Login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = null;
            this.btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Login.LineColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(356, 562);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(234)))));
            this.btn_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Login.OnHoverImage = null;
            this.btn_Login.OnHoverLineColor = System.Drawing.Color.Black;
            this.btn_Login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Login.Size = new System.Drawing.Size(323, 47);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(355, 401);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(77, 20);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Mật khẩu :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(349, 310);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 20);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Tài khoản :";
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.Black;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(355, 423);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(327, 47);
            this.txt_pass.TabIndex = 11;
            // 
            // txt_user
            // 
            this.txt_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.Black;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(355, 334);
            this.txt_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Size = new System.Drawing.Size(327, 47);
            this.txt_user.TabIndex = 10;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1029, 294);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 17;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(197)))), ((int)(((byte)(191)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(991, 9);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(29, 30);
            this.gunaControlBox1.TabIndex = 18;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.gunaPictureBox1;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(387, 502);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(197, 20);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Bạn có muốn lưu mật khẩu ?";
            // 
            // chk_savedAcc
            // 
            this.chk_savedAcc.BaseColor = System.Drawing.Color.White;
            this.chk_savedAcc.CheckedOffColor = System.Drawing.Color.Black;
            this.chk_savedAcc.CheckedOnColor = System.Drawing.Color.Black;
            this.chk_savedAcc.FillColor = System.Drawing.Color.White;
            this.chk_savedAcc.Location = new System.Drawing.Point(355, 502);
            this.chk_savedAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_savedAcc.Name = "chk_savedAcc";
            this.chk_savedAcc.Size = new System.Drawing.Size(20, 20);
            this.chk_savedAcc.TabIndex = 15;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1029, 652);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chk_savedAcc);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Login;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaMediumCheckBox chk_savedAcc;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}