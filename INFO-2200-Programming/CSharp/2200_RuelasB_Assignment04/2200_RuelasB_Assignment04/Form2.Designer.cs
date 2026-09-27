namespace _2200_RuelasB_Assignment04
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.iNFO2200_CrandallSayDataSet1 = new _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSet1();
            this.countMovieCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countMovieCategoryTableAdapter = new _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSet1TableAdapters.CountMovieCategoryTableAdapter();
            this.tableAdapterManager = new _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager();
            this.countMovieCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.countMovieCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countMovieCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingNavigator)).BeginInit();
            this.countMovieCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iNFO2200_CrandallSayDataSet1
            // 
            this.iNFO2200_CrandallSayDataSet1.DataSetName = "INFO2200_CrandallSayDataSet1";
            this.iNFO2200_CrandallSayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countMovieCategoryBindingSource
            // 
            this.countMovieCategoryBindingSource.DataMember = "CountMovieCategory";
            this.countMovieCategoryBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet1;
            // 
            // countMovieCategoryTableAdapter
            // 
            this.countMovieCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countMovieCategoryBindingNavigator
            // 
            this.countMovieCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countMovieCategoryBindingNavigator.BindingSource = this.countMovieCategoryBindingSource;
            this.countMovieCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countMovieCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countMovieCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countMovieCategoryBindingNavigatorSaveItem});
            this.countMovieCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countMovieCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countMovieCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countMovieCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countMovieCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countMovieCategoryBindingNavigator.Name = "countMovieCategoryBindingNavigator";
            this.countMovieCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countMovieCategoryBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.countMovieCategoryBindingNavigator.TabIndex = 0;
            this.countMovieCategoryBindingNavigator.Text = "bindingNavigator1";
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
            // countMovieCategoryBindingNavigatorSaveItem
            // 
            this.countMovieCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countMovieCategoryBindingNavigatorSaveItem.Enabled = false;
            this.countMovieCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countMovieCategoryBindingNavigatorSaveItem.Image")));
            this.countMovieCategoryBindingNavigatorSaveItem.Name = "countMovieCategoryBindingNavigatorSaveItem";
            this.countMovieCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.countMovieCategoryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // countMovieCategoryDataGridView
            // 
            this.countMovieCategoryDataGridView.AutoGenerateColumns = false;
            this.countMovieCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countMovieCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.countMovieCategoryDataGridView.DataSource = this.countMovieCategoryBindingSource;
            this.countMovieCategoryDataGridView.Location = new System.Drawing.Point(12, 28);
            this.countMovieCategoryDataGridView.Name = "countMovieCategoryDataGridView";
            this.countMovieCategoryDataGridView.Size = new System.Drawing.Size(300, 220);
            this.countMovieCategoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn1.HeaderText = "category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "MovieCount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countMovieCategoryDataGridView);
            this.Controls.Add(this.countMovieCategoryBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingNavigator)).EndInit();
            this.countMovieCategoryBindingNavigator.ResumeLayout(false);
            this.countMovieCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSet1 iNFO2200_CrandallSayDataSet1;
        private System.Windows.Forms.BindingSource countMovieCategoryBindingSource;
        private INFO2200_CrandallSayDataSet1TableAdapters.CountMovieCategoryTableAdapter countMovieCategoryTableAdapter;
        private INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countMovieCategoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton countMovieCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countMovieCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}