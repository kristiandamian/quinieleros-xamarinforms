using System;

namespace quinieleros.Models
{
	public class Partido
	{
		public Models.Equipo local { get; set; }
		public Models.Equipo visitante { get; set; }
		public Models.Resultado resultado{ get; set; }
		public DateTime fecha { get; set; }
		public string nombreEstadio { get; set; }

	}
}