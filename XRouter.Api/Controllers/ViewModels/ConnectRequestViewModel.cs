using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace XRouter.Api.Controllers.ViewModels
{
    public class ConnectRequestViewModel
    {
        public string Service { get; set; }
        public short NodeCount { get; set; }
    }
}