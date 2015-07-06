using System;

namespace quinieleros
{
	public abstract class ITipoLogin{
		public  static  OAuthSettings OAuth2;
	}
	
	public  class Facebook : ITipoLogin
	{
		public static new OAuthSettings OAuth2()
		{
			return new OAuthSettings ("","","","");
		}
	}
}

