
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
	[Activity(Label = "CharacterListActivity")]
	public class CharacterListActivity : Activity
	{
		string[] charList;
		ListView CharListView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.CharacterListActivityLayout);
			CharListView = FindViewById<ListView>(Resource.Id.listCharacter);
			charList = new string[] {"Mario", "Bowser", "Captain Falcon", "Donkey Kong", "Dr. Mario", "Fox", "Ganondorf",
			"Ice Climbers", "Jigglypuff", "Ice Climbers", "Kirby", "Link", "Luigi", "Marth", "Mewtwo", "Mr Game & Watch", "Ness", "Peach",
				"Pichu", "Roy", "Samus", "Sheik", "Yoshi", "Zelda"};
			CharListView.Adapter = new CharacterArrayAdapter(this, charList);

			CharListView.ItemClick += OnListItemClick;

		}

		void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			// var listView = sender as ListView;
			String item = charList[e.Position];
			var frameActivity = new Intent(this, typeof(FrameDataActivity));
			frameActivity.PutExtra("CharName", item);

			StartActivity(frameActivity);
		}
	}		
		

}
