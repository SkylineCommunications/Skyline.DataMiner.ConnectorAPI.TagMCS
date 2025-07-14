using System;
using System.Collections.Generic;
using System.Text;
using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages;
using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
using Skyline.DataMiner.Core.InterAppCalls.Common.MessageExecution;

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Executors
{
    /// <summary>
    /// Executor for the <see cref="InterAppResponse"/> message.
    /// </summary>
    public class InterAppExecutor : MessageExecutor<InterAppResponse>
    {
        /// <inheritdoc />
        public InterAppExecutor(InterAppResponse message) : base(message)
        {
        }

        /// <inheritdoc />
        public override Message CreateReturnMessage()
        {
            return null; // not required
        }

        /// <inheritdoc />
        public override void DataGets(object dataSource)
        {
        }

        /// <inheritdoc />
        public override void DataSets(object dataDestination)
        {
        }

        /// <inheritdoc />
        public override void Modify()
        {
        }

        /// <inheritdoc />
        public override void Parse()
        {
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Message.ResponseMessage;
        }

        /// <inheritdoc />
        public override bool Validate()
        {
            return Message.Success;
        }
    }
}
