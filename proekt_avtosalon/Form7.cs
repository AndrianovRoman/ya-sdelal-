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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void prodajiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodajiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodaji". При необходимости она может быть перемещена или удалена.
            this.prodajiTableAdapter.Fill(this.dataSet1.Prodaji);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodajiBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prodajiBindingSource.EndEdit();
            prodajiTableAdapter.Update(dataSet1);
        }
    }
}
