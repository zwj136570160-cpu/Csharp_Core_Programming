//引用MyGame命名空间
using MyGame.UI;
using MyGame;
//using MyGame2;
#region 1.命名空间基本概念
//概念
//命名空间是用来组织和重用代码的
//作用
//就像是一个工具包，类就像是一件一件的工具，都是申明再命名空间中的
#endregion

#region 2.命名空间的使用
//基本语法
//namespace 命名空间名
//{
//    类
//    类
//}

namespace MyGame
{
    class GameObject
    {

    }
}

namespace MyGame
{
    class Player : GameObject
    {

    }
}
#endregion

#region 4.不同命名空间中允许有同名类

namespace MyGame2
{
    //在不同的命名空间，是可以有同名类的
    class GameObject
    {

    }
}
#endregion

#region 5.命名空间可以包裹命名空间
namespace MyGame
{
    namespace UI
    {
        class Image
        {

        }
    }
    namespace Game
    {
        class Image
        {

        }
    }
}
#endregion

#region 6.关于修饰类的访问修饰符
//public —— 命名空间中的类 默认为internal
//internal —— 只能在该程序集中使用
//abstract —— 抽象类
//sealed —— 密封类
//partial —— 分布类
#endregion

namespace lesson21_面向对象相关_命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");

            #region 3.不同命名空间中相互使用 需要引用命名空间或指明出处
            GameObject g = new MyGame.GameObject();
            
            MyGame.UI.Image img = new MyGame.UI.Image();
            Image image = new Image();
            #endregion
        }
    }
    //总结
    //1.命名空间是个工具包，用来管理类的
    //2.不同命名空间中，可以有同名类
    //3.不同命名空间中相互使用，需要using引用命名空间或者指明出处
    //4.命名空间可以包裹命名空间
}
