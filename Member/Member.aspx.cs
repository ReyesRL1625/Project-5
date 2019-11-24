using Project_5_Web_App.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Project_5_Web_App
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_weather(object sender, EventArgs e)
        {
            Service1Client objW = new Service1Client();
            Service1WeatherObject[] weather;

            int tempZip = Convert.ToInt32(TextBox1.Text);

            if (tempZip.ToString().Length == 5)
            {
                weather = objW.Weather5Day(tempZip);
                for (int i = 0; i < 5; i++)
                {
                    var tmp = new HtmlTableCell();
                    tmp.ID = "TH_" + weather[i].temp;
                    tmp.InnerText = "Current temp: " + weather[i].temp.ToString() + "\t     Humidity: " + weather[i].humidity.ToString() + "\t     Description: " + weather[i].description.ToString();
                    switch (i)
                    {
                        case 0:
                            tmp.InnerText = "Today's weather - " + tmp.InnerText;
                            row0.Cells.Add(tmp);
                            break;
                        case 1:
                            tmp.InnerText = "Tomorrow's weather - " + tmp.InnerText;
                            row1.Cells.Add(tmp);
                            break;
                        case 2:
                            tmp.InnerText = "Two days from now - " + tmp.InnerText;
                            row2.Cells.Add(tmp);
                            break;
                        case 3:
                            tmp.InnerText = "Three days from now - " + tmp.InnerText;
                            row3.Cells.Add(tmp);
                            break;
                        case 4:
                            tmp.InnerText = "Four days from now - " + tmp.InnerText;
                            row4.Cells.Add(tmp);
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        protected void btn_weather_compare(object sender, EventArgs e)
        {
            Service1Client objW = new Service1Client();
            Service1WeatherObject[] weather1, weather2, bestWeather;
            int bestZip;

            int zip1 = Convert.ToInt32(TextBox2.Text);
            int zip2 = Convert.ToInt32(TextBox3.Text);

            weather1 = objW.Weather5Day(zip1);
            weather2 = objW.Weather5Day(zip2);

            bestWeather = compareWeather(weather1, weather2);

            if (weather1.Equals(bestWeather))
            {
                bestZip = zip1;
            }
            else
            {
                bestZip = zip2;
            }

            var tmp0 = new HtmlTableCell();
            tmp0.InnerText = "The better weather can be found at " + bestZip;
            row0.Cells.Add(tmp0);

            var tmp1 = new HtmlTableCell();
            tmp1.InnerText = "This is based on a variety of factors, such as extreme temperatures, humidity, and weather conditions";
            row1.Cells.Add(tmp1);

            var tmp2 = new HtmlTableCell();
            tmp2.InnerText = "The weather for " + bestZip + " is " + weather1[0].description.ToString();
            row2.Cells.Add(tmp2);

            var tmp3 = new HtmlTableCell();
            tmp3.InnerText = "The current temperature is " + bestWeather[0].temp.ToString() + " degrees Fahrenheit";
            row3.Cells.Add(tmp3);
        }

        public Service1WeatherObject[] compareWeather(Service1WeatherObject[] weather1, Service1WeatherObject[] weather2)
        {
            int weatherComp = 0;

            for (int i = 0; i < 5; i++)
            {
                if (weather1[i].temp_max < 85)
                {
                    weatherComp++;
                }
                if (weather2[i].temp_max < 85)
                {
                    weatherComp--;
                }

                if (weather1[i].temp_min > 50)
                {
                    weatherComp++;
                }
                if (weather2[i].temp_min > 50)
                {
                    weatherComp--;
                }

                if (weather1[i].humidity < 90)
                {
                    weatherComp++;
                }
                if (weather2[i].humidity < 90)
                {
                    weatherComp--;
                }
            }

            if (weatherComp > 0)
            {
                return weather1;
            }
            else
            {
                return weather2;
            }
        }
    }
}