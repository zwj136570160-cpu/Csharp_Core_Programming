namespace lesson04_练习题
{
    #region 练习题1
    //基于成员方法练习题
    //对人类的构造函数进行重载，用人类创建若干个对象

    /// <summary>
    /// 人类
    /// </summary>
    class Person
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

        /// <summary>
        /// 初始化
        /// </summary>
        public Person(string name, float height, int age, string homeAddress) : this(name, height)
        {
            this.age = age;
            this.homeAddress = homeAddress;
        }

        public Person(string name, float height)
        {
            this.name = name;
            this.height = height;
        }

        /// <summary>
        /// 说话的方法
        /// </summary>
        /// <param name="speechContent">说话的内容</param>
        public void Speak(string speechContent)
        {
            Console.WriteLine($"{name}说：{speechContent}");
        }

        /// <summary>
        /// 走路的方法
        /// </summary>
        public void Walk()
        {
            Console.WriteLine($"{name}开始走路了");
        }

        /// <summary>
        /// 吃饭的方法
        /// </summary>
        /// <param name="food">吃的食物</param>
        public void Eat(Food food)
        {
            Console.WriteLine($"{name}吃了{food.name}，获得热量：{food.calorie}");
        }
    }

    /// <summary>
    /// 食物类
    /// </summary>
    class Food
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name;

        /// <summary>
        /// 热量
        /// </summary>
        public int calorie;

        /// <summary>
        /// 使用食物的方法
        /// </summary>
        /// <param name="player">人类</param>
        /// <param name="student">学生类</param>
        /// <param name="characterType">人物类型枚举</param>
        /// <param name="food">食物</param>
        public void Eat(Person player, Food food)
        {
            food.calorie = 50;
            food.name = "汉堡";
            Console.WriteLine($"{player.name}吃了{name}，获得热量：{calorie}");
        }
    }
    #endregion

    #region 练习题2
    //基于成员变量练习题
    //对班级类的构造函数进行重载，用班级类创建若干个对象

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

        public Student(string name, int studentId, int age)
        {
            this.name = name;
            this.studentId = studentId;
            this.age = age;
        }

        /// <summary>
        /// 学习方法
        /// </summary>
        public void Learn()
        {
            Console.WriteLine($"{name}开始学习了");
        }

        /// <summary>
        /// 吃饭方法
        /// </summary>
        /// <param name="food">吃的食物</param>
        public void Eat(Food food)
        {
            Console.WriteLine($"{name}吃了{food.name}，获得热量：{food.calorie}");
        }
    }

    /// <summary>
    /// 教室类
    /// </summary>
    class ClassRoom
    {
        string major;
        int capacity;
        Student[] student;

        public ClassRoom(string major, int capacity, Student[] student)
        {
            this.student = student;
            this.major = major;
            this.capacity = capacity;
        }
    }
    #endregion

    #region 练习题3
    //写一个Ticket类，有一个距离变量（在构造对象时赋值，不能为负数），有一个价格特征，有一个方法GetPrice可以读取到价格，并且根据距离distance计算价格price（1元/公里）
    //0~100公里 不打折
    //101~200公里 大9.5折
    //201~300公里 打9折
    //300公里以上 打8折
    //有一个显示方法，可以显示这张票的信息。
    //例如：100公里100块钱

    /// <summary>
    /// 门票类
    /// </summary>
    class Ticket
    {
        /// <summary>
        /// 距离
        /// </summary>
        int distance;
        /// <summary>
        /// 价格
        /// </summary>
        float Price;

        /// <summary>
        /// 门票初始化
        /// </summary>
        /// <param name="distance">距离</param>
        public Ticket(int distance)
        {
            this.distance = distance;
            Price = GetPrice();
        }

        /// <summary>
        /// 价格计算方法
        /// </summary>
        float GetPrice()
        {
            if (distance >= 0 && distance <= 100)
            {
                return distance / 1;
            }
            else if (distance >= 101 && distance <= 200)
            {
                return (distance / 1) * 0.95f;
            }
            else if (distance >= 201 && distance <= 300)
            {
                return (distance / 1) * 0.9f;
            }
            else
            {
                return (distance / 1) * 0.8f;
            }
        }

        /// <summary>
        /// 报价方法
        /// </summary>
        public void QuoteAmount()
        {
            Console.WriteLine($"{distance}公里{Price}块钱");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数 练习题");

            //练习题1
            Person player = new Person("味精", 178.5f, 27, "地球");
            Console.WriteLine($"{player.name}");
            Console.WriteLine($"{player.age}");
            Console.WriteLine($"{player.homeAddress}");
            Console.WriteLine($"{player.height}");

            //练习题2
            Student student1 = new Student("味精", 5, 27);
            Student student2 = new Student("光耀", 5, 27);
            ClassRoom classRoom1 = new ClassRoom("C#", 50, new Student[] { student1, student2 });
            ClassRoom classRoom2 = new ClassRoom("Untiy", 50, new Student[] { student1, student2 });

            //练习题3
            Ticket ticket = new Ticket(500);
            ticket.QuoteAmount();
        }
    }
}
