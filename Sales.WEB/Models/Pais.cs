namespace Sales.WEB.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Departamento> Departamentos { get; set; } 
    }
}
