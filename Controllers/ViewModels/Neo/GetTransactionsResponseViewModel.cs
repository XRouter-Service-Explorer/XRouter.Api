using System.Collections.Generic;
using Blocknet.Lib.Responses;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels.Neo
{
    public class GetTransactionsResponseViewModel: XRouterBaseResponseViewModel
    {
        public List<TransactionResponseViewModel> Reply { get; set; }
    }
}