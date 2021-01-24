using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class GameSalesManager : Game
    {
        public void Sales(Gamer gamer,List<Campaign> campaigns)
        {
            Console.WriteLine("Satış Gerçekleşti..\n"+"Oyun Adı:"+GameName+"\t"+"Alan Oyuncu:"+gamer.NickName);
            Console.WriteLine("-------------");
            Console.WriteLine("Kampanyalarımıza Göz Atın..");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
        }
      
    }
}
