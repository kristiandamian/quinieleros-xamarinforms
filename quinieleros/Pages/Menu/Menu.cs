using System;

using Xamarin.Forms;

namespace quinieleros
{
	public class Menu : MasterDetailPage
	{
		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			if (!Login.IsLoggedIn) {
				Navigation.PushModalAsync(new InicioPage());
			}
		}
		public Menu ()
		{
			var menuPage = new MenuPage ();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

			Master = menuPage;
			Detail = new NavigationPage (new EstadisticasPage ());
		}

		void NavigateTo (MenuItem menu)
		{
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			Detail = new NavigationPage (displayPage);

			IsPresented = false;
		}
	}
}


