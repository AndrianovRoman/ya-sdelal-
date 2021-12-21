
namespace proekt_avtosalon
{
    partial class Form9
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
            System.Windows.Forms.Label iD_PokupLabel;
            System.Windows.Forms.Label nomer_PasportaLabel;
            System.Windows.Forms.Label seria_PasportaLabel;
            System.Windows.Forms.Label pokup_FamiliaLabel;
            System.Windows.Forms.Label pokup_NameLabel;
            System.Windows.Forms.Label pokup_OtchestvoLabel;
            System.Windows.Forms.Label stranaLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label domLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataSet1 = new proekt_avtosalon.DataSet1();
            this.pokupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupTableAdapter = new proekt_avtosalon.DataSet1TableAdapters.PokupTableAdapter();
            this.tableAdapterManager = new proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.pokupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pokupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pokupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_PokupTextBox = new System.Windows.Forms.TextBox();
            this.nomer_PasportaTextBox = new System.Windows.Forms.TextBox();
            this.seria_PasportaTextBox = new System.Windows.Forms.TextBox();
            this.pokup_FamiliaTextBox = new System.Windows.Forms.TextBox();
            this.pokup_NameTextBox = new System.Windows.Forms.TextBox();
            this.pokup_OtchestvoTextBox = new System.Windows.Forms.TextBox();
            this.stranaTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iD_PokupLabel = new System.Windows.Forms.Label();
            nomer_PasportaLabel = new System.Windows.Forms.Label();
            seria_PasportaLabel = new System.Windows.Forms.Label();
            pokup_FamiliaLabel = new System.Windows.Forms.Label();
            pokup_NameLabel = new System.Windows.Forms.Label();
            pokup_OtchestvoLabel = new System.Windows.Forms.Label();
            stranaLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupBindingNavigator)).BeginInit();
            this.pokupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PokupLabel
            // 
            iD_PokupLabel.AutoSize = true;
            iD_PokupLabel.Location = new System.Drawing.Point(20, 223);
            iD_PokupLabel.Name = "iD_PokupLabel";
            iD_PokupLabel.Size = new System.Drawing.Size(55, 13);
            iD_PokupLabel.TabIndex = 2;
            iD_PokupLabel.Text = "ID Pokup:";
            // 
            // nomer_PasportaLabel
            // 
            nomer_PasportaLabel.AutoSize = true;
            nomer_PasportaLabel.Location = new System.Drawing.Point(20, 249);
            nomer_PasportaLabel.Name = "nomer_PasportaLabel";
            nomer_PasportaLabel.Size = new System.Drawing.Size(86, 13);
            nomer_PasportaLabel.TabIndex = 4;
            nomer_PasportaLabel.Text = "Nomer Pasporta:";
            // 
            // seria_PasportaLabel
            // 
            seria_PasportaLabel.AutoSize = true;
            seria_PasportaLabel.Location = new System.Drawing.Point(20, 275);
            seria_PasportaLabel.Name = "seria_PasportaLabel";
            seria_PasportaLabel.Size = new System.Drawing.Size(79, 13);
            seria_PasportaLabel.TabIndex = 6;
            seria_PasportaLabel.Text = "Seria Pasporta:";
            // 
            // pokup_FamiliaLabel
            // 
            pokup_FamiliaLabel.AutoSize = true;
            pokup_FamiliaLabel.Location = new System.Drawing.Point(20, 301);
            pokup_FamiliaLabel.Name = "pokup_FamiliaLabel";
            pokup_FamiliaLabel.Size = new System.Drawing.Size(76, 13);
            pokup_FamiliaLabel.TabIndex = 8;
            pokup_FamiliaLabel.Text = "Pokup Familia:";
            // 
            // pokup_NameLabel
            // 
            pokup_NameLabel.AutoSize = true;
            pokup_NameLabel.Location = new System.Drawing.Point(20, 327);
            pokup_NameLabel.Name = "pokup_NameLabel";
            pokup_NameLabel.Size = new System.Drawing.Size(72, 13);
            pokup_NameLabel.TabIndex = 10;
            pokup_NameLabel.Text = "Pokup Name:";
            // 
            // pokup_OtchestvoLabel
            // 
            pokup_OtchestvoLabel.AutoSize = true;
            pokup_OtchestvoLabel.Location = new System.Drawing.Point(248, 223);
            pokup_OtchestvoLabel.Name = "pokup_OtchestvoLabel";
            pokup_OtchestvoLabel.Size = new System.Drawing.Size(93, 13);
            pokup_OtchestvoLabel.TabIndex = 12;
            pokup_OtchestvoLabel.Text = "Pokup Otchestvo:";
            // 
            // stranaLabel
            // 
            stranaLabel.AutoSize = true;
            stranaLabel.Location = new System.Drawing.Point(267, 252);
            stranaLabel.Name = "stranaLabel";
            stranaLabel.Size = new System.Drawing.Size(41, 13);
            stranaLabel.TabIndex = 14;
            stranaLabel.Text = "Strana:";
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(267, 278);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(39, 13);
            gorodLabel.TabIndex = 16;
            gorodLabel.Text = "Gorod:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(267, 304);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(34, 13);
            ulicaLabel.TabIndex = 18;
            ulicaLabel.Text = "Ulica:";
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(267, 330);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(32, 13);
            domLabel.TabIndex = 20;
            domLabel.Text = "Dom:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokupBindingSource
            // 
            this.pokupBindingSource.DataMember = "Pokup";
            this.pokupBindingSource.DataSource = this.dataSet1;
            // 
            // pokupTableAdapter
            // 
            this.pokupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = null;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = this.pokupTableAdapter;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proekt_avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pokupBindingNavigator
            // 
            this.pokupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pokupBindingNavigator.BindingSource = this.pokupBindingSource;
            this.pokupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pokupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pokupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pokupBindingNavigatorSaveItem});
            this.pokupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pokupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pokupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pokupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pokupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pokupBindingNavigator.Name = "pokupBindingNavigator";
            this.pokupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pokupBindingNavigator.Size = new System.Drawing.Size(1076, 25);
            this.pokupBindingNavigator.TabIndex = 0;
            this.pokupBindingNavigator.Text = "bindingNavigator1";
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
            // pokupBindingNavigatorSaveItem
            // 
            this.pokupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pokupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pokupBindingNavigatorSaveItem.Image")));
            this.pokupBindingNavigatorSaveItem.Name = "pokupBindingNavigatorSaveItem";
            this.pokupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pokupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pokupBindingNavigatorSaveItem.Click += new System.EventHandler(this.pokupBindingNavigatorSaveItem_Click);
            // 
            // pokupDataGridView
            // 
            this.pokupDataGridView.AutoGenerateColumns = false;
            this.pokupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pokupDataGridView.DataSource = this.pokupBindingSource;
            this.pokupDataGridView.Location = new System.Drawing.Point(12, 40);
            this.pokupDataGridView.Name = "pokupDataGridView";
            this.pokupDataGridView.Size = new System.Drawing.Size(1037, 172);
            this.pokupDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Pokup";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Pokup";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nomer_Pasporta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nomer_Pasporta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Seria_Pasporta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Seria_Pasporta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pokup_Familia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pokup_Familia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pokup_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pokup_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pokup_Otchestvo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pokup_Otchestvo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn7.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ulica";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ulica";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dom";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // iD_PokupTextBox
            // 
            this.iD_PokupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "ID_Pokup", true));
            this.iD_PokupTextBox.Location = new System.Drawing.Point(119, 220);
            this.iD_PokupTextBox.Name = "iD_PokupTextBox";
            this.iD_PokupTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PokupTextBox.TabIndex = 3;
            // 
            // nomer_PasportaTextBox
            // 
            this.nomer_PasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Nomer_Pasporta", true));
            this.nomer_PasportaTextBox.Location = new System.Drawing.Point(119, 246);
            this.nomer_PasportaTextBox.Name = "nomer_PasportaTextBox";
            this.nomer_PasportaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomer_PasportaTextBox.TabIndex = 5;
            // 
            // seria_PasportaTextBox
            // 
            this.seria_PasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Seria_Pasporta", true));
            this.seria_PasportaTextBox.Location = new System.Drawing.Point(119, 272);
            this.seria_PasportaTextBox.Name = "seria_PasportaTextBox";
            this.seria_PasportaTextBox.Size = new System.Drawing.Size(100, 20);
            this.seria_PasportaTextBox.TabIndex = 7;
            // 
            // pokup_FamiliaTextBox
            // 
            this.pokup_FamiliaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Pokup_Familia", true));
            this.pokup_FamiliaTextBox.Location = new System.Drawing.Point(119, 298);
            this.pokup_FamiliaTextBox.Name = "pokup_FamiliaTextBox";
            this.pokup_FamiliaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pokup_FamiliaTextBox.TabIndex = 9;
            // 
            // pokup_NameTextBox
            // 
            this.pokup_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Pokup_Name", true));
            this.pokup_NameTextBox.Location = new System.Drawing.Point(119, 324);
            this.pokup_NameTextBox.Name = "pokup_NameTextBox";
            this.pokup_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pokup_NameTextBox.TabIndex = 11;
            // 
            // pokup_OtchestvoTextBox
            // 
            this.pokup_OtchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Pokup_Otchestvo", true));
            this.pokup_OtchestvoTextBox.Location = new System.Drawing.Point(366, 220);
            this.pokup_OtchestvoTextBox.Name = "pokup_OtchestvoTextBox";
            this.pokup_OtchestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pokup_OtchestvoTextBox.TabIndex = 13;
            // 
            // stranaTextBox
            // 
            this.stranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Strana", true));
            this.stranaTextBox.Location = new System.Drawing.Point(366, 249);
            this.stranaTextBox.Name = "stranaTextBox";
            this.stranaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stranaTextBox.TabIndex = 15;
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(366, 275);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(100, 20);
            this.gorodTextBox.TabIndex = 17;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(366, 301);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ulicaTextBox.TabIndex = 19;
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokupBindingSource, "Dom", true));
            this.domTextBox.Location = new System.Drawing.Point(366, 327);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(100, 20);
            this.domTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_PokupLabel);
            this.Controls.Add(this.iD_PokupTextBox);
            this.Controls.Add(nomer_PasportaLabel);
            this.Controls.Add(this.nomer_PasportaTextBox);
            this.Controls.Add(seria_PasportaLabel);
            this.Controls.Add(this.seria_PasportaTextBox);
            this.Controls.Add(pokup_FamiliaLabel);
            this.Controls.Add(this.pokup_FamiliaTextBox);
            this.Controls.Add(pokup_NameLabel);
            this.Controls.Add(this.pokup_NameTextBox);
            this.Controls.Add(pokup_OtchestvoLabel);
            this.Controls.Add(this.pokup_OtchestvoTextBox);
            this.Controls.Add(stranaLabel);
            this.Controls.Add(this.stranaTextBox);
            this.Controls.Add(gorodLabel);
            this.Controls.Add(this.gorodTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(this.pokupDataGridView);
            this.Controls.Add(this.pokupBindingNavigator);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupBindingNavigator)).EndInit();
            this.pokupBindingNavigator.ResumeLayout(false);
            this.pokupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokupDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pokupBindingSource;
        private DataSet1TableAdapters.PokupTableAdapter pokupTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pokupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pokupBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pokupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox iD_PokupTextBox;
        private System.Windows.Forms.TextBox nomer_PasportaTextBox;
        private System.Windows.Forms.TextBox seria_PasportaTextBox;
        private System.Windows.Forms.TextBox pokup_FamiliaTextBox;
        private System.Windows.Forms.TextBox pokup_NameTextBox;
        private System.Windows.Forms.TextBox pokup_OtchestvoTextBox;
        private System.Windows.Forms.TextBox stranaTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}