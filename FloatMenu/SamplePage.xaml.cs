﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FloatMenu
{
	public partial class SamplePage : ContentPage
	{
		public SamplePage ()
		{
			var t = this;
			InitializeComponent ();
			var l = this.FindByName<ListView> ("list");
			var items = new[] {
				new { Title = "Item1" },
				new { Title = "Item2" },
				new { Title = "Item3" },
				new { Title = "Item4" }
			};
			l.ItemsSource = items;

//			var modal = this.FindByName<AbsoluteLayout> ("modal");
//			var menu = modal.FindByName<StackLayout> ("menu");

			l.ItemSelected += (sender, e) => {
				// Adjust the height to position it near the item that was clicked (so that it looks "contextual")
				var r = AbsoluteLayout.GetLayoutBounds(t.menu);
				r.Y = t.GetListItemY (l, items, e.SelectedItem) + l.RowHeight; // Add the RowHeight to position below
				AbsoluteLayout.SetLayoutBounds (t.menu, r);
				t.modal.IsVisible = true;
			};
		}

		private double GetListItemY<T> (ListView list, IList<T> items, T item)
		{
			var y = list.Y;
			var height = list.RowHeight;

			var index = items.IndexOf (item);

			return y + (height * index);
		}

		void OnTappedOnBackground(object sender, EventArgs e){
			this.modal.IsVisible = false;
		}
	}
}