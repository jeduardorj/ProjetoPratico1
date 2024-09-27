using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPratico1.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "UserID")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "UserNome")]
        [Column("Nome")]
        public string Nome { get; set; }


    }
}
