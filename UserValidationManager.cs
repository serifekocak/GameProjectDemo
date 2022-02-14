using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDay == 1985 && gamer.Name == "ENGİN" && gamer.Surname == "DEMİROĞ" && gamer.TcNo == 12345)
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
