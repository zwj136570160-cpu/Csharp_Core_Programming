namespace lesson15_练习题
{
    class Parson
    {
        public void Speak()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父 练习题");

            #region 练习题1
            //请口头描述什么是装箱拆箱

            //值类型
            //装箱：用object存储数据
            //拆箱：将object存储的数据转化成对应数据
            #endregion

            #region 练习题2
            //请用代码描述装箱拆箱
            //引用类型
            object i = new Parson();    //装箱
            if (i is Parson)    //拆箱
            {
                (i as Parson).Speak();
            }
            //值类型
            object a = 5;   //装箱
            int a2 = (int)a;    //拆箱

            object b = "123";
            object b1 = b as string;

            object b2 = new object[2];
            int[] b3 = b2 as int[];
            #endregion
        }
    }
}
