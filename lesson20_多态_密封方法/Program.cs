namespace lesson20_多态_密封方法
{
    #region 知识回顾
    //密封类
    //用sealed修饰的类
    //让类不再被继承
    #endregion

    #region 1.密封方法基本概念
    //用密封关键词sealed修饰的重写函数
    //作用：让虚方法或者抽象方法之后不能再被重写
    //特点：和override一起出现
    #endregion

    #region 2.实例
    abstract class Anima
    {
        public string name;
        public  abstract void Eat();

        public virtual void Speak()
        {
            Console.WriteLine("叫");
        }
    }
    class Person : Anima
    {
        public sealed override void Eat()
        {
            
        }
        public override void Speak()
        {
            
        }
    }
    class WhitePerson : Person
    {
        public override void Eat()
        {

        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封方法");
        }
    }
    //总结
    //密封方法可以让虚方法和抽象方法不能再被子类重写
    //特点：一定是和ovrride一起出现
}
