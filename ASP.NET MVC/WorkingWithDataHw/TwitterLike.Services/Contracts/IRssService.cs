using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterLike.RssReader;

namespace TwitterLike.Services.Contracts
{
    public interface IRssService
    {
        List<RssItem> GetAllFrogNews();
        List<RssItem> GetAllNewsBg();
        List<RssItem> GetStandartNewsBg();
        List<RssItem> GetAllDarikNews();
        List<RssItem> GetOffNewsBg();
    }
}
