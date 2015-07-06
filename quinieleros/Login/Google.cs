using System;

namespace quinieleros
{
	public  class Google : ITipoLogin
	{
		public static new OAuthSettings OAuth2()
		{
			return new OAuthSettings("","","","");
		}
	}
}

