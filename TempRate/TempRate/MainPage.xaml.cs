using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TempRate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            FindTempRatebtn.Clicked += FindTempRatebtn_Clicked;

            Title = "Enter Data Here";
        }

        private void FindTempRatebtn_Clicked(object sender, EventArgs e)
        {
            var timeStart = Convert.ToDateTime(srtTime);
            var tempStart = int.Parse(srtTemp.Text);

            var timeEnd = Convert.ToString(endTime).Split(' ')[0];
            var tempEnd = int.Parse(endTemp.Text);

            int result = Core.CalculateRate(timeStart, tempStart, timeEnd, tempEnd);

            if((tempStart > 70 && result >= .542) || (tempStart < 70 && result >= .121))
            {
                DisplayAlert("Success", $"the rate of change is {result} deg/min amd passes", "OK");
            }
            else
            {
                DisplayAlert("Failure", $"The rate of change is {result} deg/min and fails", "OK");
            }
        }
    }
}
