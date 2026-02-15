#region 练习题2
//有两个命名空间，UI(用户界面)和Graph（图表）
//两个命名空间中都有一个Image类
//请在主函数中实例化两个不同命名空间中的Image对象

using Graph;
using Ui;

//用户界面 命名空间
namespace Ui
{
    class Image
    {

    }
}
//图表 命名空间
namespace Graph
{
    class Image
    {

    }
}
#endregion

namespace lesson21_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间 练习题");

            #region 练习题1
            //请说明关键词using有什么作用

            //using用于引用命名空间
            #endregion

            //练习题2
            Ui.Image uiImage = new Ui.Image();
            Graph.Image graphImage = new Graph.Image();
            

        }
    }
}
