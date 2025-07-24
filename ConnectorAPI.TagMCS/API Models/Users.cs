#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class UsersConfig
	{
		[JsonProperty("data")]
		public List<UserData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class UserData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("role")]
		public string Role { get; set; }
	}

	public class Links
	{
		[JsonProperty("current")]
		public string Current { get; set; }
	}

	public class Metadata
	{
		[JsonProperty("item_count")]
		public int ItemCount { get; set; }

		[JsonProperty("total_items")]
		public int TotalItems { get; set; }

		[JsonProperty("current_page")]
		public int CurrentPage { get; set; }

		[JsonProperty("sort_by")]
		public List<SortBy> SortBy { get; set; }

		[JsonProperty("links")]
		public Links Links { get; set; }
	}

	public class SortBy
	{
		[JsonProperty("field")]
		public string Field { get; set; }

		[JsonProperty("direction")]
		public string Direction { get; set; }
	}

	public class DeleteResponse
	{
		[JsonProperty("data")]
		public DeleteData Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class DeleteData
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}

	public class CreateUser
	{
		public CreateUser()
		{
		}

		public CreateUser(string username, string password, string role)
		{
			Username = username ?? throw new ArgumentNullException(nameof(username));
			Password = password ?? throw new ArgumentNullException(nameof(password));
			Role = role ?? throw new ArgumentNullException(nameof(role));
		}

		[JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
		public string Uuid { get; set; }

		[JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
		public string Username { get; set; }

		[JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
		public string Password { get; set; }

		[JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
		public string Role { get; set; }
	}

	public class AddUserResponse
	{
		[JsonProperty("data")]
		public UserData Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class UsersStatus
	{
		[JsonProperty("data")]
		public List<StatusData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class StatusData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("sessions")]
		public List<Session> Sessions { get; set; }
	}

	public class Session
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }

		[JsonProperty("created_by_ip")]
		public string CreatedByIp { get; set; }

		[JsonProperty("revoked_by_user")]
		public string RevokedByUser { get; set; }

		[JsonProperty("revoked_by_ip")]
		public string RevokedByIp { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}
