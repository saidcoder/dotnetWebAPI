using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Dtos.Stock;
using api.Models;
using AutoMapper;

namespace api.Mappers
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
            CreateMap<Stock, StockDto>().ReverseMap();
            CreateMap<Stock, CreateStockRequestDto>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();
            // CreateMap<Stock, CreateStockRequestDto>().ReverseMap();
        }

        // public static StockDto ToStockDto(this Stock stockModel)
        // {
        //     return new StockDto
        //     {
        //         Id = stockModel.Id,
        //         Symbol = stockModel.Symbol,
        //         CompanyName = stockModel.CompanyName,
        //         Purchase = stockModel.Purchase,
        //         LastDiv = stockModel.LastDiv,
        //         Industry = stockModel.Industry,
        //         MarketCap = stockModel.MarketCap
        //     };
        // }
    }
}