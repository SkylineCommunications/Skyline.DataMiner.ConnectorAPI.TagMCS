namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Request to update a Channel Configuration on TAG
    /// </summary>
    public class SetChannelConfigRequest : Message
    {
        /// <summary>
        /// The Channel Configuration to be set on TAG
        /// </summary>
        public Channel Channel { get; set; }
    }
}
