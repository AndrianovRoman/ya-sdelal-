
namespace proekt_avtosalon
{
    partial class Form5
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
            System.Windows.Forms.Label iD_PersLabel;
            System.Windows.Forms.Label pers_FamiliaLabel;
            System.Windows.Forms.Label pers_NameLabel;
            System.Windows.Forms.Label pers_OtchestvoLabel;
            System.Windows.Forms.Label okladLabel;
            System.Windows.Forms.Label dojnostLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label stajLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.persBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.PersTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.persBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.persBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.persDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_PersTextBox = new System.Windows.Forms.TextBox();
            this.pers_FamiliaTextBox = new System.Windows.Forms.TextBox();
            this.pers_NameTextBox = new System.Windows.Forms.TextBox();
            this.pers_OtchestvoTextBox = new System.Windows.Forms.TextBox();
            this.okladTextBox = new System.Windows.Forms.TextBox();
            this.dojnostTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.stajTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_PersLabel = new System.Windows.Forms.Label();
            pers_FamiliaLabel = new System.Windows.Forms.Label();
            pers_NameLabel = new System.Windows.Forms.Label();
            pers_OtchestvoLabel = new System.Windows.Forms.Label();
            okladLabel = new System.Windows.Forms.Label();
            dojnostLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            stajLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persBindingNavigator)).BeginInit();
            this.persBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PersLabel
            // 
            iD_PersLabel.AutoSize = true;
            iD_PersLabel.Location = new System.Drawing.Point(12, 237);
            iD_PersLabel.Name = "iD_PersLabel";
            iD_PersLabel.Size = new System.Drawing.Size(45, 13);
            iD_PersLabel.TabIndex = 2;
            iD_PersLabel.Text = "ID Pers:";
            // 
            // pers_FamiliaLabel
            // 
            pers_FamiliaLabel.AutoSize = true;
            pers_FamiliaLabel.Location = new System.Drawing.Point(12, 263);
            pers_FamiliaLabel.Name = "pers_FamiliaLabel";
            pers_FamiliaLabel.Size = new System.Drawing.Size(66, 13);
            pers_FamiliaLabel.TabIndex = 4;
            pers_FamiliaLabel.Text = "Pers Familia:";
            // 
            // pers_NameLabel
            // 
            pers_NameLabel.AutoSize = true;
            pers_NameLabel.Location = new System.Drawing.Point(12, 289);
            pers_NameLabel.Name = "pers_NameLabel";
            pers_NameLabel.Size = new System.Drawing.Size(62, 13);
            pers_NameLabel.TabIndex = 6;
            pers_NameLabel.Text = "Pers Name:";
            // 
            // pers_OtchestvoLabel
            // 
            pers_OtchestvoLabel.AutoSize = true;
            pers_OtchestvoLabel.Location = new System.Drawing.Point(12, 315);
            pers_OtchestvoLabel.Name = "pers_OtchestvoLabel";
            pers_OtchestvoLabel.Size = new System.Drawing.Size(83, 13);
            pers_OtchestvoLabel.TabIndex = 8;
            pers_OtchestvoLabel.Text = "Pers Otchestvo:";
            // 
            // okladLabel
            // 
            okladLabel.AutoSize = true;
            okladLabel.Location = new System.Drawing.Point(220, 234);
            okladLabel.Name = "okladLabel";
            okladLabel.Size = new System.Drawing.Size(38, 13);
            okladLabel.TabIndex = 10;
            okladLabel.Text = "Oklad:";
            // 
            // dojnostLabel
            // 
            dojnostLabel.AutoSize = true;
            dojnostLabel.Location = new System.Drawing.Point(220, 260);
            dojnostLabel.Name = "dojnostLabel";
            dojnostLabel.Size = new System.Drawing.Size(46, 13);
            dojnostLabel.TabIndex = 12;
            dojnostLabel.Text = "Dojnost:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(220, 286);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 14;
            telefonLabel.Text = "Telefon:";
            // 
            // stajLabel
            // 
            stajLabel.AutoSize = true;
            stajLabel.Location = new System.Drawing.Point(220, 312);
            stajLabel.Name = "stajLabel";
            stajLabel.Size = new System.Drawing.Size(28, 13);
            stajLabel.TabIndex = 16;
            stajLabel.Text = "Staj:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // persBindingSource
            // 
            this.persBindingSource.DataMember = "Pers";
            this.persBindingSource.DataSource = this.dataSet1;
            // 
            // persTableAdapter
            // 
            this.persTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = this.persTableAdapter;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // persBindingNavigator
            // 
            this.persBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.persBindingNavigator.BindingSource = this.persBindingSource;
            this.persBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.persBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.persBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.persBindingNavigatorSaveItem});
            this.persBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.persBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.persBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.persBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.persBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.persBindingNavigator.Name = "persBindingNavigator";
            this.persBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.persBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.persBindingNavigator.TabIndex = 0;
            this.persBindingNavigator.Text = "bindingNavigator1";
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
            // persBindingNavigatorSaveItem
            // 
            this.persBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.persBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("persBindingNavigatorSaveItem.Image")));
            this.persBindingNavigatorSaveItem.Name = "persBindingNavigatorSaveItem";
            this.persBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.persBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.persBindingNavigatorSaveItem.Click += new System.EventHandler(this.persBindingNavigatorSaveItem_Click);
            // 
            // persDataGridView
            // 
            this.persDataGridView.AutoGenerateColumns = false;
            this.persDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.persDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.persDataGridView.DataSource = this.persBindingSource;
            this.persDataGridView.Location = new System.Drawing.Point(12, 28);
            this.persDataGridView.Name = "persDataGridView";
            this.persDataGridView.Size = new System.Drawing.Size(833, 195);
            this.persDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Pers";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Pers";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pers_Familia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pers_Familia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pers_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pers_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pers_Otchestvo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pers_Otchestvo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Oklad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Oklad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dojnost";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dojnost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Staj";
            this.dataGridViewTextBoxColumn8.HeaderText = "Staj";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // iD_PersTextBox
            // 
            this.iD_PersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "ID_Pers", true));
            this.iD_PersTextBox.Location = new System.Drawing.Point(101, 234);
            this.iD_PersTextBox.Name = "iD_PersTextBox";
            this.iD_PersTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PersTextBox.TabIndex = 3;
            // 
            // pers_FamiliaTextBox
            // 
            this.pers_FamiliaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Pers_Familia", true));
            this.pers_FamiliaTextBox.Location = new System.Drawing.Point(101, 260);
            this.pers_FamiliaTextBox.Name = "pers_FamiliaTextBox";
            this.pers_FamiliaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pers_FamiliaTextBox.TabIndex = 5;
            // 
            // pers_NameTextBox
            // 
            this.pers_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Pers_Name", true));
            this.pers_NameTextBox.Location = new System.Drawing.Point(101, 286);
            this.pers_NameTextBox.Name = "pers_NameTextBox";
            this.pers_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pers_NameTextBox.TabIndex = 7;
            // 
            // pers_OtchestvoTextBox
            // 
            this.pers_OtchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Pers_Otchestvo", true));
            this.pers_OtchestvoTextBox.Location = new System.Drawing.Point(101, 312);
            this.pers_OtchestvoTextBox.Name = "pers_OtchestvoTextBox";
            this.pers_OtchestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pers_OtchestvoTextBox.TabIndex = 9;
            // 
            // okladTextBox
            // 
            this.okladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Oklad", true));
            this.okladTextBox.Location = new System.Drawing.Point(309, 231);
            this.okladTextBox.Name = "okladTextBox";
            this.okladTextBox.Size = new System.Drawing.Size(100, 20);
            this.okladTextBox.TabIndex = 11;
            // 
            // dojnostTextBox
            // 
            this.dojnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Dojnost", true));
            this.dojnostTextBox.Location = new System.Drawing.Point(309, 257);
            this.dojnostTextBox.Name = "dojnostTextBox";
            this.dojnostTextBox.Size = new System.Drawing.Size(100, 20);
            this.dojnostTextBox.TabIndex = 13;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(309, 283);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 15;
            // 
            // stajTextBox
            // 
            this.stajTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.persBindingSource, "Staj", true));
            this.stajTextBox.Location = new System.Drawing.Point(309, 309);
            this.stajTextBox.Name = "stajTextBox";
            this.stajTextBox.Size = new System.Drawing.Size(100, 20);
            this.stajTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_PersLabel);
            this.Controls.Add(this.iD_PersTextBox);
            this.Controls.Add(pers_FamiliaLabel);
            this.Controls.Add(this.pers_FamiliaTextBox);
            this.Controls.Add(pers_NameLabel);
            this.Controls.Add(this.pers_NameTextBox);
            this.Controls.Add(pers_OtchestvoLabel);
            this.Controls.Add(this.pers_OtchestvoTextBox);
            this.Controls.Add(okladLabel);
            this.Controls.Add(this.okladTextBox);
            this.Controls.Add(dojnostLabel);
            this.Controls.Add(this.dojnostTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(stajLabel);
            this.Controls.Add(this.stajTextBox);
            this.Controls.Add(this.persDataGridView);
            this.Controls.Add(this.persBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persBindingNavigator)).EndInit();
            this.persBindingNavigator.ResumeLayout(false);
            this.persBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource persBindingSource;
        private DataSet1TableAdapters.PersTableAdapter persTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator persBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton persBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView persDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox iD_PersTextBox;
        private System.Windows.Forms.TextBox pers_FamiliaTextBox;
        private System.Windows.Forms.TextBox pers_NameTextBox;
        private System.Windows.Forms.TextBox pers_OtchestvoTextBox;
        private System.Windows.Forms.TextBox okladTextBox;
        private System.Windows.Forms.TextBox dojnostTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox stajTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}