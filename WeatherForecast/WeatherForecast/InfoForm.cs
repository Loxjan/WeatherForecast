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
    public partial class InfoForm : Form
    {
        public InfoForm(Reminder reminder,WeatherData temp)
        {
            InitializeComponent();
            info_txtbox.Text = "待办事项："+reminder.Info;
            if (temp.desc == "OK")
            {
                city.Text = temp.data.city;
                High.Text = temp.data.forecast[0].high;
                Low.Text = temp.data.forecast[0].low;
                fengli.Text = "风力："+temp.data.forecast[0].fengli;
                fengxiang.Text = temp.data.forecast[0].fengxiang;

                gaomao_txtbox.Text = temp.data.ganmao;
            }
            else
                gaomao_txtbox.Text = "未获取到数据，请检查网络！";

        }
    }
}
