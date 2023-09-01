using System.ComponentModel.DataAnnotations;

namespace FirstWebApiFacul.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Required(ErrorMessage ="É obrigatório o preenchimento do e-mail.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="É obrigatório o preenchimento da senha.")]
        public string Senha { get; set; }
    }
}
