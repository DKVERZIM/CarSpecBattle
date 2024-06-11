namespace CarSpecBattle.Data.Models
{
    public class CarCard
    {
        public int CardID { get; set; }
        public string Title { get; set; }
        public int TopSpeed { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
        public float Acceleration { get; set; }
        public string EngineSize { get; set; }
        /*Check with Kent*/
        public string ImageLink { get; set; }
        public int Tork { get; set; }
    }
    public class MyCsvRow
    {
    public string Column1 { get; set; }
    public string Column2 { get; set; }
    public string Column3 { get; set; }
    public string Column4 { get; set; }
    }
}
}