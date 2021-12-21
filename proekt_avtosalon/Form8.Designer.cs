
namespace proekt_avtosalon
{
    partial class Form8
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
            System.Windows.Forms.Label iD_Prodaji_PokupLabel;
            System.Windows.Forms.Label iD_ProdajiLabel;
            System.Windows.Forms.Label iD_PokupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.prodaji_PokupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaji_PokupTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.Prodaji_PokupTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.prodaji_PokupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prodaji_PokupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prodaji_PokupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_Prodaji_PokupTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProdajiTextBox = new System.Windows.Forms.TextBox();
            this.iD_PokupTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_Prodaji_PokupLabel = new System.Windows.Forms.Label();
            iD_ProdajiLabel = new System.Windows.Forms.Label();
            iD_PokupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupBindingNavigator)).BeginInit();
            this.prodaji_PokupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Prodaji_PokupLabel
            // 
            iD_Prodaji_PokupLabel.AutoSize = true;
            iD_Prodaji_PokupLabel.Location = new System.Drawing.Point(14, 242);
            iD_Prodaji_PokupLabel.Name = "iD_Prodaji_PokupLabel";
            iD_Prodaji_PokupLabel.Size = new System.Drawing.Size(90, 13);
            iD_Prodaji_PokupLabel.TabIndex = 2;
            iD_Prodaji_PokupLabel.Text = "ID Prodaji Pokup:";
            // 
            // iD_ProdajiLabel
            // 
            iD_ProdajiLabel.AutoSize = true;
            iD_ProdajiLabel.Location = new System.Drawing.Point(14, 268);
            iD_ProdajiLabel.Name = "iD_ProdajiLabel";
            iD_ProdajiLabel.Size = new System.Drawing.Size(56, 13);
            iD_ProdajiLabel.TabIndex = 4;
            iD_ProdajiLabel.Text = "ID Prodaji:";
            // 
            // iD_PokupLabel
            // 
            iD_PokupLabel.AutoSize = true;
            iD_PokupLabel.Location = new System.Drawing.Point(14, 294);
            iD_PokupLabel.Name = "iD_PokupLabel";
            iD_PokupLabel.Size = new System.Drawing.Size(55, 13);
            iD_PokupLabel.TabIndex = 6;
            iD_PokupLabel.Text = "ID Pokup:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodaji_PokupBindingSource
            // 
            this.prodaji_PokupBindingSource.DataMember = "Prodaji_Pokup";
            this.prodaji_PokupBindingSource.DataSource = this.dataSet1;
            // 
            // prodaji_PokupTableAdapter
            // 
            this.prodaji_PokupTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Prodaji_PokupTableAdapter = this.prodaji_PokupTableAdapter;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prodaji_PokupBindingNavigator
            // 
            this.prodaji_PokupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prodaji_PokupBindingNavigator.BindingSource = this.prodaji_PokupBindingSource;
            this.prodaji_PokupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodaji_PokupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prodaji_PokupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prodaji_PokupBindingNavigatorSaveItem});
            this.prodaji_PokupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prodaji_PokupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prodaji_PokupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prodaji_PokupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodaji_PokupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodaji_PokupBindingNavigator.Name = "prodaji_PokupBindingNavigator";
            this.prodaji_PokupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodaji_PokupBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.prodaji_PokupBindingNavigator.TabIndex = 0;
            this.prodaji_PokupBindingNavigator.Text = "bindingNavigator1";
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
            // prodaji_PokupBindingNavigatorSaveItem
            // 
            this.prodaji_PokupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prodaji_PokupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prodaji_PokupBindingNavigatorSaveItem.Image")));
            this.prodaji_PokupBindingNavigatorSaveItem.Name = "prodaji_PokupBindingNavigatorSaveItem";
            this.prodaji_PokupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prodaji_PokupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prodaji_PokupBindingNavigatorSaveItem.Click += new System.EventHandler(this.prodaji_PokupBindingNavigatorSaveItem_Click);
            // 
            // prodaji_PokupDataGridView
            // 
            this.prodaji_PokupDataGridView.AutoGenerateColumns = false;
            this.prodaji_PokupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodaji_PokupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.prodaji_PokupDataGridView.DataSource = this.prodaji_PokupBindingSource;
            this.prodaji_PokupDataGridView.Location = new System.Drawing.Point(12, 39);
            this.prodaji_PokupDataGridView.Name = "prodaji_PokupDataGridView";
            this.prodaji_PokupDataGridView.Size = new System.Drawing.Size(397, 161);
            this.prodaji_PokupDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Prodaji_Pokup";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Prodaji_Pokup";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Prodaji";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Prodaji";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Pokup";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Pokup";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // iD_Prodaji_PokupTextBox
            // 
            this.iD_Prodaji_PokupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaji_PokupBindingSource, "ID_Prodaji_Pokup", true));
            this.iD_Prodaji_PokupTextBox.Location = new System.Drawing.Point(110, 239);
            this.iD_Prodaji_PokupTextBox.Name = "iD_Prodaji_PokupTextBox";
            this.iD_Prodaji_PokupTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Prodaji_PokupTextBox.TabIndex = 3;
            // 
            // iD_ProdajiTextBox
            // 
            this.iD_ProdajiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaji_PokupBindingSource, "ID_Prodaji", true));
            this.iD_ProdajiTextBox.Location = new System.Drawing.Point(110, 265);
            this.iD_ProdajiTextBox.Name = "iD_ProdajiTextBox";
            this.iD_ProdajiTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProdajiTextBox.TabIndex = 5;
            // 
            // iD_PokupTextBox
            // 
            this.iD_PokupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaji_PokupBindingSource, "ID_Pokup", true));
            this.iD_PokupTextBox.Location = new System.Drawing.Point(110, 291);
            this.iD_PokupTextBox.Name = "iD_PokupTextBox";
            this.iD_PokupTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PokupTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_Prodaji_PokupLabel);
            this.Controls.Add(this.iD_Prodaji_PokupTextBox);
            this.Controls.Add(iD_ProdajiLabel);
            this.Controls.Add(this.iD_ProdajiTextBox);
            this.Controls.Add(iD_PokupLabel);
            this.Controls.Add(this.iD_PokupTextBox);
            this.Controls.Add(this.prodaji_PokupDataGridView);
            this.Controls.Add(this.prodaji_PokupBindingNavigator);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupBindingNavigator)).EndInit();
            this.prodaji_PokupBindingNavigator.ResumeLayout(false);
            this.prodaji_PokupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodaji_PokupDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource prodaji_PokupBindingSource;
        private DataSet1TableAdapters.Prodaji_PokupTableAdapter prodaji_PokupTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodaji_PokupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prodaji_PokupBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prodaji_PokupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iD_Prodaji_PokupTextBox;
        private System.Windows.Forms.TextBox iD_ProdajiTextBox;
        private System.Windows.Forms.TextBox iD_PokupTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}