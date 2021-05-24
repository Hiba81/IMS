using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    public partial class PurchaseINvoiceDetails : Sample2
    {
        public PurchaseINvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showwindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseINvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);

        }

        private void purDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purDD.SelectedIndex != -1 && purDD.SelectedIndex != 0)
            {
                float gt= 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purDD.SelectedValue.ToString()),dataGridView1,mPIDgv, proIDGV, proGV, quantGV, pupGV, TotGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;

            }
        }
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    
                    DialogResult dr = MessageBox.Show("Are you sure , you want to delete" + row.Cells["proGV"].Value.ToString() + "from purchase invoice?\n\t\t\tWARNING\nDELETION OF PRODUCT WILL EFFECT STOCK","Question....",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    int q;
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItems(Convert.ToInt64(purDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantGV"].Value.ToString()), retrieval.USER_ID, DateTime.Today);

                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()),"st_deleteProductFromPID","@mPID");

                                dataGridView1.Rows.Remove(row);
                            }

                            sc.Complete();
                        }
                        


                    }


                }
        }

    }
}
