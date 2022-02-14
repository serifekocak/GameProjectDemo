using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthDay = 1985, Name = "ENGİN", Surname = "DEMİROĞ", TcNo = 12345 });

        }
    }
}
