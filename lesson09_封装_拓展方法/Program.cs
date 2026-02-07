namespace lesson09_封装_拓展方法
{
    #region 知识回顾
    class 类名
    {
        //特征——成员变量

        //行为——成员方法

        //初始化调用——构造方法

        //释放时调用——析构方法

        //保护成员变量用——成员属性

        //通过中括号使用对象——索引器

        //静态成员
    }

    //静态类和静态构造函数
    #endregion

    #region 1.拓展方法基本概念
    //概念
    //为现有非静态，变量类型添加新方法
    //作用
    //1.提升程序拓展性
    //2.不需要在对象中重新写方法
    //3.不需要继承来添加方法
    //4.为别人封装的类型写额外的方法
    //特点
    //1.一定是写在静态类中
    //2.一定是个静态函数
    //3.第一个参数为拓展目标
    //4.第一个参数用this修饰
    #endregion

    #region 2.基本语法
    //访问修饰符 static 返回值 函数名(this 拓展类名 参数名, 参数类型 参数名,参数类型 参数名....)
    #endregion

    #region 3.实例
    static class Tools
    {
        //为int拓展了一个成员方法
        //成员方法是需要实例化对象后，才能使用的
        //value代表使用该方法的实例化对象
        public static void SpeakValue(this int value)
        {
            //拓展方法的逻辑
            Console.WriteLine($"味精为int拓展的方法：{value}");
        }
        public static void SpeakStringInfo(this string str, string str2, string str3)
        {
            Console.WriteLine("味精为string拓展的方法");
            Console.WriteLine($"调用方法的对象：{str}");
            Console.WriteLine($"传的参数：{str2},{str3}");
        }

        public static void Fun3(this Test test)
        {
            Console.WriteLine("为Test拓展的方法");
        }
    }
    #endregion

    #region 5.为自定义的类型拓展方法
    class Test
    {
        public int i = 10;
        public void Fun1()
        {
            Console.WriteLine("123");
        }
        public void Fun2()
        {
            Console.WriteLine("456");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法");

            #region 4.使用
            int i = 10;
            i.SpeakValue(); //味精为int拓展的方法：10

            string str = "000";
            str.SpeakStringInfo("味精", "111");   //味精为string拓展的方法
                                                //调用方法的对象：000
                                                //传的参数：味精，111

            Test test = new Test();
            test.Fun3();
            #endregion
        }
    }
}
