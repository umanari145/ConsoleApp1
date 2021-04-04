using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void getHTML()
        {
            try
            {
                WebClient wc = new WebClient();
                String html = wc.DownloadString("https://www.dmm.co.jp/digital/-/list/search/=/?searchstr=%E9%88%B4%E6%9D%91%E3%81%82%E3%81%84%E3%82%8A");
                var parser = new HtmlParser();
                var doc = parser.ParseDocument(html);
                var parseDoc = doc.GetElementById("main-src");
                
            }
            catch(Exception e)
            {
                Console.WriteLine("exception");
                Console.WriteLine(e.Message);
            }
        }
    }
}
