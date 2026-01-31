using System.Numerics;

namespace lesson03_练习题
{
    #region 练习题1
    //基于成员变量练习题
    //为人类定义说话、走路、吃饭等方法

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

    #endregion

    #region 练习题2
    //基于成员变量练习题
    //为学生类定义学习、吃饭等方法

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

    #endregion

    #region 练习题3
    //定义一个食物类，有名称，热量等特征
    //思考如何和人类以及学生类联系起来

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
        public void Eat(Preson player, Student student, E_CharacterType characterType, Food food)
        {
            food.calorie = 50;
            food.name = "汉堡";
            //判断是人类还是学生
            switch (characterType)
            {
                case E_CharacterType.preson:
                    player.Eat(food);
                    break;
                case E_CharacterType.student:
                    student.Eat(food);
                    break;
            }
            
        }
    }

    /// <summary>
    /// 角色类型枚举
    /// </summary>
    enum E_CharacterType
    {
        /// <summary>
        /// 人类
        /// </summary>
        preson,
        /// <summary>
        /// 学生
        /// </summary>
        student
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法 练习题");

            Preson player = new Preson();
            player.name = "味精";
            Student student = new Student();
            student.name = "光耀";
            Food food = new Food();
            food.Eat(player, student, E_CharacterType.preson, food);
        }
    }
}
