using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class ClockForm : Form
    {
        private Reminder reminder1;
        public ClockForm(Reminder reminder)
        {
            InitializeComponent();
            this.reminder1 = reminder;
            this.dateTimePicker1.Text = reminder.Time;
            this.thing_txtbox.Text = reminder.Info;
            this.city_txtbox.Text = reminder.City;
        }
        private void ClockForm_Load(object sender, EventArgs e)
        {
            Bind(GlobalDatas.Reminders);
        }

        private void Bind(List<Reminder> alarms)
        {
            if (alarms.Count > 0)
            {
                dateTimePicker1.Text = alarms[0].Time;
                city_txtbox.Text = alarms[0].City;
                thing_txtbox.Text = alarms[0].Info;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            reminder1.Info = thing_txtbox.Text;
            reminder1.Time = dateTimePicker1.Text;
            reminder1.City = city_txtbox.Text;
            if(GlobalDatas.Reminders.Count==0)
            {
                reminder1.Add();
            }
            else
            {
                reminder1.Update();
                //GlobalDatas.Reminders = Reminder.LoadAll();
            }
            this.Close();
        }
    }
}
