using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Interface
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllStock();

        Task<Stock?> GetById(int id);

        Task<Stock> Create(Stock createStock);

        Task<Stock?> Update(int id, UpdateStockRequestDto updateStock);
        
        Task<Stock?> Delete(int id);
    }
}