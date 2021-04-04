using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class SchoolGetter
    {
        public ArrayList schoolList;

        public SchoolGetter()
        {
            this.schoolList = new ArrayList();
        }

        public void GetHTML()
        {
            WebClient wc = new WebClient();
            String html = wc.DownloadString("https://www.meikogijuku.jp/school/chiba/");
            var parser = new HtmlParser();
            var doc = parser.ParseDocument(html);
            var mainSrc = doc.QuerySelectorAll("table[class='class_list_info']");
            this.GetSchoolByCity(mainSrc);
            Console.WriteLine("aaa");
        }

        private void GetSchoolByCity(IHtmlCollection<IElement> mainSrc)
        {
            foreach (var item in mainSrc)
            {
                var eachSchool = item.QuerySelectorAll("tr[class='class_list_row']");
                foreach (var school in eachSchool)
                {
                    this.EachSchool(school);
                }
            }
        }

        public void EachSchool(AngleSharp.Dom.IElement school)
        {
            School singleSchool = new School();

            var element = school.QuerySelectorAll("td[class='class_list_cell']");
            var eleLength = element.Length;


            string tmpUrl = element[0].QuerySelector("a").GetAttribute("href");
            singleSchool.url = $"https://www.meikogijuku.jp{tmpUrl}";
            singleSchool.name = element[0].TextContent;

            singleSchool.address = element[1].TextContent;

            string tmpTel = element[2].QuerySelector("a").GetAttribute("href");
            singleSchool.tel = tmpTel.Replace("tel:", "");

            string tmpStation = element[3].TextContent;
            singleSchool.station = tmpStation.Replace("最寄駅","");

            this.schoolList.Add(singleSchool);
        }
    }
}
