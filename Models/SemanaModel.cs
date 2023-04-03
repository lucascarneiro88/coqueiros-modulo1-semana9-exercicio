using System;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace exercicio_semana9.Models
{
    [Table("SEMANA")]
    public class SemanaModel

        {
        [Key]
        [Column("Semana")]
        public int Id { get; set; }

        [MaxLength(100)]
        public DateTime DataSemana9 { get; set; }
          
        public string? Conteudo { get; set; }
        public bool AplicadoConteudo { get; set; }
        }


}

