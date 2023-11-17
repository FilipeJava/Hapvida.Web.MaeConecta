namespace Hapvida.Web.MaeConecta.Models
{
    public class Usuario
    {

        public int UsuarioId { get; set; }

        public string? Nome { get; set; }

        public int Idade { get; set;}
        
        public int SemanaGestacao { get; set;}

        public string? Email { get; set;}
        
        public string? Senha { get; set; }   

        public TipoSanguineo TipoSanguineo { get; set; }
        
        public DateTime DataCadastro { get; set; }


        //1:1
        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        //1:N

        public IList<Ocorrencias> Ocorrencias { get; set;}

        public IList<Contatos> Contatos { get; set; }



    }

    public enum TipoSanguineo
    {
        APositivo, ANegativo,
        BPositivo, BNegativo,
        OPositivo, ONegativo,
        ABPositivo, ABNegativo
    }
}
