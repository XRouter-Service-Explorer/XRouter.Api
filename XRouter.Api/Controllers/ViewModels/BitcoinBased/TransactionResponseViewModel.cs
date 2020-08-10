using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.BitcoinBased
{
    public class TransactionResponseViewModel: XRouterBaseResponseViewModel
    {
        public RawTransactionResponseViewModel Reply { get; set; }
    }
}