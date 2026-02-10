namespace lesson11_封装_内部类和分部类
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

        //类名点出使用——静态成员

        //自定义对象可计算——计算符重载
    }

    //静态类和静态构造函数

    //拓展方法
    #endregion

    #region 1.内部类
    //概念
    //在一个类中再申明一个类

    //特点
    //使用时要用包裹者点出自己

    //作用
    //亲密关系的变现

    //注意
    //访问修饰符作用很大

    //人类
    class Person
    {
        public int age;
        public string name;
        public Body body;
        //身体
        public class Body
        {
            Arm leftArm;
            Arm rightArm;
            //手臂
            public class Arm
            {

            }
        }
    }
    #endregion

    #region 2.分部类
    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //注意
    //分部类可以写在多个脚本文件中
    //分部类的访问修饰符要一致
    //分部类中不能有重复成员

    partial class Student
    {
        public bool sex;
        public string name;

        #region 3.分部方法
        //概念
        //将方法的申明和实现分离
        //特点
        //1.不能加访问修饰符 默认私有
        //2.只能在分布类中申明
        //3.返回值只能是void
        //4.可以有参数但不用 out关键字

        //局限很大，了解即可
        partial void Speak();
       
    }

    partial class Student
    {
        public int number;
        public void Speak(string str)
        {
            //实现逻辑
        }
    }
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分部类");

            //内部类的使用
            Person p = new Person();
            Person.Body body= new Person.Body();
            Person.Body.Arm arm = new Person.Body.Arm();

            //分部类的使用
            Student student = new Student();
            student.number = 1;
        }
    }
}
