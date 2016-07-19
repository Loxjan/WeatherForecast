using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net.NetworkInformation;

namespace WeatherForecast
{
    public partial class MainForm : Form
    {
        private Point ptMouseNowPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;

        private PictureBox[] ptb = null;

        private HTTP httptest = null;
        private bool netlink = false;
        private bool isAlarm = true;

        Reminder reminder = new Reminder();
        
        public MainForm()
        { 
            InitializeComponent();
            httptest = new HTTP();
            ptb = new PictureBox[2];
            ptb[0] = pictureBox1;
            ptb[1] = pictureBox2;
            CheckNetlink();
            if(netlink)
            {
                String temp = httptest.getWeather("北京");
                updateWeather(temp);
            }
        }

        public bool CheckNetlink()
        {
            Ping p = new Ping();
            PingReply pr;
            pr = p.Send("123.129.254.17");//天气接口的IP
            if (pr.Status == IPStatus.Success)
            {
                netlink = true;
                lb_netlink.Text = "已联网";
                return true;
            }
            else
            {
                lb_netlink.Text = "未联网";
                netlink = false;
                return false;
            }
        }

        private void updateWeather(String temp)
        {
            WeatherData a = JsonConvert.DeserializeObject<WeatherData>(temp);
            if (a.desc == "OK")
            {
                this.CityNum.Text = a.data.city;
                int t = int.Parse(a.data.wendu);
                int tenths = t / 10;
                int units = t % 10;
                if (-units > units)
                {
                    this.pictureBox1.Image = NumimageList.Images[Math.Abs(tenths)];
                    this.pictureBox2.Image = NumimageList.Images[-units];
                    this.negative_label.Visible = true;

                }
                else
                {
                    this.pictureBox1.Image = NumimageList.Images[tenths];
                    this.pictureBox2.Image = NumimageList.Images[units];
                    this.negative_label.Visible = false;
                }
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.DetailText.Text = a.data.ganmao;
                var b = a.data.yesterday.high.Substring(3);
                this.chart1.Series[0].Points.AddXY("昨天",double.Parse(b.Substring(0, b.Length - 1)));
                b = a.data.yesterday.low.Substring(3);
                this.chart1.Series[1].Points.AddXY("昨天", double.Parse(b.Substring(0, b.Length - 1)));
                this.label1.Text = a.data.yesterday.type;
                this.label2.Text = a.data.forecast[0].type;
                this.label3.Text = a.data.forecast[1].type;
                this.label4.Text = a.data.forecast[2].type;
                this.label5.Text = a.data.forecast[3].type;
                this.label6.Text = a.data.forecast[4].type;
                for (int i = 0; i < 5; i++)
                {
                    var d = a.data.forecast[i].high.Substring(3);
                    this.chart1.Series[0].Points.AddXY(a.data.forecast[i].date, double.Parse(d.Substring(0, d.Length - 1)));
                    d = a.data.forecast[i].low.Substring(3);
                    this.chart1.Series[1].Points.AddXY(a.data.forecast[i].date, double.Parse(d.Substring(0, d.Length - 1)));

                }
            }
            else
                MessageBox.Show("您输入查找的城市有误！", "ERROR!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.8)
            {
                this.Opacity += 0.05;
            }
            if (GlobalDatas.Reminders[0].Time == DateTime.Now.ToString("HH:mm"))
            {
                if (isAlarm)
                {
                    isAlarm = false;
                    ShowInfoForm();
                    
                }
            }
        }
        private void ShowInfoForm()
        {
            String test = httptest.getWeather(GlobalDatas.Reminders[0].City);
            WeatherData temp = JsonConvert.DeserializeObject<WeatherData>(test);
            InfoForm form = new InfoForm(GlobalDatas.Reminders[0], temp);
            form.ShowDialog();
        }

        private void minSize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (this.search_txtbox.Text != ""||this.netlink == true)
            {
                updateWeather(httptest.getWeather(search_txtbox.Text));
            }
            else
                MessageBox.Show("未联网或输入城市有误", "Error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockForm form = new ClockForm(reminder);
            form.ShowDialog();
            isAlarm = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalDatas.Reminders = Reminder.LoadAll();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnMouseDown)
            {
                //Get the current position of the mouse in the screen
                ptMouseNewPos = Control.MousePosition;
                //Set window position
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseNowPos.X + ptFormPos.X;
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseNowPos.Y + ptFormPos.Y;
                //Save window position
                Location = ptFormNewPos;
                ptFormPos = ptFormNewPos;
                //Save mouse position
                ptMouseNowPos = ptMouseNewPos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //Return back signal
                blnMouseDown = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                blnMouseDown = true;
                // Save window position and mouse position
                ptMouseNowPos = Control.MousePosition;
                ptFormPos = Location;
            }
        }
        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm_MouseUp(sender, e);
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm_MouseDown(sender, e);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm_MouseMove(sender, e);
        }

        private void DetailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

    }
}
