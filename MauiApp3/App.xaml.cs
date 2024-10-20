using MauiApp3.MVVM.View;

namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH9ccHVVR2BeVU10XEQ=");
            InitializeComponent();
            MainPage = new BMIView();
        }
    }
}
