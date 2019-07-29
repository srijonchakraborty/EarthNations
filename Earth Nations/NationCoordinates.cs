using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Maps;
using Windows.UI.Xaml.Media.Imaging;
namespace Earth_Nations
{
    public class NationCoordinates
    {
        public static Pushpin pushpin = new Pushpin();
        public static BitmapImage bitmapImage = new BitmapImage();
        // Uri uri = new Uri("ms-appx:///Assets/Logo.png");

        #region Abkhazia
        public static int AbkhaziaZoomLevel = 12;
        public static Double AbkhaziaLatitude = 43.007320000000010000;
        public static Double AbkhaziaLongitude = 40.989150999999990000;
        public static Location AbkhaziaLocation = new Location(AbkhaziaLatitude, AbkhaziaLongitude);
        public static Uri AbkhaziaAnthem = new Uri(@"ms-appx:/anthems/Abkhazia.mp3");
        public static BitmapImage AbkhaziaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Abkhazia.jpg"));
        #endregion
        #region  Afghanistan
        public static int AfghanistanZoomLevel = 5;
        public static Double AfghanistanLatitude = 34.543896;
        public static Double AfghanistanLongitude = 69.160652;
        public static Location AfghanistanLocation = new Location(AfghanistanLatitude, AfghanistanLongitude);
        public static Uri AfghanistanAnthem = new Uri(@"ms-appx:/anthems/Afghanistan.mp3");
        public static BitmapImage AfghanistanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Afghanistan.jpg"));
        #endregion
        #region Albania
        public static int AlbaniaZoomLevel = 7;
        public static Double AlbaniaLatitude = 41.33165;
        public static Double AlbaniaLongitude = 19.83179999999993;
        public static Location AlbaniaLocation = new Location(AlbaniaLatitude, AlbaniaLongitude);
        public static Uri AlbaniaAnthem = new Uri(@"ms-appx:/anthems/Albania.mp3");
        public static BitmapImage AlbaniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Albania.jpg"));
        #endregion
        #region Algeria
        public static int AlgeriaZoomLevel = 4;
        public static Double AlgeriaLatitude = 36.752887;
        public static Double AlgeriaLongitude = 3.0420480000000225;
        public static Location AlgeriaLocation = new Location(AlgeriaLatitude, AlgeriaLongitude);
        public static Uri AlgeriaAnthem = new Uri(@"ms-appx:/anthems/Algeria.mp3");
        public static BitmapImage AlgeriaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Algeria.jpg"));
        #endregion
        #region Angola
        public static int AngolaZoomLevel = 5;
        public static Double AngolaLatitude = -8.8383333;
        public static Double AngolaLongitude = 13.23444440000003;
        public static Location AngolaLocation = new Location(AngolaLatitude, AngolaLongitude);
        public static Uri AngolaAnthem = new Uri(@"ms-appx:/anthems/Angola.mp3");
        public static BitmapImage AngolaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Angola.jpg"));
        #endregion
        #region Andorra
        public static int AndorraZoomLevel = 7;
        public static Double AndorraLatitude = 42.5075314;
        public static Double AndorraLongitude = 1.521815599999968;
        public static Location AndorraLocation = new Location(AndorraLatitude, AndorraLongitude);
        public static Uri AndorraAnthem = new Uri(@"ms-appx:/anthems/Andorra.mp3");
        public static BitmapImage AndorraFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Andorra.jpg"));
        #endregion
        #region Antigua
        public static int AntiguaZoomLevel = 11;
        public static Double AntiguaLatitude = 17.0746557;
        public static Double AntiguaLongitude = -61.81752069999999;
        public static Location AntiguaLocation = new Location(AntiguaLatitude, AntiguaLongitude);
        public static Uri AntiguaAnthem = new Uri(@"ms-appx:/anthems/Antigua.mp3");
        public static BitmapImage AntiguaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Antigua.jpg"));
        #endregion
        #region Argentina
        public static int ArgentinaZoomLevel = 4;
        public static Double ArgentinaLatitude = -34.6037232;
        public static Double ArgentinaLongitude = -58.3815931;
        public static Location ArgentinaLocation = new Location(ArgentinaLatitude, ArgentinaLongitude);
        public static Uri ArgentinaAnthem = new Uri(@"ms-appx:/anthems/Argentina.mp3");
        public static BitmapImage ArgentinaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Argentina.jpg"));
        #endregion
        #region Armenia
        public static int ArmeniaZoomLevel = 6;
        public static Double ArmeniaLatitude = 40.183333;
        public static Double ArmeniaLongitude = 44.516666999999984;
        public static Location ArmeniaLocation = new Location(ArmeniaLatitude, ArmeniaLongitude);
        public static Uri ArmeniaAnthem = new Uri(@"ms-appx:/anthems/Armenia.mp3");
        public static BitmapImage ArmeniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Armenia.jpg"));
        #endregion
        #region ARUBA
        public static int ARUBAZoomLevel = 10;
        public static Double ARUBALatitude = 12.52458;
        public static Double ARUBALongitude = -70.02645899999999;
        public static Location ARUBALocation = new Location(ARUBALatitude, ARUBALongitude);
        public static Uri ARUBAAnthem = new Uri(@"ms-appx:/anthems/ARUBA.mp3");
        public static BitmapImage ARUBAFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/ARUBA.jpg"));
        #endregion
        #region Austria
        public static int AustriaZoomLevel = 6;
        public static Double AustriaLatitude = 48.2081743;
        public static Double AustriaLongitude = 16.37381890000006;
        public static Location AustriaLocation = new Location(AustriaLatitude, AustriaLongitude);
        public static Uri AustriaAnthem = new Uri(@"ms-appx:/anthems/Austria.mp3");
        public static BitmapImage AustriaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Austria.jpg"));
        #endregion
        #region Australia
        public static int AustraliaZoomLevel = 3;
        public static Double AustraliaLatitude = -35.2819998;
        public static Double AustraliaLongitude = 149.12868430000003;
        public static Location AustraliaLocation = new Location(AustraliaLatitude, AustraliaLongitude);
        public static Uri AustraliaAnthem = new Uri(@"ms-appx:/anthems/Australia.mp3");
        public static BitmapImage AustraliaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Australia.jpg"));
        #endregion
        #region Azerbaijan
        public static int AzerbaijanZoomLevel = 6;
        public static Double AzerbaijanLatitude = 40.4349504;
        public static Double AzerbaijanLongitude = 49.867623200000025;
        public static Location AzerbaijanLocation = new Location(AzerbaijanLatitude, AzerbaijanLongitude);
        public static Uri AzerbaijanAnthem = new Uri(@"ms-appx:/anthems/Azerbaijan.mp3");
        public static BitmapImage AzerbaijanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Azerbaijan.jpg"));
        #endregion
        #region Bahamas
        public static int BahamasZoomLevel = 7;
        public static Double BahamasLatitude = 25.06;
        public static Double BahamasLongitude = -77.34500000000003;
        public static Location BahamasLocation = new Location(BahamasLatitude, BahamasLongitude);
        public static Uri BahamasAnthem = new Uri(@"ms-appx:/anthems/Bahamas.mp3");
        public static BitmapImage BahamasFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bahamas.jpg"));
        #endregion
        #region Bahrain
        public static int BahrainZoomLevel = 7;
        public static Double BahrainLatitude = 26.2166667;
        public static Double BahrainLongitude = 50.58333330000005;
        public static Location BahrainLocation = new Location(BahrainLatitude, BahrainLongitude);
        public static Uri BahrainAnthem = new Uri(@"ms-appx:/anthems/Bahrain.mp3");
        public static BitmapImage BahrainFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bahrain.jpg"));
        #endregion
        #region Bangladesh
        public static int BangladeshZoomLevel = 7;
        public static Double BangladeshLatitude = 23.709921;
        public static Double BangladeshLongitude = 90.40714300000002;
        public static Location BangladeshLocation = new Location(BangladeshLatitude, BangladeshLongitude);
        public static Uri BangladeshAnthem = new Uri(@"ms-appx:/anthems/Bangladesh.mp3");
        public static BitmapImage BangladeshFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bangladesh.jpg"));
        #endregion
        #region Barbados
        public static int BarbadosZoomLevel = 8;
        public static Double BarbadosLatitude = 13.098938;
        public static Double BarbadosLongitude = -59.61335200000002;
        public static Location BarbadosLocation = new Location(BarbadosLatitude, BarbadosLongitude);
        public static Uri BarbadosAnthem = new Uri(@"ms-appx:/anthems/Barbados.mp3");
        public static BitmapImage BarbadosFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Barbados.jpg"));
        #endregion
        #region Belarus
        public static int BelarusZoomLevel = 6;
        public static Double BelarusLatitude = 53.9;
        public static Double BelarusLongitude = 27.56666670000004;
        public static Location BelarusLocation = new Location(BelarusLatitude, BelarusLongitude);
        public static Uri BelarusAnthem = new Uri(@"ms-appx:/anthems/Belarus.mp3");
        public static BitmapImage BelarusFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Belarus.jpg"));
        #endregion
        #region Belgium
        public static int BelgiumZoomLevel = 7;
        public static Double BelgiumLatitude = 50.8503396;
        public static Double BelgiumLongitude = 4.351710300000036;
        public static Location BelgiumLocation = new Location(BelgiumLatitude, BelgiumLongitude);
        public static Uri BelgiumAnthem = new Uri(@"ms-appx:/anthems/Belgium.mp3");
        public static BitmapImage BelgiumFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Belgium.jpg"));
        #endregion
        #region Belize
        public static int BelizeZoomLevel = 7;
        public static Double BelizeLatitude = 17.2513889;
        public static Double BelizeLongitude = -88.7669444;
        public static Location BelizeLocation = new Location(BelizeLatitude, BelizeLongitude);
        public static Uri BelizeAnthem = new Uri(@"ms-appx:/anthems/Belize.mp3");
        public static BitmapImage BelizeFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Belize.jpg"));
        #endregion
        #region Benin
        public static int BeninZoomLevel = 5;
        public static Double BeninLatitude = 6.497222;
        public static Double BeninLongitude = 2.605000000000018;
        public static Location BeninLocation = new Location(BeninLatitude, BeninLongitude);
        public static Uri BeninAnthem = new Uri(@"ms-appx:/anthems/Benin.mp3");
        public static BitmapImage BeninFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Benin.jpg"));
        #endregion
        #region Bermuda
        public static int BermudaZoomLevel = 11;
        public static Double BermudaLatitude = 32.3078;
        public static Double BermudaLongitude = -64.75049999999999;
        public static Location BermudaLocation = new Location(BermudaLatitude, BermudaLongitude);
        public static Uri BermudaAnthem = new Uri(@"ms-appx:/anthems/Bermuda.mp3");
        public static BitmapImage BermudaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bermuda.jpg"));
        #endregion
        #region Bhutan
        public static int BhutanZoomLevel = 9;
        public static Double BhutanLatitude = 27.4666667;
        public static Double BhutanLongitude = 89.64166669999997;
        public static Location BhutanLocation = new Location(BhutanLatitude, BhutanLongitude);
        public static Uri BhutanAnthem = new Uri(@"ms-appx:/anthems/Bhutan.mp3");
        public static BitmapImage BhutanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bhutan.jpg"));
        #endregion
        #region Bolivia
        public static int BoliviaZoomLevel = 5;
        public static Double BoliviaLatitude = -19.042139;
        public static Double BoliviaLongitude = -65.25588199999999;
        public static Location BoliviaLocation = new Location(BoliviaLatitude, BoliviaLongitude);
        public static Uri BoliviaAnthem = new Uri(@"ms-appx:/anthems/Bolivia.mp3");
        public static BitmapImage BoliviaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bolivia.jpg"));
        #endregion
        #region Bosnia_and_Herzegovina
        public static int Bosnia_and_HerzegovinaZoomLevel = 7;
        public static Double Bosnia_and_HerzegovinaLatitude = 43.85;
        public static Double Bosnia_and_HerzegovinaLongitude = 18.25;
        public static Location Bosnia_and_HerzegovinaLocation = new Location(Bosnia_and_HerzegovinaLatitude, Bosnia_and_HerzegovinaLongitude);
        public static Uri Bosnia_and_HerzegovinaAnthem = new Uri(@"ms-appx:/anthems/Bosnia_and_Herzegovina.mp3");
        public static BitmapImage Bosnia_and_HerzegovinaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bosnia_and_Herzegovina.jpg"));
        #endregion
        #region Botswana
        public static int BotswanaZoomLevel = 5;
        public static Double BotswanaLatitude = -24.65411;
        public static Double BotswanaLongitude = 25.90873899999997;
        public static Location BotswanaLocation = new Location(BotswanaLatitude, BotswanaLongitude);
        public static Uri BotswanaAnthem = new Uri(@"ms-appx:/anthems/Botswana.mp3");
        public static BitmapImage BotswanaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Botswana.jpg"));
        #endregion
        #region Brazil
        public static int BrazilZoomLevel = 4;
        public static Double BrazilLatitude = -15.7801482;
        public static Double BrazilLongitude = -47.92916980000001;
        public static Location BrazilLocation = new Location(BrazilLatitude, BrazilLongitude);
        public static Uri BrazilAnthem = new Uri(@"ms-appx:/anthems/Brazil.mp3");
        public static BitmapImage BrazilFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Brazil.jpg"));
        #endregion
        #region Brunei
        public static int BruneiZoomLevel = 7;
        public static Double BruneiLatitude = 4.8902778;
        public static Double BruneiLongitude = 114.94222220000006;
        public static Location BruneiLocation = new Location(BruneiLatitude, BruneiLongitude);
        public static Uri BruneiAnthem = new Uri(@"ms-appx:/anthems/Brunei.mp3");
        public static BitmapImage BruneiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Brunei.jpg"));
        #endregion
        #region Bulgaria
        public static int BulgariaZoomLevel = 5;
        public static Double BulgariaLatitude = 42.6964917;
        public static Double BulgariaLongitude = 23.326010600000018;
        public static Location BulgariaLocation = new Location(BulgariaLatitude, BulgariaLongitude);
        public static Uri BulgariaAnthem = new Uri(@"ms-appx:/anthems/Bulgaria.mp3");
        public static BitmapImage BulgariaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Bulgaria.jpg"));
        #endregion
        #region Burkina_Faso
        public static int Burkina_FasoZoomLevel = 5;
        public static Double Burkina_FasoLatitude = 12.364637;
        public static Double Burkina_FasoLongitude = -1.5338639000000285;
        public static Location Burkina_FasoLocation = new Location(Burkina_FasoLatitude, Burkina_FasoLongitude);
        public static Uri Burkina_FasoAnthem = new Uri(@"ms-appx:/anthems/Burkina_Faso.mp3");
        public static BitmapImage Burkina_FasoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Burkina_Faso.jpg"));
        #endregion
        #region Burundi
        public static int BurundiZoomLevel = 6;
        public static Double BurundiLatitude = -3.376217;
        public static Double BurundiLongitude = 29.359349000000066;
        public static Location BurundiLocation = new Location(BurundiLatitude, BurundiLongitude);
        public static Uri BurundiAnthem = new Uri(@"ms-appx:/anthems/Burundi.mp3");
        public static BitmapImage BurundiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Burundi.jpg"));
        #endregion
        #region Cambodia
        public static int CambodiaZoomLevel = 6;
        public static Double CambodiaLatitude = 11.558831;
        public static Double CambodiaLongitude = 104.91744500000004;
        public static Location CambodiaLocation = new Location(CambodiaLatitude, CambodiaLongitude);
        public static Uri CambodiaAnthem = new Uri(@"ms-appx:/anthems/Cambodia.mp3");
        public static BitmapImage CambodiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Cambodia.jpg"));
        #endregion
        #region Cameroon
        public static int CameroonZoomLevel = 6;
        public static Double CameroonLatitude = 3.866666699999999;
        public static Double CameroonLongitude = 11.516666699999973;
        public static Location CameroonLocation = new Location(CameroonLatitude, CameroonLongitude);
        public static Uri CameroonAnthem = new Uri(@"ms-appx:/anthems/Cameroon.mp3");
        public static BitmapImage CameroonFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Cameroon.jpg"));
        #endregion
        #region Canada
        public static int CanadaZoomLevel = 4;
        public static Double CanadaLatitude = 56.130366;
        public static Double CanadaLongitude = -106.34677099999999;
        public static Location CanadaLocation = new Location(CanadaLatitude, CanadaLongitude);
        public static Uri CanadaAnthem = new Uri(@"ms-appx:/anthems/Canada.mp3");
        public static BitmapImage CanadaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Canada.jpg"));
        #endregion
        #region Cape_Verde
        public static int Cape_VerdeZoomLevel = 7;
        public static Double Cape_VerdeLatitude = 14.930464;
        public static Double Cape_VerdeLongitude = -23.51266899999996;
        public static Location Cape_VerdeLocation = new Location(Cape_VerdeLatitude, Cape_VerdeLongitude);
        public static Uri Cape_VerdeAnthem = new Uri(@"ms-appx:/anthems/Cape_Verde.mp3");
        public static BitmapImage Cape_VerdeFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Cape_Verde.jpg"));
        #endregion
        #region Central_African_Republic
        public static int Central_African_RepublicZoomLevel = 6;
        public static Double Central_African_RepublicLatitude = 4.361698;
        public static Double Central_African_RepublicLongitude = 18.55597499999999;
        public static Location Central_African_RepublicLocation = new Location(Central_African_RepublicLatitude, Central_African_RepublicLongitude);
        public static Uri Central_African_RepublicAnthem = new Uri(@"ms-appx:/anthems/Central_African_Republic.mp3");
        public static BitmapImage Central_African_RepublicFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Central_African_Republic.jpg"));
        #endregion
        #region Chad
        public static int ChadZoomLevel = 5;
        public static Double ChadLatitude = 12.104797;
        public static Double ChadLongitude = 15.044505999999956;
        public static Location ChadLocation = new Location(ChadLatitude, ChadLongitude);
        public static Uri ChadAnthem = new Uri(@"ms-appx:/anthems/Chad.mp3");
        public static BitmapImage ChadFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Chad.jpg"));
        #endregion
        #region Chile
        public static int ChileZoomLevel = 5;
        public static Double ChileLatitude = -33.4691199;
        public static Double ChileLongitude = -70.641997;
        public static Location ChileLocation = new Location(ChileLatitude, ChileLongitude);
        public static Uri ChileAnthem = new Uri(@"ms-appx:/anthems/Chile.mp3");
        public static BitmapImage ChileFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Chile.jpg"));
        #endregion
        #region Colombia
        public static int ColombiaZoomLevel = 5;
        public static Double ColombiaLatitude = 4.598056000000001;
        public static Double ColombiaLongitude = -74.07583299999999;
        public static Location ColombiaLocation = new Location(ColombiaLatitude, ColombiaLongitude);
        public static Uri ColombiaAnthem = new Uri(@"ms-appx:/anthems/Colombia.mp3");
        public static BitmapImage ColombiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Colombia.jpg"));
        #endregion
        #region Comoros
        public static int ComorosZoomLevel = 7;
        public static Double ComorosLatitude = -11.7012319;
        public static Double ComorosLongitude = 43.252927;
        public static Location ComorosLocation = new Location(ComorosLatitude, ComorosLongitude);
        public static Uri ComorosAnthem = new Uri(@"ms-appx:/anthems/Comoros.mp3");
        public static BitmapImage ComorosFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Comoros.jpg"));
        #endregion
        #region Congo
        public static int CongoZoomLevel = 5;
        public static Double CongoLatitude = -4.320836;
        public static Double CongoLongitude = 15.29866000000004;
        public static Location CongoLocation = new Location(CongoLatitude, CongoLongitude);
        public static Uri CongoAnthem = new Uri(@"ms-appx:/anthems/Congo.mp3");
        public static BitmapImage CongoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Congo.jpg"));
        #endregion
        #region Costa_Rica
        public static int Costa_RicaZoomLevel = 5;
        public static Double Costa_RicaLatitude = 9.748916999999998;
        public static Double Costa_RicaLongitude = -83.75342799999998;
        public static Location Costa_RicaLocation = new Location(Costa_RicaLatitude, Costa_RicaLongitude);
        public static Uri Costa_RicaAnthem = new Uri(@"ms-appx:/anthems/Costa_Rica.mp3");
        public static BitmapImage Costa_RicaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Costa_Rica.jpg"));
        #endregion
        #region China
        public static int ChinaZoomLevel = 4;
        public static Double ChinaLatitude = 39.90403;
        public static Double ChinaLongitude = 116.40752599999996;
        public static Location ChinaLocation = new Location(ChinaLatitude, ChinaLongitude);
        public static Uri ChinaAnthem = new Uri(@"ms-appx:/anthems/China.mp3");
        public static BitmapImage ChinaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/China.jpg"));
        #endregion
        #region Côte_d_Ivoire
        public static int Côte_d_IvoireZoomLevel = 4;
        public static Double Côte_d_IvoireLatitude = 6.8166667;
        public static Double Côte_d_IvoireLongitude = -5.283333299999981;
        public static Location Côte_d_IvoireLocation = new Location(Côte_d_IvoireLatitude, Côte_d_IvoireLongitude);
        public static Uri Côte_d_IvoireAnthem = new Uri(@"ms-appx:/anthems/Côte_d_Ivoire.mp3");
        public static BitmapImage Côte_d_IvoireFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Côte_d_Ivoire.jpg"));
        #endregion
        #region Croatia
        public static int CroatiaZoomLevel = 6;
        public static Double CroatiaLatitude = 45.814912;
        public static Double CroatiaLongitude = 15.97851449999996;
        public static Location CroatiaLocation = new Location(CroatiaLatitude, CroatiaLongitude);
        public static Uri CroatiaAnthem = new Uri(@"ms-appx:/anthems/Croatia.mp3");
        public static BitmapImage CroatiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Croatia.jpg"));
        #endregion
        #region Cuba
        public static int CubaZoomLevel = 6;
        public static Double CubaLatitude = 23.1168;
        public static Double CubaLongitude = -82.38855699999999;
        public static Location CubaLocation = new Location(CubaLatitude, CubaLongitude);
        public static Uri CubaAnthem = new Uri(@"ms-appx:/anthems/Cuba.mp3");
        public static BitmapImage CubaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Cuba.jpg"));
        #endregion
        #region Cyprus
        public static int CyprusZoomLevel = 7;
        public static Double CyprusLatitude = 35.1666667;
        public static Double CyprusLongitude = 33.366666699999996;
        public static Location CyprusLocation = new Location(CyprusLatitude, CyprusLongitude);
        public static Uri CyprusAnthem = new Uri(@"ms-appx:/anthems/Cyprus.mp3");
        public static BitmapImage CyprusFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Cyprus.jpg"));
        #endregion
        #region Czech_Republic
        public static int Czech_RepublicZoomLevel = 6;
        public static Double Czech_RepublicLatitude = 50.0878114;
        public static Double Czech_RepublicLongitude = 14.420459800000003;
        public static Location Czech_RepublicLocation = new Location(Czech_RepublicLatitude, Czech_RepublicLongitude);
        public static Uri Czech_RepublicAnthem = new Uri(@"ms-appx:/anthems/Czech_Republic.mp3");
        public static BitmapImage Czech_RepublicFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Czech_Republic.jpg"));
        #endregion
        #region Denmark
        public static int DenmarkZoomLevel = 5;
        public static Double DenmarkLatitude = 55.6760968;
        public static Double DenmarkLongitude = 12.568337100000008;
        public static Location DenmarkLocation = new Location(DenmarkLatitude, DenmarkLongitude);
        public static Uri DenmarkAnthem = new Uri(@"ms-appx:/anthems/Denmark.mp3");
        public static BitmapImage DenmarkFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Denmark.jpg"));
        #endregion
        #region Djibouti
        public static int DjiboutiZoomLevel = 6;
        public static Double DjiboutiLatitude = 11.825138;
        public static Double DjiboutiLongitude = 42.59027500000002;
        public static Location DjiboutiLocation = new Location(DjiboutiLatitude, DjiboutiLongitude);
        public static Uri DjiboutiAnthem = new Uri(@"ms-appx:/anthems/Djibouti.mp3");
        public static BitmapImage DjiboutiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Djibouti.jpg"));
        #endregion
        #region Dominica
        public static int DominicaZoomLevel = 8;
        public static Double DominicaLatitude = 15.301389;
        public static Double DominicaLongitude = -61.38833299999999;
        public static Location DominicaLocation = new Location(DominicaLatitude, DominicaLongitude);
        public static Uri DominicaAnthem = new Uri(@"ms-appx:/anthems/Dominica.mp3");
        public static BitmapImage DominicaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Dominica.jpg"));
        #endregion
        #region Dominican_Republic
        public static int Dominican_RepublicZoomLevel = 8;
        public static Double Dominican_RepublicLatitude = 18.5;
        public static Double Dominican_RepublicLongitude = -69.98333330000002;
        public static Location Dominican_RepublicLocation = new Location(Dominican_RepublicLatitude, Dominican_RepublicLongitude);
        public static Uri Dominican_RepublicAnthem = new Uri(@"ms-appx:/anthems/Dominican_Republic.mp3");
        public static BitmapImage Dominican_RepublicFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Dominican_Republic.jpg"));
        #endregion
        #region East_Timor
        public static int East_TimorZoomLevel = 8;
        public static Double East_TimorLatitude = -8.549999999999999;
        public static Double East_TimorLongitude = 125.56666700000005;
        public static Location East_TimorLocation = new Location(East_TimorLatitude, East_TimorLongitude);
        public static Uri East_TimorAnthem = new Uri(@"ms-appx:/anthems/East_Timor.mp3");
        public static BitmapImage East_TimorFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/East_Timor.jpg"));
        #endregion
        #region Ecuador
        public static int EcuadorZoomLevel = 5;
        public static Double EcuadorLatitude = -0.2166667;
        public static Double EcuadorLongitude = -78.51666670000003;
        public static Location EcuadorLocation = new Location(EcuadorLatitude, EcuadorLongitude);
        public static Uri EcuadorAnthem = new Uri(@"ms-appx:/anthems/Ecuador.mp3");
        public static BitmapImage EcuadorFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Ecuador.jpg"));
        #endregion
        #region Egypt
        public static int EgyptZoomLevel = 5;
        public static Double EgyptLatitude = 30.0444196;
        public static Double EgyptLongitude = 31.23571160000006;
        public static Location EgyptLocation = new Location(EgyptLatitude, EgyptLongitude);
        public static Uri EgyptAnthem = new Uri(@"ms-appx:/anthems/Egypt.mp3");
        public static BitmapImage EgyptFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Egypt.jpg"));
        #endregion
        #region El_Salvador
        public static int El_SalvadorZoomLevel = 7;
        public static Double El_SalvadorLatitude = 13.731000000000000000;
        public static Double El_SalvadorLongitude = -89.161;
        public static Location El_SalvadorLocation = new Location(El_SalvadorLatitude, El_SalvadorLongitude);
        public static Uri El_SalvadorAnthem = new Uri(@"ms-appx:/anthems/El_Salvador.mp3");
        public static BitmapImage El_SalvadorFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/El_Salvador.jpg"));
        #endregion
        #region Equatorial_Guinea
        public static int Equatorial_GuineaZoomLevel = 7;
        public static Double Equatorial_GuineaLatitude = 1.650801;
        public static Double Equatorial_GuineaLongitude = 10.267894999999953;
        public static Location Equatorial_GuineaLocation = new Location(Equatorial_GuineaLatitude, Equatorial_GuineaLongitude);
        public static Uri Equatorial_GuineaAnthem = new Uri(@"ms-appx:/anthems/Equatorial_Guinea.mp3");
        public static BitmapImage Equatorial_GuineaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Equatorial_Guinea.jpg"));
        #endregion
        #region Eritrea
        public static int EritreaZoomLevel = 6;
        public static Double EritreaLatitude = 15.33236;
        public static Double EritreaLongitude = 38.926169999999956;
        public static Location EritreaLocation = new Location(EritreaLatitude, EritreaLongitude);
        public static Uri EritreaAnthem = new Uri(@"ms-appx:/anthems/Eritrea.mp3");
        public static BitmapImage EritreaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Eritrea.jpg"));
        #endregion
        #region Estonia
        public static int EstoniaZoomLevel = 6;
        public static Double EstoniaLatitude = 59.4426896;
        public static Double EstoniaLongitude = 24.75319719999993;
        public static Location EstoniaLocation = new Location(EstoniaLatitude, EstoniaLongitude);
        public static Uri EstoniaAnthem = new Uri(@"ms-appx:/anthems/Estonia.mp3");
        public static BitmapImage EstoniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Estonia.jpg"));
        #endregion
        #region Ethiopia
        public static int EthiopiaZoomLevel = 5;
        public static Double EthiopiaLatitude = 9.022736;
        public static Double EthiopiaLongitude = 38.74679900000001;
        public static Location EthiopiaLocation = new Location(EthiopiaLatitude, EthiopiaLongitude);
        public static Uri EthiopiaAnthem = new Uri(@"ms-appx:/anthems/Ethiopia.mp3");
        public static BitmapImage EthiopiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Ethiopia.jpg"));
        #endregion
        #region Federated_States_of_Micronesia
        public static int Federated_States_of_MicronesiaZoomLevel = 7;
        public static Double Federated_States_of_MicronesiaLatitude = 6.9147118;
        public static Double Federated_States_of_MicronesiaLongitude = 158.16102739999997;
        public static Location Federated_States_of_MicronesiaLocation = new Location(Federated_States_of_MicronesiaLatitude, Federated_States_of_MicronesiaLongitude);
        public static Uri Federated_States_of_MicronesiaAnthem = new Uri(@"ms-appx:/anthems/Federated_States_of_Micronesia.mp3");
        public static BitmapImage Federated_States_of_MicronesiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Federated_States_of_Micronesia.jpg"));
        #endregion
        #region Finland
        public static int FinlandZoomLevel = 5;
        public static Double FinlandLatitude = 60.1726668;
        public static Double FinlandLongitude = 24.93200879999995;
        public static Location FinlandLocation = new Location(FinlandLatitude, FinlandLongitude);
        public static Uri FinlandAnthem = new Uri(@"ms-appx:/anthems/Finland.mp3");
        public static BitmapImage FinlandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Finland.jpg"));
        #endregion
        #region Fiji
        public static int FijiZoomLevel = 7;
        public static Double FijiLatitude = -18.1416;
        public static Double FijiLongitude = 178.44190000000003;
        public static Location FijiLocation = new Location(FijiLatitude, FijiLongitude);
        public static Uri FijiAnthem = new Uri(@"ms-appx:/anthems/Fiji.mp3");
        public static BitmapImage FijiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Fiji.jpg"));
        #endregion
        #region France
        public static int FranceZoomLevel = 5;
        public static Double FranceLatitude = 48.856614;
        public static Double FranceLongitude = 2.3522219000000177;
        public static Location FranceLocation = new Location(FranceLatitude, FranceLongitude);
        public static Uri FranceAnthem = new Uri(@"ms-appx:/anthems/France.mp3");
        public static BitmapImage FranceFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/France.jpg"));
        #endregion
        #region Gabon
        public static int GabonZoomLevel = 5;
        public static Double GabonLatitude = 0.390841;
        public static Double GabonLongitude = 9.45364399999994;
        public static Location GabonLocation = new Location(GabonLatitude, GabonLongitude);
        public static Uri GabonAnthem = new Uri(@"ms-appx:/anthems/Gabon.mp3");
        public static BitmapImage GabonFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Gabon.jpg"));
        #endregion
        #region Gambia
        public static int GambiaZoomLevel = 7;
        public static Double GambiaLatitude = 13.4530556;
        public static Double GambiaLongitude = -16.577499999999986;
        public static Location GambiaLocation = new Location(GambiaLatitude, GambiaLongitude);
        public static Uri GambiaAnthem = new Uri(@"ms-appx:/anthems/Gambia.mp3");
        public static BitmapImage GambiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Gambia.jpg"));
        #endregion
        #region Georgia
        public static int GeorgiaZoomLevel = 7;
        public static Double GeorgiaLatitude = 41.709981;
        public static Double GeorgiaLongitude = 44.79299844;
        public static Location GeorgiaLocation = new Location(GeorgiaLatitude, GeorgiaLongitude);
        public static Uri GeorgiaAnthem = new Uri(@"ms-appx:/anthems/Georgia.mp3");
        public static BitmapImage GeorgiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Georgia.jpg"));
        #endregion
        #region Germany
        public static int GermanyZoomLevel = 5;
        public static Double GermanyLatitude = 52.524268;
        public static Double GermanyLongitude = 13.406290000000012;
        public static Location GermanyLocation = new Location(GermanyLatitude, GermanyLongitude);
        public static Uri GermanyAnthem = new Uri(@"ms-appx:/anthems/Germany.mp3");
        public static BitmapImage GermanyFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Germany.jpg"));
        #endregion
        #region Ghana
        public static int GhanaZoomLevel = 5;
        public static Double GhanaLatitude = 5.5557169;
        public static Double GhanaLongitude = -0.1963060000000496;
        public static Location GhanaLocation = new Location(GhanaLatitude, GhanaLongitude);
        public static Uri GhanaAnthem = new Uri(@"ms-appx:/anthems/Ghana.mp3");
        public static BitmapImage GhanaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Ghana.jpg"));
        #endregion
        #region Greece
        public static int GreeceZoomLevel = 5;
        public static Double GreeceLatitude = 37.9753357;
        public static Double GreeceLongitude = 23.736149699999940;
        public static Location GreeceLocation = new Location(GreeceLatitude, GreeceLongitude);
        public static Uri GreeceAnthem = new Uri(@"ms-appx:/anthems/Greece.mp3");
        public static BitmapImage GreeceFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Greece.jpg"));
        #endregion
        #region Grenada
        public static int GrenadaZoomLevel = 8;
        public static Double GrenadaLatitude = 12.1165;
        public static Double GrenadaLongitude = -61.678999999999974;
        public static Location GrenadaLocation = new Location(GrenadaLatitude, GrenadaLongitude);
        public static Uri GrenadaAnthem = new Uri(@"ms-appx:/anthems/Grenada.mp3");
        public static BitmapImage GrenadaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Grenada.jpg"));
        #endregion
        #region Guatemala
        public static int GuatemalaZoomLevel = 7;
        public static Double GuatemalaLatitude = 14.624795;
        public static Double GuatemalaLongitude = -90.53281800000002;
        public static Location GuatemalaLocation = new Location(GuatemalaLatitude, GuatemalaLongitude);
        public static Uri GuatemalaAnthem = new Uri(@"ms-appx:/anthems/Guatemala.mp3");
        public static BitmapImage GuatemalaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Guatemala.jpg"));
        #endregion
        #region Guinea
        public static int GuineaZoomLevel = 7;
        public static Double GuineaLatitude = 9.537029;
        public static Double GuineaLongitude = -13.678470000000061;
        public static Location GuineaLocation = new Location(GuineaLatitude, GuineaLongitude);
        public static Uri GuineaAnthem = new Uri(@"ms-appx:/anthems/Guinea.mp3");
        public static BitmapImage GuineaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Guinea.jpg"));
        #endregion
        #region Guinea_Bissau
        public static int Guinea_BissauZoomLevel = 7;
        public static Double Guinea_BissauLatitude = 11.803749;
        public static Double Guinea_BissauLongitude = -15.180413000000044;
        public static Location Guinea_BissauLocation = new Location(Guinea_BissauLatitude, Guinea_BissauLongitude);
        public static Uri Guinea_BissauAnthem = new Uri(@"ms-appx:/anthems/Guinea_Bissau.mp3");
        public static BitmapImage Guinea_BissauFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Guinea_Bissau.jpg"));
        #endregion
        #region Guyana
        public static int GuyanaZoomLevel = 7;
        public static Double GuyanaLatitude = 4.860416;
        public static Double GuyanaLongitude = -58.93018000000001;
        public static Location GuyanaLocation = new Location(GuyanaLatitude, GuyanaLongitude);
        public static Uri GuyanaAnthem = new Uri(@"ms-appx:/anthems/Guyana.mp3");
        public static BitmapImage GuyanaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Guyana.jpg"));
        #endregion
        #region Haiti
        public static int HaitiZoomLevel = 7;
        public static Double HaitiLatitude = 18.971187;
        public static Double HaitiLongitude = -72.285215;
        public static Location HaitiLocation = new Location(HaitiLatitude, HaitiLongitude);
        public static Uri HaitiAnthem = new Uri(@"ms-appx:/anthems/Haiti.mp3");
        public static BitmapImage HaitiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Haiti.jpg"));
        #endregion
        #region Honduras
        public static int HondurasZoomLevel = 7;
        public static Double HondurasLatitude = 14.083300;
        public static Double HondurasLongitude = -87.216700;
        public static Location HondurasLocation = new Location(HondurasLatitude, HondurasLongitude);
        public static Uri HondurasAnthem = new Uri(@"ms-appx:/anthems/Honduras.mp3");
        public static BitmapImage HondurasFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Honduras.jpg"));
        #endregion
        #region Hungary
        public static int HungaryZoomLevel = 7;
        public static Double HungaryLatitude = 47.497912;
        public static Double HungaryLongitude = 19.040235;
        public static Location HungaryLocation = new Location(HungaryLatitude, HungaryLongitude);
        public static Uri HungaryAnthem = new Uri(@"ms-appx:/anthems/Hungary.mp3");
        public static BitmapImage HungaryFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Hungary.jpg"));
        #endregion
        #region Iceland
        public static int IcelandZoomLevel = 7;
        public static Double IcelandLatitude = 64.133333;
        public static Double IcelandLongitude = -21.933333;
        public static Location IcelandLocation = new Location(IcelandLatitude, IcelandLongitude);
        public static Uri IcelandAnthem = new Uri(@"ms-appx:/anthems/Iceland.mp3");
        public static BitmapImage IcelandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Iceland.jpg"));
        #endregion
        #region India
        public static int IndiaZoomLevel = 4;
        public static Double IndiaLatitude = 28.613939;
        public static Double IndiaLongitude = 77.209021;
        public static Location IndiaLocation = new Location(IndiaLatitude, IndiaLongitude);
        public static Uri IndiaAnthem = new Uri(@"ms-appx:/anthems/India.mp3");
        public static BitmapImage IndiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/India.jpg"));
        #endregion
        #region Indonesia
        public static int IndonesiaZoomLevel = 4;
        public static Double IndonesiaLatitude = -6.208763;
        public static Double IndonesiaLongitude = 106.845599;
        public static Location IndonesiaLocation = new Location(IndonesiaLatitude, IndonesiaLongitude);
        public static Uri IndonesiaAnthem = new Uri(@"ms-appx:/anthems/Indonesia.mp3");
        public static BitmapImage IndonesiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Indonesia.jpg"));
        #endregion
        #region Iran
        public static int IranZoomLevel = 5;
        public static Double IranLatitude = 35.696111;
        public static Double IranLongitude = 51.423056;
        public static Location IranLocation = new Location(IranLatitude, IranLongitude);
        public static Uri IranAnthem = new Uri(@"ms-appx:/anthems/Iran.mp3");
        public static BitmapImage IranFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Iran.jpg"));
        #endregion
        #region Iraq
        public static int IraqZoomLevel = 6;
        public static Double IraqLatitude = 33.325000;
        public static Double IraqLongitude = 44.422000;
        public static Location IraqLocation = new Location(IraqLatitude, IraqLongitude);
        public static Uri IraqAnthem = new Uri(@"ms-appx:/anthems/Iraq.mp3");
        public static BitmapImage IraqFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Iraq.jpg"));
        #endregion
        #region Ireland
        public static int IrelandZoomLevel = 5;
        public static Double IrelandLatitude = 53.349805;
        public static Double IrelandLongitude = -6.260310;
        public static Location IrelandLocation = new Location(IrelandLatitude, IrelandLongitude);
        public static Uri IrelandAnthem = new Uri(@"ms-appx:/anthems/Ireland.mp3");
        public static BitmapImage IrelandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Ireland.jpg"));
        #endregion
        #region Israel
        public static int IsraelZoomLevel = 7;
        public static Double IsraelLatitude = 31.768319;
        public static Double IsraelLongitude = 35.213710;
        public static Location IsraelLocation = new Location(IsraelLatitude, IsraelLongitude);
        public static Uri IsraelAnthem = new Uri(@"ms-appx:/anthems/Israel.mp3");
        public static BitmapImage IsraelFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Israel.jpg"));
        #endregion
        #region Italy
        public static int ItalyZoomLevel = 5;
        public static Double ItalyLatitude = 41.902783;
        public static Double ItalyLongitude = 12.496366;
        public static Location ItalyLocation = new Location(ItalyLatitude, ItalyLongitude);
        public static Uri ItalyAnthem = new Uri(@"ms-appx:/anthems/Italy.mp3");
        public static BitmapImage ItalyFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Italy.jpg"));
        #endregion
        #region Jamaica
        public static int JamaicaZoomLevel = 5;
        public static Double JamaicaLatitude = 18.109581;
        public static Double JamaicaLongitude = -77.297508;
        public static Location JamaicaLocation = new Location(JamaicaLatitude, JamaicaLongitude);
        public static Uri JamaicaAnthem = new Uri(@"ms-appx:/anthems/Jamaica.mp3");
        public static BitmapImage JamaicaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Jamaica.jpg"));
        #endregion
        #region Japan
        public static int JapanZoomLevel = 5;
        public static Double JapanLatitude = 35.689487;
        public static Double JapanLongitude = 139.691706;
        public static Location JapanLocation = new Location(JapanLatitude, JapanLongitude);
        public static Uri JapanAnthem = new Uri(@"ms-appx:/anthems/Japan.mp3");
        public static BitmapImage JapanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Japan.jpg"));
        #endregion
        #region Jordan
        public static int JordanZoomLevel = 7;
        public static Double JordanLatitude = 31.956578;
        public static Double JordanLongitude = 35.945695;
        public static Location JordanLocation = new Location(JordanLatitude, JordanLongitude);
        public static Uri JordanAnthem = new Uri(@"ms-appx:/anthems/Jordan.mp3");
        public static BitmapImage JordanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Jordan.jpg"));
        #endregion
        #region Kazakhstan
        public static int KazakhstanZoomLevel = 4;
        public static Double KazakhstanLatitude = 51.160523;
        public static Double KazakhstanLongitude = 71.470356;
        public static Location KazakhstanLocation = new Location(KazakhstanLatitude, KazakhstanLongitude);
        public static Uri KazakhstanAnthem = new Uri(@"ms-appx:/anthems/Kazakhstan.mp3");
        public static BitmapImage KazakhstanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kazakhstan.jpg"));
        #endregion
        #region Kenya
        public static int KenyaZoomLevel = 6;
        public static Double KenyaLatitude = -1.292066;
        public static Double KenyaLongitude = 36.821946;
        public static Location KenyaLocation = new Location(KenyaLatitude, KenyaLongitude);
        public static Uri KenyaAnthem = new Uri(@"ms-appx:/anthems/Kenya.mp3");
        public static BitmapImage KenyaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kenya.jpg"));
        #endregion
        #region Kiribati
        public static int KiribatiZoomLevel = 7;
        public static Double KiribatiLatitude = 1.870918;
        public static Double KiribatiLongitude = -157.362601;
        public static Location KiribatiLocation = new Location(KiribatiLatitude, KiribatiLongitude);
        public static Uri KiribatiAnthem = new Uri(@"ms-appx:/anthems/Kiribati.mp3");
        public static BitmapImage KiribatiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kiribati.jpg"));
        #endregion
        #region Korea_North
        public static int Korea_NorthZoomLevel = 7;
        public static Double Korea_NorthLatitude = 39.039219;
        public static Double Korea_NorthLongitude = 125.762524;
        public static Location Korea_NorthLocation = new Location(Korea_NorthLatitude, Korea_NorthLongitude);
        public static Uri Korea_NorthAnthem = new Uri(@"ms-appx:/anthems/Korea_North.mp3");
        public static BitmapImage Korea_NorthFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Korea_North.jpg"));
        #endregion
        #region Korea_South
        public static int Korea_SouthZoomLevel = 7;
        public static Double Korea_SouthLatitude = 37.566535;
        public static Double Korea_SouthLongitude = 126.977969;
        public static Location Korea_SouthLocation = new Location(Korea_SouthLatitude, Korea_SouthLongitude);
        public static Uri Korea_SouthAnthem = new Uri(@"ms-appx:/anthems/Korea_South.mp3");
        public static BitmapImage Korea_SouthFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Korea_South.jpg"));
        #endregion
        #region Kosovo
        public static int KosovoZoomLevel = 7;
        public static Double KosovoLatitude = 42.662914;
        public static Double KosovoLongitude = 21.165503;
        public static Location KosovoLocation = new Location(KosovoLatitude, KosovoLongitude);
        public static Uri KosovoAnthem = new Uri(@"ms-appx:/anthems/Kosovo.mp3");
        public static BitmapImage KosovoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kosovo.jpg"));
        #endregion
        #region Kuwait
        public static int KuwaitZoomLevel = 7;
        public static Double KuwaitLatitude = 29.375859;
        public static Double KuwaitLongitude = 47.977405;
        public static Location KuwaitLocation = new Location(KuwaitLatitude, KuwaitLongitude);
        public static Uri KuwaitAnthem = new Uri(@"ms-appx:/anthems/Kuwait.mp3");
        public static BitmapImage KuwaitFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kuwait.jpg"));
        #endregion
        #region Kyrgyzstan
        public static int KyrgyzstanZoomLevel = 5;
        public static Double KyrgyzstanLatitude = 42.874722;
        public static Double KyrgyzstanLongitude = 74.612222;
        public static Location KyrgyzstanLocation = new Location(KyrgyzstanLatitude, KyrgyzstanLongitude);
        public static Uri KyrgyzstanAnthem = new Uri(@"ms-appx:/anthems/Kyrgyzstan.mp3");
        public static BitmapImage KyrgyzstanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Kyrgyzstan.jpg"));
        #endregion
        #region Laos
        public static int LaosZoomLevel = 5;
        public static Double LaosLatitude = 17.966667;
        public static Double LaosLongitude = 102.600000;
        public static Location LaosLocation = new Location(LaosLatitude, LaosLongitude);
        public static Uri LaosAnthem = new Uri(@"ms-appx:/anthems/Laos.mp3");
        public static BitmapImage LaosFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Laos.jpg"));
        #endregion
        #region Latvia
        public static int LatviaZoomLevel = 6;
        public static Double LatviaLatitude = 56.949649;
        public static Double LatviaLongitude = 24.105186;
        public static Location LatviaLocation = new Location(LatviaLatitude, LatviaLongitude);
        public static Uri LatviaAnthem = new Uri(@"ms-appx:/anthems/Latvia.mp3");
        public static BitmapImage LatviaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Latvia.jpg"));
        #endregion
        #region Lebanon
        public static int LebanonZoomLevel = 7;
        public static Double LebanonLatitude = 33.888629;
        public static Double LebanonLongitude = 35.495479;
        public static Location LebanonLocation = new Location(LebanonLatitude, LebanonLongitude);
        public static Uri LebanonAnthem = new Uri(@"ms-appx:/anthems/Lebanon.mp3");
        public static BitmapImage LebanonFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Lebanon.jpg"));
        #endregion
        #region Lesotho
        public static int LesothoZoomLevel = 7;
        public static Double LesothoLatitude = -29.310000;
        public static Double LesothoLongitude = 27.480000;
        public static Location LesothoLocation = new Location(LesothoLatitude, LesothoLongitude);
        public static Uri LesothoAnthem = new Uri(@"ms-appx:/anthems/Lesotho.mp3");
        public static BitmapImage LesothoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Lesotho.jpg"));
        #endregion
        #region Liberia
        public static int LiberiaZoomLevel = 7;
        public static Double LiberiaLatitude = 6.313333;
        public static Double LiberiaLongitude = -10.801389;
        public static Location LiberiaLocation = new Location(LiberiaLatitude, LiberiaLongitude);
        public static Uri LiberiaAnthem = new Uri(@"ms-appx:/anthems/Liberia.mp3");
        public static BitmapImage LiberiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Liberia.jpg"));
        #endregion
        #region Libya
        public static int LibyaZoomLevel = 7;
        public static Double LibyaLatitude = 32.887209;
        public static Double LibyaLongitude = 13.191338;
        public static Location LibyaLocation = new Location(LibyaLatitude, LibyaLongitude);
        public static Uri LibyaAnthem = new Uri(@"ms-appx:/anthems/Libya.mp3");
        public static BitmapImage LibyaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Libya.jpg"));
        #endregion
        #region Liechtenstein
        public static int LiechtensteinZoomLevel = 7;
        public static Double LiechtensteinLatitude = 47.166000;
        public static Double LiechtensteinLongitude = 9.555373;
        public static Location LiechtensteinLocation = new Location(LiechtensteinLatitude, LiechtensteinLongitude);
        public static Uri LiechtensteinAnthem = new Uri(@"ms-appx:/anthems/Liechtenstein.mp3");
        public static BitmapImage LiechtensteinFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Liechtenstein.jpg"));
        #endregion
        #region Lithuania
        public static int LithuaniaZoomLevel = 7;
        public static Double LithuaniaLatitude = 54.687156;
        public static Double LithuaniaLongitude = 25.279651;
        public static Location LithuaniaLocation = new Location(LithuaniaLatitude, LithuaniaLongitude);
        public static Uri LithuaniaAnthem = new Uri(@"ms-appx:/anthems/Lithuania.mp3");
        public static BitmapImage LithuaniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Lithuania.jpg"));
        #endregion
        #region Luxembourg
        public static int LuxembourgZoomLevel = 7;
        public static Double LuxembourgLatitude = 49.815273;
        public static Double LuxembourgLongitude = 6.129583;
        public static Location LuxembourgLocation = new Location(LuxembourgLatitude, LuxembourgLongitude);
        public static Uri LuxembourgAnthem = new Uri(@"ms-appx:/anthems/Luxembourg.mp3");
        public static BitmapImage LuxembourgFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Luxembourg.jpg"));
        #endregion
        #region Macedonia
        public static int MacedoniaZoomLevel = 7;
        public static Double MacedoniaLatitude = 41.997346;
        public static Double MacedoniaLongitude = 21.427996;
        public static Location MacedoniaLocation = new Location(MacedoniaLatitude, MacedoniaLongitude);
        public static Uri MacedoniaAnthem = new Uri(@"ms-appx:/anthems/Macedonia.mp3");
        public static BitmapImage MacedoniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Macedonia.jpg"));
        #endregion
        #region  Madagascar
        public static int MadagascarZoomLevel = 6;
        public static Double MadagascarLatitude = -18.933333;
        public static Double MadagascarLongitude = 47.516667;
        public static Location MadagascarLocation = new Location(MadagascarLatitude, MadagascarLongitude);
        public static Uri MadagascarAnthem = new Uri(@"ms-appx:/anthems/Madagascar.mp3");
        public static BitmapImage MadagascarFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Madagascar.jpg"));
        #endregion
        #region Malawi
        public static int MalawiZoomLevel = 6;
        public static Double MalawiLatitude = -13.983333;
        public static Double MalawiLongitude = 33.783333;
        public static Location MalawiLocation = new Location(MalawiLatitude, MalawiLongitude);
        public static Uri MalawiAnthem = new Uri(@"ms-appx:/anthems/Malawi.mp3");
        public static BitmapImage MalawiFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Malawi.jpg"));
        #endregion
        #region Malaysia
        public static int MalaysiaZoomLevel = 6;
        public static Double MalaysiaLatitude = 3.139003;
        public static Double MalaysiaLongitude = 101.686855;
        public static Location MalaysiaLocation = new Location(MalaysiaLatitude, MalaysiaLongitude);
        public static Uri MalaysiaAnthem = new Uri(@"ms-appx:/anthems/Malaysia.mp3");
        public static BitmapImage MalaysiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Malaysia.jpg"));
        #endregion
        #region Maldives
        public static int MaldivesZoomLevel = 6;
        public static Double MaldivesLatitude = 4.175496;
        public static Double MaldivesLongitude = 73.509347;
        public static Location MaldivesLocation = new Location(MaldivesLatitude, MaldivesLongitude);
        public static Uri MaldivesAnthem = new Uri(@"ms-appx:/anthems/Maldives.mp3");
        public static BitmapImage MaldivesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Maldives.jpg"));
        #endregion
        #region Mali
        public static int MaliZoomLevel = 5;
        public static Double MaliLatitude = 12.650000;
        public static Double MaliLongitude = -8.000000;
        public static Location MaliLocation = new Location(MaliLatitude, MaliLongitude);
        public static Uri MaliAnthem = new Uri(@"ms-appx:/anthems/Mali.mp3");
        public static BitmapImage MaliFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mali.jpg"));
        #endregion
        #region Malta
        public static int MaltaZoomLevel = 7;
        public static Double MaltaLatitude = 35.898908;
        public static Double MaltaLongitude = 14.514553;
        public static Location MaltaLocation = new Location(MaltaLatitude, MaltaLongitude);
        public static Uri MaltaAnthem = new Uri(@"ms-appx:/anthems/Malta.mp3");
        public static BitmapImage MaltaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Malta.jpg"));
        #endregion
        #region Marshall_Islands
        public static int Marshall_IslandsZoomLevel = 7;
        public static Double Marshall_IslandsLatitude = 7.116421;
        public static Double Marshall_IslandsLongitude = 171.185774;
        public static Location Marshall_IslandsLocation = new Location(Marshall_IslandsLatitude, Marshall_IslandsLongitude);
        public static Uri Marshall_IslandsAnthem = new Uri(@"ms-appx:/anthems/Marshall_Islands.mp3");
        public static BitmapImage Marshall_IslandsFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Marshall_Islands.jpg"));
        #endregion
        #region Mauritania
        public static int MauritaniaZoomLevel = 5;
        public static Double MauritaniaLatitude = 18.100000;
        public static Double MauritaniaLongitude = -15.950000;
        public static Location MauritaniaLocation = new Location(MauritaniaLatitude, MauritaniaLongitude);
        public static Uri MauritaniaAnthem = new Uri(@"ms-appx:/anthems/Mauritania.mp3");
        public static BitmapImage MauritaniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mauritania.jpg"));
        #endregion
        #region Mauritius
        public static int MauritiusZoomLevel = 6;
        public static Double MauritiusLatitude = -20.166667;
        public static Double MauritiusLongitude = 57.516667;
        public static Location MauritiusLocation = new Location(MauritiusLatitude, MauritiusLongitude);
        public static Uri MauritiusAnthem = new Uri(@"ms-appx:/anthems/Mauritius.mp3");
        public static BitmapImage MauritiusFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mauritius.jpg"));
        #endregion
        #region Mexico
        public static int MexicoZoomLevel = 5;
        public static Double MexicoLatitude = 19.432608;
        public static Double MexicoLongitude = -99.133208;
        public static Location MexicoLocation = new Location(MexicoLatitude, MexicoLongitude);
        public static Uri MexicoAnthem = new Uri(@"ms-appx:/anthems/Mexico.mp3");
        public static BitmapImage MexicoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mexico.jpg"));
        #endregion
        #region Moldova
        public static int MoldovaZoomLevel = 7;
        public static Double MoldovaLatitude = 47.000000;
        public static Double MoldovaLongitude = 28.916667;
        public static Location MoldovaLocation = new Location(MoldovaLatitude, MoldovaLongitude);
        public static Uri MoldovaAnthem = new Uri(@"ms-appx:/anthems/Moldova.mp3");
        public static BitmapImage MoldovaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Moldova.jpg"));
        #endregion
        #region Monaco
        public static int MonacoZoomLevel = 7;
        public static Double MonacoLatitude = 43.738418;
        public static Double MonacoLongitude = 7.424616;
        public static Location MonacoLocation = new Location(MonacoLatitude, MonacoLongitude);
        public static Uri MonacoAnthem = new Uri(@"ms-appx:/anthems/Monaco.mp3");
        public static BitmapImage MonacoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Monaco.jpg"));
        #endregion
        #region Mongolia
        public static int MongoliaZoomLevel = 5;
        public static Double MongoliaLatitude = 47.920000;
        public static Double MongoliaLongitude = 106.920000;
        public static Location MongoliaLocation = new Location(MongoliaLatitude, MongoliaLongitude);
        public static Uri MongoliaAnthem = new Uri(@"ms-appx:/anthems/Mongolia.mp3");
        public static BitmapImage MongoliaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mongolia.jpg"));
        #endregion
        #region Montenegro
        public static int MontenegroZoomLevel = 7;
        public static Double MontenegroLatitude = 42.441286;
        public static Double MontenegroLongitude = 19.262892;
        public static Location MontenegroLocation = new Location(MontenegroLatitude, MontenegroLongitude);
        public static Uri MontenegroAnthem = new Uri(@"ms-appx:/anthems/Montenegro.mp3");
        public static BitmapImage MontenegroFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Montenegro.jpg"));
        #endregion
        #region Morocco
        public static int MoroccoZoomLevel = 5;
        public static Double MoroccoLatitude = 33.971590;
        public static Double MoroccoLongitude = -6.849813;
        public static Location MoroccoLocation = new Location(MoroccoLatitude, MoroccoLongitude);
        public static Uri MoroccoAnthem = new Uri(@"ms-appx:/anthems/Morocco.mp3");
        public static BitmapImage MoroccoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Morocco.jpg"));
        #endregion
        #region Mozambique
        public static int MozambiqueZoomLevel = 6;
        public static Double MozambiqueLatitude = -25.966667;
        public static Double MozambiqueLongitude = 32.583333;
        public static Location MozambiqueLocation = new Location(MozambiqueLatitude, MozambiqueLongitude);
        public static Uri MozambiqueAnthem = new Uri(@"ms-appx:/anthems/Mozambique.mp3");
        public static BitmapImage MozambiqueFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Mozambique.jpg"));
        #endregion
        #region Myanmar
        public static int MyanmarZoomLevel = 7;
        public static Double MyanmarLatitude = 19.750000;
        public static Double MyanmarLongitude = 96.100000;
        public static Location MyanmarLocation = new Location(MyanmarLatitude, MyanmarLongitude);
        public static Uri MyanmarAnthem = new Uri(@"ms-appx:/anthems/Myanmar.mp3");
        public static BitmapImage MyanmarFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Myanmar.jpg"));
        #endregion
        #region Nagorno_Karabakh
        public static int Nagorno_KarabakhZoomLevel = 7;
        public static Double Nagorno_KarabakhLatitude = 40.12636579999999;
        public static Double Nagorno_KarabakhLongitude = 46.50081739999996;
        public static Location Nagorno_KarabakhLocation = new Location(Nagorno_KarabakhLatitude, Nagorno_KarabakhLongitude);
        public static Uri Nagorno_KarabakhAnthem = new Uri(@"ms-appx:/anthems/Nagorno_Karabakh.mp3");
        public static BitmapImage Nagorno_KarabakhFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Nagorno_Karabakh.jpg"));
        #endregion
        #region Namibia
        public static int NamibiaZoomLevel = 5;
        public static Double NamibiaLatitude = -22.95764;
        public static Double NamibiaLongitude = 18.490409999999997;
        public static Location NamibiaLocation = new Location(NamibiaLatitude, NamibiaLongitude);
        public static Uri NamibiaAnthem = new Uri(@"ms-appx:/anthems/Namibia.mp3");
        public static BitmapImage NamibiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Namibia.jpg"));
        #endregion
        #region Nauru
        public static int NauruZoomLevel = 6;
        public static Double NauruLatitude = -0.522778;
        public static Double NauruLongitude = 166.93150300000002;
        public static Location NauruLocation = new Location(NauruLatitude, NauruLongitude);
        public static Uri NauruAnthem = new Uri(@"ms-appx:/anthems/Nauru.mp3");
        public static BitmapImage NauruFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Nauru.jpg"));
        #endregion
        #region Nepal
        public static int NepalZoomLevel = 6;
        public static Double NepalLatitude = 28.394857;
        public static Double NepalLongitude = 84.124008;
        public static Location NepalLocation = new Location(NepalLatitude, NepalLongitude);
        public static Uri NepalAnthem = new Uri(@"ms-appx:/anthems/Nepal.mp3");
        public static BitmapImage NepalFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Nepal.png"));
        #endregion
        #region Netherlands
        public static int NetherlandsZoomLevel = 6;
        public static Double NetherlandsLatitude = 52.132633;
        public static Double NetherlandsLongitude = 5.2912659999999505;
        public static Location NetherlandsLocation = new Location(NetherlandsLatitude, NetherlandsLongitude);
        public static Uri NetherlandsAnthem = new Uri(@"ms-appx:/anthems/Netherlands.mp3");
        public static BitmapImage NetherlandsFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Netherlands.jpg"));
        #endregion
        #region New_Zealand
        public static int New_ZealandZoomLevel = 6;
        public static Double New_ZealandLatitude = -40.900557;
        public static Double New_ZealandLongitude = 174.88597100000004;
        public static Location New_ZealandLocation = new Location(New_ZealandLatitude, New_ZealandLongitude);
        public static Uri New_ZealandAnthem = new Uri(@"ms-appx:/anthems/New_Zealand.mp3");
        public static BitmapImage New_ZealandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/New_Zealand.jpg"));
        #endregion
        #region Niger
        public static int NigerZoomLevel = 6;
        public static Double NigerLatitude = 17.607789;
        public static Double NigerLongitude = 8.081666000000041;
        public static Location NigerLocation = new Location(NigerLatitude, NigerLongitude);
        public static Uri NigerAnthem = new Uri(@"ms-appx:/anthems/Niger.mp3");
        public static BitmapImage NigerFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Niger.jpg"));
        #endregion
        #region Nigeria
        public static int NigeriaZoomLevel = 6;
        public static Double NigeriaLatitude = 9.081999;
        public static Double NigeriaLongitude = 8.675277000000051;
        public static Location NigeriaLocation = new Location(NigeriaLatitude, NigeriaLongitude);
        public static Uri NigeriaAnthem = new Uri(@"ms-appx:/anthems/Nigeria.mp3");
        public static BitmapImage NigeriaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Nigeria.jpg"));
        #endregion
        #region Northern_Cyprus
        public static int Northern_CyprusZoomLevel = 6;
        public static Double Northern_CyprusLatitude = 35.1666667;
        public static Double Northern_CyprusLongitude = 33.366666699999996;
        public static Location Northern_CyprusLocation = new Location(Northern_CyprusLatitude, Northern_CyprusLongitude);
        public static Uri Northern_CyprusAnthem = new Uri(@"ms-appx:/anthems/Northern_Cyprus.mp3");
        public static BitmapImage Northern_CyprusFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Northern_Cyprus.jpg"));
        #endregion
        #region Nicaragua
        public static int NicaraguaZoomLevel = 6;
        public static Double NicaraguaLatitude = 12.865416;
        public static Double NicaraguaLongitude = -85.20722899999998;
        public static Location NicaraguaLocation = new Location(NicaraguaLatitude, NicaraguaLongitude);
        public static Uri NicaraguaAnthem = new Uri(@"ms-appx:/anthems/Nicaragua.mp3");
        public static BitmapImage NicaraguaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Nicaragua.jpg"));
        #endregion
        #region Norway
        public static int NorwayZoomLevel = 6;
        public static Double NorwayLatitude = 60.47202399999999;
        public static Double NorwayLongitude = 8.46894599999996;
        public static Location NorwayLocation = new Location(NorwayLatitude, NorwayLongitude);
        public static Uri NorwayAnthem = new Uri(@"ms-appx:/anthems/Norway.mp3");
        public static BitmapImage NorwayFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Norway.jpg"));
        #endregion
        #region Oman
        public static int OmanZoomLevel = 6;
        public static Double OmanLatitude = 21.512583;
        public static Double OmanLongitude = 55.923254999999926;
        public static Location OmanLocation = new Location(OmanLatitude, OmanLongitude);
        public static Uri OmanAnthem = new Uri(@"ms-appx:/anthems/Oman.mp3");
        public static BitmapImage OmanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Oman.jpg"));
        #endregion
        #region Pakistan
        public static int PakistanZoomLevel = 6;
        public static Double PakistanLatitude = 30.375321;
        public static Double PakistanLongitude = 69.34511599999996;
        public static Location PakistanLocation = new Location(PakistanLatitude, PakistanLongitude);
        public static Uri PakistanAnthem = new Uri(@"ms-appx:/anthems/Pakistan.mp3");
        public static BitmapImage PakistanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Pakistan.jpg"));
        #endregion
        #region Palau
        public static int PalauZoomLevel = 8;
        public static Double PalauLatitude = 7.500556;
        public static Double PalauLongitude = 134.62416699999994;
        public static Location PalauLocation = new Location(PalauLatitude, PalauLongitude);
        public static Uri PalauAnthem = new Uri(@"ms-appx:/anthems/Palau.mp3");
        public static BitmapImage PalauFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Palau.jpg"));
        #endregion
        #region Palestine
        public static int PalestineZoomLevel = 7;
        public static Double PalestineLatitude = 31.952162;
        public static Double PalestineLongitude = 35.23315400000001;
        public static Location PalestineLocation = new Location(PalestineLatitude, PalestineLongitude);
        public static Uri PalestineAnthem = new Uri(@"ms-appx:/anthems/Palestine.mp3");
        public static BitmapImage PalestineFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Palestine.jpg"));
        #endregion
        #region Panama
        public static int PanamaZoomLevel = 6;
        public static Double PanamaLatitude = 8.537981;
        public static Double PanamaLongitude = -80.782127;
        public static Location PanamaLocation = new Location(PanamaLatitude, PanamaLongitude);
        public static Uri PanamaAnthem = new Uri(@"ms-appx:/anthems/Panama.mp3");
        public static BitmapImage PanamaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Panama.jpg"));
        #endregion
        #region Papua_New_Guinea
        public static int Papua_New_GuineaZoomLevel = 6;
        public static Double Papua_New_GuineaLatitude = -6.314992999999999;
        public static Double Papua_New_GuineaLongitude = 143.95555000000002;
        public static Location Papua_New_GuineaLocation = new Location(Papua_New_GuineaLatitude, Papua_New_GuineaLongitude);
        public static Uri Papua_New_GuineaAnthem = new Uri(@"ms-appx:/anthems/Papua_New_Guinea.mp3");
        public static BitmapImage Papua_New_GuineaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Papua_New_Guinea.jpg"));
        #endregion
        #region Paraguay
        public static int ParaguayZoomLevel = 6;
        public static Double ParaguayLatitude = -25.2821972;
        public static Double ParaguayLongitude = -57.635099999999966;
        public static Location ParaguayLocation = new Location(ParaguayLatitude, ParaguayLongitude);
        public static Uri ParaguayAnthem = new Uri(@"ms-appx:/anthems/Paraguay.mp3");
        public static BitmapImage ParaguayFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Paraguay.jpg"));
        #endregion
        #region Peru
        public static int PeruZoomLevel = 6;
        public static Double PeruLatitude = -12.0478158;
        public static Double PeruLongitude = -77.06220280000002;
        public static Location PeruLocation = new Location(PeruLatitude, PeruLongitude);
        public static Uri PeruAnthem = new Uri(@"ms-appx:/anthems/Peru.mp3");
        public static BitmapImage PeruFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Peru.jpg"));
        #endregion
        #region Philippines
        public static int PhilippinesZoomLevel = 6;
        public static Double PhilippinesLatitude = 14.5995124;
        public static Double PhilippinesLongitude = 120.9842195;
        public static Location PhilippinesLocation = new Location(PhilippinesLatitude, PhilippinesLongitude);
        public static Uri PhilippinesAnthem = new Uri(@"ms-appx:/anthems/Philippines.mp3");
        public static BitmapImage PhilippinesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Philippines.jpg"));
        #endregion
        #region Poland
        public static int PolandZoomLevel = 6;
        public static Double PolandLatitude = 52.2296756;
        public static Double PolandLongitude = 21.012228700000037;
        public static Location PolandLocation = new Location(PolandLatitude, PolandLongitude);
        public static Uri PolandAnthem = new Uri(@"ms-appx:/anthems/Poland.mp3");
        public static BitmapImage PolandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Poland.jpg"));
        #endregion
        #region Portugal
        public static int PortugalZoomLevel = 6;
        public static Double PortugalLatitude = 38.70693199999999;
        public static Double PortugalLongitude = -9.135632100000066;
        public static Location PortugalLocation = new Location(PortugalLatitude, PortugalLongitude);
        public static Uri PortugalAnthem = new Uri(@"ms-appx:/anthems/Portugal.mp3");
        public static BitmapImage PortugalFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Portugal.jpg"));
        #endregion
        #region Qatar
        public static int QatarZoomLevel = 6;
        public static Double QatarLatitude = 25.280282;
        public static Double QatarLongitude = 51.52247599999998;
        public static Location QatarLocation = new Location(QatarLatitude, QatarLongitude);
        public static Uri QatarAnthem = new Uri(@"ms-appx:/anthems/Qatar.mp3");
        public static BitmapImage QatarFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Qatar.jpg"));
        #endregion
        #region Taiwan
        public static int TaiwanZoomLevel = 6;
        public static Double TaiwanLatitude = 23.69781;
        public static Double TaiwanLongitude = 120.96051499999998;
        public static Location TaiwanLocation = new Location(TaiwanLatitude, TaiwanLongitude);
        public static Uri TaiwanAnthem = new Uri(@"ms-appx:/anthems/Taiwan.mp3");
        public static BitmapImage TaiwanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Taiwan.jpg"));
        #endregion
        #region Romania
        public static int RomaniaZoomLevel = 6;
        public static Double RomaniaLatitude = 44.43771100000001;
        public static Double RomaniaLongitude = 26.097366899999997;
        public static Location RomaniaLocation = new Location(RomaniaLatitude, RomaniaLongitude);
        public static Uri RomaniaAnthem = new Uri(@"ms-appx:/anthems/Romania.mp3");
        public static BitmapImage RomaniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Romania.jpg"));
        #endregion
        #region Russia
        public static int RussiaZoomLevel = 4;
        public static Double RussiaLatitude = 55.751244;
        public static Double RussiaLongitude = 37.618423;
        public static Location RussiaLocation = new Location(RussiaLatitude, RussiaLongitude);
        public static Uri RussiaAnthem = new Uri(@"ms-appx:/anthems/Russia.mp3");
        public static BitmapImage RussiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Russia.jpg"));
        #endregion
        #region Rwanda
        public static int RwandaZoomLevel = 7;
        public static Double RwandaLatitude = -1.950106;
        public static Double RwandaLongitude = 30.058768999999984;
        public static Location RwandaLocation = new Location(RwandaLatitude, RwandaLongitude);
        public static Uri RwandaAnthem = new Uri(@"ms-appx:/anthems/Rwanda.mp3");
        public static BitmapImage RwandaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Rwanda.jpg"));
        #endregion
        #region Saint_Kitts_and_Nevis
        public static int Saint_Kitts_and_NevisZoomLevel = 8;
        public static Double Saint_Kitts_and_NevisLatitude = 17.3026058;
        public static Double Saint_Kitts_and_NevisLongitude = -62.71769240000003;
        public static Location Saint_Kitts_and_NevisLocation = new Location(Saint_Kitts_and_NevisLatitude, Saint_Kitts_and_NevisLongitude);
        public static Uri Saint_Kitts_and_NevisAnthem = new Uri(@"ms-appx:/anthems/Saint_Kitts_and_Nevis.mp3");
        public static BitmapImage Saint_Kitts_and_NevisFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Saint_Kitts_and_Nevis.jpg"));
        #endregion
        #region Saint_Lucia
        public static int Saint_LuciaZoomLevel = 8;
        public static Double Saint_LuciaLatitude = 13.909444;
        public static Double Saint_LuciaLongitude = -60.97889299999997;
        public static Location Saint_LuciaLocation = new Location(Saint_LuciaLatitude, Saint_LuciaLongitude);
        public static Uri Saint_LuciaAnthem = new Uri(@"ms-appx:/anthems/Saint_Lucia.mp3");
        public static BitmapImage Saint_LuciaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Saint_Lucia.jpg"));
        #endregion
        #region Saint_Vincent_and_the_Grenadines
        public static int Saint_Vincent_and_the_GrenadinesZoomLevel = 7;
        public static Double Saint_Vincent_and_the_GrenadinesLatitude = 13.157778;
        public static Double Saint_Vincent_and_the_GrenadinesLongitude = -61.22500000000002;
        public static Location Saint_Vincent_and_the_GrenadinesLocation = new Location(Saint_Vincent_and_the_GrenadinesLatitude, Saint_Vincent_and_the_GrenadinesLongitude);
        public static Uri Saint_Vincent_and_the_GrenadinesAnthem = new Uri(@"ms-appx:/anthems/Saint_Vincent_and_the_Grenadines.mp3");
        public static BitmapImage Saint_Vincent_and_the_GrenadinesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Saint_Vincent_and_the_Grenadines.jpg"));
        #endregion
        #region Samoa
        public static int SamoaZoomLevel = 7;
        public static Double SamoaLatitude = -13.833333;
        public static Double SamoaLongitude = -171.75;
        public static Location SamoaLocation = new Location(SamoaLatitude, SamoaLongitude);
        public static Uri SamoaAnthem = new Uri(@"ms-appx:/anthems/Samoa.mp3");
        public static BitmapImage SamoaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Samoa.jpg"));
        #endregion
        #region São_Tomé_and_Príncipe
        public static int São_Tomé_and_PríncipeZoomLevel = 7;
        public static Double São_Tomé_and_PríncipeLatitude = 0.3301924;
        public static Double São_Tomé_and_PríncipeLongitude = 6.733342999999991;
        public static Location São_Tomé_and_PríncipeLocation = new Location(São_Tomé_and_PríncipeLatitude, São_Tomé_and_PríncipeLongitude);
        public static Uri São_Tomé_and_PríncipeAnthem = new Uri(@"ms-appx:/anthems/São_Tomé_and_Príncipe.mp3");
        public static BitmapImage São_Tomé_and_PríncipeFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/São_Tomé_and_Príncipe.jpg"));
        #endregion
        #region San_Marino
        public static int San_MarinoZoomLevel = 11;
        public static Double San_MarinoLatitude = 43.94236;
        public static Double San_MarinoLongitude = 12.457776999999964;
        public static Location San_MarinoLocation = new Location(San_MarinoLatitude, San_MarinoLongitude);
        public static Uri San_MarinoAnthem = new Uri(@"ms-appx:/anthems/San_Marino.mp3");
        public static BitmapImage San_MarinoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/San_Marino.jpg"));
        #endregion
        #region Saudi_Arabia
        public static int Saudi_ArabiaZoomLevel = 5;
        public static Double Saudi_ArabiaLatitude = 24.7116667;
        public static Double Saudi_ArabiaLongitude = 46.72416670000007;
        public static Location Saudi_ArabiaLocation = new Location(Saudi_ArabiaLatitude, Saudi_ArabiaLongitude);
        public static Uri Saudi_ArabiaAnthem = new Uri(@"ms-appx:/anthems/Saudi_Arabia.mp3");
        public static BitmapImage Saudi_ArabiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Saudi_Arabia.jpg"));
        #endregion
        #region Senegal
        public static int SenegalZoomLevel = 6;
        public static Double SenegalLatitude = 14.6927778;
        public static Double SenegalLongitude = -17.446666700000037;
        public static Location SenegalLocation = new Location(SenegalLatitude, SenegalLongitude);
        public static Uri SenegalAnthem = new Uri(@"ms-appx:/anthems/Senegal.mp3");
        public static BitmapImage SenegalFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Senegal.jpg"));
        #endregion
        #region Serbia
        public static int SerbiaZoomLevel = 6;
        public static Double SerbiaLatitude = 44.8205556;
        public static Double SerbiaLongitude = 20.462222200000042;
        public static Location SerbiaLocation = new Location(SerbiaLatitude, SerbiaLongitude);
        public static Uri SerbiaAnthem = new Uri(@"ms-appx:/anthems/Serbia.mp3");
        public static BitmapImage SerbiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Serbia.jpg"));
        #endregion
        #region Seychelles
        public static int SeychellesZoomLevel = 7;
        public static Double SeychellesLatitude = -4.679574;
        public static Double SeychellesLongitude = 55.49197700000002;
        public static Location SeychellesLocation = new Location(SeychellesLatitude, SeychellesLongitude);
        public static Uri SeychellesAnthem = new Uri(@"ms-appx:/anthems/Seychelles.mp3");
        public static BitmapImage SeychellesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Seychelles.jpg"));
        #endregion
        #region Sierra_Leone
        public static int Sierra_LeoneZoomLevel = 7;
        public static Double Sierra_LeoneLatitude = 8.460555;
        public static Double Sierra_LeoneLongitude = -11.779889000000026;
        public static Location Sierra_LeoneLocation = new Location(Sierra_LeoneLatitude, Sierra_LeoneLongitude);
        public static Uri Sierra_LeoneAnthem = new Uri(@"ms-appx:/anthems/Sierra_Leone.mp3");
        public static BitmapImage Sierra_LeoneFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Sierra_Leone.jpg"));
        #endregion
        #region Singapore
        public static int SingaporeZoomLevel = 7;
        public static Double SingaporeLatitude = 1.352083;
        public static Double SingaporeLongitude = 103.81983600000001;
        public static Location SingaporeLocation = new Location(SingaporeLatitude, SingaporeLongitude);
        public static Uri SingaporeAnthem = new Uri(@"ms-appx:/anthems/Singapore.mp3");
        public static BitmapImage SingaporeFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Singapore.jpg"));
        #endregion
        #region Slovakia
        public static int SlovakiaZoomLevel = 7;
        public static Double SlovakiaLatitude = 48.1462386;
        public static Double SlovakiaLongitude = 17.10726180000006;
        public static Location SlovakiaLocation = new Location(SlovakiaLatitude, SlovakiaLongitude);
        public static Uri SlovakiaAnthem = new Uri(@"ms-appx:/anthems/Slovakia.mp3");
        public static BitmapImage SlovakiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Slovakia.jpg"));
        #endregion
        #region Slovenia
        public static int SloveniaZoomLevel = 7;
        public static Double SloveniaLatitude = 46.0514263;
        public static Double SloveniaLongitude = 14.505965500000002;
        public static Location SloveniaLocation = new Location(SloveniaLatitude, SloveniaLongitude);
        public static Uri SloveniaAnthem = new Uri(@"ms-appx:/anthems/Slovenia.mp3");
        public static BitmapImage SloveniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Slovenia.jpg"));
        #endregion
        #region Solomon_Islands
        public static int Solomon_IslandsZoomLevel = 7;
        public static Double Solomon_IslandsLatitude = -9.64571;
        public static Double Solomon_IslandsLongitude = 160.15619400000003;
        public static Location Solomon_IslandsLocation = new Location(Solomon_IslandsLatitude, Solomon_IslandsLongitude);
        public static Uri Solomon_IslandsAnthem = new Uri(@"ms-appx:/anthems/Solomon_Islands.mp3");
        public static BitmapImage Solomon_IslandsFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Solomon_Islands.jpg"));
        #endregion
        #region Somalia
        public static int SomaliaZoomLevel = 6;
        public static Double SomaliaLatitude = 5.152149;
        public static Double SomaliaLongitude = 46.19961599999999;
        public static Location SomaliaLocation = new Location(SomaliaLatitude, SomaliaLongitude);
        public static Uri SomaliaAnthem = new Uri(@"ms-appx:/anthems/Somalia.mp3");
        public static BitmapImage SomaliaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Somalia.jpg"));
        #endregion
        #region Somaliland
        public static int SomalilandZoomLevel = 6;
        public static Double SomalilandLatitude = 9.4117433999999990;
        public static Double SomalilandLongitude = 46.825283799999966;
        public static Location SomalilandLocation = new Location(SomalilandLatitude, SomalilandLongitude);
        public static Uri SomalilandAnthem = new Uri(@"ms-appx:/anthems/Somaliland.mp3");
        public static BitmapImage SomalilandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Somaliland.jpg"));
        #endregion
        #region South_Africa
        public static int South_AfricaZoomLevel = 6;
        public static Double South_AfricaLatitude = -30.559482;
        public static Double South_AfricaLongitude = 22.937505999999985;
        public static Location South_AfricaLocation = new Location(South_AfricaLatitude, South_AfricaLongitude);
        public static Uri South_AfricaAnthem = new Uri(@"ms-appx:/anthems/South_Africa.mp3");
        public static BitmapImage South_AfricaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/South_Africa.jpg"));
        #endregion
        #region South_Sudan
        public static int South_SudanZoomLevel = 6;
        public static Double South_SudanLatitude = 7.9630921;
        public static Double South_SudanLongitude = 30.158930300000065;
        public static Location South_SudanLocation = new Location(South_SudanLatitude, South_SudanLongitude);
        public static Uri South_SudanAnthem = new Uri(@"ms-appx:/anthems/South_Sudan.mp3");
        public static BitmapImage South_SudanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/South_Sudan.jpg"));
        #endregion
        #region Spain
        public static int SpainZoomLevel = 6;
        public static Double SpainLatitude = 40.4167754;
        public static Double SpainLongitude = -3.7037901999999576;
        public static Location SpainLocation = new Location(SpainLatitude, SpainLongitude);
        public static Uri SpainAnthem = new Uri(@"ms-appx:/anthems/Spain.mp3");
        public static BitmapImage SpainFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Spain.jpg"));
        #endregion
        #region Sri_Lanka
        public static int Sri_LankaZoomLevel = 6;
        public static Double Sri_LankaLatitude = 6.9270786;
        public static Double Sri_LankaLongitude = 79.86124300000006;
        public static Location Sri_LankaLocation = new Location(Sri_LankaLatitude, Sri_LankaLongitude);
        public static Uri Sri_LankaAnthem = new Uri(@"ms-appx:/anthems/Sri_Lanka.mp3");
        public static BitmapImage Sri_LankaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Sri_Lanka.jpg"));
        #endregion
        #region Sudan
        public static int SudanZoomLevel = 6;
        public static Double SudanLatitude = 15.550101;
        public static Double SudanLongitude = 32.532241;
        public static Location SudanLocation = new Location(SudanLatitude, SudanLongitude);
        public static Uri SudanAnthem = new Uri(@"ms-appx:/anthems/Sudan.mp3");
        public static BitmapImage SudanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Sudan.jpg"));
        #endregion
        #region Swaziland
        public static int SwazilandZoomLevel = 7;
        public static Double SwazilandLatitude = -26.4333333;
        public static Double SwazilandLongitude = 31.200000000000045;
        public static Location SwazilandLocation = new Location(SwazilandLatitude, SwazilandLongitude);
        public static Uri SwazilandAnthem = new Uri(@"ms-appx:/anthems/Swaziland.mp3");
        public static BitmapImage SwazilandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Swaziland.jpg"));
        #endregion
        #region Sweden
        public static int SwedenZoomLevel = 4;
        public static Double SwedenLatitude = 59.32893000000001;
        public static Double SwedenLongitude = 18.064910000000054;
        public static Location SwedenLocation = new Location(SwedenLatitude, SwedenLongitude);
        public static Uri SwedenAnthem = new Uri(@"ms-appx:/anthems/Sweden.mp3");
        public static BitmapImage SwedenFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Sweden.jpg"));
        #endregion
        #region Suriname
        public static int SurinameZoomLevel = 6;
        public static Double SurinameLatitude = 5.816667;
        public static Double SurinameLongitude = -55.166668;
        public static Location SurinameLocation = new Location(SurinameLatitude, SurinameLongitude);
        public static Uri SurinameAnthem = new Uri(@"ms-appx:/anthems/Suriname.mp3");
        public static BitmapImage SurinameFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Suriname.jpg"));
        #endregion
        #region Switzerland
        public static int SwitzerlandZoomLevel = 6;
        public static Double SwitzerlandLatitude = 46.818188;
        public static Double SwitzerlandLongitude = 8.227511999999933;
        public static Location SwitzerlandLocation = new Location(SwitzerlandLatitude, SwitzerlandLongitude);
        public static Uri SwitzerlandAnthem = new Uri(@"ms-appx:/anthems/Switzerland.mp3");
        public static BitmapImage SwitzerlandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Switzerland.jpg"));
        #endregion
        #region Syria
        public static int SyriaZoomLevel = 6;
        public static Double SyriaLatitude = 33.5111;
        public static Double SyriaLongitude = 36.30639999999994;
        public static Location SyriaLocation = new Location(SyriaLatitude, SyriaLongitude);
        public static Uri SyriaAnthem = new Uri(@"ms-appx:/anthems/Syria.mp3");
        public static BitmapImage SyriaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Syria.jpg"));
        #endregion
        #region Tajikistan
        public static int TajikistanZoomLevel = 6;
        public static Double TajikistanLatitude = 38.5366667;
        public static Double TajikistanLongitude = 68.77999999999997;
        public static Location TajikistanLocation = new Location(TajikistanLatitude, TajikistanLongitude);
        public static Uri TajikistanAnthem = new Uri(@"ms-appx:/anthems/Tajikistan.mp3");
        public static BitmapImage TajikistanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Tajikistan.jpg"));
        #endregion
        #region Tanzania
        public static int TanzaniaZoomLevel = 6;
        public static Double TanzaniaLatitude = -6.1730556;
        public static Double TanzaniaLongitude = 35.741944399999966;
        public static Location TanzaniaLocation = new Location(TanzaniaLatitude, TanzaniaLongitude);
        public static Uri TanzaniaAnthem = new Uri(@"ms-appx:/anthems/Tanzania.mp3");
        public static BitmapImage TanzaniaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Tanzania_1.jpg"));
        #endregion
        #region Thailand
        public static int ThailandZoomLevel = 6;
        public static Double ThailandLatitude = 15.870032;
        public static Double ThailandLongitude = 100.99254100000007;
        public static Location ThailandLocation = new Location(ThailandLatitude, ThailandLongitude);
        public static Uri ThailandAnthem = new Uri(@"ms-appx:/anthems/Thailand.mp3");
        public static BitmapImage ThailandFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Thailand.jpg"));
        #endregion
        #region Togo
        public static int TogoZoomLevel = 6;
        public static Double TogoLatitude = 8.619543;
        public static Double TogoLongitude = 0.8247820000000274;
        public static Location TogoLocation = new Location(TogoLatitude, TogoLongitude);
        public static Uri TogoAnthem = new Uri(@"ms-appx:/anthems/Togo.mp3");
        public static BitmapImage TogoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Togo.jpg"));
        #endregion
        #region Tonga
        public static int TongaZoomLevel = 7;
        public static Double TongaLatitude = -21.133333;
        public static Double TongaLongitude = -175.2;
        public static Location TongaLocation = new Location(TongaLatitude, TongaLongitude);
        public static Uri TongaAnthem = new Uri(@"ms-appx:/anthems/Tonga.mp3");
        public static BitmapImage TongaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Tonga.jpg"));
        #endregion
        #region Transnistria
        public static int TransnistriaZoomLevel = 6;
        public static Double TransnistriaLatitude = 46.84523799999999;
        public static Double TransnistriaLongitude = 29.63310100000001;
        public static Location TransnistriaLocation = new Location(TransnistriaLatitude, TransnistriaLongitude);
        public static Uri TransnistriaAnthem = new Uri(@"ms-appx:/anthems/Transnistria.mp3");
        public static BitmapImage TransnistriaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Transnistria.jpg"));
        #endregion
        #region Trinidad_and_Tobago
        public static int Trinidad_and_TobagoZoomLevel = 7;
        public static Double Trinidad_and_TobagoLatitude = 10.6666667;
        public static Double Trinidad_and_TobagoLongitude = -61.51666669999997;
        public static Location Trinidad_and_TobagoLocation = new Location(Trinidad_and_TobagoLatitude, Trinidad_and_TobagoLongitude);
        public static Uri Trinidad_and_TobagoAnthem = new Uri(@"ms-appx:/anthems/Trinidad_and_Tobago.mp3");
        public static BitmapImage Trinidad_and_TobagoFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Trinidad_and_Tobago.jpg"));
        #endregion
        #region Tunisia
        public static int TunisiaZoomLevel = 6;
        public static Double TunisiaLatitude = 36.81881;
        public static Double TunisiaLongitude = 10.165960000000041;
        public static Location TunisiaLocation = new Location(TunisiaLatitude, TunisiaLongitude);
        public static Uri TunisiaAnthem = new Uri(@"ms-appx:/anthems/Tunisia.mp3");
        public static BitmapImage TunisiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Tunisia.jpg"));
        #endregion
        #region Turkey
        public static int TurkeyZoomLevel = 6;
        public static Double TurkeyLatitude = 39.92077;
        public static Double TurkeyLongitude = 32.85410999999999;
        public static Location TurkeyLocation = new Location(TurkeyLatitude, TurkeyLongitude);
        public static Uri TurkeyAnthem = new Uri(@"ms-appx:/anthems/Turkey.mp3");
        public static BitmapImage TurkeyFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Turkey.jpg"));
        #endregion
        #region Turkmenistan
        public static int TurkmenistanZoomLevel = 6;
        public static Double TurkmenistanLatitude = 37.950197;
        public static Double TurkmenistanLongitude = 58.380223;
        public static Location TurkmenistanLocation = new Location(TurkmenistanLatitude, TurkmenistanLongitude);
        public static Uri TurkmenistanAnthem = new Uri(@"ms-appx:/anthems/Turkmenistan.mp3");
        public static BitmapImage TurkmenistanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Turkmenistan.jpg"));
        #endregion
        #region Tuvalu
        public static int TuvaluZoomLevel = 6;
        public static Double TuvaluLatitude = -8.516667;
        public static Double TuvaluLongitude = 179.199997;
        public static Location TuvaluLocation = new Location(TuvaluLatitude, TuvaluLongitude);
        public static Uri TuvaluAnthem = new Uri(@"ms-appx:/anthems/Tuvalu.mp3");
        public static BitmapImage TuvaluFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Tuvalu.jpg"));
        #endregion
        #region Uganda
        public static int UgandaZoomLevel = 6;
        public static Double UgandaLatitude = 1.373333;
        public static Double UgandaLongitude = 32.290275000000065;
        public static Location UgandaLocation = new Location(UgandaLatitude, UgandaLongitude);
        public static Uri UgandaAnthem = new Uri(@"ms-appx:/anthems/Uganda.mp3");
        public static BitmapImage UgandaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Uganda.jpg"));
        #endregion
        #region Ukraine
        public static int UkraineZoomLevel = 6;
        public static Double UkraineLatitude = 50.4501;
        public static Double UkraineLongitude = 30.523400000000038;
        public static Location UkraineLocation = new Location(UkraineLatitude, UkraineLongitude);
        public static Uri UkraineAnthem = new Uri(@"ms-appx:/anthems/Ukraine.mp3");
        public static BitmapImage UkraineFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Ukraine.jpg"));
        #endregion
        #region United_Arab_Emirates
        public static int United_Arab_EmiratesZoomLevel = 6;
        public static Double United_Arab_EmiratesLatitude = 24.4666667;
        public static Double United_Arab_EmiratesLongitude = 54.366666699999996;
        public static Location United_Arab_EmiratesLocation = new Location(United_Arab_EmiratesLatitude, United_Arab_EmiratesLongitude);
        public static Uri United_Arab_EmiratesAnthem = new Uri(@"ms-appx:/anthems/United_Arab_Emirates.mp3");
        public static BitmapImage United_Arab_EmiratesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/United_Arab_Emirates.jpg"));
        #endregion
        #region United_Kingdom
        public static int United_KingdomZoomLevel = 5;
        public static Double United_KingdomLatitude = 51.5081289;
        public static Double United_KingdomLongitude = -0.12800500000003012;
        public static Location United_KingdomLocation = new Location(United_KingdomLatitude, United_KingdomLongitude);
        public static Uri United_KingdomAnthem = new Uri(@"ms-appx:/anthems/United_Kingdom.mp3");
        public static BitmapImage United_KingdomFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/United_Kingdom.jpg"));
        #endregion
        #region United_States
        public static int United_StatesZoomLevel = 4;
        public static Double United_StatesLatitude = 38.8951118;
        public static Double United_StatesLongitude = -77.0363658;
        public static Location United_StatesLocation = new Location(United_StatesLatitude, United_StatesLongitude);
        public static Uri United_StatesAnthem = new Uri(@"ms-appx:/anthems/United_States.mp3");
        public static BitmapImage United_StatesFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/United_States.jpg"));
        #endregion
        #region Uruguay
        public static int UruguayZoomLevel = 6;
        public static Double UruguayLatitude = -34.8836111;
        public static Double UruguayLongitude = -56.18194440000002;
        public static Location UruguayLocation = new Location(UruguayLatitude, UruguayLongitude);
        public static Uri UruguayAnthem = new Uri(@"ms-appx:/anthems/Uruguay.mp3");
        public static BitmapImage UruguayFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Uruguay.jpg"));
        #endregion
        #region Uzbekistan
        public static int UzbekistanZoomLevel = 5;
        public static Double UzbekistanLatitude = 41.26666669999999;
        public static Double UzbekistanLongitude = 69.21666670000002;
        public static Location UzbekistanLocation = new Location(UzbekistanLatitude, UzbekistanLongitude);
        public static Uri UzbekistanAnthem = new Uri(@"ms-appx:/anthems/Uzbekistan.mp3");
        public static BitmapImage UzbekistanFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Uzbekistan.jpg"));
        #endregion
        #region Vanuatu
        public static int VanuatuZoomLevel = 6;
        public static Double VanuatuLatitude = -15.376706;
        public static Double VanuatuLongitude = 166.959158;
        public static Location VanuatuLocation = new Location(VanuatuLatitude, VanuatuLongitude);
        public static Uri VanuatuAnthem = new Uri(@"ms-appx:/anthems/Vanuatu.mp3");
        public static BitmapImage VanuatuFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Vanuatu.jpg"));
        #endregion
        #region Vatican_City
        public static int Vatican_CityZoomLevel = 14;
        public static Double Vatican_CityLatitude = 41.902916;
        public static Double Vatican_CityLongitude = 12.453389000000016;
        public static Location Vatican_CityLocation = new Location(Vatican_CityLatitude, Vatican_CityLongitude);
        public static Uri Vatican_CityAnthem = new Uri(@"ms-appx:/anthems/Vatican_City.mp3");
        public static BitmapImage Vatican_CityFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Vatican_City.jpg"));
        #endregion
        #region Venezuela
        public static int VenezuelaZoomLevel = 5;
        public static Double VenezuelaLatitude = 10.491016;
        public static Double VenezuelaLongitude = -66.902061;
        public static Location VenezuelaLocation = new Location(VenezuelaLatitude, VenezuelaLongitude);
        public static Uri VenezuelaAnthem = new Uri(@"ms-appx:/anthems/Venezuela.mp3");
        public static BitmapImage VenezuelaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Venezuela.jpg"));
        #endregion
        #region Vietnam
        public static int VietnamZoomLevel = 5;
        public static Double VietnamLatitude = 21.0277644;
        public static Double VietnamLongitude = 105.83415979999995;
        public static Location VietnamLocation = new Location(VietnamLatitude, VietnamLongitude);
        public static Uri VietnamAnthem = new Uri(@"ms-appx:/anthems/Vietnam.mp3");
        public static BitmapImage VietnamFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Vietnam.jpg"));
        #endregion
        #region Western_Sahara
        public static int Western_SaharaZoomLevel = 5;
        public static Double Western_SaharaLatitude = 27.153611100000000000;
        public static Double Western_SaharaLongitude = -13.203333299999940000;
        public static Location Western_SaharaLocation = new Location(Western_SaharaLatitude, Western_SaharaLongitude);
        public static Uri Western_SaharaAnthem = new Uri(@"ms-appx:/anthems/Western_Sahara.mp3");
        public static BitmapImage Western_SaharaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Western_Sahara.jpg"));
        #endregion
        #region Yemen
        public static int YemenZoomLevel = 5;
        public static Double YemenLatitude = 15.352029;
        public static Double YemenLongitude = 44.20745599999998;
        public static Location YemenLocation = new Location(YemenLatitude, YemenLongitude);
        public static Uri YemenAnthem = new Uri(@"ms-appx:/anthems/Yemen.mp3");
        public static BitmapImage YemenFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Yemen.jpg"));
        #endregion
        #region Zambia
        public static int ZambiaZoomLevel = 5;
        public static Double ZambiaLatitude = -15.408193;
        public static Double ZambiaLongitude = 28.287166999999954;
        public static Location ZambiaLocation = new Location(ZambiaLatitude, ZambiaLongitude);
        public static Uri ZambiaAnthem = new Uri(@"ms-appx:/anthems/Zambia.mp3");
        public static BitmapImage ZambiaFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Zambia.jpg"));
        #endregion
        #region Zimbabwe
        public static int ZimbabweZoomLevel = 5;
        public static Double ZimbabweLatitude = -17.82922;
        public static Double ZimbabweLongitude = 31.053961000000072;
        public static Location ZimbabweLocation = new Location(ZimbabweLatitude, ZimbabweLongitude);
        public static Uri ZimbabweAnthem = new Uri(@"ms-appx:/anthems/Zimbabwe.mp3");
        public static BitmapImage ZimbabweFlag = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/flagimage/Zimbabwe.jpg"));
        #endregion
    }
}
