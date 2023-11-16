namespace PimTeste.Models
{
    public class FolhaDePagamento
    {

        public int Id { get; set; }
        public int FuncionarioId { get; set; }

        public Funcionario Funcionario { get; set; }
        public double Valor { get; set; }
        public DateTime DataValor { get; set; }

         //+ prioridades 

    }
}
