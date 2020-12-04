using System.ComponentModel;

namespace WPFBlitz.src
{
    public class Excel
    {
        [DisplayName("Nome do cliente")]
        public string Nome { get; set; }

        [DisplayName("Empresa")]
        public string Empresa { get; set; }

        [DisplayName("CPF CLIENTE")]
        public string Cpf { get; set; }

        [DisplayName("Data de Atraso")]
        public string dateLate { get; set; }

        [DisplayName("Erro")]
        public string Erro { get; set; }
    }
}
