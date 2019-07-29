using Bing.Maps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Earth_Nations
{
    ///  System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:REVIEW?PFN=39201srijonchak.EarthNations"));
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        bool mutuflag = false;
        SolidColorBrush blueBrush = new SolidColorBrush(Windows.UI.Colors.Azure);
        SolidColorBrush blackBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        private static Thickness myPositionSetter = new Thickness(0, 0, 0, 0);
        private static Point p;
        public MainPage()
        {
           
            this.InitializeComponent();
            NInfo.Text = "Please Select a Nation";
            MyMap.ZoomLevel = 0;
            MuteRec.Opacity = 0;        
            NameOfNation.Text="Nations Flag";
            earthanimation.Begin();
           
            SoundAnimation.Begin();
			
           
			flagUp.Begin();
            AnthemPlayer.Volume = VolumeControl.Value;
            SoundBar.Play();
           
          
        }

        private void srijon_Completed(object sender, object e)
        {
           
        }

        

        private void ellipse_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
        	
        }

        private void Earth_video_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
        }

        private void Abkhazia_event(object sender, TappedRoutedEventArgs e)
        {

            var textbox = (TextBlock)sender;
            //textbox = blueBrush;
            try 
            { 
                AnthemPlayer.Stop(); 
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere) 
            { 
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AbkhaziaAnthem;
            NInfo.Text = InfoNations.Abkhazia;
            AnthemPlayer.Play();
            
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AbkhaziaFlag;
            NameOfNation.Text = "Abkhazia";
            MyMap.Center = NationCoordinates.AbkhaziaLocation;
            MyMap.ZoomLevel = NationCoordinates.AbkhaziaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AbkhaziaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
            //textbox.Background = blackBrush;
            //
            //MyMap.ZoomLevel = NationCoordinates.AustraliaZoomLevel;
            //MyMap.Center = NationCoordinates.AustraliaLocation;
            //MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AustraliaLocation);
            //MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Afghanistan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AfghanistanAnthem;
            NInfo.Text = InfoNations.Afghanistan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AfghanistanFlag;
            NameOfNation.Text = "Afghanistan";
            MyMap.Center = NationCoordinates.AfghanistanLocation;
            MyMap.ZoomLevel = NationCoordinates.AfghanistanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AfghanistanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Albania_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AlbaniaAnthem;
            NInfo.Text = InfoNations.Albania;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AlbaniaFlag;
            NameOfNation.Text = "Albania";
            MyMap.Center = NationCoordinates.AlbaniaLocation;
            MyMap.ZoomLevel = NationCoordinates.AlbaniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AlbaniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Algeria_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AlgeriaAnthem;
            NInfo.Text = InfoNations.Algeria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AlgeriaFlag;
            NameOfNation.Text = "Algeria";
            MyMap.Center = NationCoordinates.AlgeriaLocation;
            MyMap.ZoomLevel = NationCoordinates.AlgeriaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AlgeriaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Andorra_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AndorraAnthem;
            NInfo.Text = InfoNations.Andorra;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AndorraFlag;
            NameOfNation.Text = "Andorra";
            MyMap.Center = NationCoordinates.AndorraLocation;
            MyMap.ZoomLevel = NationCoordinates.AndorraZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AndorraLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Angola_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AngolaAnthem;
            NInfo.Text = InfoNations.Angola;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AngolaFlag;
            NameOfNation.Text = "Angola";
            MyMap.Center = NationCoordinates.AngolaLocation;
            MyMap.ZoomLevel = NationCoordinates.AngolaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AngolaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Antigua_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AntiguaAnthem;
            NInfo.Text = InfoNations.Antigua;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AntiguaFlag;
            NameOfNation.Text = "Antigua";
            MyMap.Center = NationCoordinates.AntiguaLocation;
            MyMap.ZoomLevel = NationCoordinates.AntiguaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AntiguaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Argentina_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ArgentinaAnthem;
            NInfo.Text = InfoNations.Argentina;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ArgentinaFlag;
            NameOfNation.Text = "Argentina";
            MyMap.Center = NationCoordinates.ArgentinaLocation;
            MyMap.ZoomLevel = NationCoordinates.ArgentinaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ArgentinaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Armenia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ArmeniaAnthem;
            NInfo.Text = InfoNations.Armenia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ArmeniaFlag;
            NameOfNation.Text = "Armenia";
            MyMap.Center = NationCoordinates.ArmeniaLocation;
            MyMap.ZoomLevel = NationCoordinates.ArmeniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ArmeniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void ARUBA_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ARUBAAnthem;
            NInfo.Text = InfoNations.ARUBA;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ARUBAFlag;
            NameOfNation.Text = "Aruba";
            MyMap.Center = NationCoordinates.ARUBALocation;
            MyMap.ZoomLevel = NationCoordinates.ARUBAZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ARUBALocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Austria_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AustriaAnthem;
            NInfo.Text = InfoNations.Austria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AustriaFlag;
            NameOfNation.Text = "Austria";
            MyMap.Center = NationCoordinates.AustriaLocation;
            MyMap.ZoomLevel = NationCoordinates.AustriaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AustriaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Australia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AustraliaAnthem;
            NInfo.Text = InfoNations.Australia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AustraliaFlag;
            NameOfNation.Text = "Australia";
            MyMap.Center = NationCoordinates.AustraliaLocation;
            MyMap.ZoomLevel = NationCoordinates.AustraliaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AustraliaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Azerbaijan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.AzerbaijanAnthem;
            NInfo.Text = InfoNations.Azerbaijan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.AzerbaijanFlag;
            NameOfNation.Text = "Azerbaijan";
            MyMap.Center = NationCoordinates.AzerbaijanLocation;
            MyMap.ZoomLevel = NationCoordinates.AzerbaijanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.AzerbaijanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bahamas_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BahamasAnthem;
            NInfo.Text = InfoNations.Bahamas;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BahamasFlag;
            NameOfNation.Text = "Bahamas";
            MyMap.Center = NationCoordinates.BahamasLocation;
            MyMap.ZoomLevel = NationCoordinates.BahamasZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BahamasLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bahrain_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BahrainAnthem;
            NInfo.Text = InfoNations.Bahrain;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BahrainFlag;
            NameOfNation.Text = "Bahrain";
            MyMap.Center = NationCoordinates.BahrainLocation;
            MyMap.ZoomLevel = NationCoordinates.BahrainZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BahrainLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bangladesh_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BangladeshAnthem;
            NInfo.Text = InfoNations.Bangladesh;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BangladeshFlag;
            NameOfNation.Text = "Bangladesh";
            MyMap.Center = NationCoordinates.BangladeshLocation;
            MyMap.ZoomLevel = NationCoordinates.BangladeshZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BangladeshLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Barbados_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BarbadosAnthem;
            NInfo.Text = InfoNations.Barbados;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BarbadosFlag;
            NameOfNation.Text = "Barbados";
            MyMap.Center = NationCoordinates.BarbadosLocation;
            MyMap.ZoomLevel = NationCoordinates.BarbadosZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BarbadosLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Belarus_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BelarusAnthem;
            NInfo.Text = InfoNations.Belarus;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BelarusFlag;
            NameOfNation.Text = "Belarus";
            MyMap.Center = NationCoordinates.BelarusLocation;
            MyMap.ZoomLevel = NationCoordinates.BelarusZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BelarusLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Belgium_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BelgiumAnthem;
            NInfo.Text = InfoNations.Belgium;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BelgiumFlag;
            NameOfNation.Text = "Belgium";
            MyMap.Center = NationCoordinates.BelgiumLocation;
            MyMap.ZoomLevel = NationCoordinates.BelgiumZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BelgiumLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Belize_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BelizeAnthem;
            NInfo.Text = InfoNations.Belize;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BelizeFlag;
            NameOfNation.Text = "Belize";
            MyMap.Center = NationCoordinates.BelizeLocation;
            MyMap.ZoomLevel = NationCoordinates.BelizeZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BelizeLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Benin_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BeninAnthem;
            NInfo.Text = InfoNations.Benin;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BeninFlag;
            NameOfNation.Text = "Benin";
            MyMap.Center = NationCoordinates.BeninLocation;
            MyMap.ZoomLevel = NationCoordinates.BeninZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BeninLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bermuda_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BermudaAnthem;
            NInfo.Text = InfoNations.Bermuda;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BermudaFlag;
            NameOfNation.Text = "Bermuda";
            MyMap.Center = NationCoordinates.BermudaLocation;
            MyMap.ZoomLevel = NationCoordinates.BermudaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BermudaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bhutan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BhutanAnthem;
            NInfo.Text = InfoNations.Bhutan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BhutanFlag;
            NameOfNation.Text = "Bhutan";
            MyMap.Center = NationCoordinates.BhutanLocation;
            MyMap.ZoomLevel = NationCoordinates.BhutanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BhutanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bolivia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BoliviaAnthem;
            NInfo.Text = InfoNations.Bolivia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BoliviaFlag;
            NameOfNation.Text = "Bolivia";
            MyMap.Center = NationCoordinates.BoliviaLocation;
            MyMap.ZoomLevel = NationCoordinates.BoliviaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BoliviaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bosnia_and_Herzegovina_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Bosnia_and_HerzegovinaAnthem;
            NInfo.Text = InfoNations.Bosnia_and_Herzegovina;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Bosnia_and_HerzegovinaFlag;
            NameOfNation.Text = "Bosnia and Herzegovina";
            MyMap.Center = NationCoordinates.Bosnia_and_HerzegovinaLocation;
            MyMap.ZoomLevel = NationCoordinates.Bosnia_and_HerzegovinaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Bosnia_and_HerzegovinaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Botswana_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BotswanaAnthem;
            NInfo.Text = InfoNations.Botswana;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BotswanaFlag;
            NameOfNation.Text = "Botswana";
            MyMap.Center = NationCoordinates.BotswanaLocation;
            MyMap.ZoomLevel = NationCoordinates.BotswanaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BotswanaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Brazil_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BrazilAnthem;
            NInfo.Text = InfoNations.Brazil;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BrazilFlag;
            NameOfNation.Text = "Brazil";
            MyMap.Center = NationCoordinates.BrazilLocation;
            MyMap.ZoomLevel = NationCoordinates.BrazilZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BrazilLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Brunei_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BruneiAnthem;
            NInfo.Text = InfoNations.Brunei;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BruneiFlag;
            NameOfNation.Text = "Brunei";
            MyMap.Center = NationCoordinates.BruneiLocation;
            MyMap.ZoomLevel = NationCoordinates.BruneiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BruneiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Bulgaria_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BulgariaAnthem;
            NInfo.Text = InfoNations.Bulgaria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BulgariaFlag;
            NameOfNation.Text = "Bulgaria";
            MyMap.Center = NationCoordinates.BulgariaLocation;
            MyMap.ZoomLevel = NationCoordinates.BulgariaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BulgariaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Burkina_Faso_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Burkina_FasoAnthem;
            NInfo.Text = InfoNations.Burkina_Faso;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Burkina_FasoFlag;
            NameOfNation.Text = "Burkina Faso";
            MyMap.Center = NationCoordinates.Burkina_FasoLocation;
            MyMap.ZoomLevel = NationCoordinates.Burkina_FasoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Burkina_FasoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Cambodia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CambodiaAnthem;
            NInfo.Text = InfoNations.Cambodia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CambodiaFlag;
            NameOfNation.Text = "Cambodia";
            MyMap.Center = NationCoordinates.CambodiaLocation;
            MyMap.ZoomLevel = NationCoordinates.CambodiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CambodiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Cameroon_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CameroonAnthem;
            NInfo.Text = InfoNations.Cameroon;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CameroonFlag;
            NameOfNation.Text = "Cameroon";
            MyMap.Center = NationCoordinates.CameroonLocation;
            MyMap.ZoomLevel = NationCoordinates.CameroonZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CameroonLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Canada_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CanadaAnthem;
            NInfo.Text = InfoNations.Canada;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CanadaFlag;
            NameOfNation.Text = "Canada";
            MyMap.Center = NationCoordinates.CanadaLocation;
            MyMap.ZoomLevel = NationCoordinates.CanadaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CanadaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Cape_Verde_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Cape_VerdeAnthem;
            NInfo.Text = InfoNations.Cape_Verde;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Cape_VerdeFlag;
            NameOfNation.Text = "Cape Verde";
            MyMap.Center = NationCoordinates.Cape_VerdeLocation;
            MyMap.ZoomLevel = NationCoordinates.Cape_VerdeZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Cape_VerdeLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Central_African_Republic_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Central_African_RepublicAnthem;
            NInfo.Text = InfoNations.Central_African_Republic;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Central_African_RepublicFlag;
            NameOfNation.Text = "Central African Republic";
            MyMap.Center = NationCoordinates.Central_African_RepublicLocation;
            MyMap.ZoomLevel = NationCoordinates.Central_African_RepublicZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Central_African_RepublicLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Chad_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ChadAnthem;
            NInfo.Text = InfoNations.Chad;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ChadFlag;
            NameOfNation.Text = "Chad";
            MyMap.Center = NationCoordinates.ChadLocation;
            MyMap.ZoomLevel = NationCoordinates.ChadZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ChadLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Burundi_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.BurundiAnthem;
            NInfo.Text = InfoNations.Burundi;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.BurundiFlag;
            NameOfNation.Text = "Burundi";
            MyMap.Center = NationCoordinates.BurundiLocation;
            MyMap.ZoomLevel = NationCoordinates.BurundiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.BurundiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Chile_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ChileAnthem;
            NInfo.Text = InfoNations.Chile;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ChileFlag;
            NameOfNation.Text = "Chile";
            MyMap.Center = NationCoordinates.ChileLocation;
            MyMap.ZoomLevel = NationCoordinates.ChileZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ChileLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Colombia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ColombiaAnthem;
            NInfo.Text = InfoNations.Colombia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ColombiaFlag;
            NameOfNation.Text = "Colombia";
            MyMap.Center = NationCoordinates.ColombiaLocation;
            MyMap.ZoomLevel = NationCoordinates.ColombiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ColombiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Comoros_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ComorosAnthem;
            NInfo.Text = InfoNations.Comoros;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ComorosFlag;
            NameOfNation.Text = "Comoros";
            MyMap.Center = NationCoordinates.ComorosLocation;
            MyMap.ZoomLevel = NationCoordinates.ComorosZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ComorosLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Congo_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CongoAnthem;
            NInfo.Text = InfoNations.Congo;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CongoFlag;
            NameOfNation.Text = "Congo";
            MyMap.Center = NationCoordinates.CongoLocation;
            MyMap.ZoomLevel = NationCoordinates.CongoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CongoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Costa_Rica_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Costa_RicaAnthem;
            NInfo.Text = InfoNations.Costa_Rica;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Costa_RicaFlag;
            NameOfNation.Text = "Costa Rica";
            MyMap.Center = NationCoordinates.Costa_RicaLocation;
            MyMap.ZoomLevel = NationCoordinates.Costa_RicaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Costa_RicaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void China_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ChinaAnthem;
            NInfo.Text = InfoNations.China;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ChinaFlag;
            NameOfNation.Text = "China";
            MyMap.Center = NationCoordinates.ChinaLocation;
            MyMap.ZoomLevel = NationCoordinates.ChinaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ChinaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Côte_d_Ivoire_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Côte_d_IvoireAnthem;
            NInfo.Text = InfoNations.Côte_d_Ivoire;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Côte_d_IvoireFlag;
            NameOfNation.Text = "Côte_d'Ivoire";
            MyMap.Center = NationCoordinates.Côte_d_IvoireLocation;
            MyMap.ZoomLevel = NationCoordinates.Côte_d_IvoireZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Côte_d_IvoireLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Croatia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CroatiaAnthem;
            NInfo.Text = InfoNations.Croatia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CroatiaFlag;
            NameOfNation.Text = "Croatia";
            MyMap.Center = NationCoordinates.CroatiaLocation;
            MyMap.ZoomLevel = NationCoordinates.CroatiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CroatiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Cuba_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CubaAnthem;
            NInfo.Text = InfoNations.Cuba;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CubaFlag;
            NameOfNation.Text = "Cuba";
            MyMap.Center = NationCoordinates.CubaLocation;
            MyMap.ZoomLevel = NationCoordinates.CubaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CubaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Cyprus_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.CyprusAnthem;
            NInfo.Text = InfoNations.Cyprus;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.CyprusFlag;
            NameOfNation.Text = "Cyprus";
            MyMap.Center = NationCoordinates.CyprusLocation;
            MyMap.ZoomLevel = NationCoordinates.CyprusZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.CyprusLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Czech_Republic_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Czech_RepublicAnthem;
            NInfo.Text = InfoNations.Czech_Republic;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Czech_RepublicFlag;
            NameOfNation.Text = "Czech Republic";
            MyMap.Center = NationCoordinates.Czech_RepublicLocation;
            MyMap.ZoomLevel = NationCoordinates.Czech_RepublicZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Czech_RepublicLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Denmark_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.DenmarkAnthem;
            NInfo.Text = InfoNations.Denmark;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.DenmarkFlag;
            NameOfNation.Text = "Denmark";
            MyMap.Center = NationCoordinates.DenmarkLocation;
            MyMap.ZoomLevel = NationCoordinates.DenmarkZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.DenmarkLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Djibouti_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.DjiboutiAnthem;
            NInfo.Text = InfoNations.Djibouti;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.DjiboutiFlag;
            NameOfNation.Text = "Djibouti";
            MyMap.Center = NationCoordinates.DjiboutiLocation;
            MyMap.ZoomLevel = NationCoordinates.DjiboutiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.DjiboutiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Dominica_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.DominicaAnthem;
            NInfo.Text = InfoNations.Dominica;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.DominicaFlag;
            NameOfNation.Text = "Dominica";
            MyMap.Center = NationCoordinates.DominicaLocation;
            MyMap.ZoomLevel = NationCoordinates.DominicaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.DominicaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Dominican_Republic_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Dominican_RepublicAnthem;
            NInfo.Text = InfoNations.Dominican_Republic;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Dominican_RepublicFlag;
            NameOfNation.Text = "Dominican Republic";
            MyMap.Center = NationCoordinates.Dominican_RepublicLocation;
            MyMap.ZoomLevel = NationCoordinates.Dominican_RepublicZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Dominican_RepublicLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void East_Timor_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.East_TimorAnthem;
            NInfo.Text = InfoNations.East_Timor;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.East_TimorFlag;
            NameOfNation.Text = "East Timor";
            MyMap.Center = NationCoordinates.East_TimorLocation;
            MyMap.ZoomLevel = NationCoordinates.East_TimorZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.East_TimorLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Ecuador_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.EcuadorAnthem;
            NInfo.Text = InfoNations.Ecuador;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.EcuadorFlag;
            NameOfNation.Text = "Ecuador";
            MyMap.Center = NationCoordinates.EcuadorLocation;
            MyMap.ZoomLevel = NationCoordinates.EcuadorZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.EcuadorLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Egypt_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.EgyptAnthem;
            NInfo.Text = InfoNations.Egypt;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.EgyptFlag;
            NameOfNation.Text = "Egypt";
            MyMap.Center = NationCoordinates.EgyptLocation;
            MyMap.ZoomLevel = NationCoordinates.EgyptZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.EgyptLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void El_Salvador_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.El_SalvadorAnthem;
            NInfo.Text = InfoNations.El_Salvador;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.El_SalvadorFlag;
            NameOfNation.Text = "El Salvador";
            MyMap.Center = NationCoordinates.El_SalvadorLocation;
            MyMap.ZoomLevel = NationCoordinates.El_SalvadorZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.El_SalvadorLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Equatorial_Guinea_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Equatorial_GuineaAnthem;
            NInfo.Text = InfoNations.Equatorial_Guinea;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Equatorial_GuineaFlag;
            NameOfNation.Text = "Equatorial Guinea";
            MyMap.Center = NationCoordinates.Equatorial_GuineaLocation;
            MyMap.ZoomLevel = NationCoordinates.Equatorial_GuineaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Equatorial_GuineaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Eritrea_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.EritreaAnthem;
            NInfo.Text = InfoNations.Eritrea;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.EritreaFlag;
            NameOfNation.Text = "Eritrea";
            MyMap.Center = NationCoordinates.EritreaLocation;
            MyMap.ZoomLevel = NationCoordinates.EritreaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.EritreaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Estonia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.EstoniaAnthem;
            NInfo.Text = InfoNations.Estonia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.EstoniaFlag;
            NameOfNation.Text = "Estonia";
            MyMap.Center = NationCoordinates.EstoniaLocation;
            MyMap.ZoomLevel = NationCoordinates.EstoniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.EstoniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Ethiopia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.EthiopiaAnthem;
            NInfo.Text = InfoNations.Ethiopia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.EthiopiaFlag;
            NameOfNation.Text = "Ethiopia";
            MyMap.Center = NationCoordinates.EthiopiaLocation;
            MyMap.ZoomLevel = NationCoordinates.EthiopiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.EthiopiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Federated_States_of_Micronesia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Federated_States_of_MicronesiaAnthem;
            NInfo.Text = InfoNations.Federated_States_of_Micronesia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Federated_States_of_MicronesiaFlag;
            NameOfNation.Text = "Federated States of Micronesia";
            MyMap.Center = NationCoordinates.Federated_States_of_MicronesiaLocation;
            MyMap.ZoomLevel = NationCoordinates.Federated_States_of_MicronesiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Federated_States_of_MicronesiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Finland_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.FinlandAnthem;
            NInfo.Text = InfoNations.Finland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.FinlandFlag;
            NameOfNation.Text = "Finland";
            MyMap.Center = NationCoordinates.FinlandLocation;
            MyMap.ZoomLevel = NationCoordinates.FinlandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.FinlandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Fiji_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.FijiAnthem;
            NInfo.Text = InfoNations.Fiji;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.FijiFlag;
            NameOfNation.Text = "Fiji";
            MyMap.Center = NationCoordinates.FijiLocation;
            MyMap.ZoomLevel = NationCoordinates.FijiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.FijiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void France_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.FranceAnthem;
            NInfo.Text = InfoNations.France;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.FranceFlag;
            NameOfNation.Text = "France";
            MyMap.Center = NationCoordinates.FranceLocation;
            MyMap.ZoomLevel = NationCoordinates.FranceZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.FranceLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Gabon_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GabonAnthem;
            NInfo.Text = InfoNations.Gabon;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GabonFlag;
            NameOfNation.Text = "Gabon";
            MyMap.Center = NationCoordinates.GabonLocation;
            MyMap.ZoomLevel = NationCoordinates.GabonZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GabonLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Gambia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GambiaAnthem;
            NInfo.Text = InfoNations.Gambia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GambiaFlag;
            NameOfNation.Text = "Gambia";
            MyMap.Center = NationCoordinates.GambiaLocation;
            MyMap.ZoomLevel = NationCoordinates.GambiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GambiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Georgia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GeorgiaAnthem;
            NInfo.Text = InfoNations.Georgia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GeorgiaFlag;
            NameOfNation.Text = "Georgia";
            MyMap.Center = NationCoordinates.GeorgiaLocation;
            MyMap.ZoomLevel = NationCoordinates.GeorgiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GeorgiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Germany_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GermanyAnthem;
            NInfo.Text = InfoNations.Germany;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GermanyFlag;
            NameOfNation.Text = "Germany";
            MyMap.Center = NationCoordinates.GermanyLocation;
            MyMap.ZoomLevel = NationCoordinates.GermanyZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GermanyLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Ghana_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GhanaAnthem;
            NInfo.Text = InfoNations.Ghana;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GhanaFlag;
            NameOfNation.Text = "Ghana";
            MyMap.Center = NationCoordinates.GhanaLocation;
            MyMap.ZoomLevel = NationCoordinates.GhanaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GhanaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Greece_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GreeceAnthem;
            NInfo.Text = InfoNations.Greece;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GreeceFlag;
            NameOfNation.Text = "Greece";
            MyMap.Center = NationCoordinates.GreeceLocation;
            MyMap.ZoomLevel = NationCoordinates.GreeceZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GreeceLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Grenada_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GrenadaAnthem;
            NInfo.Text = InfoNations.Grenada;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GrenadaFlag;
            NameOfNation.Text = "Grenada";
            MyMap.Center = NationCoordinates.GrenadaLocation;
            MyMap.ZoomLevel = NationCoordinates.GrenadaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GrenadaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Guatemala_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GuatemalaAnthem;
            NInfo.Text = InfoNations.Guatemala;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GuatemalaFlag;
            NameOfNation.Text = "Guatemala";
            MyMap.Center = NationCoordinates.GuatemalaLocation;
            MyMap.ZoomLevel = NationCoordinates.GuatemalaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GuatemalaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Guinea_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GuineaAnthem;
            NInfo.Text = InfoNations.Guinea;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GuineaFlag;
            NameOfNation.Text = "Guinea";
            MyMap.Center = NationCoordinates.GuineaLocation;
            MyMap.ZoomLevel = NationCoordinates.GuineaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GuineaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Guinea_Bissau_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Guinea_BissauAnthem;
            NInfo.Text = InfoNations.Guinea_Bissau;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Guinea_BissauFlag;
            NameOfNation.Text = "Guinea Bissau";
            MyMap.Center = NationCoordinates.Guinea_BissauLocation;
            MyMap.ZoomLevel = NationCoordinates.Guinea_BissauZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Guinea_BissauLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Guyana_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.GuyanaAnthem;
            NInfo.Text = InfoNations.Guyana;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.GuyanaFlag;
            NameOfNation.Text = "Guyana";
            MyMap.Center = NationCoordinates.GuyanaLocation;
            MyMap.ZoomLevel = NationCoordinates.GuyanaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.GuyanaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Haiti_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.HaitiAnthem;
            NInfo.Text = InfoNations.Haiti;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.HaitiFlag;
            NameOfNation.Text = "Haiti";
            MyMap.Center = NationCoordinates.HaitiLocation;
            MyMap.ZoomLevel = NationCoordinates.HaitiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.HaitiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Honduras_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.HondurasAnthem;
            NInfo.Text = InfoNations.Honduras;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.HondurasFlag;
            NameOfNation.Text = "Honduras";
            MyMap.Center = NationCoordinates.HondurasLocation;
            MyMap.ZoomLevel = NationCoordinates.HondurasZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.HondurasLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }
        private void Hungary_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.HungaryAnthem;
            NInfo.Text = InfoNations.Hungary;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.HungaryFlag;
            NameOfNation.Text = " Hungary";
            MyMap.Center = NationCoordinates.HungaryLocation;
            MyMap.ZoomLevel = NationCoordinates.HungaryZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.HungaryLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Iceland_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IcelandAnthem;
            NInfo.Text = InfoNations.Iceland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IcelandFlag;
            NameOfNation.Text = " Iceland";
            MyMap.Center = NationCoordinates.IcelandLocation;
            MyMap.ZoomLevel = NationCoordinates.IcelandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IcelandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void India_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IndiaAnthem;
            NInfo.Text = InfoNations.India;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IndiaFlag;
            NameOfNation.Text = " India";
            MyMap.Center = NationCoordinates.IndiaLocation;
            MyMap.ZoomLevel = NationCoordinates.IndiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IndiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Indonesia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IndonesiaAnthem;
            NInfo.Text = InfoNations.Indonesia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IndonesiaFlag;
            NameOfNation.Text = "Indonesia";
            MyMap.Center = NationCoordinates.IndonesiaLocation;
            MyMap.ZoomLevel = NationCoordinates.IndonesiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IndonesiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Iran_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IranAnthem;
            NInfo.Text = InfoNations.Iran;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IranFlag;
            NameOfNation.Text = "Iran";
            MyMap.Center = NationCoordinates.IranLocation;
            MyMap.ZoomLevel = NationCoordinates.IranZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IranLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Iraq_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IraqAnthem;
            NInfo.Text = InfoNations.Iraq;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IraqFlag;
            NameOfNation.Text = "Iraq";
            MyMap.Center = NationCoordinates.IraqLocation;
            MyMap.ZoomLevel = NationCoordinates.IraqZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IraqLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Ireland_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IrelandAnthem;
            NInfo.Text = InfoNations.Ireland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IrelandFlag;
            NameOfNation.Text = "Ireland";
            MyMap.Center = NationCoordinates.IrelandLocation;
            MyMap.ZoomLevel = NationCoordinates.IrelandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IrelandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Israel_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.IsraelAnthem;
            NInfo.Text = InfoNations.Israel;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.IsraelFlag;
            NameOfNation.Text = "Israel";
            MyMap.Center = NationCoordinates.IsraelLocation;
            MyMap.ZoomLevel = NationCoordinates.IsraelZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.IsraelLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Italy_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ItalyAnthem;
            NInfo.Text = InfoNations.Italy;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ItalyFlag;
            NameOfNation.Text = "Italy";
            MyMap.Center = NationCoordinates.ItalyLocation;
            MyMap.ZoomLevel = NationCoordinates.ItalyZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ItalyLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Jamaica_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.JamaicaAnthem;
            NInfo.Text = InfoNations.Jamaica;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.JamaicaFlag;
            NameOfNation.Text = "Jamaica";
            MyMap.Center = NationCoordinates.JamaicaLocation;
            MyMap.ZoomLevel = NationCoordinates.JamaicaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.JamaicaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Japan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.JapanAnthem;
            NInfo.Text = InfoNations.Japan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.JapanFlag;
            NameOfNation.Text = "Japan";
            MyMap.Center = NationCoordinates.JapanLocation;
            MyMap.ZoomLevel = NationCoordinates.JapanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.JapanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

       
        private void Jordan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.JordanAnthem;
            NInfo.Text = InfoNations.Jordan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.JordanFlag;
            NameOfNation.Text = "Jordan";
            MyMap.Center = NationCoordinates.JordanLocation;
            MyMap.ZoomLevel = NationCoordinates.JordanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.JordanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Kazakhstan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KazakhstanAnthem;
            NInfo.Text = InfoNations.Kazakhstan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KazakhstanFlag;
            NameOfNation.Text = "Kazakhstan";
            MyMap.Center = NationCoordinates.KazakhstanLocation;
            MyMap.ZoomLevel = NationCoordinates.KazakhstanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KazakhstanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Kenya_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KenyaAnthem;
            NInfo.Text = InfoNations.Kenya;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KenyaFlag;
            NameOfNation.Text = "Kenya";
            MyMap.Center = NationCoordinates.KenyaLocation;
            MyMap.ZoomLevel = NationCoordinates.KenyaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KenyaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Kiribati_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KiribatiAnthem;
            NInfo.Text = InfoNations.Kiribati;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KiribatiFlag;
            NameOfNation.Text = "Kiribati";
            MyMap.Center = NationCoordinates.KiribatiLocation;
            MyMap.ZoomLevel = NationCoordinates.KiribatiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KiribatiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Korea_North_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Korea_NorthAnthem;
            NInfo.Text = InfoNations.Korea_North;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Korea_NorthFlag;
            NameOfNation.Text = "Korea (North)";
            MyMap.Center = NationCoordinates.Korea_NorthLocation;
            MyMap.ZoomLevel = NationCoordinates.Korea_NorthZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Korea_NorthLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Korea_South_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Korea_SouthAnthem;
            NInfo.Text = InfoNations.Korea_South;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Korea_SouthFlag;
            NameOfNation.Text = "Korea (South)";
            MyMap.Center = NationCoordinates.Korea_SouthLocation;
            MyMap.ZoomLevel = NationCoordinates.Korea_SouthZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Korea_SouthLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Kosovo_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KosovoAnthem;
            NInfo.Text = InfoNations.Kosovo;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KosovoFlag;
            NameOfNation.Text = "Kosovo";
            MyMap.Center = NationCoordinates.KosovoLocation;
            MyMap.ZoomLevel = NationCoordinates.KosovoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KosovoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Kuwait_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KuwaitAnthem;
            NInfo.Text = InfoNations.Kuwait;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KuwaitFlag;
            NameOfNation.Text = "Kuwait";
            MyMap.Center = NationCoordinates.KuwaitLocation;
            MyMap.ZoomLevel = NationCoordinates.KuwaitZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KuwaitLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
            
        }

        private void Kyrgyzstan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.KyrgyzstanAnthem;
            NInfo.Text = InfoNations.Kyrgyzstan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.KyrgyzstanFlag;
            NameOfNation.Text = "Kyrgyzstan";
            MyMap.Center = NationCoordinates.KyrgyzstanLocation;
            MyMap.ZoomLevel = NationCoordinates.KyrgyzstanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.KyrgyzstanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Laos_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LaosAnthem;
            NInfo.Text = InfoNations.Laos;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LaosFlag;
            NameOfNation.Text = "Laos";
            MyMap.Center = NationCoordinates.LaosLocation;
            MyMap.ZoomLevel = NationCoordinates.LaosZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LaosLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Latvia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LatviaAnthem;
            NInfo.Text = InfoNations.Latvia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LatviaFlag;
            NameOfNation.Text = "Latvia";
            MyMap.Center = NationCoordinates.LatviaLocation;
            MyMap.ZoomLevel = NationCoordinates.LatviaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LatviaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Lebanon_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LebanonAnthem;
            NInfo.Text = InfoNations.Lebanon;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LebanonFlag;
            NameOfNation.Text = "Lebanon";
            MyMap.Center = NationCoordinates.LebanonLocation;
            MyMap.ZoomLevel = NationCoordinates.LebanonZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LebanonLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Lesotho_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LesothoAnthem;
            NInfo.Text = InfoNations.Lesotho;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LesothoFlag;
            NameOfNation.Text = "Lesotho";
            MyMap.Center = NationCoordinates.LesothoLocation;
            MyMap.ZoomLevel = NationCoordinates.LesothoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LesothoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Liberia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LiberiaAnthem;
            NInfo.Text = InfoNations.Liberia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LiberiaFlag;
            NameOfNation.Text = "Liberia";
            MyMap.Center = NationCoordinates.LiberiaLocation;
            MyMap.ZoomLevel = NationCoordinates.LiberiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LiberiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Libya_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LibyaAnthem;
            NInfo.Text = InfoNations.Libya;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LibyaFlag;
            NameOfNation.Text = "Libya";
            MyMap.Center = NationCoordinates.LibyaLocation;
            MyMap.ZoomLevel = NationCoordinates.LibyaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LibyaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Liechtenstein_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LiechtensteinAnthem;
            NInfo.Text = InfoNations.Liechtenstein;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LiechtensteinFlag;
            NameOfNation.Text = "Liechtenstein";
            MyMap.Center = NationCoordinates.LiechtensteinLocation;
            MyMap.ZoomLevel = NationCoordinates.LiechtensteinZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LiechtensteinLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Lithuania_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LithuaniaAnthem;
            NInfo.Text = InfoNations.Lithuania;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LithuaniaFlag;
            NameOfNation.Text = "Lithuania";
            MyMap.Center = NationCoordinates.LithuaniaLocation;
            MyMap.ZoomLevel = NationCoordinates.LithuaniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LithuaniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Luxembourg_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.LuxembourgAnthem;
            NInfo.Text = InfoNations.Luxembourg;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.LuxembourgFlag;
            NameOfNation.Text = "Luxembourg";
            MyMap.Center = NationCoordinates.LuxembourgLocation;
            MyMap.ZoomLevel = NationCoordinates.LuxembourgZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.LuxembourgLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Macedonia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MacedoniaAnthem;
            NInfo.Text = InfoNations.Macedonia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MacedoniaFlag;
            NameOfNation.Text = "Macedonia";
            MyMap.Center = NationCoordinates.MacedoniaLocation;
            MyMap.ZoomLevel = NationCoordinates.MacedoniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MacedoniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Madagascar_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MadagascarAnthem;
            NInfo.Text = InfoNations.Madagascar;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MadagascarFlag;
            NameOfNation.Text = "Madagascar";
            MyMap.Center = NationCoordinates.MadagascarLocation;
            MyMap.ZoomLevel = NationCoordinates.MadagascarZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MadagascarLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Malawi_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MalawiAnthem;
            NInfo.Text = InfoNations.Malawi;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MalawiFlag;
            NameOfNation.Text = "Malawi";
            MyMap.Center = NationCoordinates.MalawiLocation;
            MyMap.ZoomLevel = NationCoordinates.MalawiZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MalawiLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Malaysia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MalaysiaAnthem;
            NInfo.Text = InfoNations.Malaysia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MalaysiaFlag;
            NameOfNation.Text = "Malaysia";
            MyMap.Center = NationCoordinates.MalaysiaLocation;
            MyMap.ZoomLevel = NationCoordinates.MalaysiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MalaysiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Maldives_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MaldivesAnthem;
            NInfo.Text = InfoNations.Maldives;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MaldivesFlag;
            NameOfNation.Text = "Maldives";
            MyMap.Center = NationCoordinates.MaldivesLocation;
            MyMap.ZoomLevel = NationCoordinates.MaldivesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MaldivesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mali_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MaliAnthem;
            NInfo.Text = InfoNations.Mali;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MaliFlag;
            NameOfNation.Text = "Mali";
            MyMap.Center = NationCoordinates.MaliLocation;
            MyMap.ZoomLevel = NationCoordinates.MaliZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MaliLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Malta_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MaltaAnthem;
            NInfo.Text = InfoNations.Malta;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MaltaFlag;
            NameOfNation.Text = "Malta";
            MyMap.Center = NationCoordinates.MaltaLocation;
            MyMap.ZoomLevel = NationCoordinates.MaltaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MaltaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Marshall_Islands_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Marshall_IslandsAnthem;
            NInfo.Text = InfoNations.Marshall_Islands;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Marshall_IslandsFlag;
            NameOfNation.Text = "Marshall Islands";
            MyMap.Center = NationCoordinates.Marshall_IslandsLocation;
            MyMap.ZoomLevel = NationCoordinates.Marshall_IslandsZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Marshall_IslandsLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mauritania_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MauritaniaAnthem;
            NInfo.Text = InfoNations.Mauritania;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MauritaniaFlag;
            NameOfNation.Text = "Mauritania";
            MyMap.Center = NationCoordinates.MauritaniaLocation;
            MyMap.ZoomLevel = NationCoordinates.MauritaniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MauritaniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mauritius_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MauritiusAnthem;
            NInfo.Text = InfoNations.Mauritius;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MauritiusFlag;
            NameOfNation.Text = "Mauritius";
            MyMap.Center = NationCoordinates.MauritiusLocation;
            MyMap.ZoomLevel = NationCoordinates.MauritiusZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MauritiusLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mexico_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MexicoAnthem;
            NInfo.Text = InfoNations.Mexico;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MexicoFlag;
            NameOfNation.Text = "Mexico";
            MyMap.Center = NationCoordinates.MexicoLocation;
            MyMap.ZoomLevel = NationCoordinates.MexicoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MexicoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Moldova_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MoldovaAnthem;
            NInfo.Text = InfoNations.Moldova;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MoldovaFlag;
            NameOfNation.Text = "Moldova";
            MyMap.Center = NationCoordinates.MoldovaLocation;
            MyMap.ZoomLevel = NationCoordinates.MoldovaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MoldovaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Monaco_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MonacoAnthem;
            NInfo.Text = InfoNations.Monaco;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MonacoFlag;
            NameOfNation.Text = "Monaco";
            MyMap.Center = NationCoordinates.MonacoLocation;
            MyMap.ZoomLevel = NationCoordinates.MonacoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MonacoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mongolia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MongoliaAnthem;
            NInfo.Text = InfoNations.Mongolia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MongoliaFlag;
            NameOfNation.Text = "Mongolia";
            MyMap.Center = NationCoordinates.MongoliaLocation;
            MyMap.ZoomLevel = NationCoordinates.MongoliaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MongoliaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Montenegro_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MontenegroAnthem;
            NInfo.Text = InfoNations.Montenegro;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MontenegroFlag;
            NameOfNation.Text = "Montenegro";
            MyMap.Center = NationCoordinates.MontenegroLocation;
            MyMap.ZoomLevel = NationCoordinates.MontenegroZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MontenegroLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Morocco_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MoroccoAnthem;
            NInfo.Text = InfoNations.Morocco;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MoroccoFlag;
            NameOfNation.Text = "Morocco";
            MyMap.Center = NationCoordinates.MoroccoLocation;
            MyMap.ZoomLevel = NationCoordinates.MoroccoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MoroccoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Mozambique_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MozambiqueAnthem;
            NInfo.Text = InfoNations.Mozambique;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MozambiqueFlag;
            NameOfNation.Text = "Mozambique";
            MyMap.Center = NationCoordinates.MozambiqueLocation;
            MyMap.ZoomLevel = NationCoordinates.MozambiqueZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MozambiqueLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Myanmar_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.MyanmarAnthem;
            NInfo.Text = InfoNations.Myanmar;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.MyanmarFlag;
            NameOfNation.Text = "Myanmar";
            MyMap.Center = NationCoordinates.MyanmarLocation;
            MyMap.ZoomLevel = NationCoordinates.MyanmarZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.MyanmarLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Nagorno_Karabakh_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Nagorno_KarabakhAnthem;
            NInfo.Text = InfoNations.Nagorno_Karabakh;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Nagorno_KarabakhFlag;
            NameOfNation.Text = "Nagorno Karabakh";
            MyMap.Center = NationCoordinates.Nagorno_KarabakhLocation;
            MyMap.ZoomLevel = NationCoordinates.Nagorno_KarabakhZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Nagorno_KarabakhLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Namibia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NamibiaAnthem;
            NInfo.Text = InfoNations.Namibia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NamibiaFlag;
            NameOfNation.Text = "Namibia";
            MyMap.Center = NationCoordinates.NamibiaLocation;
            MyMap.ZoomLevel = NationCoordinates.NamibiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NamibiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Nauru_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NauruAnthem;
            NInfo.Text = InfoNations.Nauru;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NauruFlag;
            NameOfNation.Text = "Nauru";
            MyMap.Center = NationCoordinates.NauruLocation;
            MyMap.ZoomLevel = NationCoordinates.NauruZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NauruLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Nepal_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NepalAnthem;
            NInfo.Text = InfoNations.Nepal;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NepalFlag;
            NameOfNation.Text = "Nepal";
            MyMap.Center = NationCoordinates.NepalLocation;
            MyMap.ZoomLevel = NationCoordinates.NepalZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NepalLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Netherlands_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NetherlandsAnthem;
            NInfo.Text = InfoNations.Netherlands;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NetherlandsFlag;
            NameOfNation.Text = "Netherlands";
            MyMap.Center = NationCoordinates.NetherlandsLocation;
            MyMap.ZoomLevel = NationCoordinates.NetherlandsZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NetherlandsLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void New_Zealand_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.New_ZealandAnthem;
            NInfo.Text = InfoNations.New_Zealand;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.New_ZealandFlag;
            NameOfNation.Text = "New Zealand";
            MyMap.Center = NationCoordinates.New_ZealandLocation;
            MyMap.ZoomLevel = NationCoordinates.New_ZealandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.New_ZealandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Niger_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NigerAnthem;
            NInfo.Text = InfoNations.Niger;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NigerFlag;
            NameOfNation.Text = "Niger";
            MyMap.Center = NationCoordinates.NigerLocation;
            MyMap.ZoomLevel = NationCoordinates.NigerZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NigerLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Nigeria_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NigeriaAnthem;
            NInfo.Text = InfoNations.Nigeria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NigeriaFlag;
            NameOfNation.Text = "Nigeria";
            MyMap.Center = NationCoordinates.NigeriaLocation;
            MyMap.ZoomLevel = NationCoordinates.New_ZealandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NigeriaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Northern_Cyprus_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Northern_CyprusAnthem;
            NInfo.Text = InfoNations.Northern_Cyprus;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Northern_CyprusFlag;
            NameOfNation.Text = "Northern Cyprus";
            MyMap.Center = NationCoordinates.Northern_CyprusLocation;
            MyMap.ZoomLevel = NationCoordinates.Northern_CyprusZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Northern_CyprusLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Nicaragua_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NicaraguaAnthem;
            NInfo.Text = InfoNations.Nicaragua;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NicaraguaFlag;
            NameOfNation.Text = "Nicaragua";
            MyMap.Center = NationCoordinates.NicaraguaLocation;
            MyMap.ZoomLevel = NationCoordinates.NicaraguaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NicaraguaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Norway_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.NorwayAnthem;
            NInfo.Text = InfoNations.Norway;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.NorwayFlag;
            NameOfNation.Text = "Norway";
            MyMap.Center = NationCoordinates.NorwayLocation;
            MyMap.ZoomLevel = NationCoordinates.NorwayZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.NorwayLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Oman_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.OmanAnthem;
            NInfo.Text = InfoNations.Oman;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.OmanFlag;
            NameOfNation.Text = "Oman";
            MyMap.Center = NationCoordinates.OmanLocation;
            MyMap.ZoomLevel = NationCoordinates.OmanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.OmanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Pakistan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PakistanAnthem;
            NInfo.Text = InfoNations.Pakistan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PakistanFlag;
            NameOfNation.Text = "Pakistan";
            MyMap.Center = NationCoordinates.PakistanLocation;
            MyMap.ZoomLevel = NationCoordinates.PakistanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PakistanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Palau_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PalauAnthem;
            NInfo.Text = InfoNations.Palau;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PalauFlag;
            NameOfNation.Text = "Palau";
            MyMap.Center = NationCoordinates.PalauLocation;
            MyMap.ZoomLevel = NationCoordinates.PalauZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PalauLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Palestine_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PalestineAnthem;
            NInfo.Text = InfoNations.Palestine;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PalestineFlag;
            NameOfNation.Text = "Palestine";
            MyMap.Center = NationCoordinates.PalestineLocation;
            MyMap.ZoomLevel = NationCoordinates.PalestineZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PalestineLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Panama_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PanamaAnthem;
            NInfo.Text = InfoNations.Panama;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PanamaFlag;
            NameOfNation.Text = "Panama";
            MyMap.Center = NationCoordinates.PanamaLocation;
            MyMap.ZoomLevel = NationCoordinates.PanamaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PanamaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Papua_New_Guinea_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Papua_New_GuineaAnthem;
            NInfo.Text = InfoNations.Papua_New_Guinea;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Papua_New_GuineaFlag;
            NameOfNation.Text = "Papua New Guinea";
            MyMap.Center = NationCoordinates.Papua_New_GuineaLocation;
            MyMap.ZoomLevel = NationCoordinates.Papua_New_GuineaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Papua_New_GuineaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Paraguay_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ParaguayAnthem;
            NInfo.Text = InfoNations.Paraguay;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ParaguayFlag;
            NameOfNation.Text = "Paraguay";
            MyMap.Center = NationCoordinates.ParaguayLocation;
            MyMap.ZoomLevel = NationCoordinates.ParaguayZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ParaguayLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Peru_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PeruAnthem;
            NInfo.Text = InfoNations.Peru;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PeruFlag;
            NameOfNation.Text = "Peru";
            MyMap.Center = NationCoordinates.PeruLocation;
            MyMap.ZoomLevel = NationCoordinates.PeruZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PeruLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Philippines_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PhilippinesAnthem;
            NInfo.Text = InfoNations.Philippines;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PhilippinesFlag;
            NameOfNation.Text = "Philippines";
            MyMap.Center = NationCoordinates.PhilippinesLocation;
            MyMap.ZoomLevel = NationCoordinates.PhilippinesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PhilippinesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Poland_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PolandAnthem;
            NInfo.Text = InfoNations.Poland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PolandFlag;
            NameOfNation.Text = "Poland";
            MyMap.Center = NationCoordinates.PolandLocation;
            MyMap.ZoomLevel = NationCoordinates.PolandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PolandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Portugal_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.PortugalAnthem;
            NInfo.Text = InfoNations.Portugal;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.PortugalFlag;
            NameOfNation.Text = "Portugal";
            MyMap.Center = NationCoordinates.PortugalLocation;
            MyMap.ZoomLevel = NationCoordinates.PortugalZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.PortugalLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Qatar_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.QatarAnthem;
            NInfo.Text = InfoNations.Qatar;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.QatarFlag;
            NameOfNation.Text = "Qatar";
            MyMap.Center = NationCoordinates.QatarLocation;
            MyMap.ZoomLevel = NationCoordinates.QatarZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.QatarLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Republic_of_China_Taiwan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TaiwanAnthem;
            NInfo.Text = InfoNations.Taiwan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TaiwanFlag;
            NameOfNation.Text = "Taiwan";
            MyMap.Center = NationCoordinates.TaiwanLocation;
            MyMap.ZoomLevel = NationCoordinates.TaiwanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TaiwanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Romania_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.RomaniaAnthem;
            NInfo.Text = InfoNations.Romania;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.RomaniaFlag;
            NameOfNation.Text = "Romania";
            MyMap.Center = NationCoordinates.RomaniaLocation;
            MyMap.ZoomLevel = NationCoordinates.RomaniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.RomaniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Russia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.RussiaAnthem;
            NInfo.Text = InfoNations.Russia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.RussiaFlag;
            NameOfNation.Text = "Russia";
            MyMap.Center = NationCoordinates.RussiaLocation;
            MyMap.ZoomLevel = NationCoordinates.RussiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.RussiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Rwanda_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.RwandaAnthem;
            NInfo.Text = InfoNations.Rwanda;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.RwandaFlag;
            NameOfNation.Text = "Rwanda";
            MyMap.Center = NationCoordinates.RwandaLocation;
            MyMap.ZoomLevel = NationCoordinates.RwandaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.RwandaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Saint_Kitts_and_Nevis_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Saint_Kitts_and_NevisAnthem;
            NInfo.Text = InfoNations.Saint_Kitts_and_Nevis;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Saint_Kitts_and_NevisFlag;
            NameOfNation.Text = "Saint Kitts and Nevis";
            MyMap.Center = NationCoordinates.Saint_Kitts_and_NevisLocation;
            MyMap.ZoomLevel = NationCoordinates.Saint_Kitts_and_NevisZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Saint_Kitts_and_NevisLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Saint_Lucia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Saint_LuciaAnthem;
            NInfo.Text = InfoNations.Saint_Lucia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Saint_LuciaFlag;
            NameOfNation.Text = "Saint Lucia";
            MyMap.Center = NationCoordinates.Saint_LuciaLocation;
            MyMap.ZoomLevel = NationCoordinates.Saint_LuciaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Saint_LuciaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Saint_Vincent_and_the_Grenadines_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Saint_Vincent_and_the_GrenadinesAnthem;
            NInfo.Text = InfoNations.Saint_Vincent_and_the_Grenadines;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Saint_Vincent_and_the_GrenadinesFlag;
            NameOfNation.Text = "Saint Vincent and The Grenadines";
            MyMap.Center = NationCoordinates.Saint_Vincent_and_the_GrenadinesLocation;
            MyMap.ZoomLevel = NationCoordinates.Saint_Vincent_and_the_GrenadinesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Saint_Vincent_and_the_GrenadinesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Samoa_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SamoaAnthem;
            NInfo.Text = InfoNations.Samoa;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SamoaFlag;
            NameOfNation.Text = "Samoa";
            MyMap.Center = NationCoordinates.SamoaLocation;
            MyMap.ZoomLevel = NationCoordinates.SamoaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SamoaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void San_Marino_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.San_MarinoAnthem;
            NInfo.Text = InfoNations.San_Marino;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.San_MarinoFlag;
            NameOfNation.Text = "San Marino";
            MyMap.Center = NationCoordinates.San_MarinoLocation;
            MyMap.ZoomLevel = NationCoordinates.San_MarinoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.San_MarinoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void São_Tomé_and_Príncipe_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.São_Tomé_and_PríncipeAnthem;
            NInfo.Text = InfoNations.São_Tomé_and_Príncipe;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.São_Tomé_and_PríncipeFlag;
            NameOfNation.Text = "São Tomé and Príncipe";
            MyMap.Center = NationCoordinates.São_Tomé_and_PríncipeLocation;
            MyMap.ZoomLevel = NationCoordinates.São_Tomé_and_PríncipeZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.São_Tomé_and_PríncipeLocation);
            MyMap.Children.Add(NationCoordinates.pushpin); 
        }

        private void Saudi_Arabia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Saudi_ArabiaAnthem;
            NInfo.Text = InfoNations.Saudi_Arabia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Saudi_ArabiaFlag;
            NameOfNation.Text = "Saudi Arabia";
            MyMap.Center = NationCoordinates.Saudi_ArabiaLocation;
            MyMap.ZoomLevel = NationCoordinates.Saudi_ArabiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Saudi_ArabiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
            //http://apps.microsoft.com/windows/app/all-tv-shows/2192aaed-0081-4b2f-b75d-7c0226203e3a //All tv show rel1 URL
            //Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:REVIEW?PFN=PACKAGENAME"));
            //Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:REVIEW?PFN=39201srijonchak.AllTVShows"));
        }
       
        private void Senegal_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SenegalAnthem;
            NInfo.Text = InfoNations.Senegal;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SenegalFlag;
            NameOfNation.Text = "Senegal";
            MyMap.Center = NationCoordinates.SenegalLocation;
            MyMap.ZoomLevel = NationCoordinates.SenegalZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SenegalLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Serbia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SerbiaAnthem;
            NInfo.Text = InfoNations.Serbia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SerbiaFlag;
            NameOfNation.Text = "Serbia";
            MyMap.Center = NationCoordinates.SerbiaLocation;
            MyMap.ZoomLevel = NationCoordinates.SerbiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SerbiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Seychelles_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SeychellesAnthem;
            NInfo.Text = InfoNations.Seychelles;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SeychellesFlag;
            NameOfNation.Text = "Seychelles";
            MyMap.Center = NationCoordinates.SeychellesLocation;
            MyMap.ZoomLevel = NationCoordinates.SeychellesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SeychellesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Sierra_Leone_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Sierra_LeoneAnthem;
            NInfo.Text = InfoNations.Sierra_Leone;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Sierra_LeoneFlag;
            NameOfNation.Text = "Sierra Leone";
            MyMap.Center = NationCoordinates.Sierra_LeoneLocation;
            MyMap.ZoomLevel = NationCoordinates.Sierra_LeoneZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Sierra_LeoneLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Singapore_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SingaporeAnthem;
            NInfo.Text = InfoNations.Singapore;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SingaporeFlag;
            NameOfNation.Text = "Singapore";
            MyMap.Center = NationCoordinates.SingaporeLocation;
            MyMap.ZoomLevel = NationCoordinates.SingaporeZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SingaporeLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Slovakia_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SlovakiaAnthem;
            NInfo.Text = InfoNations.Slovakia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SlovakiaFlag;
            NameOfNation.Text = "Slovakia";
            MyMap.Center = NationCoordinates.SlovakiaLocation;
            MyMap.ZoomLevel = NationCoordinates.SlovakiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SlovakiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Slovenia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SloveniaAnthem;
            NInfo.Text = InfoNations.Slovenia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SloveniaFlag;
            NameOfNation.Text = "Slovenia";
            MyMap.Center = NationCoordinates.SloveniaLocation;
            MyMap.ZoomLevel = NationCoordinates.SloveniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SloveniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Solomon_Islands_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Solomon_IslandsAnthem;
            NInfo.Text = InfoNations.Solomon_Islands;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Solomon_IslandsFlag;
            NameOfNation.Text = "Solomon Islands";
            MyMap.Center = NationCoordinates.Solomon_IslandsLocation;
            MyMap.ZoomLevel = NationCoordinates.Solomon_IslandsZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Solomon_IslandsLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Somalia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SomaliaAnthem;
            NInfo.Text = InfoNations.Somalia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SomaliaFlag;
            NameOfNation.Text = "Somalia";
            MyMap.Center = NationCoordinates.SomaliaLocation;
            MyMap.ZoomLevel = NationCoordinates.SomaliaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SomaliaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Somaliland_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SomalilandAnthem;
            NInfo.Text = InfoNations.Somaliland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SomalilandFlag;
            NameOfNation.Text = "Somaliland";
            MyMap.Center = NationCoordinates.SomalilandLocation;
            MyMap.ZoomLevel = NationCoordinates.SomalilandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SomalilandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void South_Africa_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.South_AfricaAnthem;
            NInfo.Text = InfoNations.South_Africa;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.South_AfricaFlag;
            NameOfNation.Text = "South Africa";
            MyMap.Center = NationCoordinates.South_AfricaLocation;
            MyMap.ZoomLevel = NationCoordinates.South_AfricaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.South_AfricaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void South_Sudan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.South_SudanAnthem;
            NInfo.Text = InfoNations.South_Sudan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.South_SudanFlag;
            NameOfNation.Text = "South Sudan";
            MyMap.Center = NationCoordinates.South_SudanLocation;
            MyMap.ZoomLevel = NationCoordinates.South_SudanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.South_SudanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Spain_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SpainAnthem;
            NInfo.Text = InfoNations.Spain;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SpainFlag;
            NameOfNation.Text = "Spain";
            MyMap.Center = NationCoordinates.SpainLocation;
            MyMap.ZoomLevel = NationCoordinates.SpainZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SpainLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Sri_Lanka_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Sri_LankaAnthem;
            NInfo.Text = InfoNations.Sri_Lanka;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Sri_LankaFlag;
            NameOfNation.Text = "Sri Lanka";
            MyMap.Center = NationCoordinates.Sri_LankaLocation;
            MyMap.ZoomLevel = NationCoordinates.Sri_LankaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Sri_LankaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Sudan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SudanAnthem;
            NInfo.Text = InfoNations.Sudan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SudanFlag;
            NameOfNation.Text = "Sudan";
            MyMap.Center = NationCoordinates.SudanLocation;
            MyMap.ZoomLevel = NationCoordinates.SudanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SudanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Swaziland_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SwazilandAnthem;
            NInfo.Text = InfoNations.Swaziland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SwazilandFlag;
            NameOfNation.Text = "Swaziland";
            MyMap.Center = NationCoordinates.SwazilandLocation;
            MyMap.ZoomLevel = NationCoordinates.SwazilandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SwazilandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Sweden_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SwedenAnthem;
            NInfo.Text = InfoNations.Sweden;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SwedenFlag;
            NameOfNation.Text = "Sweden";
            MyMap.Center = NationCoordinates.SwedenLocation;
            MyMap.ZoomLevel = NationCoordinates.SwedenZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SwedenLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Suriname_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SurinameAnthem;
            NInfo.Text = InfoNations.Suriname;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SurinameFlag;
            NameOfNation.Text = "Suriname";
            MyMap.Center = NationCoordinates.SurinameLocation;
            MyMap.ZoomLevel = NationCoordinates.SurinameZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SurinameLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Switzerland_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SwitzerlandAnthem;
            NInfo.Text = InfoNations.Switzerland;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SwitzerlandFlag;
            NameOfNation.Text = "Switzerland";
            MyMap.Center = NationCoordinates.SwitzerlandLocation;
            MyMap.ZoomLevel = NationCoordinates.SwitzerlandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SwitzerlandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Syria_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.SyriaAnthem;
            NInfo.Text = InfoNations.Syria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.SyriaFlag;
            NameOfNation.Text = "Syria";
            MyMap.Center = NationCoordinates.SyriaLocation;
            MyMap.ZoomLevel = NationCoordinates.SyriaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.SyriaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Tajikistan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TajikistanAnthem;
            NInfo.Text = InfoNations.Tajikistan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TajikistanFlag;
            NameOfNation.Text = "Tajikistan";
            MyMap.Center = NationCoordinates.TajikistanLocation;
            MyMap.ZoomLevel = NationCoordinates.TajikistanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TajikistanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Tanzania_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TanzaniaAnthem;
            NInfo.Text = InfoNations.Tanzania;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TanzaniaFlag;
            NameOfNation.Text = "Tanzania";
            MyMap.Center = NationCoordinates.TanzaniaLocation;
            MyMap.ZoomLevel = NationCoordinates.TanzaniaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TanzaniaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Thailand_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ThailandAnthem;
            NInfo.Text = InfoNations.Thailand;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ThailandFlag;
            NameOfNation.Text = "Thailand";
            MyMap.Center = NationCoordinates.ThailandLocation;
            MyMap.ZoomLevel = NationCoordinates.ThailandZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ThailandLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Togo_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TogoAnthem;
            NInfo.Text = InfoNations.Togo;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TogoFlag;
            NameOfNation.Text = "Togo";
            MyMap.Center = NationCoordinates.TogoLocation;
            MyMap.ZoomLevel = NationCoordinates.TogoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TogoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Tonga_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TongaAnthem;
            NInfo.Text = InfoNations.Tonga;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TongaFlag;
            NameOfNation.Text = "Tonga";
            MyMap.Center = NationCoordinates.TongaLocation;
            MyMap.ZoomLevel = NationCoordinates.TongaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TongaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Transnistria_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TransnistriaAnthem;
            NInfo.Text = InfoNations.Transnistria;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TransnistriaFlag;
            NameOfNation.Text = "Transnistria";
            MyMap.Center = NationCoordinates.TransnistriaLocation;
            MyMap.ZoomLevel = NationCoordinates.TransnistriaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TransnistriaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Trinidad_and_Tobago_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Trinidad_and_TobagoAnthem;
            NInfo.Text = InfoNations.Trinidad_and_Tobago;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Trinidad_and_TobagoFlag;
            NameOfNation.Text = "Trinidad and Tobago";
            MyMap.Center = NationCoordinates.Trinidad_and_TobagoLocation;
            MyMap.ZoomLevel = NationCoordinates.Trinidad_and_TobagoZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Trinidad_and_TobagoLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Tunisia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TunisiaAnthem;
            NInfo.Text = InfoNations.Tunisia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TunisiaFlag;
            NameOfNation.Text = "Tunisia";
            MyMap.Center = NationCoordinates.TunisiaLocation;
            MyMap.ZoomLevel = NationCoordinates.TunisiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TunisiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Turkey_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TurkeyAnthem;
            NInfo.Text = InfoNations.Turkey;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TurkeyFlag;
            NameOfNation.Text = "Turkey";
            MyMap.Center = NationCoordinates.TurkeyLocation;
            MyMap.ZoomLevel = NationCoordinates.TurkeyZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TurkeyLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Turkmenistan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TurkmenistanAnthem;
            NInfo.Text = InfoNations.Turkmenistan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TurkmenistanFlag;
            NameOfNation.Text = "Turkmenistan";
            MyMap.Center = NationCoordinates.TurkmenistanLocation;
            MyMap.ZoomLevel = NationCoordinates.TurkmenistanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TurkmenistanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Tuvalu_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.TuvaluAnthem;
            NInfo.Text = InfoNations.Tuvalu;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.TuvaluFlag;
            NameOfNation.Text = "Tuvalu";
            MyMap.Center = NationCoordinates.TuvaluLocation;
            MyMap.ZoomLevel = NationCoordinates.TuvaluZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.TuvaluLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Uganda_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.UgandaAnthem;
            NInfo.Text = InfoNations.Uganda;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.UgandaFlag;
            NameOfNation.Text = "Uganda";
            MyMap.Center = NationCoordinates.UgandaLocation;
            MyMap.ZoomLevel = NationCoordinates.UgandaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.UgandaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Ukraine_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.UkraineAnthem;
            NInfo.Text = InfoNations.Ukraine;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.UkraineFlag;
            NameOfNation.Text = "Ukraine";
            MyMap.Center = NationCoordinates.UkraineLocation;
            MyMap.ZoomLevel = NationCoordinates.UkraineZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.UkraineLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void United_Arab_Emirates_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.United_Arab_EmiratesAnthem;
            NInfo.Text = InfoNations.United_Arab_Emirates;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.United_Arab_EmiratesFlag;
            NameOfNation.Text = "United Arab Emirates";
            MyMap.Center = NationCoordinates.United_Arab_EmiratesLocation;
            MyMap.ZoomLevel = NationCoordinates.United_Arab_EmiratesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.United_Arab_EmiratesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void United_Kingdom_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.United_KingdomAnthem;
            NInfo.Text = InfoNations.United_Kingdom;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.United_KingdomFlag;
            NameOfNation.Text = "United Kingdom";
            MyMap.Center = NationCoordinates.United_KingdomLocation;
            MyMap.ZoomLevel = NationCoordinates.United_KingdomZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.United_KingdomLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void United_States_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.United_StatesAnthem;
            NInfo.Text = InfoNations.United_States;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.United_StatesFlag;
            NameOfNation.Text = "United States";
            MyMap.Center = NationCoordinates.United_StatesLocation;
            MyMap.ZoomLevel = NationCoordinates.United_StatesZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.United_StatesLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Uruguay_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.UruguayAnthem;
            NInfo.Text = InfoNations.Uruguay;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.UruguayFlag;
            NameOfNation.Text = "Uruguay";
            MyMap.Center = NationCoordinates.UruguayLocation;
            MyMap.ZoomLevel = NationCoordinates.UruguayZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.UruguayLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Uzbekistan_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.UzbekistanAnthem;
            NInfo.Text = InfoNations.Uzbekistan;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.UzbekistanFlag;
            NameOfNation.Text = "Uzbekistan";
            MyMap.Center = NationCoordinates.UzbekistanLocation;
            MyMap.ZoomLevel = NationCoordinates.UzbekistanZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.UzbekistanLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Vanuatu_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.VanuatuAnthem;
            NInfo.Text = InfoNations.Vanuatu;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.VanuatuFlag;
            NameOfNation.Text = "Vanuatu";
            MyMap.Center = NationCoordinates.VanuatuLocation;
            MyMap.ZoomLevel = NationCoordinates.VanuatuZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.VanuatuLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Vatican_City_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Vatican_CityAnthem;
            NInfo.Text = InfoNations.Vatican_City;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Vatican_CityFlag;
            NameOfNation.Text = "Vatican City";
            MyMap.Center = NationCoordinates.Vatican_CityLocation;
            MyMap.ZoomLevel = NationCoordinates.Vatican_CityZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Vatican_CityLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Venezuela_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.VenezuelaAnthem;
            NInfo.Text = InfoNations.Venezuela;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.VenezuelaFlag;
            NameOfNation.Text = "Venezuela";
            MyMap.Center = NationCoordinates.VenezuelaLocation;
            MyMap.ZoomLevel = NationCoordinates.VenezuelaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.VenezuelaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Vietnam_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.VietnamAnthem;
            NInfo.Text = InfoNations.Vietnam;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.VietnamFlag;
            NameOfNation.Text = "Vietnam";
            MyMap.Center = NationCoordinates.VietnamLocation;
            MyMap.ZoomLevel = NationCoordinates.VietnamZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.VietnamLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Western_Sahara_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.Western_SaharaAnthem;
            NInfo.Text = InfoNations.Western_Sahara;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.Western_SaharaFlag;
            NameOfNation.Text = "Western Sahara";
            MyMap.Center = NationCoordinates.Western_SaharaLocation;
            MyMap.ZoomLevel = NationCoordinates.Western_SaharaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.Western_SaharaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Yemen_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.YemenAnthem;
            NInfo.Text = InfoNations.Yemen;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.YemenFlag;
            NameOfNation.Text = "Yemen";
            MyMap.Center = NationCoordinates.YemenLocation;
            MyMap.ZoomLevel = NationCoordinates.YemenZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.YemenLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Zambia_event(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ZambiaAnthem;
            NInfo.Text = InfoNations.Zambia;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ZambiaFlag;
            NameOfNation.Text = "Zambia";
            MyMap.Center = NationCoordinates.ZambiaLocation;
            MyMap.ZoomLevel = NationCoordinates.ZambiaZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ZambiaLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
        }

        private void Zimbabwe_event(object sender, TappedRoutedEventArgs e)
        {

            try
            {
                AnthemPlayer.Stop();
                SoundAnimation.Stop();
                flagUp.Stop();
                flagGone.Stop();
                MyMap.Children.Remove(NationCoordinates.pushpin);
            }
            catch (Exception ere)
            {
            }
            flagGone.Begin();
            flagUp.Begin();
            AnthemPlayer.Source = NationCoordinates.ZimbabweAnthem;
            NInfo.Text = InfoNations.Zimbabwe;
            AnthemPlayer.Play();
            SoundAnimation.Begin();
            image.Source = NationCoordinates.ZimbabweFlag;
            NameOfNation.Text = "Zimbabwe";
            MyMap.Center = NationCoordinates.ZimbabweLocation;
            MyMap.ZoomLevel = NationCoordinates.ZimbabweZoomLevel;
            MapLayer.SetPosition(NationCoordinates.pushpin, NationCoordinates.ZimbabweLocation);
            MyMap.Children.Add(NationCoordinates.pushpin);
           
           
       
        }

        private void AnthemPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            SoundAnimation.Stop();
            //SoundBar.Opacity = 0;
        }

        private void AnthemPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            //SoundBar.Opacity = 100;
        }

        private void VolumeControl_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            try 
            { 
                AnthemPlayer.Volume = VolumeControl.Value;
                if (VolumeControl.Value == 0)
                {
                    MuteRec.Opacity = 100;
                    mutuflag = true;
                }
                else
                {
                    MuteRec.Opacity = 0;
                }
            }
            catch (Exception ex) { }
        }

        private void Canvas_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            if(mutuflag==false)
            {
                if (VolumeControl.Value == 100)
                {
                    MuteRec.Opacity = 100;
                    AnthemPlayer.Volume = 0;
                    VolumeControl.Value = 0;
                    mutuflag = true;
                }
                else
                {
                    MuteRec.Opacity = 100;
                    AnthemPlayer.Volume = 100;
                    VolumeControl.Value = 100;
                    mutuflag = true;
                }
            }
            else if (mutuflag == true)
            {
                if (VolumeControl.Value == 0) 
                {
                    MuteRec.Opacity = 0;
                    AnthemPlayer.Volume = 100;
                    VolumeControl.Value = 100;
                    mutuflag = false;
                }
                else
                {
                    MuteRec.Opacity = 0;
                    AnthemPlayer.Volume = 0;
                    VolumeControl.Value = 0;
                    mutuflag = false;
                }
            }

        }

        private void Canvas_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

        }

        private void MyTapped(object sender, TappedRoutedEventArgs e)
        {
           
            //On Tapped animation
            p = e.GetPosition(MAINGRID);            
            myPositionSetter.Left = p.X-20;
            myPositionSetter.Top = p.Y-20;
            //textbtn.Margin = myPositionSetter;
            canvas1.Margin = myPositionSetter;
            Click.Begin();
               // mytapaudio.Stop();
                mytapaudio.Play();
            
        }

        private void RateUs_event(object sender, TappedRoutedEventArgs e)
        {
            //http://apps.microsoft.com/windows/app/all-tv-shows/2192aaed-0081-4b2f-b75d-7c0226203e3a //All tv show rel1 URL
            Windows.System.Launcher.LaunchUriAsync(new Uri("http://apps.microsoft.com/windows/app/earth-nations/f41ac445-5e81-4d19-86a2-3c35dca9e8ae"));
            //Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:REVIEW?PFN=39201srijonchak.AllTVShows"));
            //int test = 1;
        }

       
    }
}
