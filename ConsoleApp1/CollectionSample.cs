using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class CollectionSample
    {
        public CollectionSample()
        {
            Console.WriteLine("Collection Sample");
            this.SumSample();
            this.MapSample();
            List<Dictionary<String, String>> lc = this.ConvertSample();
            this.filterCollection(lc);
        }

        public void SumSample()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int sumAnswer = array.Sum();
            Console.WriteLine("sum:" + sumAnswer);
        }

        public void MapSample()
        {
            int[] array = { 2, 1, 3, 4, 5 };
            /*
            foreach(var ele in array.Select(s => s * 2))
            {
                Console.WriteLine("eachElement" + ele);
            }*/

            //Collectionの型
            IEnumerable<int> collectionSample = array.Select(s => s * 2);
            foreach(int c in collectionSample)
            {
                Console.WriteLine($"eachElement {c}");
            }

        }

        public List<Dictionary<String, String>> ConvertSample()
        {
            List<Dictionary<String, String>> lc = new List<Dictionary<String, String>>();
            //一番プレーンな書き方
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("name", "kazuki");
            dic.Add("domain", "gmail");
            dic.Add("age", "30");
            dic.Add("pref", "chiba");
            lc.Add(dic);

            //初期化＋定義
            Dictionary<String, String> dic2 = new Dictionary<string, string>()
            {
                {"name", "ichirou"},
                {"domain", "yahoo.co.jp"},
　              {"age", "18"},
                {"pref", "tokyo"},
            };
            lc.Add(dic2);

            //簡便な書き方
            var dic3  = new Dictionary<string, string>()
            {
                {"name", "yuusuke"},
                {"domain", "hotmail.com"},
              　{"age", "25"},
                {"pref", "chiba"},
            };
            lc.Add(dic3);

            //簡便な書き方
            var dic4 = new Dictionary<string, string>()
            {
                {"name", "satoshi"},
                {"domain", "gmail.com"},
                {"age", "45"},
                {"pref", "kanagawa"},
            };
            lc.Add(dic4);


            //簡便な書き方
            var dic5 = new Dictionary<string, string>()
            {
                {"name", "jirou"},
                {"domain", "hotmail.com"},
                {"age", "9"},
                {"pref", "tokyo"},
            };

            lc.Add(dic5);

            //展開した方法
            /*foreach (var eachDic in lc)
            {
                foreach(var pair in eachDic)
                {
                    Console.WriteLine($"key={pair.Key}, value={pair.Value}");
                }
                Console.WriteLine("------------------------------------------");
            }*/

            return lc;
        }

        public void filterCollection(List<Dictionary<String, String>> lc)
        {
            //var lc2 = lc.Where(e => e["pref"] == "tokyo");
            var lc2 = lc.Where(e => int.Parse(e["age"]) >= 20);
            foreach (var ele in lc2) {
                Console.WriteLine("{" + String.Join(", ", from v in ele select v.Key + "=>" + v.Value) + "}");
            }

        }
    }
}
