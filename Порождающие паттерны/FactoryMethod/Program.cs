using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    interface IProduction
    {
        void Release();
    }

    class Car : IProduction
    {
        public void Release()
        {
            Console.WriteLine("Выпущен новый легковой автомобиль");
        }
    }

    class Truck : IProduction
    {
        public void Release()
        {
            Console.WriteLine("Выпущен грузовой автомобиль");
        }
    }

    interface IWorkShop
    {
        IProduction Create();
    }

    class CarWorkShop : IWorkShop
    {
        public IProduction Create()
        {
            return new Car();
        }
    }

    class TruckWorkShop : IWorkShop
    {
        public IProduction Create()
        {
            return new Truck();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IWorkShop creator = new CarWorkShop();
            IProduction car = creator.Create();

            creator = new TruckWorkShop();
            IProduction track = creator.Create();

            car.Release();
            track.Release();

        }
    }
}
