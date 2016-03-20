namespace TwitterLike.RssReader
{
    using System.Collections.Generic;
    using System.Xml;

    public class RssFeederXml
    {

        public List<RssItem> ReadRss(string url)
        {
            
            XmlDocument rssDoc = new XmlDocument();
            var rssContent = new List<RssItem>();
            rssDoc.Load(url);

            foreach (XmlNode rssNode in rssDoc)
            {
                if (rssNode.Name == "rss")
                {
                    XmlNode rssSubNode = rssNode.SelectSingleNode("channel");
                    var rssItems = rssSubNode.SelectNodes("item");
                    foreach (XmlNode item in rssItems)
                    {
                        var title = item.SelectSingleNode("title").InnerText;
                        var urlItem = item.SelectSingleNode("link").InnerText;
                        var date = item.SelectSingleNode("pubDate").InnerText;
                        var description = item.SelectSingleNode("description").InnerText;
                        var rssItem = new RssItem
                        {
                            Title = title,
                            Link = urlItem,
                            Description = description,
                            Date = date
                        };
                        rssContent.Add(rssItem);
                    }
                }
            }
            return rssContent;
        }
    }
}
