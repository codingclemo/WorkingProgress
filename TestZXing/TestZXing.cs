using System;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace TestZXing
{
    public class App : Application
    {
        ZXingScannerPage scanPage;

        public App()
        {
            scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) =>
            {
                //System.Diagnostics.Debug.WriteLine("Scanned datamatrix code -> [" + result.Text + "]");
                
                // Stop scanning
                scanPage.IsScanning = false;

                // Show the result
                Device.BeginInvokeOnMainThread(() =>
                {
                    scanPage.DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            
            //MainPage needs to be set, otherwise error
            MainPage = scanPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
