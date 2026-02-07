namespace lesson05_练习题
{
    //定义一个学生类，有五种属性，分别为姓名、性别、年龄、CSharp成绩、Unity成绩
    //有两个方法：
    //一个打招呼：介绍自己交XX，今年几岁了。是男同学还是女同学
    //计算自己总分数和平均分并显示的方法
    //使用属性完成：年龄必须是0 ~150岁之间，成绩必须是0 ~100
    //性别只能是男或女
    //实例化两个对象并测试

    /// <summary>
    /// 学生类
    /// </summary>
    class ClassRoom
    {
        /// <summary>
        /// 姓名
        /// </summary>
        string name;
        /// <summary>
        /// 性别
        /// </summary>
        bool sex;
        /// <summary>
        /// 年龄
        /// </summary>
        int age;
        /// <summary>
        /// Csharp成绩
        /// </summary>
        int cSharpScore;
        /// <summary>
        /// untiy成绩
        /// </summary>
        int unityScore;

        /// <summary>
        /// 学生类初始化
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="sex">性别</param>
        public ClassRoom(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 打招呼方法
        /// </summary>
        public void Speak()
        {
            string gender = Sex ? "男" : "女";
            Console.WriteLine($"我叫：{name}，今年{Age}岁，{gender}同学");
        }

        public int CSharpScore
        {
            get
            {
                return cSharpScore;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    cSharpScore = value;
                }
                else
                {
                    Console.WriteLine("cSharp成绩输入错误，成绩范围需要在0-100分");
                }
            }
        }

        public int UnityScore
        {
            get
            {
                return unityScore;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    unityScore = value;
                }
                else
                {
                    Console.WriteLine("unity成绩输入错误，成绩范围需要在0-100分");
                }
            }
        }

        public bool Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
            }
        }

        public int Age
        {
            get
            {
                return age; 
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("输入错误，年龄范围需要在0-150岁");
                }
            }
        }

        public void Score()
        {
            if (CSharpScore == 0 || UnityScore == 0)
            {
                if (CSharpScore == 0 && UnityScore == 0)
                {
                    Console.WriteLine("请正确输入CSharp和Unity成绩后再做计算");
                }
                else
                {
                    if (CSharpScore == 0)
                    {
                        Console.WriteLine("请正确输入CSharp成绩后再做计算");
                    }
                    else
                    {
                        Console.WriteLine("请正确输入Unity成绩后再做计算");
                    }
                }
            }
            else
            {
                int sum = CSharpScore + UnityScore;
                float avg = sum / 2f;
                Console.WriteLine($"总分：{sum}，平均分：{avg}");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员属性 练习题");

            ClassRoom classRoom = new ClassRoom("味精");
            classRoom.Age = 27;
            classRoom.Sex = true;
            classRoom.Speak();
            classRoom.CSharpScore = 90;
            classRoom.UnityScore = 90;
            classRoom.Score();
        }
    }
}