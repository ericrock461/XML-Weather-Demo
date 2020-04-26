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
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

            // make the backdrop the parent of all labels and pictureBoxes
            todayLabel.Parent = backdrop;
            forecastLabel.Parent = backdrop;
            label5.Parent = backdrop;
            dateLabel.Parent = backdrop;

            cityOutput.Parent = backdrop;
            tempLabel.Parent = backdrop;          
            weatherIconBox.Parent = backdrop;
            minOutput.Parent = backdrop;
            maxOutput.Parent = backdrop;
            humidLabel.Parent = backdrop;
            conditionLabel.Parent = backdrop;
            obligatoryJapaneseLabel.Parent = backdrop;
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            dateLabel.Text = Form1.days[0].date;
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow + "°";
            maxOutput.Text = Form1.days[0].tempHigh + "°";
            humidLabel.Text = "Humidity: " + Form1.days[0].humidity + "%";
            conditionLabel.Text = Form1.days[0].condition;

            // change the background image based on current weather conditions
            // capitalize the first letter of each word of weather conditions, to look more pleasant
            if (conditionLabel.Text == "clear sky") 
            {
                conditionLabel.Text = "Clear";
                backdrop.BackgroundImage = Properties.Resources.Clear;
            }
            else if (conditionLabel.Text == "few clouds") 
            {
                conditionLabel.Text = "Few Clouds";
                backdrop.BackgroundImage = Properties.Resources.few_clouds;
            }
            else if (conditionLabel.Text == "broken clouds")
            {
                conditionLabel.Text = "Broken Clouds";
                backdrop.BackgroundImage = Properties.Resources.broken_clouds;
            }
            else if (conditionLabel.Text == "overcast clouds")
            {
                conditionLabel.Text = "Overcast Clouds";
                backdrop.BackgroundImage = Properties.Resources.Overcast;
            }
            else if (conditionLabel.Text == "scattered clouds")
            {
                conditionLabel.Text = "Scattered Clouds";
                backdrop.BackgroundImage = Properties.Resources.Scatter_Clouds;
            }
            else if (conditionLabel.Text == "haze")
            {
                conditionLabel.Text = "Haze";
                backdrop.BackgroundImage = Properties.Resources.haze;
            }
            else if (conditionLabel.Text == "light rain" || conditionLabel.Text == "light intensity shower rain")
            {
                conditionLabel.Text = "Light Rain";
                backdrop.BackgroundImage = Properties.Resources.Rainy_Day;
            }
            else if (conditionLabel.Text == "moderate rain")
            {
                conditionLabel.Text = "Moderate Rain";
                backdrop.BackgroundImage = Properties.Resources.Rain3;
            }
            else if (conditionLabel.Text == "thunderstorm")
            {
                conditionLabel.Text = "Thunderstorm";
                backdrop.BackgroundImage = Properties.Resources.stormy;
            }
            else if (conditionLabel.Text == "light snow")
            {
                conditionLabel.Text = "Light Snow";
                backdrop.BackgroundImage = Properties.Resources.snowy;
            }
            else 
            {
                backdrop.BackgroundImage = null;
            }


            // change weather icon based on current weather conditions
            if (conditionLabel.Text == "Clear") 
            {
                weatherIconBox.BackgroundImage = Properties.Resources.sun_icon;
            }
            else if (conditionLabel.Text == "Overcast Clouds")
            {
                weatherIconBox.BackgroundImage = Properties.Resources.cloud_2;
            }
            else if (conditionLabel.Text == "Light Rain" || conditionLabel.Text == "Moderate Rain") 
            {
                weatherIconBox.BackgroundImage = Properties.Resources.rain_icon;
            }
            else if (conditionLabel.Text == "Thunderstorm")
            {
                weatherIconBox.BackgroundImage = Properties.Resources.thunder_icon;
            }
            else if (conditionLabel.Text == "Light Snow" || conditionLabel.Text == "Heavy Snow")
            {
                weatherIconBox.BackgroundImage = Properties.Resources.snow_icon;
            }
            else
            {
                weatherIconBox.BackgroundImage = Properties.Resources.partyCloudy2;
            }
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
