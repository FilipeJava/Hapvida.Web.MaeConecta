using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Hapvida.Web.MaeConecta.Models
{
    [Table("Tbl_Endereco")]
    public class Endereco
    {
        [Column("id"), HiddenInput]
        public int EnderecoId { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Cep { get; set; }
    }
}