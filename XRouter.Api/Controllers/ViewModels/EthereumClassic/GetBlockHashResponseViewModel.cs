using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.EthereumClassic
{
    public class GetBlockHashResponseViewModel : XRouterBaseResponseViewModel
    {
        public BlockHashResponseViewModel Reply { get; set; }
    }
}