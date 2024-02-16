using System.ComponentModel.DataAnnotations;

namespace TxArt.GoldenNews.Web.ViewModels.AutenticacaoAutorizacao
{
    public class LoginViewModel
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool Lembrar { get; set; }
    }
}
