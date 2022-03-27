using MMStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMStore.DAL
{
    class userDAL
    {
        static string myConnString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data from Database
        public DataTable select()
        {
            //static Method to connect Database
            SqlConnection con = new SqlConnection(myConnString);
            // to store data later in rows and columns
            DataTable dt = new DataTable();

            try
            {
                // SQL stored in string
                string sql = "SELECT * FROM user";
                // to excute the command 
                SqlCommand cmd = new SqlCommand(sql, con);
                // excute the commande and store it in the adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // open connection
                con.Open();
                // fill data in the table 
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            //return the data 
            return dt;
        }
        #endregion

        #region Insert Data in Database 
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "INSERT INTO tbl_user (firstName, lastName, email, username, password, contact, address, gender, userType, addedDate, addedBy) Values (@firstName, @lastName, @email, @username, @password, @contact, @address, @gender, @userType, @addedDate, @addedBy";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@firstName", u.firstName);
                cmd.Parameters.AddWithValue("@lastName", u.lastName);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.userName);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.adress);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@userType", u.userType);
                cmd.Parameters.AddWithValue("@addedDate", u.addedDate);
                cmd.Parameters.AddWithValue("@addedBy", u.addedBy);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                
                //If the query is executed Successfully then the value of rows will be greater then 0 else failed
                if (rows > 0)
                {
                    //Query Sucewsfull 
                    isSuccess = true; 
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Update Data in Database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "UPDATE user SET firstName=@firstName, lastName=@lastName, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, userType=@userType, addedDate=@addedDate, addedBy=@addedBy WHERE id=@id ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@firstName", u.firstName);
                cmd.Parameters.AddWithValue("@lastName", u.lastName);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.userName);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.adress);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@userType", u.userType);
                cmd.Parameters.AddWithValue("@addedDate", u.addedDate);
                cmd.Parameters.AddWithValue("@addedBy", u.addedBy);
                cmd.Parameters.AddWithValue("@id", u.id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value of rows will be greater then 0 else failed
                if (rows > 0)
                {
                    //Query Sucewsfull 
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Delete Data from Database 
        public bool Delete( userBLL u)
        {
            bool isSuccess = false; 
            //static Method to connect Database
            SqlConnection con = new SqlConnection(myConnString);
          

            try
            {

                string sql = "DELETE FROM user WHERE  id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", u.id);
                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                   //query Successfull 
                    isSuccess = true; 

                }
                else
                {
                    //failed
                    isSuccess = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
