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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void prodaji_PokupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodaji_PokupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodaji_Pokup". При необходимости она может быть перемещена или удалена.
            this.prodaji_PokupTableAdapter.Fill(this.dataSet1.Prodaji_Pokup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodaji_PokupBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prodaji_PokupBindingSource.EndEdit();
            prodaji_PokupTableAdapter.Update(dataSet1);
        }
    }
}
