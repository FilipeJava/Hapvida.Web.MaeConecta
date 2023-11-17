using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Hapvida.Web.MaeConecta.Models
{

    [Table("Tbl_contato")]
    public class Contatos
    {
        [Column("id"), HiddenInput]
        public int ContatosId { get; set; }

        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Relacionamento { get; set; }
        [Required]
        public string Telefone { get; set; }




    }
}
