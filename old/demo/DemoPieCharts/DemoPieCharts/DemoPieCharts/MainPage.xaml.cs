using System.Collections.Generic;
using Microcharts;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace DemoPieCharts
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
            {
                new Entry(10)
                {
                    Color = SkiaSharp.SKColor.Parse("#FF5733"),         //Orange
                    Label = "january",
                    ValueLabel = "200",
                },
            new Entry(20)
                {
                    Color = SkiaSharp.SKColor.Parse("#33FF6E"),         //Green
                    Label = "Feruary",
                    ValueLabel = "200",
            },
            new Entry(60)
                {
                    Color = SkiaSharp.SKColor.Parse("#339FFF"),         //Blue
                    Label = "March",
                    ValueLabel = "200",
                }
            };
        
        public MainPage()
        {
            InitializeComponent();

            //chart1.Chart = new RadialGaugeChart { Entries = entries };
            //chart1.Chart = new BarChart { Entries = entries };
            //chart1.Chart = new LineChart { Entries = entries };
            //chart1.Chart = new RadarChart { Entries = entries };
            chart1.Chart = new PointChart { Entries = entries };

           // initPieChart();
        }

        //protected void initPieChart()
        //{
        //    chart1.Chart = new 
        //}
    }
}
