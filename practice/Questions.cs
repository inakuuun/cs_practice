using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    /// <summary>
    /// 基本情報資格試験勉強クラス
    /// </summary>
    public class Questions
    {
        /// <summary>
        /// 単方向リスト生成クラス
        /// </summary>
        private ListElement? listHead = null;

        public void QuestStart()
        {
            // 単方向リスト生成
            Question3("あいうえお");
            Question3("こんにちは");
            // 親のデータが空の場合
            if (listHead == null)
            {
                Console.WriteLine("データが存在しません");
            }
            // 親のデータが存在する場合
            else
            {
                // 子データが存在する場合
                // 子データを優先的に表示する
                if (listHead.NextNode != null)
                {
                    // 子データが保持する値を表示
                    Console.WriteLine(listHead.NextNode.CurrVal);
                }
                // 子データが存在しない場合
                else
                {
                    // 親のデータ値を表示
                    Console.WriteLine(listHead.CurrVal);
                }
            }

            // ユーグリッドの互除法
            Question4(50, 120);

            // ツリー構造
            Console.WriteLine($"■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine($" ツリー構造 処理開始");
            Question9(1);
            Console.WriteLine("");


        }


        /// <summary>
        /// 過去問演習問3
        /// </summary>
        /// <remarks>
        /// 単方向リスト生成処理
        /// </remarks>
        /// <returns></returns>
        private void Question3(string qVal)
        {
            ListElement? prev = new();
            ListElement? curr = new ListElement(qVal);

            // 初期処理
            if (listHead == null)
            {
                listHead = curr;
            }
            // 2回目以降
            else
            {
                // 子データが存在する間ループ処理を実施
                while(listHead.NextNode != null)
                {
                    listHead = listHead.NextNode;
                }
                // while文を抜けたタイミングで親データが最新のインスタンスになっている
                // 最新の親データに今回インスタンス化したデータを子として格納
                listHead.NextNode = curr;
            }
        }

        /// <summary>
        /// 過去問演習問4
        /// </summary>
        /// <remarks>
        /// ユーグリッドの互除法を使った計算
        /// </remarks>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private void Question4(int num1, int num2)
        {
            int x = num1;
            int y = num2;

            Console.WriteLine($"■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine($" ユーグリッドの互除法を使った計算 処理開始");
            Console.WriteLine($"----------------------------------------------------");
            while (x != y)
            {
                Console.WriteLine($"x = {x}：y = {y}");
                if (x > y)
                {
                    Console.Write($"{x}-{y}は");
                    x = x - y;
                    Console.WriteLine($"{x}です");
                }
                else
                {
                    Console.Write($"{y}-{x}は");
                    y = y - x;
                    Console.WriteLine($"{y}です");
                }
                Console.WriteLine($"----------------------------------------------------");
            }
            Console.WriteLine($"取得結果は:{x}です{Environment.NewLine}");
        }

        /// <summary>
        /// 過去問演習問9
        /// </summary>
        /// <remarks>
        /// ツリー構造の出力
        /// </remarks>
        /// <returns></returns>
        private void Question9(int num)
        {
            // ツリー構造の初期化
            int[,] tree = new int[,]
            {
                { 0, 0 }, // 演習問題とインデックスを揃えるため
                { 2, 3 },
                { 4, 5 },
                { 6, 7 },
                { 8, 9 },
                { 10, 11 },
                { 12, 13 },
                { 14, 0 },
                // 以下はインデックスエラー対策
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
            };

            // n番目の要素が2つ以上ある場合
            if (tree[num,0] > 0 && tree[num, 1] > 0)
            {
                // 1つめの要素で再帰処理
                Question9(tree[num, 0]);
                // nを出力
                Console.Write($"{num},");
                // 2つめの要素で再帰処理
                Question9(tree[num, 1]);
            }
            // n番目の要素が1つだけの場合
            else if (tree[num, 0] > 0)
            {
                // 1つめの要素で再帰処理
                Question9(tree[num, 0]);
                // nを出力
                Console.Write($"{num},");
            }
            else
            {
                // nを出力
                Console.Write($"{num},");
            }
        }
    }
}
