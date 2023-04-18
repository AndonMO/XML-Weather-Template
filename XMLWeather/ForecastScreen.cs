using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        int weather1;
        int weather2;
        int weather3;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            weather1 = Convert.ToInt32(Form1.days[1].icon);
            weather2 = Convert.ToInt32(Form1.days[2].icon);
            weather3 = Convert.ToInt32(Form1.days[3].icon);

            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            min1.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempLow), 0)}";
            max1.Text = $"{Math.Round(Convert.ToDouble(Form1.days[1].tempHigh), 0)}";

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min2.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempLow), 0)}";
            max2.Text = $"{Math.Round(Convert.ToDouble(Form1.days[2].tempHigh), 0)}";

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            min3.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempLow), 0)}";
            max3.Text = $"{Math.Round(Convert.ToDouble(Form1.days[3].tempHigh), 0)}";

            #region Icons
            #region pictureBox 1
            if (weather1 > 199 && weather1 < 232)
            {
                pictureBox1.Image = Properties.Resources.stormIcon;
            }
            else if (weather1 > 299 && weather1 < 531)
            {
                pictureBox1.Image = Properties.Resources.rainIcon;
            }
            else if (weather1 > 599 && weather1 < 622)
            {
                pictureBox1.Image = Properties.Resources.snowIcon;
            }
            else if (weather1 == 800)
            {
                pictureBox1.Image = Properties.Resources.sunIcon;
            }
            else if (weather1 > 800 && weather1 < 805)
            {
                pictureBox1.Image = Properties.Resources.cloudyIcon;
            }
            #endregion

            #region picturebox 2
            if (weather2 > 199 && weather2 < 232)
            {
                pictureBox2.Image = Properties.Resources.stormIcon;
            }
            else if (weather2 > 299 && weather2 < 531)
            {
                pictureBox2.Image = Properties.Resources.rainIcon;
            }
            else if (weather2 > 599 && weather2 < 622)
            {
                pictureBox2.Image = Properties.Resources.snowIcon;
            }
            else if (weather2 == 800)
            {
                pictureBox2.Image = Properties.Resources.sunIcon;
            }
            else if (weather2 > 800 && weather2 < 805)
            {
                pictureBox2.Image = Properties.Resources.cloudyIcon;
            }
            #endregion

            #region pictureBox 3
            if (weather3 > 199 && weather3 < 232)
            {
                pictureBox3.Image = Properties.Resources.stormIcon;
            }
            else if (weather3 > 299 && weather3 < 531)
            {
                pictureBox3.Image = Properties.Resources.rainIcon;
            }
            else if (weather3 > 599 && weather3 < 622)
            {
                pictureBox3.Image = Properties.Resources.snowIcon;
            }
            else if (weather3 == 800)
            {
                pictureBox3.Image = Properties.Resources.sunIcon;
            }
            else if (weather3 > 800 && weather3 < 805)
            {
                pictureBox3.Image = Properties.Resources.cloudyIcon;
            }
            #endregion

            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
