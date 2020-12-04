using WatiN.Core;
using WatiN.Core.Native.Windows;

namespace WPFBlitz.src.Montreal
{
    public class Explorer
    {
        protected static IE iBrowser;

        public void InicializeMontreal(string site)
        {
            iBrowser = new IE(site);            
            iBrowser.WaitForComplete();
        }

        public void CloseMontreal()
        {
            iBrowser.Close();
        }
    }
}
