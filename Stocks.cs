using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.deleteBtn.Enabled = false;

        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        retrieval r = new retrieval();

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showStockDetails(dataGridView1, proIDGV, proGV, barGV, expiryGV,bpGV,SpGV, catGV, quantGV, statusGV,finalGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

