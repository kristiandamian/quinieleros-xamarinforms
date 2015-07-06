using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace quinieleros
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "Resultados", 
				IconSource = "contracts.png", 
				TargetType = typeof(ResultadosPage)
			});

			this.Add (new MenuItem () { 
				Title = "Crear grupo", 
				IconSource = "Lead.png", 
				TargetType = typeof(CrearGrupoPage)
			});

			this.Add (new MenuItem () { 
				Title = "Ver grupo", 
				IconSource = "Accounts.png", 
				TargetType = typeof(VerGrupoPage)
			});

			this.Add (new MenuItem () {
				Title = "Estadisticas",
				IconSource = "Opportunity.png",
				TargetType = typeof(EstadisticasPage)
			});
		}
	}
}


