namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// InterApp request to create or update a Tally Proxy entry. The executor decides whether to POST
    /// (create, when no matching entry exists yet) or PUT (update, when one already does) against the
    /// TAG MCS API.
    /// </summary>
    public class AddOrUpdateTallyProxyRequest : Message
	{
		/// <summary>
		/// Gets or sets the Tally Proxy entry to create or update. <see cref="TallyProxyEntry.Device"/> or
		/// <see cref="TallyProxyEntry.Output"/> (whichever applies) must already hold a resolved UUID.
		/// </summary>
		public TallyProxyEntry Entry { get; set; }
	}
}
