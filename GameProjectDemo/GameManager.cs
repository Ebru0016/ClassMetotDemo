using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameManager:Game
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Başarılı bir şekilde eklendi.Keyifli oyunlar dileriz :) ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Başarılı bir şekilde güncellendi.");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Silme işlemi başarılı bir şekilde tamamlandı!");
        }
    }
}
