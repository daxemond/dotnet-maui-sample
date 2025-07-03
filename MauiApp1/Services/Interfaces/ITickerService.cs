#if ANDROID
    using Android.Content;
    using Android.Net.Wifi.Rtt;
    using Android.Renderscripts;
    using static Android.Icu.Util.LocaleData;
#endif
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
        Task<IEnumerable<TickerModel>> GetPage(TickerSearchModel? search, IEnumerable<SortingItem<TickerModel>> sortings, int page, int pageSize);
        Task<int> GetTotalRecords(TickerSearchModel? search);

        Task<IEnumerable<AutoCompleteModel>> GetAllIndexes();
    }
}
