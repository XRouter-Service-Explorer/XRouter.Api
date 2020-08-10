using AutoMapper;
using Blocknet.Lib.Responses;
using Blocknet.Lib.Responses.SharedComponents;
using Blocknet.Lib.Services.Coins.Blocknet.Xrouter;
using Blocknet.Lib.Services.Coins.Blocknet.Xrouter.EthereumClassic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRouter.Api.Controllers.ViewModels;
using XRouter.Api.Controllers.ViewModels.EthereumClassic;

namespace XRouter.Api.Mapper
{
    public class XRouterEthereumClassicMappingProfile : Profile
    {
        public XRouterEthereumClassicMappingProfile()
        {
            CreateMap<Blocknet.Lib.Responses.EthereumClassic.BlockHashResponse, BlockHashResponseViewModel>();
            CreateMap<Blocknet.Lib.Responses.EthereumClassic.BlockResponse, BlockResponseViewModel>();
            CreateMap<Blocknet.Lib.Responses.EthereumClassic.TransactionResponse, TransactionResponseViewModel>();
            CreateMap<Blocknet.Lib.Services.Coins.Blocknet.Xrouter.EthereumClassic.GetBlockResponse, GetBlockResponseViewModel>();
            CreateMap<GetBlocksResponse, GetBlocksResponseViewModel>();
            CreateMap<Blocknet.Lib.Services.Coins.Blocknet.Xrouter.EthereumClassic.GetTransactionResponse, GetTransactionResponseViewModel>();
            CreateMap<GetTransactionsResponse, GetTransactionsResponseViewModel>();
            CreateMap<SendTransactionResponse, SendTransactionResponseViewModel>();
            CreateMap<GetBlockCountResponse, GetBlockCountResponseViewModel>()
                .ForSourceMember(bc => bc.Code, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Error, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Id, opt => opt.DoNotValidate());
            CreateMap<GetBlockHashResponse, GetBlockHashResponseViewModel>();
        }
    }
}
