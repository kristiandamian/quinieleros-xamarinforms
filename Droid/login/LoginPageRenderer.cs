using System; 
using Android.App;
using quinieleros;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer (typeof (LoginPage), typeof (LoginPageRenderer))]
namespace quinieleros.Droid
{
	public class LoginPageRenderer : PageRenderer
	{
		public models.TipoLogin Tipo {
			get;
			set;
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);

			// this is a ViewGroup - so should be able to load an AXML file and FindView<>
			var activity = this.Context as Activity;

			var config = Login.OAuth (Tipo);//FACEBOOK O GOOGLE

			var auth = new OAuth2Authenticator (
				clientId: config.ClientId, // your OAuth2 client id
				scope: config.Scope, // The scopes for the particular API you're accessing. The format for this will vary by API.
				authorizeUrl: new Uri (config.AuthorizeUrl), // the auth URL for the service
				redirectUrl: new Uri (config.RedirectUrl)); // the redirect URL for the service

			auth.Completed += (sender, eventArgs) => {
				if (eventArgs.IsAuthenticated) {
					Login.SuccessfulLoginAction.Invoke();
					// Use eventArgs.Account to do wonderful things
					Login.SaveToken(eventArgs.Account.Properties["access_token"]);
				} else {
					// The user cancelled
				}
			};

			activity.StartActivity (auth.GetUI(activity));
		}
	}
}

