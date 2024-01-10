using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_adois.Models
{   
    [Table("Destinos")]
    public class Destinos
    {
        [Key]
        public int IdDes { get; set; }

        [Column("NomeDoDestino")]
        public string NomeDes { get; set; } = string.Empty;

        [Column("ImagemDoDestino")]
        public string ImgDestino { get; set; } = string.Empty;

        [Column("PrecoDest")]
        public int PrecoDest {get; set;}
    }
}