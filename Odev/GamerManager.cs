using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class GamerManager
    {
        public void Register(IGamerDal gamerDal)
        {
            gamerDal.Register();
        }
        public void Update(IGamerDal gamerDal)
        {
            gamerDal.Update();
        }
        public void Delete(IGamerDal gamerDal)
        {
            gamerDal.Delete();
        }
        
        public void UserCheck(IGamerDal gamerDal,Gamer gamer)
        {
            gamerDal.IdControl(gamer);
        }
    }
}
