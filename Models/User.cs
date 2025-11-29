using System.ComponentModel.DataAnnotations;

namespace LoginApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O nome e obrigatorio")]
        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "O email e obrigatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "A senha e obrigatoria")]
        [MinLength(6, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
        [Display(Name = "Senha")]
        public string Password { get; set; } = string.Empty;
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "O email e obrigatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha e obrigatoria")]
        [Display(Name = "Senha")]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O nome e obrigatorio")]
        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email e obrigatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha e obrigatoria")]
        [MinLength(6, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
        [Display(Name = "Senha")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas nao conferem")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public bool AcceptTerms { get; set; }
    }
}
