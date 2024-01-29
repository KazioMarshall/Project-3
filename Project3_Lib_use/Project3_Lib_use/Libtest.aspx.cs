using Project_3_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3_Lib_use
{
    public partial class Libtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Instantiate the Student class from the DLL
                Student student = new Student
                {
                    Name = "John Doe",
                    Age = 20,
                    StudentId = "12345"
                };

                // Call the GetCellPhoneNumber() method
                string cellPhoneNumber = student.GetCellPhoneNumber();

                // Display the result
                Label1.Text = $"<strong>Cell Phone Number</strong>: {cellPhoneNumber}";
            }
            catch (Exception ex)
            {
                Label1.Text += ex.Message;
            }
        }
    }
}