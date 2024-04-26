using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpecBattle
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
}
