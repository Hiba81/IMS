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
    public partial class ProductPricing : Sample2
    {
        retrieval r = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\-[0-9]*)?$");

        public ProductPricing()
        {
            InitializeComponent();
            r.getList("st_CategoriesList", categoryDD, "Category", "ID");

        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                r.showProductWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), dataGridView1, proIDGV, proGV, buyingPriceGV, FinalPriceGV, discountGV, profitMarginGV);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;
                    float finalSellingPrice = buyingPrice + amountToIncrease;

                    float discountPer;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;

                    }
                    row.Cells["FinalPriceGV"].Value = finalSellingPrice-discountPer;
                }
                else
                {
                    row.Cells["FinalPriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;


                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                dataGridView1.BeginEdit(true);
            }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }
        updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {

            int che = 0;
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        che++;
                        Int64 pID;
                        float disc, pm, bp, sp;
                        pID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());

                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;

                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["FinalPriceGV"].Value.ToString());
                        }
                        u.updateProductPrice(pID, bp, sp, disc, pm);

                    }
                }
                if (che > 0)
                {
                   MainClass.showMSG("Product Pricing updated successfully....", "Success", "Success");

                    che = 0;
                }
                else
                {
                    MainClass.showMSG("Please select any product first....", "Error", "Error");

                    che = 0;
                }
            }
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
             dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }

}



