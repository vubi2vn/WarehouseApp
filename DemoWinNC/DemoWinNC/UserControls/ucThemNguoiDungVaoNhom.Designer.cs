namespace DemoWinNC.UserControls
{
    partial class ucThemNguoiDungVaoNhom
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
            System.Windows.Forms.Label mANHOMNGUOIDUNGLabel;
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLK = new DemoWinNC.DataSetQLK();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOATDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENDN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHOMNGUOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tAIKHOANTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager();
            this.nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter();
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter();
            this.qL_NHOMNGUOIDUNGTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANHOMNGUOIDUNGComboBox = new System.Windows.Forms.ComboBox();
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mANHOMNGUOIDUNGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHOMNGUOIDUNGLabel
            // 
            mANHOMNGUOIDUNGLabel.AutoSize = true;
            mANHOMNGUOIDUNGLabel.Location = new System.Drawing.Point(422, 64);
            mANHOMNGUOIDUNGLabel.Name = "mANHOMNGUOIDUNGLabel";
            mANHOMNGUOIDUNGLabel.Size = new System.Drawing.Size(105, 25);
            mANHOMNGUOIDUNGLabel.TabIndex = 3;
            mANHOMNGUOIDUNGLabel.Text = "Mã nhóm";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tAIKHOANBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(354, 518);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.dataSetQLK;
            // 
            // dataSetQLK
            // 
            this.dataSetQLK.DataSetName = "DataSetQLK";
            this.dataSetQLK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colTENDN,
            this.colMATKHAU,
            this.colHOATDONG});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.PaintStyleName = "UltraFlat";
            // 
            // colTENDN
            // 
            this.colTENDN.FieldName = "TENDN";
            this.colTENDN.MinWidth = 25;
            this.colTENDN.Name = "colTENDN";
            this.colTENDN.Visible = true;
            this.colTENDN.VisibleIndex = 0;
            this.colTENDN.Width = 94;
            // 
            // colMATKHAU
            // 
            this.colMATKHAU.FieldName = "MATKHAU";
            this.colMATKHAU.MinWidth = 25;
            this.colMATKHAU.Name = "colMATKHAU";
            this.colMATKHAU.Visible = true;
            this.colMATKHAU.VisibleIndex = 1;
            this.colMATKHAU.Width = 94;
            // 
            // colHOATDONG
            // 
            this.colHOATDONG.FieldName = "HOATDONG";
            this.colHOATDONG.MinWidth = 25;
            this.colHOATDONG.Name = "colHOATDONG";
            this.colHOATDONG.Visible = true;
            this.colHOATDONG.VisibleIndex = 2;
            this.colHOATDONG.Width = 94;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(427, 100);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(370, 474);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource.DataMember = "NGUOIDUNG_NHOMNGUOIDUNGDK";
            this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource.DataSource = this.dataSetQLK;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENDN1,
            this.colMANHOMNGUOIDUNG});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.PaintStyleName = "UltraFlat";
            // 
            // colTENDN1
            // 
            this.colTENDN1.FieldName = "TENDN";
            this.colTENDN1.MinWidth = 25;
            this.colTENDN1.Name = "colTENDN1";
            this.colTENDN1.Visible = true;
            this.colTENDN1.VisibleIndex = 0;
            this.colTENDN1.Width = 94;
            // 
            // colMANHOMNGUOIDUNG
            // 
            this.colMANHOMNGUOIDUNG.FieldName = "MANHOMNGUOIDUNG";
            this.colMANHOMNGUOIDUNG.MinWidth = 25;
            this.colMANHOMNGUOIDUNG.Name = "colMANHOMNGUOIDUNG";
            this.colMANHOMNGUOIDUNG.Visible = true;
            this.colMANHOMNGUOIDUNG.VisibleIndex = 1;
            this.colMANHOMNGUOIDUNG.Width = 94;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEU_DATTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = null;
            this.tableAdapterManager.KE_HANGTableAdapter = null;
            this.tableAdapterManager.KHU_VUCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter = this.nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.UpdateOrder = DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // mANHOMNGUOIDUNGComboBox
            // 
            this.mANHOMNGUOIDUNGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NHOMNGUOIDUNGBindingSource, "MANHOMNGUOIDUNG", true));
            this.mANHOMNGUOIDUNGComboBox.DataSource = this.qLNHOMNGUOIDUNGBindingSource;
            this.mANHOMNGUOIDUNGComboBox.FormattingEnabled = true;
            this.mANHOMNGUOIDUNGComboBox.Location = new System.Drawing.Point(533, 58);
            this.mANHOMNGUOIDUNGComboBox.Name = "mANHOMNGUOIDUNGComboBox";
            this.mANHOMNGUOIDUNGComboBox.Size = new System.Drawing.Size(219, 33);
            this.mANHOMNGUOIDUNGComboBox.TabIndex = 4;
            this.mANHOMNGUOIDUNGComboBox.SelectedIndexChanged += new System.EventHandler(this.mANHOMNGUOIDUNGComboBox_SelectedIndexChanged);
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGBindingSource
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataMember = "NGUOIDUNG_NHOMNGUOIDUNG";
            this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(363, 232);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(57, 36);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = ">>>";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // nGUOIDUNGNHOMNGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataMember = "NGUOIDUNG_NHOMNGUOIDUNG";
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // qLNHOMNGUOIDUNGBindingSource
            // 
            this.qLNHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qLNHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLK;
            // 
            // ucThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(mANHOMNGUOIDUNGLabel);
            this.Controls.Add(this.mANHOMNGUOIDUNGComboBox);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucThemNguoiDungVaoNhom";
            this.Size = new System.Drawing.Size(835, 600);
            this.Load += new System.EventHandler(this.ucThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNG_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DataSetQLK dataSetQLK;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDN;
        private DevExpress.XtraGrid.Columns.GridColumn colMATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn colHOATDONG;
        private DataSetQLKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DataSetQLKTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetQLKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.ComboBox mANHOMNGUOIDUNGComboBox;
        private DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter nGUOIDUNG_NHOMNGUOIDUNGDKTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIDUNG_NHOMNGUOIDUNGDKBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHOMNGUOIDUNG;
        private DataSetQLKTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter nGUOIDUNG_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIDUNG_NHOMNGUOIDUNGBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource qLNHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.BindingSource nGUOIDUNGNHOMNGUOIDUNGBindingSource;
    }
}
