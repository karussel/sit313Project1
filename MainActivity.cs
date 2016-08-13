using Android.App; // main shit
using Android.Widget; using Android.OS; using Android.Util; using System.Net; using System; using System.Linq; using Android.Content; using System.Collections.Generic; using Android.Provider; using Android.Content.PM; using Android.Graphics; using Java.IO;

namespace Project1
{



	[Activity(Label = "Project1", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to i



			Button characterButton = FindViewById<Button>(Resource.Id.characterButton);
			characterButton.Click += delegate
					{

						var CharacterActivity1 = new Intent(this, typeof(CharacterListActivity));
						StartActivity(CharacterActivity1);
					};
		}
	}
}