// <copyright file="CollectionSample.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleApp1.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 　Collection Sampleは簡単なコレクションのサンプルです。
    /// </summary>
    public class CollectionSample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSample"/> class.
        /// </summary>
        public CollectionSample()
        {
        }

        /// <summary>
        /// 　StartCollectionSample 外から呼び出されるクラス.
        /// </summary>
        public void StartCollectionSample()
        {
            Console.WriteLine("Collection Sample");
            this.ArithmeticSample();
            this.MapSample();
            List<Dictionary<string, string>> lc = this.ConvertSample();
            this.FilterCollection(lc);
            this.groupByCollection(lc);
            this.sortByCollection(lc);
        }

        /// <summary>
        /// 　ArithmeticSample 算術関数.
        /// </summary>
        public void ArithmeticSample()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int sumAnswer = array.Sum();
            Console.WriteLine("sum:" + sumAnswer);

            double averageAnswer = array.Average();
            Console.WriteLine("average:" + averageAnswer);

            int countAnswer = array.Count();
            Console.WriteLine("count:" + countAnswer);

            int maxAnswer = array.Max();
            Console.WriteLine("max:" + maxAnswer);

            int minAnswer = array.Min();
            Console.WriteLine("min:" + minAnswer);
        }

        /// <summary>
        /// 　MapSample mapの変換処理.
        /// </summary>
        public void MapSample()
        {
            int[] array = { 2, 1, 3, 4, 5 };
            /*
            foreach(var ele in array.Select(s => s * 2))
            {
                Console.WriteLine("eachElement" + ele);
            }*/

            // Collectionの型
            IEnumerable<int> collectionSample = array.Select(s => s * 2);
            foreach (int c in collectionSample)
            {
                Console.WriteLine($"eachElement {c}");
            }
        }

        /// <summary>
        /// 　ConvertSample 値の変換.
        /// </summary>
        /// <returns>変換されたリスト</returns>
        public List<Dictionary<string, string>> ConvertSample()
        {
            List<Dictionary<string, string>> lc = new List<Dictionary<string, string>>();

            // 一番プレーンな書き方
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name", "kazuki");
            dic.Add("domain", "gmail");
            dic.Add("age", "30");
            dic.Add("pref", "chiba");
            dic.Add("math", "67");
            dic.Add("english", "87");
            lc.Add(dic);

            // 初期化＋定義
            Dictionary<string, string> dic2 = new Dictionary<string, string>()
            {
                { "name", "ichirou" },
                { "domain", "yahoo.co.jp" },
                { "age", "30" },
                { "pref", "tokyo" },
                { "math", "55" },
                { "english", "12" },
            };
            lc.Add(dic2);

            // 簡便な書き方
            var dic3 = new Dictionary<string, string>()
            {
                { "name", "yuusuke" },
                { "domain", "hotmail.com" },
                { "age", "30" },
                { "pref", "chiba" },
                { "math", "67" },
                { "english", "75" },
            };
            lc.Add(dic3);

            // 簡便な書き方
            var dic4 = new Dictionary<string, string>()
            {
                { "name", "satoshi" },
                { "domain", "gmail.com" },
                { "age", "45" },
                { "pref", "kanagawa" },
                { "math", "23" },
                { "english", "47" },
            };
            lc.Add(dic4);

            // 簡便な書き方
            var dic5 = new Dictionary<string, string>()
            {
                { "name", "jirou" },
                { "domain", "hotmail.com" },
                { "age", "9" },
                { "pref", "tokyo" },
                { "math", "45" },
                { "english", "9" },
            };

            lc.Add(dic5);

            // 展開した方法
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

        /// <summary>
        /// 　filterCollection 値のフィルタリング.
        /// </summary>
        public void FilterCollection(List<Dictionary<string, string>> lc)
        {
            // var lc2 = lc.Where(e => e["pref"] == "tokyo");
            Console.WriteLine("filter");
            var lc2 = lc.Where(e => int.Parse(e["age"]) >= 20);
            foreach (var ele in lc2)
            {
                Console.WriteLine(string.Join(", ", ele.Select(v => $"{v.Key}:{v.Value}")));
            }
        }

        /// <summary>
        /// 　groupByCollection groupByのサンプル.
        /// </summary>
        /// <param name="lc">リストのサンプル</param>
        public void GroupByCollection(List<Dictionary<string, string>> lc)
        {
            Console.WriteLine("groupby");
            var lc2 = lc.GroupBy(e => e["pref"]);
            foreach (var ele in lc2)
            {
                // 年齢順位置き換え
                Console.WriteLine($"key:{ele.Key}");
                foreach (var eachDic in ele.OrderBy(v => int.Parse(v["age"])))
                {
                    eachDic["email"] = $"{eachDic["name"]}@{eachDic["domain"]}";
                    // mapのデバッグ
                    Console.WriteLine(string.Join(",", eachDic.Select(v => $"{v.Key}: {v.Value}")));
                }
            }
        }

        /// <summary>
        /// 　SortByCollection sortのサンプル.
        /// </summary>
        /// <param name="lc">リストのサンプル</param>
        public void SortByCollection(List<Dictionary<string, string>> lc)
        {
            Console.WriteLine("sortByCollection");
            var sortList = lc.OrderBy(v => int.Parse(v["age"]));
            sortList = sortList.ThenBy(v => int.Parse(v["math"]));
            sortList = sortList.ThenBy(v => int.Parse(v["english"]));
            foreach (var sl in sortList)
            {
                Console.WriteLine(string.Join(",", sl.Select(v => $"{v.Key}: {v.Value}")));
            }

            Console.WriteLine("sort result");

        }
    }
}
