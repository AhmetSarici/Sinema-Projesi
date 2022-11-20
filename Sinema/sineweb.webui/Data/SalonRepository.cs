using System.Collections.Generic;
using System.Linq;

namespace sineweb.webui.Data
{
    public class SalonRepository
    {
        private static List<Salon> _salonlar = null;

        static SalonRepository()
        {
            _salonlar = new List<Salon>
            {
                new Salon {SalonId=1,Name="Salon 1",Description="Açık"},
                new Salon {SalonId=2,Name="Salon 2",Description="Kapalı"},
                new Salon {SalonId=3,Name="Salon 3",Description="Açık"}
            };
        }

        public static List<Salon> Salonlar
        {
            get
            {
                return _salonlar;
            }
        }

        public static void AddSalon(Salon salon)
        {
            _salonlar.Add(salon);
        }

        public static Salon GetSalonbyId(int id)
        {
            return _salonlar.FirstOrDefault(c => c.SalonId == id);
        }
    }
}