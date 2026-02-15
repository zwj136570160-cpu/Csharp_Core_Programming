using System.Text;

namespace lesson24_面向对象相关_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识回顾
            //string是特殊的引用
            //每次重写赋值或者拼接时会分配新的内存空间
            //如果一个字符串经常改变会非常浪费空间
            #endregion

            #region StringBuilder
            //C#提供的一个用于处理字符串的公共类
            //主要解决的问题是：
            //修改字符串而不创建新的对象，需要频繁修改和拼接的字符串可以使用他，可以提升性能
            //使用前，需要引用命名空间

            #region 初始化 直接指明内容
            StringBuilder str = new StringBuilder("123123123");
            Console.WriteLine(str); //123123123
            
            #endregion

            #region 容量
            //StringBuilder存在一个容量的问题，每次往里面增加时，会自动扩容
            //获得容量
            Console.WriteLine(str.Capacity);    //16
            //获得字符长度
            Console.WriteLine(str.Length);  //9
            #endregion

            #region 增删查改
            //增(Append, AppendFormat)
            str.Append("444");
            Console.WriteLine(str); //123123123444
            Console.WriteLine(str.Length);  //13
            Console.WriteLine(str.Capacity);    //16

            str.AppendFormat($"{100}{999}");
            Console.WriteLine(str); //123123123444100999
            Console.WriteLine(str.Length);  //18
            Console.WriteLine(str.Capacity);    //32

            //插入(Insert)
            str.Insert(0, "味精");    
            Console.WriteLine(str); //味精123123123444100999

            //删(Remove)
            str.Remove(0, 10);
            Console.WriteLine(str); //3444100999

            //清空(Clear)
            //str.Clear();
            //Console.WriteLine(str); //空内容

            //查
            Console.WriteLine(str[0]);  //3

            //改
            str[0] = 'A';
            Console.WriteLine(str); //A444100999

            //替换
            str.Replace("4", "味精");
            Console.WriteLine(str); //A味精味精味精100999

            //重写赋值StringBuilder
            str.Clear();
            str.Append("123123");
            Console.WriteLine(str); //123123

            //判断StringBuilder是否和某一个字符串相等
            if (str.Equals("123123"))
            {
                Console.WriteLine("相等");
            }
            #endregion

            #endregion
        }
    }
}
