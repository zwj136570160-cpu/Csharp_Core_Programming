namespace lesson23_练习题
{
    
    internal class Program
    {
        #region 练习题5
        //编写一个函数，将输入的字符串反转。不要使用中间商，你必须原地修改输入数组。交换过程中不使用额外空间
        //比如：输入{‘h’,‘e’,‘l’,‘l’,‘o’}
        //输出{‘o’,‘l’,‘l’,‘e’,‘h’}

        static void Reverse(string strings)
        {
            char[] chars = strings.ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
            {
                chars[i] = (char)(chars[i] + chars[chars.Length - 1 - i]);
                chars[chars.Length - 1 - i] = (char)(chars[i] - chars[chars.Length - 1 - i]);
                chars[i] = (char)(chars[i] - chars[chars.Length - 1 - i]);
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
            }
            Console.WriteLine();
            string str = new string(chars);
            Console.Write(str);
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("string 练习题");

            #region 练习题1
            //请写出string中提供的截取和替换对应的函数名
            //Substring(截取)
            //Replace(替换)
            #endregion

            #region 练习题2
            //请将字符串    1 | 2 | 3 | 4 | 5 | 6 | 7
            //变为          2 | 3 | 4 | 5 | 6 | 7 | 8
            //并输出
            //（使用字符串切割的方法）
            string str = "1 | 2 | 3 | 4 | 5 | 6 | 7";
            string[] strs = str.Split(" | ");
            for (int i = 0; i < strs.Length; i++)
            {
                if (i < strs.Length - 1)
                {
                    Console.Write($"{int.Parse(strs[i]) + 1} | ");
                    continue;
                }
                Console.Write($"{int.Parse(strs[i]) + 1}");
            }
            Console.WriteLine("-------------------------");
            #endregion

            #region 练习题3
            //String和string、Int32和int、Int16和short、Int64和long他们的区别是什么？
            //string int short long 他们没有区别，后者就是前者，前者就是后者
            #endregion

            #region 练习题4
            //str = null;
            //str = "123";
            //string str2 = str;
            //str2 = "321";
            //str2 += "123";
            //请问，上面这段代码，分配了多少个新的堆空间

            //3个
            #endregion

            #region 练习题5
            string str1 = Console.ReadLine();
            Reverse(str1);
            #endregion
        }
    }
}
