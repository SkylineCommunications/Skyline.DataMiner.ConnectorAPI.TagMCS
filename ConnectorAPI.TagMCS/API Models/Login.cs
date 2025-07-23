namespace QAction_1.API_Models
{
	using Newtonsoft.Json;

	public class Credentials
	{
		public Credentials(string username, string password)
		{
			Username = username;
			Password = password;
		}

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }
	}

	public class RefreshLogin
	{
		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }
	}

	public class Login
	{
		[JsonProperty("data")]
		public TokensData Data { get; set; }

		[JsonProperty("metadata")]
		public object Metadata { get; set; }
	}

	public class TokensData
	{
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }
	}
}
