namespace dbMaintenanceBound
{
    partial class attendBlackOutTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendBlackOutTypes));
            this.attendanceDataSet = new dbMaintenanceBound.AttendanceDataSet();
            this.attendBlackOutTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendBlackOutTypesTableAdapter = new dbMaintenanceBound.AttendanceDataSetTableAdapters.attendBlackOutTypesTableAdapter();
            this.tableAdapterManager = new dbMaintenanceBound.AttendanceDataSetTableAdapters.TableAdapterManager();
            this.attendBlackOutTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attendBlackOutTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendBlackOutTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesBindingNavigator)).BeginInit();
            this.attendBlackOutTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceDataSet
            // 
            this.attendanceDataSet.DataSetName = "AttendanceDataSet";
            this.attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendBlackOutTypesBindingSource
            // 
            this.attendBlackOutTypesBindingSource.DataMember = "attendBlackOutTypes";
            this.attendBlackOutTypesBindingSource.DataSource = this.attendanceDataSet;
            // 
            // attendBlackOutTypesTableAdapter
            // 
            this.attendBlackOutTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activityLogTableAdapter = null;
            this.tableAdapterManager.attendBlackOutTypesTableAdapter = this.attendBlackOutTypesTableAdapter;
            this.tableAdapterManager.attendDoWTableAdapter = null;
            this.tableAdapterManager.attendLogTypesTableAdapter = null;
            this.tableAdapterManager.attendRolesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.blackOutDatesTableAdapter = null;
            this.tableAdapterManager.courseInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbMaintenanceBound.AttendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // attendBlackOutTypesBindingNavigator
            // 
            this.attendBlackOutTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendBlackOutTypesBindingNavigator.BindingSource = this.attendBlackOutTypesBindingSource;
            this.attendBlackOutTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendBlackOutTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendBlackOutTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attendBlackOutTypesBindingNavigatorSaveItem});
            this.attendBlackOutTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendBlackOutTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendBlackOutTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendBlackOutTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendBlackOutTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendBlackOutTypesBindingNavigator.Name = "attendBlackOutTypesBindingNavigator";
            this.attendBlackOutTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendBlackOutTypesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.attendBlackOutTypesBindingNavigator.TabIndex = 0;
            this.attendBlackOutTypesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // attendBlackOutTypesBindingNavigatorSaveItem
            // 
            this.attendBlackOutTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendBlackOutTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendBlackOutTypesBindingNavigatorSaveItem.Image")));
            this.attendBlackOutTypesBindingNavigatorSaveItem.Name = "attendBlackOutTypesBindingNavigatorSaveItem";
            this.attendBlackOutTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.attendBlackOutTypesBindingNavigatorSaveItem.Text = "Save Data";
            this.attendBlackOutTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendBlackOutTypesBindingNavigatorSaveItem_Click);
            // 
            // attendBlackOutTypesDataGridView
            // 
            this.attendBlackOutTypesDataGridView.AutoGenerateColumns = false;
            this.attendBlackOutTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendBlackOutTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.attendBlackOutTypesDataGridView.DataSource = this.attendBlackOutTypesBindingSource;
            this.attendBlackOutTypesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendBlackOutTypesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.attendBlackOutTypesDataGridView.Name = "attendBlackOutTypesDataGridView";
            this.attendBlackOutTypesDataGridView.Size = new System.Drawing.Size(800, 425);
            this.attendBlackOutTypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "blackOutType";
            this.dataGridViewTextBoxColumn2.HeaderText = "blackOutType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // attendBlackOutTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendBlackOutTypesDataGridView);
            this.Controls.Add(this.attendBlackOutTypesBindingNavigator);
            this.Name = "attendBlackOutTypes";
            this.Text = "attendBlackOutTypes";
            this.Load += new System.EventHandler(this.attendBlackOutTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesBindingNavigator)).EndInit();
            this.attendBlackOutTypesBindingNavigator.ResumeLayout(false);
            this.attendBlackOutTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendBlackOutTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AttendanceDataSet attendanceDataSet;
        private System.Windows.Forms.BindingSource attendBlackOutTypesBindingSource;
        private AttendanceDataSetTableAdapters.attendBlackOutTypesTableAdapter attendBlackOutTypesTableAdapter;
        private AttendanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendBlackOutTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attendBlackOutTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendBlackOutTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}