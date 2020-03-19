using System;

namespace Timer
{
    public delegate void AlamrHandler(object sender, AlarmEventArgs args);
    public class AlarmEventArgs
    {
        public long CurrentTime;
        public AlarmEventArgs(Timer alarm)
        {
            CurrentTime = alarm.CurrentTime;
        }
    }

    public class Timer
    {
        public long CurrentTime;
        public long Begin;
        public long Clock;

        public event AlamrHandler TickEvent;
        public event AlamrHandler AlarmEvent;

        public Timer()
        {
            CurrentTime = 0;
            Begin = -1;
            Clock = 0;
        }

        public void SetClock(long second)
        {
            Begin = CurrentTime;
            Clock = second;
        }

        public void Start()
        {
            Console.Write("Start\n");
            Console.Write("When do you want to be alarmed?");
            string input = Console.ReadLine();
            long Clocknum;
            try
            {
                Clocknum = Int64.Parse(input);
                if (Clocknum > 0) Clock = Clocknum;
                else Clock = 5;
            }
            catch (Exception e) { Console.Write(e); }

            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                CurrentTime++;
                TickEvent(this, new AlarmEventArgs(this));
                if ((CurrentTime - Begin) % Clock == 0)
                {
                    AlarmEvent(this, new AlarmEventArgs(this));
                }
            }

        }
    }
    public class program
    {
        public Timer alarm = new Timer();
        void Tick(object sender, AlarmEventArgs args)
        {
            Console.Write("Now:" + args.CurrentTime + '\n');
        }
        void Alarm(object sender, AlarmEventArgs args)
        {
            Console.Write("Alarm:" + (args.CurrentTime+1) + '\n');
        }

        public program()
        {
            alarm.TickEvent += Tick;
            alarm.AlarmEvent += Alarm;
        }
    }
    class run
    {
        static void Main(string[] args)
        {
            program one = new program();
            one.alarm.Start();

        }
    }
}