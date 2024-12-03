using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GabrielCalderon_Taller.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool Extranjeros { get; set; }
        [ForeignKey("Estadio")]
        public int IDEstadio { get; set; }
        public Estadio Estadio { get; set; }
    }
}
