using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ims
{
    class insertion
    {
        public void insertUser(string name, string username, string pass, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Added to the system sucessfully", "Success....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error....", "Error");

            }
        }

        public void insertCat(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Added to the system sucessfully", "Success....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error....", "Error");

            }
        }
        public void insertProduct(string product, string barcode,  int catID, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode ", barcode);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry ", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry ", expiry);
                } cmd.Parameters.AddWithValue("@catID ", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " Added to the system successfully ", "Success....", "Success");
            }

            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");

            }
        }
        public void insertSupplier(string company, string person, string phone1, string address, Int16 status, string phone2, string ntn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {

                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);

                }
                else
                {

                    cmd.Parameters.AddWithValue("@phone2", phone2);

                }

                if (ntn == null)
                {

                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);

                }
                else
                {

                    cmd.Parameters.AddWithValue("@ntn", ntn);

                }
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);


                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " Added to the system successfully ", "Success....", "Success");
            }

            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");

            }
        }

        private Int64 purchaseInvoiceID;
        public Int64 insertPurchaseInvoice(DateTime date, int doneBy, int suppID)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("st_insertPurchaseINvoice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@suppID", suppID);

                    MainClass.con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getLastPurchaseID";
                    cmd.Parameters.Clear();
                    purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());



                    MainClass.con.Close();
                  

                }
                
            
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error....", "Error");

            }
            return purchaseInvoiceID;
        }
        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int quan, float totPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID",purID);
                cmd.Parameters.AddWithValue("@proID",proID);
                cmd.Parameters.AddWithValue("@quan",quan);
                cmd.Parameters.AddWithValue("@totPrice",totPrice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
                
            }

            return pidCount;
                   
                
            
        }

        public void insertStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();

            }




        }



        public void insertDeletedItems(Int64 pid, Int64 proid, int quan, int userid, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemsPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usrID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error....", "Error");

            }
        }

        public void insertProductPrice(Int64 proID, float buyingAmount)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmount);
                
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
              
                MainClass.con.Close();


            }


            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error....", "Error");

            }
        }
        int salCount=0;
        Int64 salesID;
        retrieval r = new retrieval();
        updation u = new updation();
        public void insertSales(DataGridView gv, string proIDgv, string proQuanGV,string pupGV,string discGV, int doneBy, DateTime dt, float tAmount, float tDiscount, float aGiven, float aREturned, string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totamt", tAmount);
                    cmd.Parameters.AddWithValue("@totdis", tDiscount);
                    cmd.Parameters.AddWithValue("@given", aGiven);
                    cmd.Parameters.AddWithValue("@return", aREturned);
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 0);

                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 1);

                    }
                    else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 2);

                    }



                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellingPrice", Convert.ToSingle(row.Cells[pupGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[discGV].Value.ToString()));


                            cmd3.ExecuteNonQuery();
                            int stockofProduct =Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString())));
                            int currentQuanofProduct = Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
                            int finalProductQuantity = stockofProduct - currentQuanofProduct;
                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString()), finalProductQuantity);
                        }
                    }

                    MainClass.con.Close();
                    MainClass.showMSG("Sales Succesfull", "Success", "Success");
                    sc.Complete();

                }
               

            }
            catch (Exception)
            {
                MainClass.con.Close();

            }


        }

        int x = 0;
        public int insertReturnRefund(Int64 salesID, DateTime dt, int doneBy, Int64 proID, Int16 quan, float amount)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("insertReturnRefund", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@refsalesId", salesID);
                cmd.Parameters.AddWithValue("@refdate", dt);
                cmd.Parameters.AddWithValue("@refDoneby", doneBy);
                cmd.Parameters.AddWithValue("@refproid", proID);
                cmd.Parameters.AddWithValue("@refquantity", quan);
                cmd.Parameters.AddWithValue("@refamount", amount);
                MainClass.con.Open();
                x= cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return x;
        }
    }

}
