using System.Runtime.InteropServices;

namespace Demo

{
    public abstract class Clock
    {
        public abstract void ShowTime();

    }

    public interface ITalkative
    {
        void Talk();
    }

    interface IAlarm
    {
        void Ring();
    }

    interface IDate
    {
        void Date();
    }

    class AnalogClock : Clock
    {

        public override void ShowTime()
        {
            Console.WriteLine("Show time using Hour, minute and second hands");
        }
    }

    class DigitalClock : Clock, IAlarm
    {
        public void Ring()
        {
            Console.WriteLine("raise alarm");
        }

        public override void ShowTime()
        {
            Console.WriteLine("display numeric time");
        }


    }

    class donoclock : Clock, IAlarm
    {
        public override void ShowTime()
        {
            Console.WriteLine("dono clock shows time");

        }

        public void Ring()
        {
            Console.WriteLine("dono clock is Ringing");
        }




        internal class Program
        {
            static void Main(string[] args)
            {
                donoclock dono = new donoclock();
                dono.ShowTime();
                dono.Ring();

            }
        }
    }
}
