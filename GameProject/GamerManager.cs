using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager:IGamerService
    {
        IUserValidationService userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt Oldu");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }


    }

    internal interface IUserValidationService
    {
    }
}
