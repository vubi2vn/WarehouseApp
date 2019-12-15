namespace DemoWinNC
{
    partial class frmLuuTru
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSetQLK = new DemoWinNC.DataSetQLK();
            this.kE_HANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kE_HANGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.KE_HANGTableAdapter();
            this.tableAdapterManager = new DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kE_HANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 285);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(826, 417);
            this.gridControl1.TabIndex = 1;
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
            this.colMANCC,
            this.colTENNCC,
            this.colSODIENTHOAI,
            this.colDIACHI,
            this.colGHICHU});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.PaintStyleName = "UltraFlat";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMANCC
            // 
            this.colMANCC.Caption = "Mã NCC";
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.MinWidth = 25;
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 0;
            this.colMANCC.Width = 94;
            // 
            // colTENNCC
            // 
            this.colTENNCC.Caption = "Tên NCC";
            this.colTENNCC.FieldName = "TENNCC";
            this.colTENNCC.MinWidth = 25;
            this.colTENNCC.Name = "colTENNCC";
            this.colTENNCC.Visible = true;
            this.colTENNCC.VisibleIndex = 1;
            this.colTENNCC.Width = 94;
            // 
            // colSODIENTHOAI
            // 
            this.colSODIENTHOAI.Caption = "Số điện thoại";
            this.colSODIENTHOAI.FieldName = "SODIENTHOAI";
            this.colSODIENTHOAI.MinWidth = 25;
            this.colSODIENTHOAI.Name = "colSODIENTHOAI";
            this.colSODIENTHOAI.Visible = true;
            this.colSODIENTHOAI.VisibleIndex = 2;
            this.colSODIENTHOAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colGHICHU
            // 
            this.colGHICHU.Caption = "Ghi chú";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 25;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 4;
            this.colGHICHU.Width = 94;
            // 
            // dataSetQLK
            // 
            this.dataSetQLK.DataSetName = "DataSetQLK";
            this.dataSetQLK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kE_HANGBindingSource
            // 
            this.kE_HANGBindingSource.DataMember = "KE_HANG";
            this.kE_HANGBindingSource.DataSource = this.dataSetQLK;
            // 
            // kE_HANGTableAdapter
            // 
            this.kE_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEU_DATTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = null;
            this.tableAdapterManager.KE_HANGTableAdapter = this.kE_HANGTableAdapter;
            this.tableAdapterManager.KHU_VUCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 714);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmLuuTru";
            this.Text = "frmLuuTru";
            this.Load += new System.EventHandler(this.frmLuuTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kE_HANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSODIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DataSetQLK dataSetQLK;
        private System.Windows.Forms.BindingSource kE_HANGBindingSource;
        private DataSetQLKTableAdapters.KE_HANGTableAdapter kE_HANGTableAdapter;
        private DataSetQLKTableAdapters.TableAdapterManager tableAdapterManager;
    }
}