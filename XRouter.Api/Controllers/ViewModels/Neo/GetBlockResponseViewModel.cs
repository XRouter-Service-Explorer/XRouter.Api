using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.Neo
{
    public class GetBlockResponseViewModel : XRouterBaseResponseViewModel
    {
        public BlockResponseViewModel Reply { get; set; }
    }
}