namespace lesson07_封装_静态成员
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
    }
    #endregion

    #region 1.静态成员基本概念
    //静态关键字：static
    //用static修饰的成员变量、方法、属性等称为静态成员
    //静态成员的特点：直接用类名点出使用
    #endregion

    #region 2.早已出现的静态成员

    #endregion

    #region 3.自定义静态成员
    class Test
    {
        public const float G = 9.8f;
        //静态成员变量
        static public float PI = 3.1415926f;

        //成员变量
        public int testInt = 100;

        //静态成员方法
        static public float CalCircle(float r)
        {
            #region 6.静态函数中不能使用非静态成员
            //成员变量只能将对象实例化出来后，才能点出来使用，不能无中生有
            //不能直接使用非静态成员，否则会报错
            //Console.WriteLine(testInt);
            Test test = new Test();
            Console.WriteLine(test.testInt);
            #endregion
            return PI * r * r;
        }

        //成员方法
        public void TestFun()
        {
            #region 7.非静态函数可以使用静态成员
            Console.WriteLine(PI);
            Console.WriteLine(CalCircle(2));
            #endregion
            Console.WriteLine("123");
        }
    }
    #endregion

    #region 5.为什么可以直接点出来使用
    //程序中是不能无中生有的
    //我们要使用的对象、变量、函数都是要在内存中分配内存空间的
    //之所以要实例化对象，目的就是分配内存空间，在程序中产生一个抽象的对象

    //静态成员的特点
    //程序开始运行时，就会分配内存空间，所以我们就能直接使用
    //静态成员和程序同生共死
    //只要使用了他，直到程序结束时内存空间才会被释放
    //所以一个静态成员就会有自己唯一的一个“内存小房间”
    //这让静态成员就有了唯一性
    //在任何地方使用都是用的小房间里的内容，改变了他也是改变小房间里的内容
    #endregion

    #region 8.静态成员对于我们的作用
    //静态变量：
    //1.常用唯一变量的申明
    //2.方便别人获取的对象申明
    //静态方法：
    //常用的唯一的方法申明，比如相同规则的数学计算相关函数
    #endregion

    #region 9.常量和静态变量
    //const(常量) 可以理解为特殊的static(静态)
    //相同点
    //他们都可以通过类名点出来使用
    //不同点
    //1.const必须初始化，不能修改，static没有这个规则
    //2.const只能修饰变量，static可以修饰很多
    //3.const一定是写在访问修饰符后面的，static没有这个要求
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员");

            #region 4.静态成员的使用
            Console.WriteLine(Test.PI);
            #endregion
        }
    }
}
