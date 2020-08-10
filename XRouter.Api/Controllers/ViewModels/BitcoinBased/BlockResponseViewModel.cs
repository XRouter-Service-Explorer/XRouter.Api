using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.BitcoinBased
{
    public class BlockResponseViewModel : XRouterBaseResponseViewModel
    {
        public BlockViewModel Reply { get; set; }
    }
}