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
				IconSource = "resultados.png", 
				TargetType = typeof(ResultadosPage)
			});

			this.Add (new MenuItem () { 
				Title = "Crear grupo", 
				IconSource = "grupo.png", 
				TargetType = typeof(CrearGrupoPage)
			});

			this.Add (new MenuItem () { 
				Title = "Ver grupo", 
				IconSource = "verGrupo.png", 
				TargetType = typeof(VerGrupoPage)
			});

			this.Add (new MenuItem () {
				Title = "Estadisticas",
				IconSource = "estadisticas.png",
				TargetType = typeof(EstadisticasPage)
			});
		}
	}
}


