using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Hardware.Camera2;

namespace TestZXing.Droid
{
    [Activity(Label = "TestZXing.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

            /*
            var camera = global::Android.Hardware.Camera.Open(1);
            var options = camera.GetParameters();
        

            if (options.IsZoomSupported)
            {
                options.Zoom = (options.MaxZoom / 2);
                Console.WriteLine("Set zoom to " + options.Zoom);
                camera.SetParameters(options);                             
            }

            camera.Release();
            */
            
            /*
            var manager = (CameraManager)GetSystemService(Context.CameraService);

            for (var i = 0; i < manager.GetCameraIdList().Length; i++)
            {
                var cameraId = manager.GetCameraIdList()[i];
                CameraCharacteristics characteristics = manager.GetCameraCharacteristics(cameraId);

                Console.WriteLine(characteristics.Get(CameraCharacteristics.LensFacing).ToString());
            }
            */

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}
