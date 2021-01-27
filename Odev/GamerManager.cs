using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class GamerManager : IGamerDal
    {
        IUserEState userEState = new UserEStateManager();
        public GamerManager(UserEStateManager userEStateManager)
        {
            userEState = userEStateManager;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Register(Gamer gamer)
        {
            if (userEState.Validation(gamer))
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
