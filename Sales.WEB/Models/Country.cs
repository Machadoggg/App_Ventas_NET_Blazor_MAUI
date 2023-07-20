namespace Sales.WEB.Models
{
    public class Country
    {
        public string Name { get; set; }
        public List<State> States { get; set; }
    }

    public class State
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
    }
}
