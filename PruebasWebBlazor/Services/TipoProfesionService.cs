using PruebasWebBlazor.Models;

namespace PruebasWebBlazor.Services
{
    public class TipoProfesionService
    {
        public List<TipoProfesion> GetTipoProfesion()
        {
            return new List<TipoProfesion>
            {
                new TipoProfesion { Id = 1, Nombre = "Ingeniero" },
                new TipoProfesion { Id = 2, Nombre = "Abogado" },
                new TipoProfesion { Id = 3, Nombre = "Médico" },
                new TipoProfesion { Id = 4, Nombre = "Arquitecto" }
            };
        }
    }
}
