using System.Reflection;
namespace lesson02_封装_成员变量和访问修饰符
{
    #region 知识回顾
    //类和对象
    //申明类
    //class Person
    //{
    //    //特征——成员变量
    //    //行为——成员方法
    //    //保护特征——成员属性

    //    //构造函数和析构函数
    //    //索引器
    //    //运算符重载
    //    //静态成员
    //}

    //实例化对象
    //Person 变量名;
    //Person 变量名 = null;
    //Person 变量名 = new Person();
    #endregion

    #region 1.成员变量
    //基本规则
    //1.申明在类语句块中
    //2.用来描述对象的特征
    //3.可以是任意变量类型
    //4.数量不做限制
    //5.是否赋值根据需求来定

    //性别枚举
    enum E_SexType
    {
        man,
        woman,
    }
    //位置结构体
    struct Position
    {

    }
    //宠物类
    class Pet
    {

    }
    //人类
    class Person
    {
        //特征——成员变量
        //姓名
        public string name = "味精";
        //年龄
        public int age;
        //性别
        public E_SexType sex;
        //女朋友
        //如果要在类中申明一个和自己相同类型的成员变量时
        //不能堆他进行实例化
        public Person gridFriend;
        //朋友
        public Person[] boyFriend;
        //位置
        public Position position;
        //宠物
        public Pet pet;
    }
    #endregion

    #region 2.访问修饰符
    //public —— 公共的 自己（内部）和别人（外部）都能访问和使用
    //private —— 私有的 自己（内部）才能访问和使用 不写 默认是private
    //protected —— 保护的 自己（内部）和子类才能访问和使用
    //目前决定类内部的成员 的 访问权限
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");

            Person p = new Person();

            #region 3.成员变量的使用和初始值
            //值类型：数字类型，默认值都是0，bool类型：false
            //引用类型：null

            //要看一个类型的默认值可以直接打印  default(变量类型) 就能得到默认值
            Console.WriteLine(default(int));
            #endregion

            //总结
            //成员变量
            //描述特征
            //类中申明
            //赋值随意
            //默认值，值不相同
            //默认值，引用为null
            //任意类型
            //任意数量

            //访问修饰符
            //3p
            //public 公共的
            //private 私有的
            //protected 保护的
        }
    }
}
