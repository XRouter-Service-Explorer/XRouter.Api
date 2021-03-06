﻿using System.Collections.Generic;

namespace XRouter.Api.Controllers.ViewModels.BitcoinBased
{
    public class ScriptPubKeyViewModel
    {
        public class ScriptPubKey
        {
            public string Asm { get; set; }
            public string Hex { get; set; }
            public int ReqSigs { get; set; }
            public string Type { get; set; }
            public List<string> Addresses { get; set; }
        }
    }
}