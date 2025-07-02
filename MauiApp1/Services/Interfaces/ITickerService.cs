using BlazorBootstrap;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal interface ITickerService
    {
        Task<IEnumerable<TickerModel>> GetPage(int page, int pageSize);
        Task<int> GetTotalRecords();
    }
}
