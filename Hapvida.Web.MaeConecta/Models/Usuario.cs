namespace Hapvida.Web.MaeConecta.Models
{
    public class Usuario
    {

        public int UsuarioId { get; set; }

        public string? Nome { get; set; }

        public int Idade { get; set;}
        
        public int SemanaGestacao { get; set;}

        public string ? Email { get; set;}
        
        public string? Senha { get; set; }   

        public TipoSanguineo TipoSanguineo { get; set; }
        
        public DateTime DataCadastro { get; set; }

       
    }

    public enum TipoSanguineo
    {
        APositivo, ANegativo,
        BPositivo, BNegativo,
        OPositivo, ONegativo,
        ABPositivo, ABNegativo
    }
}
