using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2.Client.Age2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBirthday_Click(object sender, EventArgs e)
        {
            var birthday = DateTime.Parse(TextBoxBirthday.Text);
            DaysClient days = new DaysClient();
            LabelDays.Text = days.GetAge(birthday);
        }
    }
}