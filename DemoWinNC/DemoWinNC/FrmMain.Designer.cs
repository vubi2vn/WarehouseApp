namespace DemoWinNC
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelFooter = new DevExpress.XtraEditors.PanelControl();
            this.lblTime = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelNavbar = new DevExpress.XtraEditors.PanelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup7 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup8 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.PanelMain = new DevExpress.XtraEditors.PanelControl();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup10 = new DevExpress.XtraNavBar.NavBarGroup();
            this.dataSetQLK = new DemoWinNC.DataSetQLK();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOMNGUOIDUNGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager();
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter();
            this.dM_MANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_MANHINHTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.DM_MANHINHTableAdapter();
            this.qL_PHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PHANQUYENTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.QL_PHANQUYENTableAdapter();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.TAIKHOANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNavbar)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelFooter.Appearance.Options.UseBackColor = true;
            this.panelFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelFooter.Controls.Add(this.lblTime);
            this.panelFooter.Controls.Add(this.labelControl1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 640);
            this.panelFooter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1055, 19);
            this.panelFooter.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(984, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(184, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Copyright@2019.Quản lý kho";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1055, 36);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.ImageOptions.Image = global::DemoWinNC.Properties.Resources.logout;
            this.simpleButton1.Location = new System.Drawing.Point(975, 0);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 36);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "\r\n";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 20);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Quản lý kho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(1015, 0);
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "\r\n";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.navBarControl1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Location = new System.Drawing.Point(0, 36);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(251, 604);
            this.panelNavbar.TabIndex = 3;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Red;
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5,
            this.navBarGroup6,
            this.navBarGroup7,
            this.navBarGroup8});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem2,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13});
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 247;
            this.navBarControl1.Size = new System.Drawing.Size(247, 600);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Nhân viên";
            this.navBarGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup1.ImageOptions.SvgImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.Tag = "MH1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem1.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem1.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItem1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem1.Caption = "Thông tin nhân viên";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Nhập - Xuất";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup2.ImageOptions.SvgImage")));
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.Tag = "MH2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem3.Appearance.Options.UseFont = true;
            this.navBarItem3.Caption = "Phiếu nhập hàng";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem4.Appearance.Options.UseFont = true;
            this.navBarItem4.Caption = "Test";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.Visible = false;
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Phiếu xuất hàng";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup3.Appearance.Options.UseFont = true;
            this.navBarGroup3.Caption = "Khách hàng";
            this.navBarGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup3.ImageOptions.SvgImage")));
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.Tag = "MH3";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Nhà cung cấp";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem9_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup4.Appearance.Options.UseFont = true;
            this.navBarGroup4.Caption = "Quản lý kho";
            this.navBarGroup4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup4.ImageOptions.SvgImage")));
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.Tag = "MH4";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Khu vực";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup5.Appearance.Options.UseFont = true;
            this.navBarGroup5.Caption = "Báo cáo thống kê";
            this.navBarGroup5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup5.ImageOptions.SvgImage")));
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13)});
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.Tag = "MH5";
            this.navBarGroup5.Visible = false;
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Báo cáo word";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Báo cáo Excel";
            this.navBarItem13.Name = "navBarItem13";
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup6.Appearance.Options.UseFont = true;
            this.navBarGroup6.Caption = "Trợ giúp";
            this.navBarGroup6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup6.ImageOptions.SvgImage")));
            this.navBarGroup6.Name = "navBarGroup6";
            this.navBarGroup6.Tag = "MH6";
            this.navBarGroup6.Visible = false;
            // 
            // navBarGroup7
            // 
            this.navBarGroup7.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup7.Appearance.Options.UseFont = true;
            this.navBarGroup7.Caption = "Hệ thống";
            this.navBarGroup7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup7.ImageOptions.SvgImage")));
            this.navBarGroup7.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup7.Name = "navBarGroup7";
            this.navBarGroup7.Tag = "MH7";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Đổi mật khẩu";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem10_LinkClicked);
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Quản lý tài khoản";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // navBarGroup8
            // 
            this.navBarGroup8.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup8.Appearance.Options.UseFont = true;
            this.navBarGroup8.Caption = "Phân quyền";
            this.navBarGroup8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup8.ImageOptions.SvgImage")));
            this.navBarGroup8.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup8.Name = "navBarGroup8";
            this.navBarGroup8.Tag = "MH8";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem5.Appearance.Options.UseFont = true;
            this.navBarItem5.Caption = "Người dùng-Nhóm người dùng";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem7.Appearance.Options.UseFont = true;
            this.navBarItem7.Caption = "Phân quyền";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(251, 36);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(804, 604);
            this.PanelMain.TabIndex = 4;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarGroup10
            // 
            this.navBarGroup10.Appearance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup10.Appearance.Options.UseFont = true;
            this.navBarGroup10.Caption = "Phân quyền";
            this.navBarGroup10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup10.ImageOptions.SvgImage")));
            this.navBarGroup10.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup10.Name = "navBarGroup10";
            // 
            // dataSetQLK
            // 
            this.dataSetQLK.DataSetName = "DataSetQLK";
            this.dataSetQLK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEU_DATTableAdapter = null;
            this.tableAdapterManager.CHI_TIET_PHIEU_XUATTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = null;
            this.tableAdapterManager.KE_HANGTableAdapter = null;
            this.tableAdapterManager.KHU_VUCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.PHIEU_XUAT_KHOTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGBindingSource
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataMember = "NGUOIDUNG_NHOMNGUOIDUNG";
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // dM_MANHINHBindingSource
            // 
            this.dM_MANHINHBindingSource.DataMember = "DM_MANHINH";
            this.dM_MANHINHBindingSource.DataSource = this.dataSetQLK;
            // 
            // dM_MANHINHTableAdapter
            // 
            this.dM_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PHANQUYENBindingSource
            // 
            this.qL_PHANQUYENBindingSource.DataMember = "QL_PHANQUYEN";
            this.qL_PHANQUYENBindingSource.DataSource = this.dataSetQLK;
            // 
            // qL_PHANQUYENTableAdapter
            // 
            this.qL_PHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.dataSetQLK;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1055, 659);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNavbar)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelFooter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PanelControl panelNavbar;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup7;
        private DevExpress.XtraEditors.PanelControl PanelMain;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DataSetQLK dataSetQLK;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private DataSetQLKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private DataSetQLKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource nGUOIDUNG_NHOMNGUOIDUNGBindingSource;
        private DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter nGUOIDUNG_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource dM_MANHINHBindingSource;
        private DataSetQLKTableAdapters.DM_MANHINHTableAdapter dM_MANHINHTableAdapter;
        private System.Windows.Forms.BindingSource qL_PHANQUYENBindingSource;
        private DataSetQLKTableAdapters.QL_PHANQUYENTableAdapter qL_PHANQUYENTableAdapter;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DataSetQLKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
    }
}