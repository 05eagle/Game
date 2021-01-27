using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    interface IGamerDal
    {

        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

        
    }

    
}
