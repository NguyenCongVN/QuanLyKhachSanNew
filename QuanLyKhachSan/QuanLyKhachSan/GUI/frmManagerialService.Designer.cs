namespace QuanLyKhachSan.GUI
{
    partial class frmManagerialService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerialService));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_control = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.thongtindichvu = new System.Windows.Forms.GroupBox();
            this.txtgia = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtloaidichvu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txttendichvu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtmadichvu = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.showDataService = new Guna.UI.WinForms.GunaDataGridView();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.thongtindichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataService)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_control
            // 
            this.panel_control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_control.BackgroundImage")));
            this.panel_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_control.Controls.Add(this.btn_exit);
            this.panel_control.Controls.Add(this.gunaLabel1);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Quality = 10;
            this.panel_control.Size = new System.Drawing.Size(962, 36);
            this.panel_control.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(921, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 27);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 21;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 2;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(11, 7);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(118, 21);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Quản lý dịch vụ";
            // 
            // thongtindichvu
            // 
            this.thongtindichvu.Controls.Add(this.txtgia);
            this.thongtindichvu.Controls.Add(this.gunaLabel2);
            this.thongtindichvu.Controls.Add(this.txtloaidichvu);
            this.thongtindichvu.Controls.Add(this.gunaLabel9);
            this.thongtindichvu.Controls.Add(this.txttendichvu);
            this.thongtindichvu.Controls.Add(this.gunaLabel7);
            this.thongtindichvu.Controls.Add(this.txtmadichvu);
            this.thongtindichvu.Controls.Add(this.gunaLabel5);
            this.thongtindichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtindichvu.ForeColor = System.Drawing.Color.Black;
            this.thongtindichvu.Location = new System.Drawing.Point(18, 42);
            this.thongtindichvu.Name = "thongtindichvu";
            this.thongtindichvu.Size = new System.Drawing.Size(246, 378);
            this.thongtindichvu.TabIndex = 23;
            this.thongtindichvu.TabStop = false;
            this.thongtindichvu.Text = "Thông tin dịch vụ";
            // 
            // txtgia
            // 
            this.txtgia.BaseColor = System.Drawing.Color.White;
            this.txtgia.BorderColor = System.Drawing.Color.Silver;
            this.txtgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtgia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtgia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.ForeColor = System.Drawing.Color.Black;
            this.txtgia.Location = new System.Drawing.Point(21, 314);
            this.txtgia.Margin = new System.Windows.Forms.Padding(2);
            this.txtgia.Name = "txtgia";
            this.txtgia.PasswordChar = '\0';
            this.txtgia.Size = new System.Drawing.Size(204, 38);
            this.txtgia.TabIndex = 30;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(18, 295);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(34, 17);
            this.gunaLabel2.TabIndex = 29;
            this.gunaLabel2.Text = "Giá :";
            // 
            // txtloaidichvu
            // 
            this.txtloaidichvu.BaseColor = System.Drawing.Color.White;
            this.txtloaidichvu.BorderColor = System.Drawing.Color.Silver;
            this.txtloaidichvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtloaidichvu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtloaidichvu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtloaidichvu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtloaidichvu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloaidichvu.ForeColor = System.Drawing.Color.Black;
            this.txtloaidichvu.Location = new System.Drawing.Point(21, 228);
            this.txtloaidichvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtloaidichvu.Name = "txtloaidichvu";
            this.txtloaidichvu.PasswordChar = '\0';
            this.txtloaidichvu.Size = new System.Drawing.Size(204, 38);
            this.txtloaidichvu.TabIndex = 28;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel9.Location = new System.Drawing.Point(18, 209);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 17);
            this.gunaLabel9.TabIndex = 27;
            this.gunaLabel9.Text = "Loại dịch vụ :";
            // 
            // txttendichvu
            // 
            this.txttendichvu.BaseColor = System.Drawing.Color.White;
            this.txttendichvu.BorderColor = System.Drawing.Color.Silver;
            this.txttendichvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttendichvu.FocusedBaseColor = System.Drawing.Color.White;
            this.txttendichvu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txttendichvu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttendichvu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendichvu.ForeColor = System.Drawing.Color.Black;
            this.txttendichvu.Location = new System.Drawing.Point(21, 142);
            this.txttendichvu.Margin = new System.Windows.Forms.Padding(2);
            this.txttendichvu.Name = "txttendichvu";
            this.txttendichvu.PasswordChar = '\0';
            this.txttendichvu.Size = new System.Drawing.Size(204, 38);
            this.txttendichvu.TabIndex = 24;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel7.Location = new System.Drawing.Point(18, 123);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(84, 17);
            this.gunaLabel7.TabIndex = 23;
            this.gunaLabel7.Text = "Tên dịch vụ :";
            // 
            // txtmadichvu
            // 
            this.txtmadichvu.BaseColor = System.Drawing.Color.White;
            this.txtmadichvu.BorderColor = System.Drawing.Color.Silver;
            this.txtmadichvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmadichvu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmadichvu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtmadichvu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmadichvu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadichvu.ForeColor = System.Drawing.Color.Black;
            this.txtmadichvu.Location = new System.Drawing.Point(21, 56);
            this.txtmadichvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtmadichvu.Name = "txtmadichvu";
            this.txtmadichvu.PasswordChar = '\0';
            this.txtmadichvu.Size = new System.Drawing.Size(204, 38);
            this.txtmadichvu.TabIndex = 20;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel5.Location = new System.Drawing.Point(18, 37);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(82, 17);
            this.gunaLabel5.TabIndex = 19;
            this.gunaLabel5.Text = "Mã dịch vụ :";
            // 
            // showDataService
            // 
            this.showDataService.AllowUserToAddRows = false;
            this.showDataService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.showDataService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showDataService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showDataService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDataService.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDataService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showDataService.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDataService.DefaultCellStyle = dataGridViewCellStyle3;
            this.showDataService.EnableHeadersVisualStyles = false;
            this.showDataService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataService.Location = new System.Drawing.Point(271, 102);
            this.showDataService.Margin = new System.Windows.Forms.Padding(4);
            this.showDataService.Name = "showDataService";
            this.showDataService.ReadOnly = true;
            this.showDataService.RowHeadersVisible = false;
            this.showDataService.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.showDataService.RowTemplate.Height = 24;
            this.showDataService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataService.Size = new System.Drawing.Size(685, 318);
            this.showDataService.TabIndex = 31;
            this.showDataService.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.showDataService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.showDataService.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showDataService.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showDataService.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showDataService.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showDataService.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataService.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.showDataService.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showDataService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataService.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showDataService.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showDataService.ThemeStyle.HeaderStyle.Height = 25;
            this.showDataService.ThemeStyle.ReadOnly = true;
            this.showDataService.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataService.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showDataService.ThemeStyle.RowsStyle.Height = 24;
            this.showDataService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.showDataService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showDataService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataService_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = false;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = false;
            this.btnThem.IconZoom = 40D;
            this.btnThem.IsTab = true;
            this.btnThem.Location = new System.Drawing.Point(6, 449);
            this.btnThem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(204, 38);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = null;
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = false;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = false;
            this.btnXoa.IconZoom = 40D;
            this.btnXoa.IsTab = true;
            this.btnXoa.Location = new System.Drawing.Point(502, 448);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(204, 38);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuy.Iconimage = null;
            this.btnHuy.Iconimage_right = null;
            this.btnHuy.Iconimage_right_Selected = null;
            this.btnHuy.Iconimage_Selected = null;
            this.btnHuy.IconMarginLeft = 0;
            this.btnHuy.IconMarginRight = 0;
            this.btnHuy.IconRightVisible = false;
            this.btnHuy.IconRightZoom = 0D;
            this.btnHuy.IconVisible = false;
            this.btnHuy.IconZoom = 40D;
            this.btnHuy.IsTab = true;
            this.btnHuy.Location = new System.Drawing.Point(750, 448);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(204, 38);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = null;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = false;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = false;
            this.btnSua.IconZoom = 40D;
            this.btnSua.IsTab = true;
            this.btnSua.Location = new System.Drawing.Point(254, 448);
            this.btnSua.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(204, 38);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox4.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox4.Location = new System.Drawing.Point(271, 58);
            this.gunaTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Size = new System.Drawing.Size(204, 38);
            this.gunaTextBox4.TabIndex = 39;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Tìm kiếm";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = false;
            this.bunifuFlatButton5.IconZoom = 40D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(502, 58);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(204, 38);
            this.bunifuFlatButton5.TabIndex = 40;
            this.bunifuFlatButton5.Text = "Tìm kiếm";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel_control;
            // 
            // frmManagerialService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 502);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.gunaTextBox4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.showDataService);
            this.Controls.Add(this.thongtindichvu);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagerialService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagerialService";
            this.Load += new System.EventHandler(this.frmManagerialService_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.thongtindichvu.ResumeLayout(false);
            this.thongtindichvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_control;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.GroupBox thongtindichvu;
        private Guna.UI.WinForms.GunaTextBox txtgia;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtloaidichvu;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txttendichvu;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtmadichvu;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDataGridView showDataService;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}