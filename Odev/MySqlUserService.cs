using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class MySqlUserService : IGamerDal
    {
        public void Delete()
        {
            Console.WriteLine("MySql Silme İşlemi Gerçekleşti.");
        }

        public void IdControl(Gamer gamer)
        {
            Console.WriteLine("Mysql Kullanıcı Kontrolü Gerçekleşti."+gamer.NickName);
        }

        public void Register()
        {
            Console.WriteLine("MySql Kayıt İşlemi Gerçekleşti.");
        }

        public void Update()
        {
            Console.WriteLine("MySql Güncelleme İşlemi Gerçekleşti.");
        }
    }
}
