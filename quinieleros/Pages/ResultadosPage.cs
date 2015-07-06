using System;

using Xamarin.Forms;

namespace quinieleros
{
	public class ResultadosPage : ContentPage
	{
		public ResultadosPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


