using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void pokupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pokupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Pokup". При необходимости она может быть перемещена или удалена.
            this.pokupTableAdapter.Fill(this.dataSet1.Pokup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pokupBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokupBindingSource.EndEdit();
            pokupTableAdapter.Update(dataSet1);
        }
    }
}
