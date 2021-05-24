using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    class retrieval
    {
        public void showusers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn emailGV, DataGridViewColumn passwordGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;


            }
            catch (Exception)
            {

            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[st_CategoriesData]", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error", "Error");
            }
        }
        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

                cb.DataSource = dt;



            }
            catch (Exception)
            {

            }



        }
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

                cb.DataSource = dt;



            }
            catch (Exception ex)
            {

            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn barGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getproductData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category Id"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load categories data", "Error", "Error");
            }

        }
        private int productStockCount = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = Convert.ToInt32(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }
        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseINvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();

                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();


                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load data", "Error", "Error");
            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private string[] productsData = new string[6];

        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString();// Prod ID
                        productsData[1] = dr[1].ToString();// Product
                        productsData[2] = dr[2].ToString();// Barcode
                        productsData[3] = dr[3].ToString();// Selling price
                        productsData[4] = dr[4].ToString();// Discount
                        productsData[5] = dr[5].ToString();// Final selling price

                    }
                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                }
                MainClass.con.Close();

            }

            catch (Exception)
            {
                MainClass.con.Close();
            }
            return productsData;

        }


        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }


                }
                else
                    checkLogin = false;
                {
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid User and Password", "Error", "Error");
                        }


                    }
                }
                MainClass.con.Close();



            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMSG("Unable to Login...", "Error", "Error");
            }
            return checkLogin;
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn comNameGV, DataGridViewColumn personGV,
            DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV,
            DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                comNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG("Unable to load suppliers data", "Error", "Error");
            }
        }


        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV,
            DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn availStGV,
            DataGridViewColumn statusGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getALLStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["Product Id"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                availStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load stock data", "Error", "Error");
            }
        }

        public void showProductWRTCategory(int catID, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV,
            DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn profitPerGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load products", "Error", "Error");
            }
        }
        private bool CheckPPExistence;
        public bool checkProductPriceExistence(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("proID", proID);
                MainClass.con.Open();
                MainClass.con.Close();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    CheckPPExistence = true;
                }
                else
                {
                    CheckPPExistence = false;
                }
            }
            catch (Exception)
            {

            }
            return CheckPPExistence;
        }

        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                productStockCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }

        public void showReport(string reportName,ReportDocument rd, CrystalReportViewer crv, string proc, string param1 = null, object val1 = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                else
                {

                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath + "\\Reports\\"+reportName);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();


            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }


        public void showDailySales(DateTime date, DataGridView gv, DataGridViewColumn salIDGV, DataGridViewColumn userGV, DataGridViewColumn totAmountGV, DataGridViewColumn totDis, DataGridViewColumn AmountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn usrIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                usrIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totDis.DataPropertyName = dt.Columns["Total Discount"].ToString();
                AmountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Returned Amount"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load  data", "Error", "Error");
            }

        }

        public void showSalesDataViaID(Int64 salesID, DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcodeGV, DataGridViewColumn productGV, DataGridViewColumn quantGV, DataGridViewColumn totdisGV, DataGridViewColumn totAmountGV, DataGridViewColumn amountgivenGV, DataGridViewColumn amountreturnedGV, DataGridViewColumn dateGV, DataGridViewColumn productpriceGV, DataGridViewColumn perproductdiscGV, DataGridViewColumn perproducttotalGV, DataGridViewColumn userGV, DataGridViewColumn paymentGV,DataGridViewColumn proIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                totdisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                amountgivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountreturnedGV.DataPropertyName = dt.Columns["Amount Returned"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                productpriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                perproductdiscGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                perproducttotalGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                paymentGV.DataPropertyName = dt.Columns["Pay Type"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product Id"].ToString();


                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load  data", "Error", "Error");
            }

        }

    }
}