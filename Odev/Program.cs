using System;
using System.Collections.Generic;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();

            gamer1.Id = 1;
            gamer1.FirstName = "Kemal";
            gamer1.LastName = "Kartal";
            gamer1.NickName = "deneme";
            gamer1.TcNo = "11111111111";
            gamer1.Date = 1995;

            gamer1.Password = 1234;

            Gamer gamer2 = new Gamer();

            gamer2.Id = 2;
            gamer2.FirstName = "Kerim";
            gamer2.LastName = "Dev";
            gamer2.NickName = "deneme2";
            gamer2.TcNo = "22222222";
            gamer2.Date = 2000;
            gamer2.Password = 12345;

            GamerManager gamerManager = new GamerManager(new UserEStateManager());

            gamerManager.Register(gamer1);
            gamerManager.Register(gamer2);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer2);



            Campaign campaign = new Campaign(); 
            campaign.Id = 1;
            campaign.CampaignName = "Kampanya 1";

            Campaign campaign2 = new Campaign();

            campaign2.Id = 2;
            campaign2.CampaignName = "Kampanya 2";


            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign);

            List<Campaign> campaigns = new List<Campaign>() { campaign, campaign2 };

            GameSalesManager gameSalesManager = new GameSalesManager();

            gameSalesManager.Sales(gamer2,campaigns);

          







        }
    }
}
