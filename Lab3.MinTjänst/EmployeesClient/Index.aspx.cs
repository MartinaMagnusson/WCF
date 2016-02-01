using NorthwindService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeesClient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new EmployeesServiceClient();
                var id = int.Parse(TextBoxID.Text);
                if (id > 0)
                {
                    var employee = service.GetEmployee(id);
                    TextBoxEmployeeID.Text = employee.ID.ToString();
                    TextBoxFirstName.Text = employee.FirstName;
                    TextBoxLastName.Text = employee.LastName;
                    TextBoxTitle.Text = employee.Title;
                    TextBoxTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                    TextBoxBirthDate.Text = employee.BirthDate.ToString();
                    TextBoxHireDate.Text = employee.HireDate.ToString();
                    TextBoxAddress.Text = employee.Address;
                    TextBoxCity.Text = employee.City;
                }
            }
            catch (FaultException<SqlException> ex)
            {
                throw new FaultException<SqlException>(ex.Detail, "Something went wrong");
            }
            catch (Exception ex)
            {
                throw new Exception("Client error: " + ex.Message);
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new EmployeesServiceClient();
                var employee = new Employees();
                employee.ID = int.Parse(TextBoxEmployeeID.Text);
                employee.FirstName = TextBoxFirstName.Text;
                employee.LastName = TextBoxLastName.Text;
                employee.Title = TextBoxTitle.Text;
                employee.TitleOfCourtesy = TextBoxTitleOfCourtesy.Text;
                employee.BirthDate = DateTime.Parse(TextBoxBirthDate.Text);
                employee.HireDate = DateTime.Parse(TextBoxHireDate.Text);
                employee.Address = TextBoxAddress.Text;
                employee.City = TextBoxCity.Text;
                service.EditEmployee(employee);
            }
            catch (FaultException<SqlException> ex)
            {
                throw new FaultException<SqlException>(ex.Detail, "Something went wrong");
            }
            catch (Exception ex)
            {
                throw new Exception("Client error: " + ex.Message);
            }
        }
    }
}