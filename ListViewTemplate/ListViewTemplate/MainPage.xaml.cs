using ListViewTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewTemplate
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private SampleViewModel sampleViewModel = new SampleViewModel();
        public MainPage()
        {
            InitializeComponent();

            sampleViewModel.SampleItems.Add(new Models.SampleItem
            {
                MainImageURL = "city1.jpg",
                SubText = "Coordinates: 29°33′30″N 106°34′00″",
                Description = "Chongqing is a major city in southwest China",
                Name = "Chongqing, China",
            });

            sampleViewModel.SampleItems.Add(new Models.SampleItem
            {
                MainImageURL = "city2.jpg",
                SubText = "Coordinates: 31°13′43″N 121°28′29″",
                Description = "Shanghai is one of the four municipalities of the People's Republic of China",
                Name = "Shanghai, China",
            });

            sampleViewModel.SampleItems.Add(new Models.SampleItem
            {
                MainImageURL = "city3.jpg",
                SubText = "Coordinates: 39°55′N 116°23′",
                Description = "Beijing, alternately romanized as Peking, is the capital of the People's Republic of China",
                Name = "Beijing, China",
            });
             
            sampleViewModel.SampleItems.Add(new Models.SampleItem
            {
                MainImageURL = "city4.jpg",
                SubText = "Coordinates: 41°00′49″N 28°57′18″",
                Description = "Istanbul, formerly known as Byzantium and Constantinople, is the most populous city in Turkey and the country's economic, cultural and historic center. ",
                Name = "Istanbul, Turkey",
            });

            sampleViewModel.SampleItems.Add(new Models.SampleItem
            {
                MainImageURL = "city5.jpg",
                SubText = "Coordinates: 24°51′36″N 67°0′36″",
                Description = "Karachi is the capital of the Pakistani province of Sindh. It is the most populous city in Pakistan,[12][13] and fifth-most-populous city proper in the world.",
                Name = "Karachi, Pakistan",
            });

            this.BindingContext = sampleViewModel;

        }

    }
}
