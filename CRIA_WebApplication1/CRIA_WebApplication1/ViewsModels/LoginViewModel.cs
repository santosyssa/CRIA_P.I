using System.ComponentModel.DataAnnotations;

namespace CRIA_WebApplication1.ViewsModels
{
    public class LoginViewModel
    {
        [Required]
        public  string Email {  get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
