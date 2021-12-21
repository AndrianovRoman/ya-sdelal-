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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void firma_AvtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firma_AvtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Firma_Avto". При необходимости она может быть перемещена или удалена.
            this.firma_AvtoTableAdapter.Fill(this.dataSet1.Firma_Avto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firma_AvtoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firma_AvtoBindingSource.EndEdit();
            firma_AvtoTableAdapter.Update(dataSet1);
        }
    }
}
