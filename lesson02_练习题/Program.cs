using System;

namespace lesson02_练习题
{
    #region 练习题2
    //定义一个人类，有姓名，身高，年龄，家庭住址等特征
    //用人创建若干个对象

    /// <summary>
    /// 人类
    /// </summary>
    class Preson
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 身高
        /// </summary>
        public float height;
        /// <summary>
        /// 年龄
        /// </summary>
        public int age;
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string homeAddress;
    }
    #endregion

    #region 练习题3
    //定义一个学生类，有姓名，学号，年龄，同桌等特征。用学生类创建若干个学生

    /// <summary>
    /// 学生类
    /// </summary>
    class Student
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 学号
        /// </summary>
        public int studentId;
        /// <summary>
        /// 年龄
        /// </summary>
        public int age;
        /// <summary>
        /// 同桌
        /// </summary>
        public Student deskmate;
    }
    #endregion

    #region 练习题4
    //定义一个班级类，有专业名称，教室容量，学生等创建一个班级对象

    /// <summary>
    /// 班级类
    /// </summary>
    class ClassRoom
    {
        /// <summary>
        /// 专业名称
        /// </summary>
        public string major;
        /// <summary>
        /// 教室容量
        /// </summary>
        public int classRoomCapacity;
        /// <summary>
        /// 学生
        /// </summary>
        public Student[] student;
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符 练习题");

            #region 练习题1
            //3P是什么？
            //public 公共的 外部和内部都可以调用的
            //private 私有的 只有内部可调用
            //protected 保护的 内部和子类可调用
            #endregion

            //练习题2
            Preson player = new Preson();
            player.name = "味精";
            player.age = 27;
            player.height = 177.5f;
            player.homeAddress = "人类世界";

            #region 练习题3
            Student student1 = new Student();
            student1.name = "味精";
            student1.age = 27;
            student1.studentId = 5;

            Student student2 = new Student();
            student2.name = "光耀";
            student2.age = 27;
            student2.studentId = 6;

            student2.deskmate = student1;
            student1.deskmate = student2;

            #endregion


            //练习题4
            ClassRoom classRoom = new ClassRoom();
            classRoom.classRoomCapacity = 50;
            classRoom.major = "unity";
            classRoom.student = new Student[] { student1, student2 };

            #region 练习题5
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;
            //请问p.age为多少？

            //p.age = 10;
            #endregion

            #region 练习题6
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = p;
            //p2.age = 20;
            //请问p.age为多少？

            //p.age = 20;
            #endregion

            #region 练习题7
            //Student s = new Student();
            //s.age = 10;
            //int age = s.age;
            //age = 20;
            //请问s.age为多少？

            //s.age = 10;
            #endregion

            #region 练习题8
            //Student s = new Student();
            //s.deskmate = new Student();
            //s.deskmate.age = 10;
            //Sudent s2 = s.deskmate;
            //s2.age = 20;
            //请问s.deskmate.age为多少？

            //s.deskmate.age = 20;
            #endregion
        }
    }
}
