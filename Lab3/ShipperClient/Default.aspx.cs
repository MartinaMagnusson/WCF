using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using NorthwindService;
using System.Data.SqlClient;

namespace ShipperClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            var service = new ShipperServiceClient();
            try
            {
                var id = int.Parse(TextBoxID.Text);
                if (id >= 1 || id <= 3)
                {
                    var shipper = service.GetShipper(id.ToString());
                    TextBoxShipperID.Text = shipper.ID;
                    TextBoxShipperName.Text = shipper.CompanyName;
                    TextBoxShipperPhone.Text = shipper.Phone;
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
            var service = new ShipperServiceClient();
            var shipper = new Shipper();
            try
            {
                shipper.ID = TextBoxID.Text;
                shipper.CompanyName = TextBoxShipperName.Text;
                shipper.Phone = TextBoxShipperPhone.Text;
                service.SaveShipper(shipper);
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