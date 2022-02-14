using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    
    class GamerManager : IGamerService
    {
        // constructor
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }
    }
}
