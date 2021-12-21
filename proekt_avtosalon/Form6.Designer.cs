
namespace proekt_avtosalon
{
    partial class Form6
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
            System.Windows.Forms.Label iD_Firma_AvtoLabel;
            System.Windows.Forms.Label iD_FirmaLabel;
            System.Windows.Forms.Label iD_AvtoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.firma_AvtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firma_AvtoTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.Firma_AvtoTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.firma_AvtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.firma_AvtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firma_AvtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iD_Firma_AvtoTextBox = new System.Windows.Forms.TextBox();
            this.iD_FirmaTextBox = new System.Windows.Forms.TextBox();
            this.iD_AvtoTextBox = new System.Windows.Forms.TextBox();
            iD_Firma_AvtoLabel = new System.Windows.Forms.Label();
            iD_FirmaLabel = new System.Windows.Forms.Label();
            iD_AvtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoBindingNavigator)).BeginInit();
            this.firma_AvtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Firma_AvtoLabel
            // 
            iD_Firma_AvtoLabel.AutoSize = true;
            iD_Firma_AvtoLabel.Location = new System.Drawing.Point(9, 258);
            iD_Firma_AvtoLabel.Name = "iD_Firma_AvtoLabel";
            iD_Firma_AvtoLabel.Size = new System.Drawing.Size(74, 13);
            iD_Firma_AvtoLabel.TabIndex = 4;
            iD_Firma_AvtoLabel.Text = "ID Firma Avto:";
            // 
            // iD_FirmaLabel
            // 
            iD_FirmaLabel.AutoSize = true;
            iD_FirmaLabel.Location = new System.Drawing.Point(9, 284);
            iD_FirmaLabel.Name = "iD_FirmaLabel";
            iD_FirmaLabel.Size = new System.Drawing.Size(49, 13);
            iD_FirmaLabel.TabIndex = 6;
            iD_FirmaLabel.Text = "ID Firma:";
            // 
            // iD_AvtoLabel
            // 
            iD_AvtoLabel.AutoSize = true;
            iD_AvtoLabel.Location = new System.Drawing.Point(9, 310);
            iD_AvtoLabel.Name = "iD_AvtoLabel";
            iD_AvtoLabel.Size = new System.Drawing.Size(46, 13);
            iD_AvtoLabel.TabIndex = 8;
            iD_AvtoLabel.Text = "ID Avto:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firma_AvtoBindingSource
            // 
            this.firma_AvtoBindingSource.DataMember = "Firma_Avto";
            this.firma_AvtoBindingSource.DataSource = this.dataSet1;
            // 
            // firma_AvtoTableAdapter
            // 
            this.firma_AvtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = this.firma_AvtoTableAdapter;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firma_AvtoBindingNavigator
            // 
            this.firma_AvtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.firma_AvtoBindingNavigator.BindingSource = this.firma_AvtoBindingSource;
            this.firma_AvtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.firma_AvtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.firma_AvtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.firma_AvtoBindingNavigatorSaveItem});
            this.firma_AvtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.firma_AvtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.firma_AvtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.firma_AvtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.firma_AvtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.firma_AvtoBindingNavigator.Name = "firma_AvtoBindingNavigator";
            this.firma_AvtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.firma_AvtoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.firma_AvtoBindingNavigator.TabIndex = 0;
            this.firma_AvtoBindingNavigator.Text = "bindingNavigator1";
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
            // firma_AvtoBindingNavigatorSaveItem
            // 
            this.firma_AvtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firma_AvtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("firma_AvtoBindingNavigatorSaveItem.Image")));
            this.firma_AvtoBindingNavigatorSaveItem.Name = "firma_AvtoBindingNavigatorSaveItem";
            this.firma_AvtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.firma_AvtoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.firma_AvtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.firma_AvtoBindingNavigatorSaveItem_Click);
            // 
            // firma_AvtoDataGridView
            // 
            this.firma_AvtoDataGridView.AutoGenerateColumns = false;
            this.firma_AvtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firma_AvtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.firma_AvtoDataGridView.DataSource = this.firma_AvtoBindingSource;
            this.firma_AvtoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.firma_AvtoDataGridView.Name = "firma_AvtoDataGridView";
            this.firma_AvtoDataGridView.Size = new System.Drawing.Size(417, 204);
            this.firma_AvtoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Firma_Avto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Firma_Avto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Firma";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Firma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Avto";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Avto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iD_Firma_AvtoTextBox
            // 
            this.iD_Firma_AvtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firma_AvtoBindingSource, "ID_Firma_Avto", true));
            this.iD_Firma_AvtoTextBox.Location = new System.Drawing.Point(89, 255);
            this.iD_Firma_AvtoTextBox.Name = "iD_Firma_AvtoTextBox";
            this.iD_Firma_AvtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Firma_AvtoTextBox.TabIndex = 5;
            // 
            // iD_FirmaTextBox
            // 
            this.iD_FirmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firma_AvtoBindingSource, "ID_Firma", true));
            this.iD_FirmaTextBox.Location = new System.Drawing.Point(89, 281);
            this.iD_FirmaTextBox.Name = "iD_FirmaTextBox";
            this.iD_FirmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_FirmaTextBox.TabIndex = 7;
            // 
            // iD_AvtoTextBox
            // 
            this.iD_AvtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firma_AvtoBindingSource, "ID_Avto", true));
            this.iD_AvtoTextBox.Location = new System.Drawing.Point(89, 307);
            this.iD_AvtoTextBox.Name = "iD_AvtoTextBox";
            this.iD_AvtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_AvtoTextBox.TabIndex = 9;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_Firma_AvtoLabel);
            this.Controls.Add(this.iD_Firma_AvtoTextBox);
            this.Controls.Add(iD_FirmaLabel);
            this.Controls.Add(this.iD_FirmaTextBox);
            this.Controls.Add(iD_AvtoLabel);
            this.Controls.Add(this.iD_AvtoTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firma_AvtoDataGridView);
            this.Controls.Add(this.firma_AvtoBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoBindingNavigator)).EndInit();
            this.firma_AvtoBindingNavigator.ResumeLayout(false);
            this.firma_AvtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firma_AvtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource firma_AvtoBindingSource;
        private DataSet1TableAdapters.Firma_AvtoTableAdapter firma_AvtoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator firma_AvtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton firma_AvtoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView firma_AvtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iD_Firma_AvtoTextBox;
        private System.Windows.Forms.TextBox iD_FirmaTextBox;
        private System.Windows.Forms.TextBox iD_AvtoTextBox;
    }
}