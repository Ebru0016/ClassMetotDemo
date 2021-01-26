using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class PlayerManager:Player
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı kullanıcı eklendi.");
        }
        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı kullanıcı başarılı bir şekilde güncellendi.");
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı kullanıcı silindi!");
        }
    }
}
