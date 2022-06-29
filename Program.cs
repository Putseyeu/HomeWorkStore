using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBeforeDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.SearchOverdueCarcass();
            Console.ReadLine();
        }
    }

    class Storage
    {
        private List<Сarcass> _сarcasses = new List<Сarcass>()
        {
            new  Сarcass("Веселый кабанчик", 2004, 5),
            new  Сarcass("Грустный кабанчик", 2004, 15),
            new  Сarcass("Счастливая Курочка", 2019, 6),
            new  Сarcass("Веселыая корова", 2018, 10),
            new  Сarcass("Отчаенный турист", 20015, 5),
        };

        public void SearchOverdueCarcass()
        {
            int _currentYear = 2022;
             var overdueCarcass = _сarcasses.Where(сarcasses => сarcasses.ProductionYear + сarcasses.ShelfLife <= _currentYear).ToList();
            ShowProductsInfo(overdueCarcass);
        }

        private void ShowProductsInfo(List<Сarcass> products)
        {
            foreach (var product in products)
            {
                product.ShowInfo();
            }
        }
    }


    class Сarcass
    {
        public string Name { get;private set; }
        public int ProductionYear { get; private set; }
        public int ShelfLife { get; private set; }

        public Сarcass(string name, int productionYear, int shelfLife)
        {
            Name = name;
            ProductionYear = productionYear;
            ShelfLife = shelfLife;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название тушонки {Name} Дата производства {ProductionYear}");
        }
    }
}
