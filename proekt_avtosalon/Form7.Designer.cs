
namespace proekt_avtosalon
{
    partial class Form7
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
            System.Windows.Forms.Label iD_ProdajiLabel;
            System.Windows.Forms.Label iD_PersLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label stoimostLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.prodajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodajiTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.ProdajiTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.prodajiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prodajiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prodajiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_ProdajiTextBox = new System.Windows.Forms.TextBox();
            this.iD_PersTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stoimostTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_ProdajiLabel = new System.Windows.Forms.Label();
            iD_PersLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            stoimostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingNavigator)).BeginInit();
            this.prodajiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ProdajiLabel
            // 
            iD_ProdajiLabel.AutoSize = true;
            iD_ProdajiLabel.Location = new System.Drawing.Point(12, 239);
            iD_ProdajiLabel.Name = "iD_ProdajiLabel";
            iD_ProdajiLabel.Size = new System.Drawing.Size(56, 13);
            iD_ProdajiLabel.TabIndex = 2;
            iD_ProdajiLabel.Text = "ID Prodaji:";
            // 
            // iD_PersLabel
            // 
            iD_PersLabel.AutoSize = true;
            iD_PersLabel.Location = new System.Drawing.Point(12, 265);
            iD_PersLabel.Name = "iD_PersLabel";
            iD_PersLabel.Size = new System.Drawing.Size(45, 13);
            iD_PersLabel.TabIndex = 4;
            iD_PersLabel.Text = "ID Pers:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(12, 292);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "Data:";
            // 
            // stoimostLabel
            // 
            stoimostLabel.AutoSize = true;
            stoimostLabel.Location = new System.Drawing.Point(12, 317);
            stoimostLabel.Name = "stoimostLabel";
            stoimostLabel.Size = new System.Drawing.Size(50, 13);
            stoimostLabel.TabIndex = 8;
            stoimostLabel.Text = "Stoimost:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodajiBindingSource
            // 
            this.prodajiBindingSource.DataMember = "Prodaji";
            this.prodajiBindingSource.DataSource = this.dataSet1;
            // 
            // prodajiTableAdapter
            // 
            this.prodajiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = this.prodajiTableAdapter;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prodajiBindingNavigator
            // 
            this.prodajiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prodajiBindingNavigator.BindingSource = this.prodajiBindingSource;
            this.prodajiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodajiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prodajiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prodajiBindingNavigatorSaveItem});
            this.prodajiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prodajiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prodajiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prodajiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodajiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodajiBindingNavigator.Name = "prodajiBindingNavigator";
            this.prodajiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodajiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.prodajiBindingNavigator.TabIndex = 0;
            this.prodajiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prodajiBindingNavigatorSaveItem
            // 
            this.prodajiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prodajiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prodajiBindingNavigatorSaveItem.Image")));
            this.prodajiBindingNavigatorSaveItem.Name = "prodajiBindingNavigatorSaveItem";
            this.prodajiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prodajiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prodajiBindingNavigatorSaveItem.Click += new System.EventHandler(this.prodajiBindingNavigatorSaveItem_Click);
            // 
            // prodajiDataGridView
            // 
            this.prodajiDataGridView.AutoGenerateColumns = false;
            this.prodajiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodajiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prodajiDataGridView.DataSource = this.prodajiBindingSource;
            this.prodajiDataGridView.Location = new System.Drawing.Point(12, 38);
            this.prodajiDataGridView.Name = "prodajiDataGridView";
            this.prodajiDataGridView.Size = new System.Drawing.Size(511, 192);
            this.prodajiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Prodaji";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Prodaji";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Pers";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Pers";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stoimost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stoimost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iD_ProdajiTextBox
            // 
            this.iD_ProdajiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodajiBindingSource, "ID_Prodaji", true));
            this.iD_ProdajiTextBox.Location = new System.Drawing.Point(74, 236);
            this.iD_ProdajiTextBox.Name = "iD_ProdajiTextBox";
            this.iD_ProdajiTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ProdajiTextBox.TabIndex = 3;
            // 
            // iD_PersTextBox
            // 
            this.iD_PersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodajiBindingSource, "ID_Pers", true));
            this.iD_PersTextBox.Location = new System.Drawing.Point(74, 262);
            this.iD_PersTextBox.Name = "iD_PersTextBox";
            this.iD_PersTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PersTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prodajiBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(74, 288);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // stoimostTextBox
            // 
            this.stoimostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodajiBindingSource, "Stoimost", true));
            this.stoimostTextBox.Location = new System.Drawing.Point(74, 314);
            this.stoimostTextBox.Name = "stoimostTextBox";
            this.stoimostTextBox.Size = new System.Drawing.Size(200, 20);
            this.stoimostTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_ProdajiLabel);
            this.Controls.Add(this.iD_ProdajiTextBox);
            this.Controls.Add(iD_PersLabel);
            this.Controls.Add(this.iD_PersTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(stoimostLabel);
            this.Controls.Add(this.stoimostTextBox);
            this.Controls.Add(this.prodajiDataGridView);
            this.Controls.Add(this.prodajiBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiBindingNavigator)).EndInit();
            this.prodajiBindingNavigator.ResumeLayout(false);
            this.prodajiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodajiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource prodajiBindingSource;
        private DataSet1TableAdapters.ProdajiTableAdapter prodajiTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodajiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prodajiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prodajiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iD_ProdajiTextBox;
        private System.Windows.Forms.TextBox iD_PersTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox stoimostTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}