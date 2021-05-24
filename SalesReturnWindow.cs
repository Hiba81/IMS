using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        insertion i = new insertion();
        updation u = new updation();
        float amount_refund = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        retrieval r = new retrieval();
        Regex rg = new Regex("^[0-9]+$");
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if(salesIDTxt.Text != "")
            {
                if (rg.Match(salesIDTxt.Text).Success)
                {
                    r.showSalesDataViaID(Convert.ToInt64(salesIDTxt.Text), dataGridView1, SaleIDGV, barcodeGV, productGV, quantityGV, totaldiscGV, totalAmountGV, AmountGivenGV, AmountreturnedGV, dateGV, priceGV, PerProductDiscountGV, perproducttotalGV, UserGV, paymentGV, proidGV);
                    if (dataGridView1.RowCount > 0)
                    {


                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        userTXt.Text = dataGridView1.Rows[0].Cells["UserGV"].Value.ToString();
                        payTxt.Text = dataGridView1.Rows[0].Cells["paymentGV"].Value.ToString();
                        
                    }
                }
                else
                {
                    salesIDTxt.Text = "";
                    salesIDTxt.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    userTXt.Text = "";
                    payTxt.Text = "";
                  

                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                userTXt.Text = "";
                payTxt.Text = "";
               
            }
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (amountrefundTxt.Text != "" && ht.Count>0 && salesIDTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure,you want to proceed?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += i.insertReturnRefund(Convert.ToInt64(salesIDTxt.Text), DateTime.Now, retrieval.USER_ID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Value),amount_refund);
                            int currentquantity = (int)r.getProductQuantity(Convert.ToInt64(de.Key));
                            int finalquantity = currentquantity-Convert.ToInt16(de.Value);
                            u.updateStock(Convert.ToInt64(de.Key),finalquantity);
                            ///u.updateSalesQuantity(Convert.ToInt64(salesIDTxt.Text), Convert.ToInt16(de.Value));
                            
                        }
                        if (x>0)
                        {
                           DialogResult drr = MainClass.showMSG("Return and refund successfull","Success","Success");
                           if (drr ==DialogResult.OK)
                            {
                                SalesReturnReceiptWindow obj = new SalesReturnReceiptWindow();
                                obj.ShowDialog();
                           }
                            x=0;
                            ht.Clear();

                        }
                        sc.Complete();

                    }

                    }
            }
            else
            {
                MainClass.showMSG("please provide complete details","Error","Error");
            }
        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
        //    if (barcodeTxt.Text != "")
        //    {
        //        if (dataGridView1.Rows.Count>0)
        //        {
        //            using (TransactionScope sc = new TransactionScope())
        //            {

        //                foreach(DataGridViewRow row in dataGridView1.Rows)
        //                {
        //                    if (barcodeTxt.Text == row.Cells["barcodeGV"].Value.ToString())
        //                    {
        //                        DialogResult dr = MessageBox.Show("Are you sure you want to return" + row.Cells["productGV"].Value.ToString() + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //                        if (dr == DialogResult.Yes)
        //                        {
        //                            Int64 product_id = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
        //                            float product_price = Convert.ToSingle(row.Cells["priceGV"].Value.ToString());

        //                            int product_quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
        //                            amount_refund += product_price;

        //                           amountrefundTxt.Text=Math.Round(amount_refund,0).ToString());
        //                            if (product_quantity == 0)
        //                            {
        //                                if (ht.ContainsKey(row.Cells["proidGV"].Value))

        //                                {
        //                                    Int64 proIDht = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
        //                                    ht[proIDht] = Convert.ToInt32(ht[proIDht])-1;
        //                                }
        //                                else
        //                                {
        //                                    ht.Add(row.Cells["proidGV"].Value,1);

        //                                }
        //                                dataGridView1.Rows.Remove(row);

        //                            }
        //                            else
        //                            {
        //                                row.Cells["quantityGV"].Value = product_quantity;
        //                                row.Cells["perproducttotalGV"].Value = (Convert.ToSingle(row.Cells["priceGV"].Value).ToString())* Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
        //                                if (ht.ContainsKey(row.Cells["proidGV"].Value))
        //                                {
        //                                    Int64 proIDht = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
        //                                    ht[proIDht] = Convert.ToInt32(ht[proIDht])+1;
        //                                }
        //                                else
        //                                {
        //                                  ht.Add(row.Cells["proidGV"].Value,1);

        //                                }
        //                            }
        //                        }
        //                        break;
                                
        //                    }
        //                }
        //            }
        //        }
        //    }

        
}

        private void barcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                if (barcodeTxt.Text != "")
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                DialogResult dr = MessageBox.Show("Are you sure you want to return " + "?", "Question");
                                if (dr == DialogResult.OK)
                                {
                                    if (row.Cells["barcodeGV"].Value.ToString() == barcodeTxt.Text)
                                    {
                                        Int64 product_id = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
                                        float product_price = Convert.ToSingle(row.Cells["priceGV"].Value.ToString());

                                        int product_quant = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) - 1;
                                        amount_refund += product_price;

                                        amountrefundTxt.Text = Math.Round(amount_refund, 0).ToString();
                                        if (product_quant == 0)
                                        {

                                            if (ht.ContainsKey(row.Cells["proidGV"].Value))
                                            {
                                                Int64 prodIDht = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
                                                ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) - 1;

                                            }
                                            else
                                            {
                                                ht.Add(row.Cells["proidGV"].Value, 1);
                                            }
                                            dataGridView1.Rows.Remove(row);

                                        }
                                        else
                                        {
                                            row.Cells["quantityGV"].Value = product_quant;
                                            row.Cells["perproducttotalGV"].Value = (Convert.ToSingle(row.Cells["perproducttotalGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                                            if (ht.ContainsKey(row.Cells["proidGV"].Value))
                                            {
                                                Int64 prodIDht = Convert.ToInt64(row.Cells["proidGV"].Value.ToString());
                                                ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) + 1;
                                            }
                                            else
                                            {
                                                ht.Add(row.Cells["proidGV"].Value, 1);
                                            }

                                        }

                                    }
                                }

                                break;
                            }
                        }
                    }
                }

            }


        }

        private void salesIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            

            }

        private void SalesReturnWindow_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;

        }
        }
    }

