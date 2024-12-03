using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GabrielCalderon_Taller.Models
{
    public class Jugador
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        [ForeignKey("Equipo")]
        public int IDEquipo { get; set; }
        public Equipo Equipo { get; set; }
    }
}
