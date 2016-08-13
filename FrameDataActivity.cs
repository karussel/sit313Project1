
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project1
{
	[Activity(Label = "FrameDataActivity")]
	public class FrameDataActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.FramadataLayout);

			string characterName = Intent.GetStringExtra("CharName") ?? "Data not available";

			ImageView frame = FindViewById<ImageView>(Resource.Id.chardatatxtView);

			if if (characterName.Equals("Bowser"))
			{
			    frame.SetImageResource(Resource.Drawable.                                                                                                                                                                                                                  );
			}

			else if (characterName.Equals("Mario"))
			{
				frame.SetImageResource(Resource.Drawable.2);
			}

			else if (characterName.Equals("Captain Falcon"))
			{
				frame.SetImageResource(Resource.Drawable.3);
			}

		}
	}
}

