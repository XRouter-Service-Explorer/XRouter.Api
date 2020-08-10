using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.Monero
{
    public class GetBlockResponseViewModel : XRouterBaseResponseViewModel
    {
        public BlockResponseViewModel Reply { get; set; }
    }
}