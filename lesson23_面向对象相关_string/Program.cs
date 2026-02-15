namespace lesson23_面向对象相关_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string");

            #region 1.字符串指定位置获取
            //字符串本质是char数组
            string str = "味精";
            Console.WriteLine(str[0]);  //味
            //转为char数组
            char[] chars = str.ToCharArray();
            Console.WriteLine(chars[1]);    //精

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion

            #region 2.字符串拼接
            str = string.Format($"{1}{3333}");
            Console.WriteLine(str); //13333
            #endregion

            #region 3.正向查找字符位置
            str = "我是味精";
            int index = str.IndexOf("味");
            Console.WriteLine(index);

            //如果字符串中未找到这个字，默认返回-1
            index = str.IndexOf("光");
            Console.WriteLine(index);   //-1
            #endregion

            #region 4.反向查找指定字符串位置
            str = "我是味精味精精";

            index = str.LastIndexOf("味精精");
            Console.WriteLine(index);   //4

            //如果字符串中未找到这个字，默认返回-1
            index = str.LastIndexOf("光");
            Console.WriteLine(index);   //-1
            #endregion

            #region 5.移除指定位置后的字符
            str = "我是味精精";
            str = str.Remove(4);
            Console.WriteLine(str); //我是味精

            //执行两个参数进行移除
            //参数1 开始位置
            //参数2 字符个数
            str = str.Remove(2, 1);
            Console.WriteLine(str); //我是精
            #endregion

            #region 6.替换指定字符串
            str = "我是味精味精味精精";
            str = str.Replace("味精味精味精精", "光耀");
            Console.WriteLine(str); //我是光耀
            #endregion

            #region 7.大小写转换
            str = "asdasdasdasdasvc";
            str = str.ToUpper();    
            Console.WriteLine(str); //ASDASDASDASDASVC

            str = str.ToLower();
            Console.WriteLine(str); //asdasdasdasdasvc
            #endregion

            #region 8.字符串截取
            str = "我是味精精";
            //截取从指定位置开始之后的字符串
            str = str.Substring(2);
            Console.WriteLine(str); //味精精

            //参数一 开始位置
            //参数二 指定个数
            //不会自动的帮助你判断是否越界，你需要自己去判断
            str = str.Substring(1, 2);
            Console.WriteLine(str); //精精
            #endregion

            #region 9.字符串切割
            str = "1,2,3,4,5,6,7,8";
            string[] strs = str.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
            #endregion
        }
    }
}
