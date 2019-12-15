namespace DemoWinNC.UserControls
{
    partial class ucXuatHang
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
            this.components = new System.ComponentModel.Container();
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.dataSetQLK = new DemoWinNC.DataSetQLK();
            this.pHIEU_DAT_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEU_DAT_HANGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.PHIEU_DAT_HANGTableAdapter();
            this.tableAdapterManager = new DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager();
            this.pHIEU_XUAT_KHOTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.PHIEU_XUAT_KHOTableAdapter();
            this.pHIEU_XUAT_KHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAHDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pHIEUXUATKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoPhieuDat = new DevExpress.XtraEditors.SimpleButton();
            this.cboMANV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEU_DAT_HANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEU_XUAT_KHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            // 
            // dataSetQLK
            // 
            this.dataSetQLK.DataSetName = "DataSetQLK";
            this.dataSetQLK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEU_DAT_HANGBindingSource
            // 
            this.pHIEU_DAT_HANGBindingSource.DataMember = "PHIEU_DAT_HANG";
            this.pHIEU_DAT_HANGBindingSource.DataSource = this.dataSetQLK;
            // 
            // pHIEU_DAT_HANGTableAdapter
            // 
            this.pHIEU_DAT_HANGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PHIEU_DAT_HANGTableAdapter = this.pHIEU_DAT_HANGTableAdapter;
            this.tableAdapterManager.PHIEU_XUAT_KHOTableAdapter = this.pHIEU_XUAT_KHOTableAdapter;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHIEU_XUAT_KHOTableAdapter
            // 
            this.pHIEU_XUAT_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEU_XUAT_KHOBindingSource
            // 
            this.pHIEU_XUAT_KHOBindingSource.DataMember = "PHIEU_XUAT_KHO";
            this.pHIEU_XUAT_KHOBindingSource.DataSource = this.dataSetQLK;
            // 
            // mAHDTextEdit
            // 
            this.mAHDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEU_XUAT_KHOBindingSource, "MAHD", true));
            this.mAHDTextEdit.Enabled = false;
            this.mAHDTextEdit.Location = new System.Drawing.Point(158, 27);
            this.mAHDTextEdit.Name = "mAHDTextEdit";
            this.mAHDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAHDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAHDTextEdit.Size = new System.Drawing.Size(161, 32);
            this.mAHDTextEdit.TabIndex = 3;
            // 
            // pHIEUXUATKHOBindingSource
            // 
            this.pHIEUXUATKHOBindingSource.DataMember = "PHIEU_XUAT_KHO";
            this.pHIEUXUATKHOBindingSource.DataSource = this.dataSetQLK;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pHIEU_XUAT_KHOBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 147);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 460);
            this.gridControl1.TabIndex = 8;
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
            this.colMAHD,
            this.colMANV,
            this.colNGAYLAP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.PaintStyleName = "UltraFlat";
            this.gridView1.AfterPrintRow += new DevExpress.XtraGrid.Views.Base.AfterPrintRowEventHandler(this.s);
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMAHD
            // 
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.MinWidth = 25;
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            this.colMAHD.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 94;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.MinWidth = 25;
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 2;
            this.colNGAYLAP.Width = 94;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(590, 30);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 73);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTaoPhieuDat
            // 
            this.btnTaoPhieuDat.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTaoPhieuDat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuDat.Appearance.Options.UseBorderColor = true;
            this.btnTaoPhieuDat.Appearance.Options.UseFont = true;
            this.btnTaoPhieuDat.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTaoPhieuDat.AppearanceHovered.Options.UseBackColor = true;
            this.btnTaoPhieuDat.Location = new System.Drawing.Point(499, 30);
            this.btnTaoPhieuDat.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnTaoPhieuDat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTaoPhieuDat.Name = "btnTaoPhieuDat";
            this.btnTaoPhieuDat.Size = new System.Drawing.Size(87, 73);
            this.btnTaoPhieuDat.TabIndex = 17;
            this.btnTaoPhieuDat.Text = "Tạo phiếu";
            this.btnTaoPhieuDat.Click += new System.EventHandler(this.btnTaoPhieuDat_Click);
            // 
            // cboMANV
            // 
            this.cboMANV.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMANV.FormattingEnabled = true;
            this.cboMANV.Location = new System.Drawing.Point(158, 86);
            this.cboMANV.Name = "cboMANV";
            this.cboMANV.Size = new System.Drawing.Size(161, 33);
            this.cboMANV.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã hoá đơn";
            // 
            // ucXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMANV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTaoPhieuDat);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.mAHDTextEdit);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucXuatHang";
            this.Size = new System.Drawing.Size(800, 607);
            this.Load += new System.EventHandler(this.ucXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEU_DAT_HANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEU_XUAT_KHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Data.RealTimeSource realTimeSource1;
        private DataSetQLK dataSetQLK;
        private System.Windows.Forms.BindingSource pHIEU_DAT_HANGBindingSource;
        private DataSetQLKTableAdapters.PHIEU_DAT_HANGTableAdapter pHIEU_DAT_HANGTableAdapter;
        private DataSetQLKTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetQLKTableAdapters.PHIEU_XUAT_KHOTableAdapter pHIEU_XUAT_KHOTableAdapter;
        private System.Windows.Forms.BindingSource pHIEU_XUAT_KHOBindingSource;
        private DevExpress.XtraEditors.TextEdit mAHDTextEdit;
        private System.Windows.Forms.BindingSource pHIEUXUATKHOBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnTaoPhieuDat;
        private System.Windows.Forms.ComboBox cboMANV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
