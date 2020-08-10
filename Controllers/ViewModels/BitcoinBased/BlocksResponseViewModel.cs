using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.BitcoinBased
{
    public class BlocksResponseViewModel : XRouterBaseResponseViewModel
    {
        public List<BlockViewModel> Reply { get; set; }
    }
}