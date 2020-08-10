using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.Neo
{
    public class GetBlocksResponseViewModel : XRouterBaseResponseViewModel
    {
        public List<GetBlockResponseViewModel> Reply { get; set; }
    }
}