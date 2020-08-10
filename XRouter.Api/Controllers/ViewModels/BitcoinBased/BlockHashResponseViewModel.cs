using System.Collections.Generic;
using Blocknet.Lib.RPC.Deserializer;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.BitcoinBased
{
    public class BlockHashResponseViewModel : XRouterBaseResponseViewModel
    {
        public string Reply { get; set; }
    }
}