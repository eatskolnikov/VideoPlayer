using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.MediaManager;
using Xamarin.Forms;

namespace VideoPlayer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text=="Play")
            {
                CrossMediaManager.Current.Play("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);
                btn.Text = "Stop";
            }
            else if (btn.Text == "Stop")
            {
                CrossMediaManager.Current.Stop();
                btn.Text = "Play";                                                   
            }
        }
    }
}
