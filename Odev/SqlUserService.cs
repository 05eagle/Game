using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class SqlUserService : IGamerDal
    {
        public void Delete()
        {
            Console.WriteLine("Sql Silme İşlemi Gerçekleşti.");
        }

        public void IdControl(Gamer gamer)
        {
            Console.WriteLine("Sql Kontrol Sağlandı."+gamer.NickName);
        }

        public void Register()
        {
            Console.WriteLine("Sql Kayıt İşlemi Gerçekleşti.");
        }

        public void Update()
        {
            Console.WriteLine("Sql Kullanıcı Kontrolü Gerçekleşti.");
        }

        
    }
}
