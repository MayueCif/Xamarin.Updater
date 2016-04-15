using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Updater;

namespace Xamarin.Updater_Test
{
	[Activity (Label = "Xamarin.Updater_Test", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				var updater = UpdateAgent.GetInstance (this);
				updater.DownloadMode = DownloadMode.Overwrite;
				updater.Start ("http://filelx.liqucn.com/upload/2015/shipin/360Video_ys4873.apk", "ys4873.apk");

			};

		}
	}

}


