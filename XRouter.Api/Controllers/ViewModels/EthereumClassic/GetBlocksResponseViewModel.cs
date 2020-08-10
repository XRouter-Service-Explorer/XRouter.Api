using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.EthereumClassic
{
    public class GetBlocksResponseViewModel : XRouterBaseResponseViewModel
    {
        public List<BlockResponseViewModel> Reply { get; set; }
    }
}