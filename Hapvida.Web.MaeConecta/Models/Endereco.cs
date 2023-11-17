using System.ComponentModel.DataAnnotations;

namespace Hapvida.Web.MaeConecta.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Cep { get; set; }
    }
}