using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    interface IEngine
    {
        void ReleaseEngine();
    }

    class JapaneseEngine : IEngine
    {
        public void ReleaseEngine()
        {
            Console.WriteLine("Японский двигатель");
        }
    }

    class RussianEngine : IEngine
    {
        public void ReleaseEngine()
        {
            Console.WriteLine("Российский двигатель");
        }
    }

    interface ICar
    {
        void ReleaseCar(IEngine engine);
    }

    class JapaneseCar: ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали японский автомобиль: ");
            engine.ReleaseEngine();
        }
    }

    class RussianCar: ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали российский автомобиль: ");
            engine.ReleaseEngine();
        }
    }

    interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }

    class JapaneseFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new JapaneseCar();
        }

        public IEngine CreateEngine()
        {
            return new JapaneseEngine();
        }
    }

    class RussianFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new RussianCar();
        }

        public IEngine CreateEngine()
        {
            return new RussianEngine();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*Japanese car*/
            IFactory jFactory = new JapaneseFactory();
            IEngine jEngine = jFactory.CreateEngine();
            ICar jCar = jFactory.CreateCar();
            jCar.ReleaseCar(jEngine);
            /*Russian car*/

            IFactory rFactory = new RussianFactory();
            IEngine rEngine = rFactory.CreateEngine();
            ICar rCar = rFactory.CreateCar();
            rCar.ReleaseCar(rEngine);
        }
    }
}
