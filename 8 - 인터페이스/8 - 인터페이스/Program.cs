using System;
using System.IO;
using static System.Console;

namespace 인터페이스
{
    internal interface ILogger
    {
        void WriteLog(string log);
    }

    internal interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    internal class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }

    internal class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }

        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }

    internal class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }

    internal class ClimateMonitor
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Write("온도를 입력해주세요. : ");
                string temperature = ReadLine();
                if (temperature == "")
                    break;
                if (temperature == "-273")
                {
                    logger.WriteLog("일격필살! 프로그램은 쓰러졌다!");
                    break;
                }
                logger.WriteLog("현재 온도 : " + temperature + "℃");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ILogger logger1 = new ConsoleLogger();
            // ConsoleLogger는 ILogger를 상속받고, 상속받는 클래스는 부모 클래스와 같은 형식으로 간주하기에 ConsoleLogger의 객체는 ILogger의 객체로 취급할 수 있다? 음..
            //인터페이스는 객체를 못 만들고 참조만 시켜줌.. 저렇게 객체를 생성하는 건 클래스가 해줘야 되는 듯.

            IFormattableLogger logger2 = new ConsoleLogger2();
            //logger1.WriteLog("{0} + {1} = {2}", 1, 2, 3);
            //위 코드는 오류 발생시킴
            logger2.WriteLog("{0} + {1} = {2}", 1, 2, 3);
            ClimateMonitor climateMonitor;
            climateMonitor = new ClimateMonitor(new ConsoleLogger());
            //climateMonitor = new ClimateMonitor(new FileLogger("C:\\users\\user\\Desktop\\모나빵디.txt"));
            climateMonitor.Start();
        }
    }
}