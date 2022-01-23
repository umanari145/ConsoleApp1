// <copyright file="CollectionSample.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleApp1.Util
{
    using ConsoleApp1.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 　Collection Class Sampleは簡単なコレクションのサンプルです。
    /// </summary>
    public class CollectionClassSample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionClassSample"/> class.
        /// </summary>
        public CollectionClassSample()
        {
        }

        /// <summary>
        /// 　StartCollectionClassSample 外から呼び出されるクラス.
        /// </summary>
        public void StartCollectionSample()
        {
            Console.WriteLine("Collection ClassSample");
            List<User> userList = this.ConvertSample();
            this.FilterCollection(userList);
            this.GroupByCollection(userList);
        }

        /// <summary>
        /// 　ConvertClassSample 値の変換.
        /// </summary>
        /// <returns>変換されたリスト</returns>
        private List<User> ConvertSample()
        {
            List<User> userList = new List<User>();

            // 一番プレーンな書き方
            User user = new User()
            {
                id = 1,
                name = "kiyohara",
                sex = 1,
                pref = "osaka",
                birthday = new DateTime(1967, 8, 18),
            };

            userList.Add(user);

            User user2 = new User()
            {
                id = 2,
                name = "kuwata",
                sex = 1,
                pref = "osaka",
                birthday = new DateTime(1968, 4, 1),
            };

            userList.Add(user2);

            User user3 = new User()
            {
                id = 3,
                name = "ochiai",
                sex = 1,
                pref = "akita",
                birthday = new DateTime(1953, 12, 9),
            };

            userList.Add(user3);

            User user4 = new User()
            {
                id = 4,
                name = "matsui",
                sex = 1,
                pref = "ishikawa",
                birthday = new DateTime(1974, 6, 12),
            };

            userList.Add(user4);

            return userList;
        }

        /// <summary>
        /// 　filterCollection 値のフィルタリング.
        /// </summary>
        private void FilterCollection(List<User> userList)
        {
            //List<User> userList2 = (List<User>)userList.Where(u => u.pref == "akita");
            List<User> userList2 = userList.Where(u => u.pref == "akita").ToList();
            Console.WriteLine("filter");
            foreach (User eachUser in userList2)
            {
                Console.WriteLine(eachUser.id);
                Console.WriteLine(eachUser.name);
            }
        }

        /// <summary>
        /// 　groupByCollection groupByのサンプル.
        /// </summary>
        /// <param name="List<User">リストのサンプル</param>
        private void GroupByCollection(List<User> userList)
        {
            Console.WriteLine("groupby");
            var userList2 = userList.GroupBy(e => e.pref);
            foreach (var userList3 in userList2)
            {
                // 年齢順位置き換え
                Console.WriteLine($"key:{userList3.Key}");
                foreach (User user in userList3.OrderByDescending(u => u.birthday))
                {
                    Console.WriteLine(user.name);
                }
            }
        }
    }
}
