using System;
using System.Data;
using System.Data.SqlClient;

namespace PicnicRUS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=LAPTOP-L7R84ONM;Initial Catalog= PicnicRUS; Trusted_Connection = Yes;integrated security = SSPI;persist security info = False";

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where UserName='" + TxtUserName.Text + "' and Password='" + Txtpassword.Text + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")

                {
                    Response.Redirect("BookAnOrder.aspx", false);
                    //Response.Redirect("BookAnOrder.aspx");
                   // Response.Redirect("~/Error.aspx?ErrorMsg = " + ex.Message, false);
                }
                else
                    LblerrorMsg.Visible = true;
                LblerrorMsg.Text = "UserName Or Password Incorrect!!!";
            }
            catch (Exception ex)
            {

            }
        }
    }
}