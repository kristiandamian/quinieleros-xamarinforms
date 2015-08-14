using System;
using Xamarin.Forms;

namespace quinieleros
{
	public static class Login
	{
		static NavigationPage _NavPage;
		static string _Token;
		public static string Token {
			get { return _Token; }
		}

		public static Page GetMainPage ()
		{
			var profilePage = new Menu();

			_NavPage = new NavigationPage(profilePage);

			return _NavPage;

		}

		public static bool IsLoggedIn {
			get { return !string.IsNullOrWhiteSpace(_Token); }
		}
		public static void SaveToken(string token)
		{
			_Token = token;
		}

		public static Action SuccessfulLoginAction
		{
			get {
				return new Action (() => {
					_NavPage.Navigation.PopModalAsync();
				});
			}
		}

		public static OAuthSettings OAuth(Models.TipoLogin tipo){
			OAuthSettings _tipoLogin=null;
			switch (tipo) {
			case quinieleros.Models.TipoLogin.Facebook:
				_tipoLogin = Facebook.OAuth2 ();
				break;
			case quinieleros.Models.TipoLogin.Google:
				_tipoLogin = Google.OAuth2 ();
				break;
			default:
				break;
			}
			return _tipoLogin;
		}
	}
}

