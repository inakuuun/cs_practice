using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class StartUpMgr
    {
        public StartUpMgr() 
        {
            Console.WriteLine("こんにちは");
        }

        public void Str()
        {
            string str = "count:";
            int num = 100;
            List<string> list = new();
            for (int i = 0; i<num; i++)
            {
                list.Add(str + i);
            }

            list.Remove(str + 5);
            Console.WriteLine(list[5]);

            var index = list.IndexOf(str + 5);

            if (index == -1)
            {
                Console.WriteLine("存在しません");
            }
            else
            {
                Console.WriteLine("存在します");
            }
        }
    }
}
