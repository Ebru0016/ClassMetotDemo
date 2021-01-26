using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.FirstName = "Ebru";
            player1.LastName = "Sevinç";
            player1.BirtDate = "1996";
            player1.TcNo = "111111111";

            Player player2 = new Player();
            player2.FirstName = "Sefa";
            player2.LastName = "Bilir";
            player2.BirtDate = "2010";
            player2.TcNo = "222222222";


            Game game1 = new Game();
            game1.GameName = "Pubg";
            game1.Price = 50;
            game1.Id = 1;


            Game game2 = new Game();
            game2.GameName = "FS 2019";
            game2.Price = 150;
            game2.Id = 2;

            IGameManager campaignPlayer = new CampaignPlayer();
            ILoggerService logger = new ControlService();

            GameManager gameManager = new GameManager();
            PlayerManager playerManager = new PlayerManager();
            CampaignManager campaignManager = new CampaignManager();


            playerManager.Add(player1);
            gameManager.Add(game1);
            campaignManager.Message();
            campaignManager.MakeCampaign(game1, campaignPlayer);
          
            
            



        }
    }
}
