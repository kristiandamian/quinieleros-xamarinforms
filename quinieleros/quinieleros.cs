using System;

using Xamarin.Forms;

namespace quinieleros
{
	public class App : Application
	{
		NavigationPage _NavPage;

		public App ()
		{
			
		}
		public Page GetMainPage ()
		{
			var menu = new Menu();

			_NavPage = new NavigationPage(menu);

			return _NavPage;
		}
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

