using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class ListPractice
    {
        private List<string> list = new();

        public void ListStart()
        {
            // 配列をリストに追加
            string[] src = { "Tokyo", "Osaka", "Nagoya", "Kitamura" };
            list.AddRange(src);

            // リスト追加
            list.Add("Kanagawa");
            list.Add("Yokohama");
            list.Add("Osaka");
            list.Add("Ehime");

            // 削除
            list.RemoveAll(x => x == "Osaka");

            // 昇順ソート
            list.OrderBy(x => x);

            // 降順ソート
            list.OrderByDescending(x => x);

            Console.WriteLine(list.IndexOf("Ehime"));

            foreach (var val in list)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine(list.Count);
        }
    }
}
