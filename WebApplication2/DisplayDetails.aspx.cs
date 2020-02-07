using System;
using System.Data;
using System.Data.SqlClient;
using HotelBooking;
using System.Web.UI.WebControls;
namespace HotelBookingSystem
{
    public partial class DisplayDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = KOWSALYA\SQLSERVER; Initial Catalog = master; User ID = sa; Password = gowtham");
            DataTable table = new DataTable();
            UserRepository userRepository = new UserRepository();
            table = userRepository.ViewDetails(sqlConnection);
            userDetail.DataSource = table;
            userDetail.DataBind();
        }
        protected void gridService_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                //gridService.EditIndex = e.NewEditIndex;
                //BindService();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}