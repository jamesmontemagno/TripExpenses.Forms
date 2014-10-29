using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripExpenses.Views;
using Xamarin.Forms;

namespace TripExpenses
{
	public class App
	{
		public static Page GetMainPage()
		{
      return new NavigationPage(new ExpenseListPage()) { Tint = Color.FromRgb(52, 152, 219) };
		}
	}
}
