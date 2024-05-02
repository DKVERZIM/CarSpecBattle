using CarSpecBattle.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarSpecBattle.Data.Repositories
{
    public class CarCardRepository
    {

        public CarCardRepository() { }

        public List<CarCard> GetCarCards()
        { 
            var carCards = new List<CarCard>();
            StreamReader sr = new StreamReader("C:/BRIAN/WHATEVER.CSV");

            while (sr.ReadLine() != null)
            { 
                var line = sr.ReadLine();
                var row = line.Split(",");

                var card = new CarCard()
                {
                  
                };
                carCards.Add(card);
            }
            return carCards;
        }
        
        
    }
}
