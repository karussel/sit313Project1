
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
	public class CharacterArrayAdapter : BaseAdapter<String>
	{
		string[] characters;
		Activity context;

		public CharacterArrayAdapter(Activity context, string[] characters)
		{
			this.context = context;
			this.characters = characters;
		}

		public override long GetItemId(int position)
		{
			return position;
		}
		public override string this[int position]
		{
			get { return characters[position]; }
		}
		public override int Count
		{
			get { return characters.Length; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			LayoutInflater inflator = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
			View characterRows = inflator.Inflate(Resource.Layout.charListLayout, parent, false);

			TextView charName = (TextView)characterRows.FindViewById<TextView>(Resource.Id.charTextView);

			ImageView charView = (ImageView)characterRows.FindViewById<ImageView>(Resource.Id.charImageView);

			charName.Text = (characters[position]);

			string charstr = characters[position];

			if (charstr.StartsWith("Bowser"))
			{
				charView.SetImageResource(Resource.Drawable.bowserIcon);
			}

			else if (charstr.StartsWith("Mario"))
			{
				charView.SetImageResource(Resource.Drawable.marioIcon);
			}

			else if (charstr.StartsWith("Captain Falcon"))
			{
				charView.SetImageResource(Resource.Drawable.captainfalconIcon);
			}

			else if (charstr.StartsWith("Donkey Kong"))
			{
				charView.SetImageResource(Resource.Drawable.donkeykongIcon);
			}

			else if (charstr.StartsWith("Dr. Mario"))
			{
				charView.SetImageResource(Resource.Drawable.drmarioIcon);
			}
			else if (charstr.StartsWith("Falco"))
			{
				charView.SetImageResource(Resource.Drawable.falcoIcon);
			}
			else if (charstr.StartsWith("Fox"))
			{
				charView.SetImageResource(Resource.Drawable.foxIcon);
			}
			else if (charstr.StartsWith("Ganondorf"))
			{
				charView.SetImageResource(Resource.Drawable.ganondorfIcon);

			}
			else if (charstr.StartsWith("Ice Climbers"))
			{
				charView.SetImageResource(Resource.Drawable.iceclimbersIcon);
			}
			else if (charstr.StartsWith("Jigglypuff"))
			{
				charView.SetImageResource(Resource.Drawable.jigglypuffIcon);
			}
			else if (charstr.StartsWith("Kirby"))
			{
				charView.SetImageResource(Resource.Drawable.kirbyIcon);
			}
			else if (charstr.StartsWith("Link"))
			{
				charView.SetImageResource(Resource.Drawable.linkIcon);
			}
			else if (charstr.StartsWith("Luigi"))
			{
				charView.SetImageResource(Resource.Drawable.luigiIcon);
			}
			else if (charstr.StartsWith("Marth"))
			{
				charView.SetImageResource(Resource.Drawable.marthIcon);
			}
			else if (charstr.StartsWith("Mewtwo"))
			{
				charView.SetImageResource(Resource.Drawable.mewtwoIcon);
			}
			else if (charstr.StartsWith("Mr Game & Watch"))
			{
				charView.SetImageResource(Resource.Drawable.mrgameandwatchIcon);
			}
			else if (charstr.StartsWith("Ness"))
			{
				charView.SetImageResource(Resource.Drawable.nessIcon);
			}
			else if (charstr.StartsWith("Peach"))
			{
				charView.SetImageResource(Resource.Drawable.peachIcon);
			}
			else if (charstr.StartsWith("Pichu"))
			{
				charView.SetImageResource(Resource.Drawable.pichuIcon);
			}
			else if (charstr.StartsWith("Roy"))
			{
				charView.SetImageResource(Resource.Drawable.royIcon);
			}
			else if (charstr.StartsWith("Samus"))
			{
				charView.SetImageResource(Resource.Drawable.samusIcon);
			}
			else if (charstr.StartsWith("Sheik"))
			{
				charView.SetImageResource(Resource.Drawable.sheikIcon);
			}
			else if (charstr.StartsWith("Yoshi"))
			{
				charView.SetImageResource(Resource.Drawable.yoshiIcon);
			}
			else if (charstr.StartsWith("Zelda"))
			{
				charView.SetImageResource(Resource.Drawable.zeldaIcon);
			}

			return characterRows;
		}



	}


}

