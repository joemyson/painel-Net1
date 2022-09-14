using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Painel_Net.Models
{
    [Table("Painel")]
    public class Painel
    {

        [Column("Id")]
        [Display(Name ="Id")]
        public int Id { get; set; }


        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha{ get; set; }


        [Column("Guiche")]
        [Display(Name = "Guiche")]
        public string Guiche { get; set; }
    }
}
