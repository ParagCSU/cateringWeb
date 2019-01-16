using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PicnicRUS
{
    public partial class BookAnOrder : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDate_Click(object sender, EventArgs e)
        {
            CalDate.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        /*{
             string connectionString = null;
             SqlConnection cnn;
             connectionString = "Data Source=LAPTOP-L7R84ONM;Initial Catalog= PicnicRUS; Trusted_Connection = Yes;integrated security = SSPI;persist security info = False";

             cnn = new SqlConnection(connectionString);
             try
             {
                 cnn.Open();
                 //MessageBox.Show("Connection Open ! ");

                 using (SqlCommand cmd = new SqlCommand("SP_CreateOrder", cnn))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;

                     cmd.Parameters.AddWithValue("Fname", SqlDbType.VarChar).Value = txtFirstname.Text;

                     cmd.Parameters.AddWithValue("Lname", SqlDbType.VarChar).Value = txtLastName.Text;
                     cmd.Parameters.AddWithValue("PhoneNumber", SqlDbType.VarChar).Value = TxtContactNumber.Text;
                     cmd.Parameters.AddWithValue("PicnicDate", SqlDbType.VarChar).Value = TxtDate.Text;
                    // cmd.Parameters.AddWithValue("EmployeeAssigned", SqlDbType.VarChar).Value = ddlEmployee.SelectedValue;

                     //trial.Text = CalDate.SelectedDate.DayOfWeek.ToString();

                     // cnn.Open();
                     cmd.ExecuteNonQuery();
                     //lblmsg.Visible = true;
                    // lblmsg.Text = "Customer Data Saved Successfully";


                     int orderID; 
                     using (var command = new SqlCommand("INSERT INTO orders (Created,OrderTotal) VALUES (GetDate(),@OrderTotal); SELECT CONVERT(int, SCOPE_IDENTITY()) as OrderID;", cnn))
                     {
                         command.Parameters.AddWithValue("@OrderTotal", 10.0f);
                       //  cnn.Open();
                         orderID = (int)command.ExecuteScalar();
                     }  


                 }


             }
             catch (Exception ex)
             {
                 //MessageBox.Show("Can not open connection ! ");
             }
         }*/

        protected void TxtDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CalDate_SelectionChanged(object sender, EventArgs e)
        {
            TxtDate.Text = CalDate.SelectedDate.ToShortDateString();
            CalDate.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=LAPTOP-L7R84ONM;Initial Catalog= PicnicRUS; Trusted_Connection = Yes;integrated security = SSPI;persist security info = False";

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");

                using (SqlCommand cmd = new SqlCommand("SP_Customer", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("LastName", SqlDbType.VarChar).Value = txtLastName.Text;
                    cmd.Parameters.AddWithValue("FirstName", SqlDbType.VarChar).Value = txtFirstname.Text;
                    cmd.Parameters.AddWithValue("CustomerType", SqlDbType.VarChar).Value = ddlCustomerType.SelectedValue;
                    cmd.Parameters.AddWithValue("Address", SqlDbType.VarChar).Value = txtAddress.Text;
                    cmd.Parameters.AddWithValue("PhoneNumber", SqlDbType.VarChar).Value = TxtContactNumber.Text;



                    // cnn.Open();
                    cmd.CommandTimeout = 0;
                    cmd.ExecuteNonQuery();
                    lblCustomerCreation.Visible = true;
                    lblCustomerCreation.Text = "Customer Data Saved Successfully";



                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAvailability_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=LAPTOP-L7R84ONM;Initial Catalog= PicnicRUS; Trusted_Connection = Yes;integrated security = SSPI;persist security info = False";

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");

                DateTime? firstVariable=null;
                DateTime  ?secondVariable=null ;

                string EmpName = ddlemployeename.SelectedValue;
                    using (SqlCommand command = new SqlCommand("SELECT Start_Date, End_Date FROM Schedule WHERE EMployeeName = 'Arya Strak'", cnn))
                    {
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                firstVariable = Convert.ToDateTime(reader[0]);
                                secondVariable = Convert.ToDateTime(reader[1]);
                            }

                            if (CalDate.SelectedDate > firstVariable && CalDate.SelectedDate < secondVariable)
                            {
                                lblEmpAvailbility.Visible = true;
                                lblEmpAvailbility.Text = "Employee is available";
                            }

                            else
                                lblEmpAvailbility.Visible = true;
                            lblEmpAvailbility.Text = "Employee is Not available.Choose Another Employee";
                        }
                    }

                
            }
            catch (Exception ex)
            {

            }
            }
    }
}