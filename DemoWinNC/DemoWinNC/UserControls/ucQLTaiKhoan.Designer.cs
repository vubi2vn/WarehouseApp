namespace DemoWinNC.UserControls
{
    partial class ucQLTaiKhoan
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLTaiKhoan));
            System.Windows.Forms.Label tENDNLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label hOATDONGLabel;
            this.dataSetQLK = new DemoWinNC.DataSetQLK();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new DemoWinNC.DataSetQLKTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager();
            this.tAIKHOANBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tAIKHOANBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tAIKHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tENDNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mATKHAUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOATDONGCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            label1 = new System.Windows.Forms.Label();
            tENDNLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            hOATDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingNavigator)).BeginInit();
            this.tAIKHOANBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATKHAUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(21, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 36);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản";
            // 
            // dataSetQLK
            // 
            this.dataSetQLK.DataSetName = "DataSetQLK";
            this.dataSetQLK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEU_DATTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = null;
            this.tableAdapterManager.KE_HANGTableAdapter = null;
            this.tableAdapterManager.KHU_VUCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.UpdateOrder = DemoWinNC.DataSetQLKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAIKHOANBindingNavigator
            // 
            this.tAIKHOANBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAIKHOANBindingNavigator.BindingSource = this.tAIKHOANBindingSource;
            this.tAIKHOANBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAIKHOANBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAIKHOANBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tAIKHOANBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tAIKHOANBindingNavigatorSaveItem});
            this.tAIKHOANBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAIKHOANBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAIKHOANBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAIKHOANBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAIKHOANBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAIKHOANBindingNavigator.Name = "tAIKHOANBindingNavigator";
            this.tAIKHOANBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAIKHOANBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tAIKHOANBindingNavigator.TabIndex = 9;
            this.tAIKHOANBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tAIKHOANBindingNavigatorSaveItem
            // 
            this.tAIKHOANBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAIKHOANBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAIKHOANBindingNavigatorSaveItem.Image")));
            this.tAIKHOANBindingNavigatorSaveItem.Name = "tAIKHOANBindingNavigatorSaveItem";
            this.tAIKHOANBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tAIKHOANBindingNavigatorSaveItem.Text = "Save Data";
            this.tAIKHOANBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAIKHOANBindingNavigatorSaveItem_Click);
            // 
            // tAIKHOANGridControl
            // 
            this.tAIKHOANGridControl.DataSource = this.tAIKHOANBindingSource;
            this.tAIKHOANGridControl.Location = new System.Drawing.Point(18, 228);
            this.tAIKHOANGridControl.MainView = this.gridView1;
            this.tAIKHOANGridControl.Name = "tAIKHOANGridControl";
            this.tAIKHOANGridControl.Size = new System.Drawing.Size(760, 354);
            this.tAIKHOANGridControl.TabIndex = 9;
            this.tAIKHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tAIKHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // tENDNLabel
            // 
            tENDNLabel.AutoSize = true;
            tENDNLabel.Location = new System.Drawing.Point(49, 94);
            tENDNLabel.Name = "tENDNLabel";
            tENDNLabel.Size = new System.Drawing.Size(138, 20);
            tENDNLabel.TabIndex = 9;
            tENDNLabel.Text = "Tên đăng nhập";
            // 
            // tENDNTextEdit
            // 
            this.tENDNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "TENDN", true));
            this.tENDNTextEdit.Location = new System.Drawing.Point(187, 91);
            this.tENDNTextEdit.Name = "tENDNTextEdit";
            this.tENDNTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENDNTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENDNTextEdit.Size = new System.Drawing.Size(183, 26);
            this.tENDNTextEdit.TabIndex = 10;
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(49, 122);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(88, 20);
            mATKHAULabel.TabIndex = 11;
            mATKHAULabel.Text = "Mật khẩu";
            // 
            // mATKHAUTextEdit
            // 
            this.mATKHAUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "MATKHAU", true));
            this.mATKHAUTextEdit.Location = new System.Drawing.Point(187, 119);
            this.mATKHAUTextEdit.Name = "mATKHAUTextEdit";
            this.mATKHAUTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATKHAUTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mATKHAUTextEdit.Size = new System.Drawing.Size(183, 26);
            this.mATKHAUTextEdit.TabIndex = 12;
            // 
            // hOATDONGLabel
            // 
            hOATDONGLabel.AutoSize = true;
            hOATDONGLabel.Location = new System.Drawing.Point(49, 150);
            hOATDONGLabel.Name = "hOATDONGLabel";
            hOATDONGLabel.Size = new System.Drawing.Size(98, 20);
            hOATDONGLabel.TabIndex = 13;
            hOATDONGLabel.Text = "Hoạt động";
            // 
            // hOATDONGCheckEdit
            // 
            this.hOATDONGCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "HOATDONG", true));
            this.hOATDONGCheckEdit.Location = new System.Drawing.Point(187, 151);
            this.hOATDONGCheckEdit.Name = "hOATDONGCheckEdit";
            this.hOATDONGCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOATDONGCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.hOATDONGCheckEdit.Properties.Caption = "";
            this.hOATDONGCheckEdit.Size = new System.Drawing.Size(125, 19);
            this.hOATDONGCheckEdit.TabIndex = 14;
            // 
            // ucQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(tENDNLabel);
            this.Controls.Add(this.tENDNTextEdit);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(this.mATKHAUTextEdit);
            this.Controls.Add(hOATDONGLabel);
            this.Controls.Add(this.hOATDONGCheckEdit);
            this.Controls.Add(this.tAIKHOANGridControl);
            this.Controls.Add(this.tAIKHOANBindingNavigator);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucQLTaiKhoan";
            this.Size = new System.Drawing.Size(800, 602);
            this.Load += new System.EventHandler(this.ucQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingNavigator)).EndInit();
            this.tAIKHOANBindingNavigator.ResumeLayout(false);
            this.tAIKHOANBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATKHAUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetQLK dataSetQLK;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DataSetQLKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DataSetQLKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAIKHOANBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tAIKHOANBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl tAIKHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit tENDNTextEdit;
        private DevExpress.XtraEditors.TextEdit mATKHAUTextEdit;
        private DevExpress.XtraEditors.CheckEdit hOATDONGCheckEdit;
    }
}
