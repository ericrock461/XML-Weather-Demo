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
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();

            // set the backdrop
            backgroundBox.BackgroundImage = Properties.Resources.pattern2;

            todayLabel.Parent = backgroundBox;
            forecastLabel.Parent = backgroundBox;
            label5.Parent = backgroundBox;
            nextDaysLabel.Parent = backgroundBox;
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {     
            // displaying data while formatting dates and temperatures
            day1.Text = Convert.ToDateTime(Form1.days[1].date).ToString("dd");
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("##");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("##");

            // show an image in the "icon" pictureBoxes based on the weather conditions
            // there's probably a better way of doing this
            if (Form1.days[1].condition == "clear") 
            {
                icon1.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[1].condition == "overcast clouds")
            {
                icon1.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[1].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon1.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[1].condition == "Thunderstorm")
            {
                icon1.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[1].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon1.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon1.BackgroundImage = Properties.Resources.partyCloudy2;
            }

            
            day2.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dd");
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("##");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("##");

            if (Form1.days[2].condition == "clear")
            {
                icon2.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[2].condition == "overcast clouds")
            {
                icon2.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[2].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon2.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[2].condition == "Thunderstorm")
            {
                icon2.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[2].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon2.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon2.BackgroundImage = Properties.Resources.partyCloudy2;
            }


            day3.Text = Convert.ToDateTime(Form1.days[3].date).ToString("dd");
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("##");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("##");

            if (Form1.days[3].condition == "clear")
            {
                icon3.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[3].condition == "overcast clouds")
            {
                icon3.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[3].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon3.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[3].condition == "Thunderstorm")
            {
                icon3.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[3].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon3.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon3.BackgroundImage = Properties.Resources.partyCloudy2;
            }


            day4.Text = Convert.ToDateTime(Form1.days[4].date).ToString("dd");
            min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("##");
            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("##");

            if (Form1.days[4].condition == "clear")
            {
                icon4.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[4].condition == "overcast clouds")
            {
                icon4.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[4].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon4.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[4].condition == "Thunderstorm")
            {
                icon4.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[4].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon4.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon4.BackgroundImage = Properties.Resources.partyCloudy2;
            }


            day5.Text = Convert.ToDateTime(Form1.days[5].date).ToString("dd");
            min5.Text = Convert.ToDouble(Form1.days[5].tempLow).ToString("##");
            max5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("##");

            if (Form1.days[5].condition == "clear")
            {
                icon5.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[5].condition == "overcast clouds")
            {
                icon5.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[5].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon5.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[5].condition == "Thunderstorm")
            {
                icon5.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[5].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon5.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon5.BackgroundImage = Properties.Resources.partyCloudy2;
            }


            day6.Text = Convert.ToDateTime(Form1.days[6].date).ToString("dd");
            min6.Text = Convert.ToDouble(Form1.days[6].tempLow).ToString("##");
            max6.Text = Convert.ToDouble(Form1.days[6].tempHigh).ToString("##");

            if (Form1.days[6].condition == "clear")
            {
                icon6.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (Form1.days[6].condition == "overcast clouds")
            {
                icon6.BackgroundImage = Properties.Resources.clouds_icon;
            }
            else if (Form1.days[6].condition == "Light Rain" || Form1.days[2].condition == "Moderate Rain")
            {
                icon6.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (Form1.days[6].condition == "Thunderstorm")
            {
                icon6.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (Form1.days[6].condition == "Light Snow" || Form1.days[1].condition == "Heavy Snow")
            {
                icon6.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                icon6.BackgroundImage = Properties.Resources.partyCloudy2;
            }


            // formatting the dates in English, while simultaneously formatting in Japanese
            /*each day of the week in Japanese has its own character. I programmed the 
             * corresponding character to appear alongside the "dd" date 
             * based on what is shown on the English labels. for example, 
             * if the dayE label displays "Mon", the day label will show the corresponding JP character.
             * I feel like there may have been an easier way to do this, but it still works nonetheless :) */
            day1E.Text = Convert.ToDateTime(Form1.days[1].date).ToString("ddd");
            if (day1E.Text == "Mon")
            {
                day1.Text += " (月)";
            }
            else if (day1E.Text == "Tue")
            {
                day1.Text += " (火)";
            }
            else if (day1E.Text == "Wed")
            {
                day1.Text += " (水)";
            }
            else if (day1E.Text == "Thu")
            {
                day1.Text += " (木)";
            }
            else if (day1E.Text == "Fri")
            {
                day1.Text += " (金)";
            }
            else if (day1E.Text == "Sat")
            {
                day1.Text += " (土)";
            }
            else 
            { 
            day1.Text += " (日)";
            }

            day2E.Text = Convert.ToDateTime(Form1.days[2].date).ToString("ddd");
            if (day2E.Text == "Mon")
            {
                day2.Text += " (月)";
            }
            else if (day2E.Text == "Tue")
            {
                day2.Text += " (火)";
            }
            else if (day2E.Text == "Wed")
            {
                day2.Text += " (水)";
            }
            else if (day2E.Text == "Thu")
            {
                day2.Text += " (木)";
            }
            else if (day2E.Text == "Fri")
            {
                day2.Text += " (金)";
            }
            else if (day2E.Text == "Sat")
            {
                day2.Text += " (土)";
            }
            else
            {
                day1.Text += " (日)";
            }

            day3E.Text = Convert.ToDateTime(Form1.days[3].date).ToString("ddd");
            if (day3E.Text == "Mon")
            {
                day3.Text += " (月)";
            }
            else if (day3E.Text == "Tue")
            {
                day3.Text += " (火)";
            }
            else if (day3E.Text == "Wed")
            {
                day3.Text += " (水)";
            }
            else if (day3E.Text == "Thu")
            {
                day3.Text += " (木)";
            }
            else if (day3E.Text == "Fri")
            {
                day3.Text += " (金)";
            }
            else if (day3E.Text == "Sat")
            {
                day3.Text += " (土)";
            }
            else
            {
                day3.Text += " (日)";
            }
            
            day4E.Text = Convert.ToDateTime(Form1.days[4].date).ToString("ddd");
            if (day4E.Text == "Mon")
            {
                day4.Text += " (月)";
            }
            else if (day4E.Text == "Tue")
            {
                day4.Text += " (火)";
            }
            else if (day4E.Text == "Wed")
            {
                day4.Text += " (水)";
            }
            else if (day4E.Text == "Thu")
            {
                day4.Text += " (木)";
            }
            else if (day4E.Text == "Fri")
            {
                day4.Text += " (金)";
            }
            else if (day4E.Text == "Sat")
            {
                day4.Text += " (土)";
            }
            else
            {
                day4.Text += " (日)";
            }
            
            day5E.Text = Convert.ToDateTime(Form1.days[5].date).ToString("ddd");
            if (day5E.Text == "Mon")
            {
                day5.Text += " (月)";
            }
            else if (day5E.Text == "Tue")
            {
                day5.Text += " (火)";
            }
            else if (day5E.Text == "Wed")
            {
                day5.Text += " (水)";
            }
            else if (day5E.Text == "Thu")
            {
                day5.Text += " (木)";
            }
            else if (day5E.Text == "Fri")
            {
                day5.Text += " (金)";
            }
            else if (day5E.Text == "Sat")
            {
                day5.Text += " (土)";
            }
            else
            {
                day5.Text += " (日)";
            }

            day6E.Text = Convert.ToDateTime(Form1.days[6].date).ToString("ddd");
            if (day6E.Text == "Mon")
            {
                day6.Text += " (月)";
            }
            else if (day6E.Text == "Tue")
            {
                day6.Text += " (火)";
            }
            else if (day6E.Text == "Wed")
            {
                day6.Text += " (水)";
            }
            else if (day6E.Text == "Thu")
            {
                day6.Text += " (木)";
            }
            else if (day6E.Text == "Fri")
            {
                day6.Text += " (金)";
            }
            else if (day6E.Text == "Sat")
            {
                day6.Text += " (土)";
            }
            else
            {
                day6.Text += " (日)";
            }           
        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
