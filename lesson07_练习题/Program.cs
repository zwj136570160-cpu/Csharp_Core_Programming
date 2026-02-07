namespace lesson07_练习题
{
    //请用静态成员相关知识实现
    //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的存在，不能在外部实例化，直接通过该类类名就能够得到唯一的对象

    class MyClass
    {
        private static MyClass myClass = new MyClass();

        public int testInt = 10;
        public static MyClass myClass01
        {
            get
            {
                return myClass;
            }
        }
        private MyClass()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员 练习题");

            //请说出const和static的区别
            //const必须初始化，static不用
            //const只能修饰变量，static可以修饰很多的数据类型
            //const不能写在访问修饰符前面，一定是写在变量申明前面，static没有这个规则

            Console.WriteLine(MyClass.myClass01.testInt);


        }
    }
}
