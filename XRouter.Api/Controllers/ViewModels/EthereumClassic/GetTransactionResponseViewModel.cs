using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.EthereumClassic
{
    public class GetTransactionResponseViewModel: XRouterBaseResponseViewModel
    {
        public TransactionResponseViewModel Reply { get; set; }
    }
}