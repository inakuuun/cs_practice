// See https://aka.ms/new-console-template for more information
using practice;
using System;

class Program
{
    static void Main()
    {
        ListPractice list = new();
        list.ListStart();

        ExcelController excel = new();
        excel.CreateExcelFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "excelbook.xlsx"));

        //// 基本情報インスタンス生成
        //Questions q = new();
        //q.QuestStart();

        //StartUpMgr startUp = new();
        //startUp.Str();
    }

    /// <summary>
    /// 過去問演習問4
    /// </summary>
    /// <remarks>
    /// ユーグリッド互除法を使った計算
    /// </remarks>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    static int Question4(int num1, int num2)
    {
        int x = num1;
        int y = num2;

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
        return x;
    }

    /// <summary>
    /// 過去問演習問4
    /// </summary>
    /// <remarks>
    /// ユーグリッド互除法を使った計算
    /// </remarks>
    /// <returns></returns>
    static void Question9()
    {

    }
}