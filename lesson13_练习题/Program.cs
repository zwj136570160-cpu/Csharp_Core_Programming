namespace lesson13_练习题
{
    #region 练习题2
    //写一个Monster类，它派生出Boss和Goblin两个类，Boss有技能；小怪有攻击；随机生成10个怪，装载到数组中，遍历这个数组，调用他们的攻击方法，如果是boss就释放技能

    class Monster
    {

    }
    class Boss : Monster
    {
        public void Skill()
        {
            Console.WriteLine("Boss释放了技能");
        }
    }
    class Goblin : Monster
    {
        public void Akt()
        {
            Console.WriteLine("小怪发动了攻击");
        }
    }
    #endregion

    #region 练习题3
    //FPS游戏模拟
    //写一个玩家类，玩家可以拥有各种武器
    //现在有四种武器，冲锋枪，散弹枪，手枪，匕首
    //玩家默认拥有匕首
    //请在玩家类中写一个方法，可以拾取不同的武器替换自己拥有的枪械

    /// <summary>
    /// 武器类
    /// </summary>
    class Weapon
    {

    }
    /// <summary>
    /// 冲锋枪
    /// </summary>
    class Smg : Weapon
    {

    }
    /// <summary>
    /// 霰弹枪
    /// </summary>
    class Shotgun : Weapon
    {

    }
    /// <summary>
    /// 手枪
    /// </summary>
    class Pistol : Weapon
    {

    }
    /// <summary>
    /// 匕首
    /// </summary>
    class Dagger : Weapon
    {

    }
    class Player
    {
        private Weapon nowHaveWeapon;
        public Player()
        {
            nowHaveWeapon = new Dagger();
        }
        public void PickUp(Weapon weapon)
        {
            nowHaveWeapon = weapon;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则 练习题");

            #region 练习题1
            //is和as的区别是什么
            //is用于判断，as用于转换
            #endregion

            #region 练习题2
            Random random = new Random();
            Monster[] monster = new Monster[10];
            for (int i = 0; i < monster.Length; i++)
            {
                int Id = random.Next(2);
                Console.WriteLine($"{Id}");
                if (Id == 0)
                {
                    monster[i] = new Boss();
                    (monster[i] as Boss).Skill();
                }
                else
                {
                    monster[i] = new Goblin();
                    (monster[i] as Goblin).Akt();
                }

            }
            #endregion

            #region 练习题3
            Player player = new Player();
            player.PickUp(new Pistol());
            #endregion

        }
    }
}
