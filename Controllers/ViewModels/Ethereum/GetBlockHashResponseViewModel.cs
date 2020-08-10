using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.Ethereum
{
    public class GetBlockHashResponseViewModel : XRouterBaseResponseViewModel
    {
        public BlockHashResponseViewModel Reply { get; set; }
    }
}