using DungeonsAndDragons.Tipos.TiposComunes;

namespace DungeonsAndDragons.Razas
{
    public class RazaJugable
    {
        public string raza { get; set; }
        public string subraza { get; set; }
        public string tamaño { get; set; }
        public int velocidad { get; set; }
        public string[] habilidades { get; set; }
        public string[] idiomas { get; set; }
        public Estadisticas estadisticas { get; set; }
    }
}
