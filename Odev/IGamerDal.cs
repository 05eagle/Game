using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    interface IGamerDal
    {

        void Register();
        void Update();
        void Delete();

        void IdControl(Gamer gamer);
    }

    
}
