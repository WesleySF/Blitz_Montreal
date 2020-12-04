using System;
using System.Threading;
using System.Windows;
using WatiN.Core;
using WPFBlitz.src.Montreal.Tasks.Values_Objects;

namespace WPFBlitz.src.Montreal.Tasks
{
    public class PageLog : Explorer
    {
        public void Login()
        {
            var users = new Users();
            
            users.Client = "SANTANDER";
            users.User = "x144221";
            users.Password = "crespo2020";            

            try
            {
                var principalDiv = iBrowser.Div(Find.ById("dvHeader"));                               

                principalDiv.TextField(Find.ById("CLIENTE")).Value = users.Client.ToString();

                principalDiv.TextField(Find.ById("OPERADOR")).Value = users.User.ToString();

                principalDiv.TextField(Find.ById("SENHA")).Value = users.Password.ToString();

                Thread.Sleep(2000);

                principalDiv.Buttons[0].Click();

                Thread.Sleep(2000);

                principalDiv.Divs[2].Divs[2].Spans[0].Click();

            }
			catch (Exception error)
			{
                MessageBox.Show("Error: Verifique os dados inseridos");
			}
        }
    }
}
