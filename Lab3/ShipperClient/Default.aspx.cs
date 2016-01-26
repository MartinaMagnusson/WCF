using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using NorthwindService;

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
            var id = int.Parse(TextBoxID.Text);
            if (id >= 1 || id <= 3)
            {
                var shipper = service.GetShipper(id.ToString());
                TextBoxShipperID.Text = shipper.ID;
                TextBoxShipperName.Text = shipper.CompanyName;
                TextBoxShipperPhone.Text = shipper.Phone;
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            var service = new ShipperServiceClient();
            var shipper = new Shipper();
            shipper.ID = TextBoxID.Text;
            shipper.CompanyName = TextBoxShipperName.Text;
            shipper.Phone = TextBoxShipperPhone.Text;
            service.SaveShipper(shipper);
        }
    }
}