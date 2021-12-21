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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void avto_ProdajiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avto_ProdajiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Avto_Prodaji". При необходимости она может быть перемещена или удалена.
            this.avto_ProdajiTableAdapter.Fill(this.dataSet1.Avto_Prodaji);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            avto_ProdajiBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avto_ProdajiBindingSource.EndEdit();
            avto_ProdajiTableAdapter.Update(dataSet1);
        }
    }
}
