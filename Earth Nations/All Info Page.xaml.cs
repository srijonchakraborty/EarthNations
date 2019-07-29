using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Earth_Nations
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class All_Info_Page : Page
    {
        public All_Info_Page()
        {
            this.InitializeComponent();
            voice.Play();
            //voice.
            SoundAnimation.Begin();
            voice.MediaEnded += NextPage;

        }

        private void NextPage(object sender, object e)
        {
            //throw new NotImplementedException();
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
