using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1Client
{
    public partial class Index : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            ComputerGames.ComputerGamesWebServiceSoapClient games = new ComputerGames.ComputerGamesWebServiceSoapClient();
            var listOfGame = games.ReturnListOfGame();
            foreach (var game in listOfGame)
            {
                TextBoxGames.Text += game + "\r\n";
            }
        }

        protected void ButtonWeather_Click(object sender, EventArgs e)
        {
            Weather.Lab1WebServiceSoapClient weather = new Weather.Lab1WebServiceSoapClient();
            LabelWeather.Text = weather.Weather();
        }

        protected void ButtonAddTwoNumbers_Click(object sender, EventArgs e)
        {
            AddTwoNumbers.AddsTwoNumbersSoapClient add = new AddTwoNumbers.AddsTwoNumbersSoapClient();
            var numberOne = int.Parse(TextBoxNumberOne.Text);
            var numberTwo = int.Parse(TextBoxNumberTwo.Text);
            LabelAddTwoNumbers.Text = add.AddNumbers(numberOne, numberTwo).ToString();
        }

        protected void ButtonAddThreeNumbers_Click(object sender, EventArgs e)
        {
            AddThreeNumbers.AddThreeNumbersSoapClient add = new AddThreeNumbers.AddThreeNumbersSoapClient();
            var numberOne = int.Parse(TextBoxAddNumberOne.Text);
            var numberTwo = int.Parse(TextBoxAddNumberTwo.Text);
            var numberThree = int.Parse(TextBoxAddNumberThree.Text);
            LabelAddThreeNumbers.Text = add.AddNumbers(numberOne, numberTwo, numberThree);
        }

        protected void ButtonSubtracTwoNumbers_Click(object sender, EventArgs e)
        {
            SubtractTwoNumbers.SubtractTwoNumbersSoapClient subtract = new SubtractTwoNumbers.SubtractTwoNumbersSoapClient();
            var numberOne = int.Parse(TextBoxSubtracNumberOne.Text);
            var numberTwo = int.Parse(TextBoxSubtracNumberTwo.Text);
            LabelSubtracNumbers.Text = subtract.Subtract(numberOne, numberTwo);
        }

        protected void ButtonNameDay_Click(object sender, EventArgs e)
        {
            NameDay.NameDay1SoapClient nameDay = new NameDay.NameDay1SoapClient();
            var name = TextBoxName.Text;
            LabelName.Text = nameDay.ReturnDay(name);
        }

        protected void ButtonWars_Click(object sender, EventArgs e)
        {
            Wars.WarsWebServiceSoapClient wars = new Wars.WarsWebServiceSoapClient();
            var list = wars.ReturnListOfWars();
            foreach (var war in list)
            {
                TextBoxWars.Text += war + "\r\n";
            }
        }
    }
}