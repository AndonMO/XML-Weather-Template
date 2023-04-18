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
    public partial class CurrentScreen : UserControl
    {
        int weather;

        string search;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            conditonsLabel.Text = Form1.days[0].condition;
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0)}";
            minOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0)}";
            maxOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0)}";
            dateOutput.Text = DateTime.Now.ToString("dddd");


            weather = Convert.ToInt32(Form1.days[0].background);
            //weather = 801;
            

            #region background
            if (weather > 199 && weather < 232)
            {
                BackgroundImage = Properties.Resources.stormDayWeather;
            }
            else if (weather > 299 && weather < 531)
            {
                BackgroundImage = Properties.Resources.rainyDayWeather;
            }
            else if (weather > 599 && weather < 622)
            {
                BackgroundImage = Properties.Resources.snowDayWeather;
            }
            else if (weather == 800)
            {
                BackgroundImage = Properties.Resources.sunnyDayWeather2;
            }
            else if (weather > 800 && weather < 805)
            {
                BackgroundImage = Properties.Resources.cloudyDayWeather2;
            }
            #endregion

            

            
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            cityInput.Text = Form1.city;
            countryInput.Text = Form1.country;
            Form1.days.Clear();
        }
    }
}
