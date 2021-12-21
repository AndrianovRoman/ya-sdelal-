
namespace proekt_avtosalon
{
    partial class Form4
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
            System.Windows.Forms.Label iD_AvtoLabel;
            System.Windows.Forms.Label avto_NameLabel;
            System.Windows.Forms.Label cvetLabel;
            System.Windows.Forms.Label data_RegistrLabel;
            System.Windows.Forms.Label kuzovLabel;
            System.Windows.Forms.Label dvigatelLabel;
            System.Windows.Forms.Label siliLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.AvtoTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.avtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_AvtoTextBox = new System.Windows.Forms.TextBox();
            this.avto_NameTextBox = new System.Windows.Forms.TextBox();
            this.cvetTextBox = new System.Windows.Forms.TextBox();
            this.data_RegistrDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kuzovTextBox = new System.Windows.Forms.TextBox();
            this.dvigatelTextBox = new System.Windows.Forms.TextBox();
            this.siliTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_AvtoLabel = new System.Windows.Forms.Label();
            avto_NameLabel = new System.Windows.Forms.Label();
            cvetLabel = new System.Windows.Forms.Label();
            data_RegistrLabel = new System.Windows.Forms.Label();
            kuzovLabel = new System.Windows.Forms.Label();
            dvigatelLabel = new System.Windows.Forms.Label();
            siliLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingNavigator)).BeginInit();
            this.avtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_AvtoLabel
            // 
            iD_AvtoLabel.AutoSize = true;
            iD_AvtoLabel.Location = new System.Drawing.Point(12, 242);
            iD_AvtoLabel.Name = "iD_AvtoLabel";
            iD_AvtoLabel.Size = new System.Drawing.Size(46, 13);
            iD_AvtoLabel.TabIndex = 2;
            iD_AvtoLabel.Text = "ID Avto:";
            // 
            // avto_NameLabel
            // 
            avto_NameLabel.AutoSize = true;
            avto_NameLabel.Location = new System.Drawing.Point(12, 268);
            avto_NameLabel.Name = "avto_NameLabel";
            avto_NameLabel.Size = new System.Drawing.Size(63, 13);
            avto_NameLabel.TabIndex = 4;
            avto_NameLabel.Text = "Avto Name:";
            // 
            // cvetLabel
            // 
            cvetLabel.AutoSize = true;
            cvetLabel.Location = new System.Drawing.Point(12, 294);
            cvetLabel.Name = "cvetLabel";
            cvetLabel.Size = new System.Drawing.Size(32, 13);
            cvetLabel.TabIndex = 6;
            cvetLabel.Text = "Cvet:";
            // 
            // data_RegistrLabel
            // 
            data_RegistrLabel.AutoSize = true;
            data_RegistrLabel.Location = new System.Drawing.Point(12, 321);
            data_RegistrLabel.Name = "data_RegistrLabel";
            data_RegistrLabel.Size = new System.Drawing.Size(69, 13);
            data_RegistrLabel.TabIndex = 8;
            data_RegistrLabel.Text = "Data Registr:";
            // 
            // kuzovLabel
            // 
            kuzovLabel.AutoSize = true;
            kuzovLabel.Location = new System.Drawing.Point(305, 239);
            kuzovLabel.Name = "kuzovLabel";
            kuzovLabel.Size = new System.Drawing.Size(40, 13);
            kuzovLabel.TabIndex = 10;
            kuzovLabel.Text = "Kuzov:";
            // 
            // dvigatelLabel
            // 
            dvigatelLabel.AutoSize = true;
            dvigatelLabel.Location = new System.Drawing.Point(305, 265);
            dvigatelLabel.Name = "dvigatelLabel";
            dvigatelLabel.Size = new System.Drawing.Size(49, 13);
            dvigatelLabel.TabIndex = 12;
            dvigatelLabel.Text = "Dvigatel:";
            // 
            // siliLabel
            // 
            siliLabel.AutoSize = true;
            siliLabel.Location = new System.Drawing.Point(305, 291);
            siliLabel.Name = "siliLabel";
            siliLabel.Size = new System.Drawing.Size(23, 13);
            siliLabel.TabIndex = 14;
            siliLabel.Text = "Sili:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.dataSet1;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = this.avtoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // avtoBindingNavigator
            // 
            this.avtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avtoBindingNavigator.BindingSource = this.avtoBindingSource;
            this.avtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.avtoBindingNavigatorSaveItem});
            this.avtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avtoBindingNavigator.Name = "avtoBindingNavigator";
            this.avtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avtoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.avtoBindingNavigator.TabIndex = 0;
            this.avtoBindingNavigator.Text = "bindingNavigator1";
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
            // avtoBindingNavigatorSaveItem
            // 
            this.avtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avtoBindingNavigatorSaveItem.Image")));
            this.avtoBindingNavigatorSaveItem.Name = "avtoBindingNavigatorSaveItem";
            this.avtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.avtoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.avtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.avtoBindingNavigatorSaveItem_Click);
            // 
            // avtoDataGridView
            // 
            this.avtoDataGridView.AutoGenerateColumns = false;
            this.avtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.avtoDataGridView.DataSource = this.avtoBindingSource;
            this.avtoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.avtoDataGridView.Name = "avtoDataGridView";
            this.avtoDataGridView.Size = new System.Drawing.Size(776, 202);
            this.avtoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Avto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Avto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Avto_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Avto_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cvet";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cvet";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_Registr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data_Registr";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kuzov";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kuzov";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dvigatel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dvigatel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sili";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sili";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // iD_AvtoTextBox
            // 
            this.iD_AvtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "ID_Avto", true));
            this.iD_AvtoTextBox.Location = new System.Drawing.Point(87, 239);
            this.iD_AvtoTextBox.Name = "iD_AvtoTextBox";
            this.iD_AvtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_AvtoTextBox.TabIndex = 3;
            // 
            // avto_NameTextBox
            // 
            this.avto_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Avto_Name", true));
            this.avto_NameTextBox.Location = new System.Drawing.Point(87, 265);
            this.avto_NameTextBox.Name = "avto_NameTextBox";
            this.avto_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.avto_NameTextBox.TabIndex = 5;
            // 
            // cvetTextBox
            // 
            this.cvetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Cvet", true));
            this.cvetTextBox.Location = new System.Drawing.Point(87, 291);
            this.cvetTextBox.Name = "cvetTextBox";
            this.cvetTextBox.Size = new System.Drawing.Size(200, 20);
            this.cvetTextBox.TabIndex = 7;
            // 
            // data_RegistrDateTimePicker
            // 
            this.data_RegistrDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.avtoBindingSource, "Data_Registr", true));
            this.data_RegistrDateTimePicker.Location = new System.Drawing.Point(87, 317);
            this.data_RegistrDateTimePicker.Name = "data_RegistrDateTimePicker";
            this.data_RegistrDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_RegistrDateTimePicker.TabIndex = 9;
            // 
            // kuzovTextBox
            // 
            this.kuzovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Kuzov", true));
            this.kuzovTextBox.Location = new System.Drawing.Point(380, 236);
            this.kuzovTextBox.Name = "kuzovTextBox";
            this.kuzovTextBox.Size = new System.Drawing.Size(200, 20);
            this.kuzovTextBox.TabIndex = 11;
            // 
            // dvigatelTextBox
            // 
            this.dvigatelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Dvigatel", true));
            this.dvigatelTextBox.Location = new System.Drawing.Point(380, 262);
            this.dvigatelTextBox.Name = "dvigatelTextBox";
            this.dvigatelTextBox.Size = new System.Drawing.Size(200, 20);
            this.dvigatelTextBox.TabIndex = 13;
            // 
            // siliTextBox
            // 
            this.siliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Sili", true));
            this.siliTextBox.Location = new System.Drawing.Point(380, 288);
            this.siliTextBox.Name = "siliTextBox";
            this.siliTextBox.Size = new System.Drawing.Size(200, 20);
            this.siliTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_AvtoLabel);
            this.Controls.Add(this.iD_AvtoTextBox);
            this.Controls.Add(avto_NameLabel);
            this.Controls.Add(this.avto_NameTextBox);
            this.Controls.Add(cvetLabel);
            this.Controls.Add(this.cvetTextBox);
            this.Controls.Add(data_RegistrLabel);
            this.Controls.Add(this.data_RegistrDateTimePicker);
            this.Controls.Add(kuzovLabel);
            this.Controls.Add(this.kuzovTextBox);
            this.Controls.Add(dvigatelLabel);
            this.Controls.Add(this.dvigatelTextBox);
            this.Controls.Add(siliLabel);
            this.Controls.Add(this.siliTextBox);
            this.Controls.Add(this.avtoDataGridView);
            this.Controls.Add(this.avtoBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingNavigator)).EndInit();
            this.avtoBindingNavigator.ResumeLayout(false);
            this.avtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private DataSet1TableAdapters.AvtoTableAdapter avtoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton avtoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox iD_AvtoTextBox;
        private System.Windows.Forms.TextBox avto_NameTextBox;
        private System.Windows.Forms.TextBox cvetTextBox;
        private System.Windows.Forms.DateTimePicker data_RegistrDateTimePicker;
        private System.Windows.Forms.TextBox kuzovTextBox;
        private System.Windows.Forms.TextBox dvigatelTextBox;
        private System.Windows.Forms.TextBox siliTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}