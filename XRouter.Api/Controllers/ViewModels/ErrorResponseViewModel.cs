using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels
{
    public class ErrorResponseViewModel
    {
        public int Code { get; set; }
        public JsonRpcError Error { get; set; }
        public int Id { get; set; }
    }
}