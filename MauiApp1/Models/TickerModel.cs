using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class TickerModel
    {
        public required DateTimeOffset TradeDate { get; set; }
        public required string Symbol { get; set; }
        public required string Index { get; set; }
        public required float Open { get; set; }
        public required float Close { get; set; }
        public required float High { get; set; }
        public required float Low { get; set; }
        public required float Volume { get; set; } = 0;

    }
}
