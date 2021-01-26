using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager
    {
        public double MakeCampaign(Game game , IGameManager campaign)
        {
            return campaign.Price(game.Price);
        }
        public void Message()
        {
            Console.WriteLine("Size özel kampanya fırsatını kaçırmayın.Sadece 24 saat için geçerlidir.");
        }
    }
}
