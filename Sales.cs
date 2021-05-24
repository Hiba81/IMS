using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{

    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }

        Regex rg = new Regex(@"^[0-9]*(?:\-[0-9]*)?$");

        
        retrieval r = new retrieval();
        string[] prodARR = new string[6];
        float GROSS = 0;

        


        
        int rowNumber;
        private bool productCheck;

        
                
       

        private void Sales_Load_1(object sender, EventArgs e)
        {

        }

        private void barCodeTxt_KeyDown_1(object sender, KeyEventArgs e)
        {
            {
                {
                    if (barCodeTxt.Text != "")
                    {
                        grossTxt.Text = "";
                        totDiscountTxt.Text = "";
                        amountTxt.Text = "";
                        changeGivenTxt.Text = "";
                        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                        {
                            int qCount = 0, sQuant = 0, nCount = 0;
                            prodARR = r.getProductsWRTBarcode(barCodeTxt.Text);
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (prodARR[0] == row.Cells["proIDGV"].Value.ToString())
                                {
                                    qCount = qCount + Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                                }
                            }
                            sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt64(prodARR[0])));
                            nCount = sQuant - qCount;

                            if (nCount <= 0)
                            {

                            }
                            else
                            {
                                if (dataGridView1.Rows.Count == 0)
                                {
                                    //dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1,
                                    //    Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));

                                    dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1,
                                       Convert.ToSingle(prodARR[3]),Math.Round(Convert.ToSingle(prodARR[4]),2), Convert.ToSingle(prodARR[3]));
                                }
                                else
                                {
                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                                        {
                                            productCheck = true;
                                            rowNumber = row.Index;

                                        }
                                        else
                                        {
                                            productCheck = false;
                                        }
                                    }
                                    if (productCheck)
                                    {
                                        float disc = 0;
                                        int current = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["quantGV"].Value) + 1;
                                        dataGridView1.Rows[rowNumber].Cells["quantGV"].Value = current;

                                        disc = Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["discGV"].Value.ToString()) + Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["discGV"].Value.ToString());
                                        dataGridView1.Rows[rowNumber].Cells["discGV"].Value = disc;

                                        float tot = (Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["pupGV"].Value.ToString()) *
                                            Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["quantGV"].Value.ToString())) -
                                            Convert.ToSingle(dataGridView1.Rows[rowNumber].Cells["discGV"].Value.ToString());
                                        dataGridView1.Rows[rowNumber].Cells["TotGV"].Value = tot;
                                    }
                                    else
                                    {
                                       // dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1,
                                       //Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1,
                                     Convert.ToSingle(prodARR[3]), Math.Round(Convert.ToSingle(prodARR[4]), 2), Convert.ToSingle(prodARR[3]));
                                    }
                                }
                                GROSS = 0;
                                float DISCOUNT = 0;
                                foreach (DataGridViewRow item in dataGridView1.Rows)
                                {
                                    GROSS += Convert.ToSingle(item.Cells["TotGV"].Value.ToString());
                                    DISCOUNT += Convert.ToSingle(item.Cells["discGV"].Value.ToString());
                                }
                                grossLabel.Text = Math.Ceiling(GROSS).ToString();
                                barCodeTxt.Focus();
                                barCodeTxt.SelectAll();
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    GROSS = 0;
                    grossTxt.Text = "";
                    totDiscountTxt.Text = "";
                    amountTxt.Text = "";
                    changeGivenTxt.Text = "";
                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);

                    }
                    else if (q > 1)
                    {
                        q--;
                        dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        row.Cells["discGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantGV"].Value.ToString()) * Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - dis;
                        row.Cells["TotGV"].Value = tot;
                        row.Cells["quantGV"].Value = q;

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["TotGV"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString();
                        GROSS = 0;


                    }
                }
            }
        }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)

            {
                float dis = 0, gross = 0;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());

                }
                grossTxt.Text =Math.Round(gross,0).ToString();
                totDiscountTxt.Text =dis.ToString();
            }
        }

        private void amountTxt_TextChanged(object sender, EventArgs e)
        {
            if (amountTxt.Text != "")
            {
                if (!rg.Match(amountTxt.Text).Success)
                {
                    amountTxt.Text = "";
                    amountTxt.Focus();
                }
                else
                {
                   
                }

            }
            else
            {
                changeGivenTxt.Text = "";
            }
        }

        private void amountTxt_Validating(object sender, CancelEventArgs e)
        {
            if (amountTxt.Text != "" && grossTxt.Text!="")
            {
                if (!(Convert.ToSingle(grossTxt.Text) <= Convert.ToSingle(amountTxt.Text)))
                {
                    amountTxt.Text = "";
                    changeGivenTxt.Text = "";
                    amountTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountTxt.Text);
                    float amounttoreturn = amountGiven - Convert.ToSingle(grossTxt.Text);
                    changeGivenTxt.Text = Math.Ceiling(amounttoreturn).ToString();
                }

            }
        }
        insertion i = new insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (amountTxt.Text !="" && totDiscountTxt.Text != "" && grossTxt.Text!= "" && payDD.SelectedIndex != -1 && changeGivenTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount :" + grossTxt.Text + "\n\tTotal Discount : " + totDiscountTxt.Text + "\n\tAmount Given: " + amountTxt.Text + "\n\tAmount Returned: " + changeGivenTxt.Text + "\n\nAre you sure,submit current sales?\n", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV", "quantGV","pupGV","discGV" ,retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTxt.Text), Convert.ToSingle(totDiscountTxt.Text), Convert.ToSingle(amountTxt.Text), Convert.ToSingle(changeGivenTxt.Text),payDD.SelectedItem.ToString());
                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                    SalesReport sr = new SalesReport();
                    sr.Show(); 
                }
            }
        }


        public override void viewBtn_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showwindow(vsi, this, MDI.ActiveForm);
        }
    }
}
