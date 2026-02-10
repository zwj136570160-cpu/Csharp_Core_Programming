namespace lesson12_练习题
{
    //写一个人类，人类中有姓名，年龄属性，有说话行为
    //战士类继承人类，有攻击行为

    /// <summary>
    /// 人类
    /// </summary>
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void Speak(string str)
        {
            Console.WriteLine($"{Name}说了：{str}");
        }
    }
    /// <summary>
    /// 战士类
    /// </summary>
    class Warrior : Person
    {
        public void Attack(Person player)
        {
            Console.WriteLine($"{Name}打了{player.Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本概念 练习题");

            Person player = new Person();
            player.Name = "味精";
            player.Age = 27;
            player.Speak($"名字：{player.Name}，年龄：{player.Age}");
            Warrior warrior = new Warrior();
            warrior.Name = "小怪兽";
            warrior.Attack(player);
        }
    }
}
