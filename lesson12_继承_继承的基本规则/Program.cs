namespace lesson12_继承_继承的基本规则
{
    #region 1.基本概念
    //一个类A继承一个类B
    //类A将会继承类B的所有成员
    //A类将拥有B类的所有特征和行为

    //被继承的类
    //称为父类、基类、超类

    //继承的类
    //称为子类、派生类

    //子类可以有自己的特征和行为

    //特点
    //1.单根性 子类只能有一个父类
    //2.传递性 子类可以间接继承父类的父类
    #endregion

    #region 2.基本语法
    //class 类名 : 被继承的类名
    //{

    //}
    #endregion

    #region 3.实例
    class Teacher
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 职工号
        /// </summary>
        public int number;
        /// <summary>
        /// 介绍名字方法
        /// </summary>
        public void SpeakName()
        {
            Console.WriteLine(name);
        }
    }
    /// <summary>
    /// 教学老师
    /// </summary>
    class TeachingTeacher : Teacher
    {
        /// <summary>
        /// 科目
        /// </summary>
        public string subject;
        /// <summary>
        /// 介绍科目方法
        /// </summary>
        public void SpeakSubject()
        {
            Console.WriteLine($"{subject}老师");
        }
    }
    class ChineseTeacher : TeachingTeacher
    {
        public void Skill()
        {
            Console.WriteLine("Mg+O2​→MgO");
        }
    }
    #endregion

    #region 4.访问修饰符的影响
    //public - 公共 内外部访问
    //private - 私有 内部访问
    //protected - 保护 内部和子类访问

    //之后讲命名空间的时候讲
    //internal - 内部的 只有在同一个程序集的文件中，内部类型或者是成员才可以访问
    #endregion

    #region 5.子类和父类的同名成员
    //概念
    //C#中允许子类存在和父类同名的成员
    //但是，极不建议使用
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本规则");

            TeachingTeacher teachingTeacher = new TeachingTeacher();
            teachingTeacher.name = "味精";
            teachingTeacher.number = 1;
            teachingTeacher.SpeakName();
            teachingTeacher.subject = "unity";
            teachingTeacher.SpeakSubject();

            ChineseTeacher chineseTeacher = new ChineseTeacher();
            chineseTeacher.name = "林老头";
            chineseTeacher.number = 2;
            chineseTeacher.subject = "化学";
            chineseTeacher.SpeakName();
            chineseTeacher.SpeakSubject();
            chineseTeacher.Skill();

            //总结
            //继承基本语法
            //class 类型 : 父类名
            //1.单根性：只能继承一个父类
            //2.传递性：子类可以继承父类的父类
            //3.访问修饰符，对于成员的影响

            //4.极其不建议使用在子类中申明和父类同名的成员（以后学习了多态再来解决这个问题）
        }
    }
}
