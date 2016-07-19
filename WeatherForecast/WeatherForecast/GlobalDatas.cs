using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class GlobalDatas
    {
        private static List<Reminder> reminders;
        public static List<Reminder> Reminders
        {
            get
            {
                if (reminders == null)
                {
                    reminders = new List<Reminder>();
                }

                return reminders;
            }
            set
            {
                reminders = value;
            }
        }
    }
}
