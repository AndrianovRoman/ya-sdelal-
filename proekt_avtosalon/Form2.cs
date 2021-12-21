﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_avtosalon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void firmaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firmaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Firma". При необходимости она может быть перемещена или удалена.
            this.firmaTableAdapter.Fill(this.dataSet1.Firma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firmaBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firmaBindingSource.EndEdit();
            firmaTableAdapter.Update(dataSet1);
        }
    }
}
