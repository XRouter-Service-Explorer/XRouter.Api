using AutoMapper;
using Blocknet.Lib.Responses;
using Blocknet.Lib.Responses.Monero;
using Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Monero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRouter.Api.Controllers.ViewModels;
using XRouter.Api.Controllers.ViewModels.Monero;

namespace XRouter.Api.Mapper
{
    public class XRouterMoneroMappingProfile : Profile
    {
        public XRouterMoneroMappingProfile()
        {
            CreateMap<BlockHeader, BlockHeaderViewModel>();
            CreateMap<Transaction, TransactionViewModel>();

            CreateMap<TransactionResponse, TransactionResponseViewModel>();
            CreateMap<Blocknet.Lib.Responses.Monero.BlockResponse, BlockResponseViewModel>();
            CreateMap<GetBlockCountResponse, GetBlockCountResponseViewModel>()
                .ForSourceMember(bc => bc.Code, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Error, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Id, opt => opt.DoNotValidate());
            CreateMap<GetBlockHashResponse, GetBlockHashResponseViewModel>()
                .ForSourceMember(bc => bc.Code, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Error, opt => opt.DoNotValidate())
                .ForSourceMember(bc => bc.Id, opt => opt.DoNotValidate());

            CreateMap<Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Monero.GetBlockResponse, GetBlockResponseViewModel>();
            CreateMap<GetBlocksResponse, GetBlocksResponseViewModel>();
            CreateMap<Blocknet.Lib.Services.Coins.Blocknet.Xrouter.Monero.GetTransactionResponse, GetTransactionResponseViewModel>();
            CreateMap<GetTransactionsResponse, GetTransactionsResponseViewModel>();
            CreateMap<SendTransactionResponse, SendTransactionResponseViewModel>();
            CreateMap<GetDecodeRawTransactionResponse, GetDecodeRawTransactionResponseViewModel>();            
        }
    }
}
