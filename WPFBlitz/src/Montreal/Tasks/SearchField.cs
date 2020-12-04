using System;
using System.Threading;
using WatiN.Core;

namespace WPFBlitz.src.Montreal.Tasks
{
    public class SearchField : Explorer
    {
        public void Search(string cpf, string dateLate, string erro)
        {
			try
			{
                var divUser = iBrowser.Div(Find.ById("dvCorpo"));

                Thread.Sleep(2000);

                divUser.TextField(Find.ById("P_NOME")).Value = cpf;

                divUser.Span(Find.ById("JONIco_P_NOME")).Click();

                Thread.Sleep(2000);

                var divAlert = iBrowser.Div(Find.ById("dvMsgAlert"));

                if (divAlert.Exists)
                {
                    Thread.Sleep(2000);
                    erro = divAlert.InnerHtml;
                    divAlert.Spans[0].Click();
                    return;
                }

                Thread.Sleep(2000);

                var divMenu = iBrowser.Div(Find.ById("dvMenu"));

                divMenu.Links[24].Click();

                Thread.Sleep(2000);

                dateLate = divUser.TextField(Find.ById("GRUPO_ATRASO")).Text;

                Thread.Sleep(2000);
            }
			catch (Exception error)
			{

			}
        }
    }
}
