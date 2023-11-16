using Microsoft.Extensions.Diagnostics.HealthChecks;
using PimTeste.Enums;
using System.ComponentModel.DataAnnotations;

namespace PimTeste.Models
{
    public class UsuarioLogin
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Digite o seu email")]
        public string? Email { get ; set; }
 
        [Required(ErrorMessage = " Digite sua senha ")]
        public string? senha { get; set; }
        public PerfilEnum Perfil { get; set; }
        //quando o usuário foi cadastrado e modificado;
        public DateTime DataCadastro { get; set; }
        public DateTime? AlteracaoUsuario { get; set; }


        // + prioridades 

    }
}
