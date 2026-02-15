namespace lesson22_练习题
{
    #region 练习题1
    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX”XX为具体内容

    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public int dodge;

        public Player(string name, int hp, int atk, int def, int dodge)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.dodge = dodge;
        }

        public void Speak()
        {
            Console.WriteLine($"玩家{name}，血量：{hp}，攻击力{atk}，防御力{def}，闪避力{dodge}");
        }
    }
    #endregion

    #region 练习题2
    //一个Monster类的引用对象A，Monster类有 攻击力、防御力、血量、技能ID等属性。我想复制一个和A对象一模一样的B对象。并且改变了B的属性，A不会受到影响。请问如何实现？
    class Monster
    {
        public Monster(int atk, int def, int hp, int skillID)
        {
            Atk = atk;
            Def = def;
            Hp = hp;
            SkillID = skillID;
        }

        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int SkillID { get; set; }

        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }

        public override string ToString()
        {
            return string.Format($"攻击力{Atk}，防御力{Def}，血量{Hp}，技能{SkillID}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法 练习题");

            Player player = new Player("味精", 100, 50, 50, 50);
            player.Speak();

            //练习题2
            Monster m = new Monster(10, 20, 100, 1);
            Monster m2 = m.Clone();
            m2.Atk = 30;
            m2.SkillID = 100;
            Console.WriteLine(m);
            Console.WriteLine(m2);
        }
    }
}
