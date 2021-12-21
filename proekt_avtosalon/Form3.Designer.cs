
namespace proekt_avtosalon
{
    partial class Form3
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
            System.Windows.Forms.Label iD_Avto_ProdajiLabel;
            System.Windows.Forms.Label iD_AvtoLabel;
            System.Windows.Forms.Label iD_ProdajiLabel;
            System.Windows.Forms.Label avto_NameLabel;
            System.Windows.Forms.Label avto_KolvoLabel;
            System.Windows.Forms.Label summaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.avto_ProdajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avto_ProdajiTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.Avto_ProdajiTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.avto_ProdajiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avto_ProdajiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avto_ProdajiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_Avto_ProdajiTextBox = new System.Windows.Forms.TextBox();
            this.iD_AvtoTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProdajiTextBox = new System.Windows.Forms.TextBox();
            this.avto_NameTextBox = new System.Windows.Forms.TextBox();
            this.avto_KolvoTextBox = new System.Windows.Forms.TextBox();
            this.summaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_Avto_ProdajiLabel = new System.Windows.Forms.Label();
            iD_AvtoLabel = new System.Windows.Forms.Label();
            iD_ProdajiLabel = new System.Windows.Forms.Label();
            avto_NameLabel = new System.Windows.Forms.Label();
            avto_KolvoLabel = new System.Windows.Forms.Label();
            summaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiBindingNavigator)).BeginInit();
            this.avto_ProdajiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Avto_ProdajiLabel
            // 
            iD_Avto_ProdajiLabel.AutoSize = true;
            iD_Avto_ProdajiLabel.Location = new System.Drawing.Point(12, 269);
            iD_Avto_ProdajiLabel.Name = "iD_Avto_ProdajiLabel";
            iD_Avto_ProdajiLabel.Size = new System.Drawing.Size(81, 13);
            iD_Avto_ProdajiLabel.TabIndex = 2;
            iD_Avto_ProdajiLabel.Text = "ID Avto Prodaji:";
            // 
            // iD_AvtoLabel
            // 
            iD_AvtoLabel.AutoSize = true;
            iD_AvtoLabel.Location = new System.Drawing.Point(12, 295);
            iD_AvtoLabel.Name = "iD_AvtoLabel";
            iD_AvtoLabel.Size = new System.Drawing.Size(46, 13);
            iD_AvtoLabel.TabIndex = 4;
            iD_AvtoLabel.Text = "ID Avto:";
            // 
            // iD_ProdajiLabel
            // 
            iD_ProdajiLabel.AutoSize = true;
            iD_ProdajiLabel.Location = new System.Drawing.Point(12, 321);
            iD_ProdajiLabel.Name = "iD_ProdajiLabel";
            iD_ProdajiLabel.Size = new System.Drawing.Size(56, 13);
            iD_ProdajiLabel.TabIndex = 6;
            iD_ProdajiLabel.Text = "ID Prodaji:";
            // 
            // avto_NameLabel
            // 
            avto_NameLabel.AutoSize = true;
            avto_NameLabel.Location = new System.Drawing.Point(225, 269);
            avto_NameLabel.Name = "avto_NameLabel";
            avto_NameLabel.Size = new System.Drawing.Size(63, 13);
            avto_NameLabel.TabIndex = 8;
            avto_NameLabel.Text = "Avto Name:";
            // 
            // avto_KolvoLabel
            // 
            avto_KolvoLabel.AutoSize = true;
            avto_KolvoLabel.Location = new System.Drawing.Point(225, 295);
            avto_KolvoLabel.Name = "avto_KolvoLabel";
            avto_KolvoLabel.Size = new System.Drawing.Size(62, 13);
            avto_KolvoLabel.TabIndex = 10;
            avto_KolvoLabel.Text = "Avto Kolvo:";
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Location = new System.Drawing.Point(225, 321);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new System.Drawing.Size(45, 13);
            summaLabel.TabIndex = 12;
            summaLabel.Text = "Summa:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avto_ProdajiBindingSource
            // 
            this.avto_ProdajiBindingSource.DataMember = "Avto_Prodaji";
            this.avto_ProdajiBindingSource.DataSource = this.dataSet1;
            // 
            // avto_ProdajiTableAdapter
            // 
            this.avto_ProdajiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = this.avto_ProdajiTableAdapter;
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // avto_ProdajiBindingNavigator
            // 
            this.avto_ProdajiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avto_ProdajiBindingNavigator.BindingSource = this.avto_ProdajiBindingSource;
            this.avto_ProdajiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avto_ProdajiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avto_ProdajiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.avto_ProdajiBindingNavigatorSaveItem});
            this.avto_ProdajiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avto_ProdajiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avto_ProdajiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avto_ProdajiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avto_ProdajiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avto_ProdajiBindingNavigator.Name = "avto_ProdajiBindingNavigator";
            this.avto_ProdajiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avto_ProdajiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.avto_ProdajiBindingNavigator.TabIndex = 0;
            this.avto_ProdajiBindingNavigator.Text = "bindingNavigator1";
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
            // avto_ProdajiBindingNavigatorSaveItem
            // 
            this.avto_ProdajiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avto_ProdajiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avto_ProdajiBindingNavigatorSaveItem.Image")));
            this.avto_ProdajiBindingNavigatorSaveItem.Name = "avto_ProdajiBindingNavigatorSaveItem";
            this.avto_ProdajiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.avto_ProdajiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.avto_ProdajiBindingNavigatorSaveItem.Click += new System.EventHandler(this.avto_ProdajiBindingNavigatorSaveItem_Click);
            // 
            // avto_ProdajiDataGridView
            // 
            this.avto_ProdajiDataGridView.AutoGenerateColumns = false;
            this.avto_ProdajiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avto_ProdajiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.avto_ProdajiDataGridView.DataSource = this.avto_ProdajiBindingSource;
            this.avto_ProdajiDataGridView.Location = new System.Drawing.Point(12, 28);
            this.avto_ProdajiDataGridView.Name = "avto_ProdajiDataGridView";
            this.avto_ProdajiDataGridView.Size = new System.Drawing.Size(744, 230);
            this.avto_ProdajiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Avto_Prodaji";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Avto_Prodaji";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Avto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Avto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Prodaji";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Prodaji";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Avto_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Avto_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Avto_Kolvo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Avto_Kolvo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Summa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Summa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iD_Avto_ProdajiTextBox
            // 
            this.iD_Avto_ProdajiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "ID_Avto_Prodaji", true));
            this.iD_Avto_ProdajiTextBox.Location = new System.Drawing.Point(99, 266);
            this.iD_Avto_ProdajiTextBox.Name = "iD_Avto_ProdajiTextBox";
            this.iD_Avto_ProdajiTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Avto_ProdajiTextBox.TabIndex = 3;
            // 
            // iD_AvtoTextBox
            // 
            this.iD_AvtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "ID_Avto", true));
            this.iD_AvtoTextBox.Location = new System.Drawing.Point(99, 292);
            this.iD_AvtoTextBox.Name = "iD_AvtoTextBox";
            this.iD_AvtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_AvtoTextBox.TabIndex = 5;
            // 
            // iD_ProdajiTextBox
            // 
            this.iD_ProdajiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "ID_Prodaji", true));
            this.iD_ProdajiTextBox.Location = new System.Drawing.Point(99, 318);
            this.iD_ProdajiTextBox.Name = "iD_ProdajiTextBox";
            this.iD_ProdajiTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProdajiTextBox.TabIndex = 7;
            // 
            // avto_NameTextBox
            // 
            this.avto_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "Avto_Name", true));
            this.avto_NameTextBox.Location = new System.Drawing.Point(312, 266);
            this.avto_NameTextBox.Name = "avto_NameTextBox";
            this.avto_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.avto_NameTextBox.TabIndex = 9;
            // 
            // avto_KolvoTextBox
            // 
            this.avto_KolvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "Avto_Kolvo", true));
            this.avto_KolvoTextBox.Location = new System.Drawing.Point(312, 292);
            this.avto_KolvoTextBox.Name = "avto_KolvoTextBox";
            this.avto_KolvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.avto_KolvoTextBox.TabIndex = 11;
            // 
            // summaTextBox
            // 
            this.summaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avto_ProdajiBindingSource, "Summa", true));
            this.summaTextBox.Location = new System.Drawing.Point(312, 318);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.Size = new System.Drawing.Size(100, 20);
            this.summaTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_Avto_ProdajiLabel);
            this.Controls.Add(this.iD_Avto_ProdajiTextBox);
            this.Controls.Add(iD_AvtoLabel);
            this.Controls.Add(this.iD_AvtoTextBox);
            this.Controls.Add(iD_ProdajiLabel);
            this.Controls.Add(this.iD_ProdajiTextBox);
            this.Controls.Add(avto_NameLabel);
            this.Controls.Add(this.avto_NameTextBox);
            this.Controls.Add(avto_KolvoLabel);
            this.Controls.Add(this.avto_KolvoTextBox);
            this.Controls.Add(summaLabel);
            this.Controls.Add(this.summaTextBox);
            this.Controls.Add(this.avto_ProdajiDataGridView);
            this.Controls.Add(this.avto_ProdajiBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiBindingNavigator)).EndInit();
            this.avto_ProdajiBindingNavigator.ResumeLayout(false);
            this.avto_ProdajiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avto_ProdajiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource avto_ProdajiBindingSource;
        private DataSet1TableAdapters.Avto_ProdajiTableAdapter avto_ProdajiTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avto_ProdajiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton avto_ProdajiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avto_ProdajiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iD_Avto_ProdajiTextBox;
        private System.Windows.Forms.TextBox iD_AvtoTextBox;
        private System.Windows.Forms.TextBox iD_ProdajiTextBox;
        private System.Windows.Forms.TextBox avto_NameTextBox;
        private System.Windows.Forms.TextBox avto_KolvoTextBox;
        private System.Windows.Forms.TextBox summaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}