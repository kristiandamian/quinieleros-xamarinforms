using System;

using Xamarin.Forms;

namespace quinieleros
{
	public class InicioPage : ContentPage
	{
		public InicioPage ()
		{
			var btnFacebook = new Button {
				Image = "Facebook.png"
			};
			var btnGoogle=new Button{
				Image="Google.png"
			};
			btnFacebook.Clicked += BtnFacebook_Clicked;
			btnGoogle.Clicked += BtnGoogle_Clicked;

			this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

			Content = new StackLayout { 
				Children = {
					btnFacebook,
					btnGoogle
				}
			};
		}

		void BtnGoogle_Clicked (object sender, EventArgs e)
		{
			var log = new LoginPage ();
			log.Tipo = quinieleros.Models.TipoLogin.Google;
			Navigation.PushModalAsync(log);
		}

		void BtnFacebook_Clicked (object sender, EventArgs e)
		{
			var log = new LoginPage ();
			log.Tipo = quinieleros.Models.TipoLogin.Facebook;
			Navigation.PushModalAsync(log);
		}
	}
}


