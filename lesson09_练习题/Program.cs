using System.Numerics;

namespace lesson09_练习题
{
    #region 练习题1
    //为整形拓展一个求平方的方法
    static class Tools
    {
        public static int CalculateSquare(this int value)
        {
            return value * value;
        }
    }
    #endregion

    #region 练习题2
    //写一个玩家类，包含姓名，血量，攻击力，防御力等特征，攻击，移动，受伤等方法
    //为该玩家类拓展一个自杀的方法

    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public void Atk(Player otherPlayer)
        {

        }

        public void Move()
        {

        }

        public void Wound(Player otherPlayer)
        {

        }
    }

    static class PlayerExtensions
    {
        public static void KillSelf(this Player player)
        {
            Console.WriteLine($"玩家{player.name},自杀");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法 练习题");

            int num = 4;
            Console.WriteLine(num.CalculateSquare());
            Console.WriteLine("-----------------------------------");

            Player player = new Player();
            player.name = "味精";
            PlayerExtensions.KillSelf(player);
        }
    }
}
