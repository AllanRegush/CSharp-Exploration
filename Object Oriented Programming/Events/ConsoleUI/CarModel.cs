using System;
using System.Threading;

namespace ConsoleUI
{
    public class CarModel
    {
        public event EventHandler<string> OnStart;
        public string Name { get; private set; }
        public CarModel(string name)
        {
            Name = name;
        }

        public void AttemptStart()
        {
            const int oneSecond = 1000;
            Thread.Sleep(oneSecond);
            OnStart?.Invoke(this, "Started!");
        }

    }
}
