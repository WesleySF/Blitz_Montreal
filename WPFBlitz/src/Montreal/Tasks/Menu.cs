using System;
using System.Threading;
using System.Windows;
using WatiN.Core;

namespace WPFBlitz.src.Montreal.Tasks
{
    public class Menu : Explorer
    {
        public void Principal()
        {
			try
			{
                var divMenu = iBrowser.Div(Find.ById("dvNavBar"));

                Thread.Sleep(2000);

                divMenu.Links[2].Click();
            }
			catch (Exception error)
			{
                MessageBox.Show("Erro");
			}
        }
    }
}
