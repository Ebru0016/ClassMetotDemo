using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignPlayer : IGameManager
    {
        public double Price(double Price)
        {
            double Prices = Price - (Price / 100);
            Console.WriteLine("New Price " + Prices+"!!");
            return Prices;
        }

      
        public string Message(string Message)
        {
            Console.WriteLine("Size özel kampanya fırsatını kaçırmayın.Sadece 24 saat için geçerlidir.");
            return Message;


        }
    }
}
