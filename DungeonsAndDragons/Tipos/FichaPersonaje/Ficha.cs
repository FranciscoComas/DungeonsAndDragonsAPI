using DungeonsAndDragons.Tipos.TiposComunes;

namespace DungeonsAndDragons.Tipos.FichaPersonaje
{
    public class Ficha
    {
        public string nombre { get; set; }
        public Clase clase { get; set; }
        public string trasfondo { get; set; }
        public string nombreJugador { get; set; }
        public string raza { get; set; }
        public string alineamiento { get; set; }
        public int puntosExperiencia { get; set; }
        public Estadisticas estadisticas { get; set; }
        public SabiduriaPasiva sabiduriaPasiva {get; set;}
        public Dictionary<string, List<string>> lenguajes { get; set; }
        public Dictionary<string, List<string>> proficencias { get; set; }
        public int inspiracion { get; set; }
        public int bonoProficencia { get; set; }
    }
}
