using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    [Serializable]
    public class Reminder
    {
        public Guid ID
        {
            get;
            set;
        }

        public string Info
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }

        public Reminder()
        {
            this.ID = Guid.NewGuid();
            this.Info = string.Empty;
            this.Time = string.Empty;
            this.City = string.Empty;
        }

        public void Add()
        {
            GlobalDatas.Reminders.Add(this);

            StorageHelper.Serialize<Reminder>(GlobalDatas.Reminders, StorageHelper.alarmStorage);
        }
        public void Update()
        {
            for (int i = 0; i < GlobalDatas.Reminders.Count; i++)
            {
                    GlobalDatas.Reminders[i].Info = this.Info;
                    GlobalDatas.Reminders[i].Time = this.Time;
                    GlobalDatas.Reminders[i].City = this.City;
                    break;
            }

            StorageHelper.Serialize<Reminder>(GlobalDatas.Reminders, StorageHelper.alarmStorage);
        }

        public static List<Reminder> LoadAll()
        {
            GlobalDatas.Reminders = StorageHelper.Deserialize<Reminder>(StorageHelper.alarmStorage);

            return GlobalDatas.Reminders;
        }
    }
}
