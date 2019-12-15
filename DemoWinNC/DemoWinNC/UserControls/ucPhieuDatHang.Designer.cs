namespace DemoWinNC.UserControls
{
    partial class ucPhieuDatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaoPhieuDat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboMANV = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPD = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAPHIEUDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPD.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPhieuDat
            // 
            this.btnTaoPhieuDat.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTaoPhieuDat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuDat.Appearance.Options.UseBorderColor = true;
            this.btnTaoPhieuDat.Appearance.Options.UseFont = true;
            this.btnTaoPhieuDat.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaoPhieuDat.AppearanceHovered.Options.UseBackColor = true;
            this.btnTaoPhieuDat.Location = new System.Drawing.Point(535, 14);
            this.btnTaoPhieuDat.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnTaoPhieuDat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTaoPhieuDat.Name = "btnTaoPhieuDat";
            this.btnTaoPhieuDat.Size = new System.Drawing.Size(87, 73);
            this.btnTaoPhieuDat.TabIndex = 3;
            this.btnTaoPhieuDat.Text = "Tạo phiếu";
            this.btnTaoPhieuDat.Click += new System.EventHandler(this.btnTaoPhieuDat_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnChiTiet);
            this.panelControl1.Controls.Add(this.cboMANV);
            this.panelControl1.Controls.Add(this.cboNCC);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtMaPD);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnUpdate);
            this.panelControl1.Controls.Add(this.btnTaoPhieuDat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 97);
            this.panelControl1.TabIndex = 4;
            // 
            // cboMANV
            // 
            this.cboMANV.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMANV.FormattingEnabled = true;
            this.cboMANV.Location = new System.Drawing.Point(368, 54);
            this.cboMANV.Name = "cboMANV";
            this.cboMANV.Size = new System.Drawing.Size(161, 33);
            this.cboMANV.TabIndex = 15;
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(368, 15);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(161, 33);
            this.cboNCC.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã phiếu ";
            // 
            // txtMaPD
            // 
            this.txtMaPD.Enabled = false;
            this.txtMaPD.Location = new System.Drawing.Point(122, 15);
            this.txtMaPD.Name = "txtMaPD";
            this.txtMaPD.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPD.Properties.Appearance.Options.UseFont = true;
            this.txtMaPD.Size = new System.Drawing.Size(125, 32);
            this.txtMaPD.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(626, 54);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseBorderColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.Location = new System.Drawing.Point(711, 54);
            this.btnUpdate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 33);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 503);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(794, 476);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAPHIEUDAT,
            this.MANCC,
            this.MANV,
            this.NGAYLAP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.PaintStyleName = "UltraFlat";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // MAPHIEUDAT
            // 
            this.MAPHIEUDAT.Caption = "Mã phiếu";
            this.MAPHIEUDAT.FieldName = "MAPHIEUDAT";
            this.MAPHIEUDAT.MinWidth = 25;
            this.MAPHIEUDAT.Name = "MAPHIEUDAT";
            this.MAPHIEUDAT.Visible = true;
            this.MAPHIEUDAT.VisibleIndex = 0;
            this.MAPHIEUDAT.Width = 94;
            // 
            // MANCC
            // 
            this.MANCC.Caption = "Mã NCC";
            this.MANCC.FieldName = "MANCC";
            this.MANCC.MinWidth = 25;
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = true;
            this.MANCC.VisibleIndex = 1;
            this.MANCC.Width = 94;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã nhân viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 25;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 2;
            this.MANV.Width = 94;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.MinWidth = 25;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 3;
            this.NGAYLAP.Width = 94;
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Appearance.Options.UseBorderColor = true;
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChiTiet.AppearanceHovered.Options.UseBackColor = true;
            this.btnChiTiet.Location = new System.Drawing.Point(626, 15);
            this.btnChiTiet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnChiTiet.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(169, 35);
            this.btnChiTiet.TabIndex = 16;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // ucPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucPhieuDatHang";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ucPhieuDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPD.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTaoPhieuDat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaPD;
        private System.Windows.Forms.ComboBox cboMANV;
        private System.Windows.Forms.ComboBox cboNCC;
        private DevExpress.XtraGrid.Columns.GridColumn MAPHIEUDAT;
        private DevExpress.XtraGrid.Columns.GridColumn MANCC;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
    }
}
