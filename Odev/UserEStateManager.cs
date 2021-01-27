using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class UserEStateManager : IUserEState
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.FirstName=="Kemal" && gamer.TcNo=="11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
