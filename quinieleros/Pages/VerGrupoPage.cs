using System;

using Xamarin.Forms;

namespace quinieleros
{
	public class VerGrupoPage : ContentPage
	{
		public VerGrupoPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


