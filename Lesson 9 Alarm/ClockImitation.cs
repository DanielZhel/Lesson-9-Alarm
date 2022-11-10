using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Alarm
{
    public class ClockImitation
    {
        public delegate void ActionComplite();

        private string _userMessage { get; set; }
        private int _time { get; set; }

        public ClockImitation(int time, string userMessage)
        {
            Console.WriteLine(userMessage);
            _time = time;
        }

        public void Alarm()
        {
            Thread.Sleep(_time*1000);
            action.Invoke();
        }

        public static void EventMessage()
        {
            Console.WriteLine("Time is runnig out!");
        }

        public ActionComplite action = new ActionComplite(EventMessage);

    }

    public class Observer
    {
        public void AddObsreverNotification(ClockImitation alarmNum)
        {
            alarmNum.action += ObserverMessage;
        }
        
        public void ObserverMessage()
        {
            Console.WriteLine("I'm Observer. I got the message about ending");
        }
    }
}