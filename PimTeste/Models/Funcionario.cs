using Microsoft.AspNetCore.Identity;

namespace PimTeste.Models
{
    public class Funcionario
    {

        public string? NomeFuncionario { get; set; } 

        public string? CPF { get; set; }
        public int LoginId { get; set; }

        public UsuarioLogin? usuario;
        public string? Cargo { get; set; }

        public double Salario { get; set; }
        public string? NomeDepartamento { get; set; }


        //+ propiedades


}
}
