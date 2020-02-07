using System;
using System.Data.SqlClient;
using HotelBooking;
namespace HotelBookingSystem
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected virtual void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = KOWSALYA\SQLSERVER; Initial Catalog = master; User ID = sa; Password = gowtham");
            try
            {
                User user = new User(txtFirstName.Text, txtLastName.Text, txtMobileNumber.Text, txtGmail.Text, txtPassword.Text, rdButton.SelectedItem.ToString());
                UserRepository userRepository = new UserRepository();
                int retRows = userRepository.Registration(user, sqlConnection);
                if (retRows >= 1)
                {
                    string message = "Registered successfully.";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                else
                {
                    Response.Write("Not Registered...");
                }
            }
            catch(Exception m)
            {
                Console.WriteLine(m.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        protected virtual void LogIn_Clicked(object sender, EventArgs e)
        {
            Response.Redirect("LogInForm.aspx");
        }
        protected virtual void Display_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayDetails.aspx");
        }
    }
}