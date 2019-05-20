using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using _1_Chronometer.Contracts;

namespace _1_Chronometer
{
    public class Chronometers : IChronometer
    {
        public static void Main(string[] args)
        {
            IChronometer chronometer = new Chronometers();

            string inputLine;

            while ((inputLine=Console.ReadLine())!="exit")
            {
                switch (inputLine)
                {
                    case "start": chronometer.Start(); break;
                    case "stop": chronometer.Stop(); break;
                    case "lap":Console.WriteLine(chronometer.Lap()); break;
                    case "laps":
                        var temp = "Laps"+(chronometer.Laps.Count == 0
                            ?"no laps"
                            : "\r\n"+string.Join("\r\n",chronometer.Laps.Select((lap, index) => $"{index}. {lap}")));
                        Console.WriteLine(temp);
                break;
                    case "time":Console.WriteLine(chronometer.GetTime); break;
                    case "reset": chronometer.Reset(); break;
                }
            }
            Console.WriteLine("Hello World!");
        }

        private long milliseconds;

        public string GetTime => $"{milliseconds / 60000:d2}:{milliseconds / 1000:d2}:{milliseconds%1000:d4}";
        public List<string> Laps { get; private set; }

        private bool isRunning;

        public Chronometers()
        {
            this.Reset();
        }

        public void Start()
        {
            isRunning = true;
            Task.Run(() =>
            {
                while (isRunning)
                {
                    Thread.Sleep(1);
                    milliseconds++;
                }
            });
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        public string Lap()
        {
            var lap = this.GetTime;
            this.Laps.Add(lap);
            return lap;
        }

        public void Reset()
        {
            this.milliseconds = 0;
            this.Stop();
            this.Laps = new List<string>();
        }
    }
}
