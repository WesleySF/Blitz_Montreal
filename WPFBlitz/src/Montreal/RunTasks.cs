using WPFBlitz.src.Infra;
using WPFBlitz.src.Montreal.Tasks;

namespace WPFBlitz.src.Montreal
{
    public class RunTasks
    {
        private readonly Repository _repository = new Repository();
        public void Tasks(string cpf, string dateLate, string erro)
        {
            var consultaSite = _repository.SiteAddress();
            var explorer = new Explorer();
            var log = new PageLog();
            var searchCpf = new SearchField();
            var menu = new Menu();

            var site = consultaSite.Rows[0]["url"].ToString();
                        

            explorer.InicializeMontreal(site);
            log.Login();
            menu.Principal();
            searchCpf.Search(cpf, dateLate, erro);
            explorer.CloseMontreal();

        }
    }
}
