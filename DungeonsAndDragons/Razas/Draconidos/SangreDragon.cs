using Newtonsoft.Json;
using System.Text;

namespace DungeonsAndDragons.Razas.Draconidos
{
    public class SangreDragon : RazaJugable
    { 

        public SangreDragon() {
            this.raza = "Draconido";
            this.subraza = "SangreDragon";

            this.tamaño = "Mediano";
            this.velocidad = "30 pies";

            this.habilidades = new String[] { "Linaje Dracónico", "Arma de Aliento", "Resistencia al daño" };
            this.idiomas = new string[] { "Común", "Dracónico"};

            this.fuerza = 2;
            this.destreza = 0;
            this.constitucion = 0;
            this.sabiduria = 0;
            this.inteligencia = 2;
            this.carisma = 2;
        }
        
    }
}
