namespace lesson14_练习题
{
    //有一个打工人基类，有工种，工作内容两个特征，一个工作方法
    //程序员、策划、美术分别继承打工人
    //请用继承中的构造函数这个知识点
    //实例化3个对象，分别是程序员、策划、美术

    /// <summary>
    /// 打工人父类
    /// </summary>
    class Worker
    {
        public string job;
        public string jobContent;
        public Worker(string job, string jobContent)
        {
            this.job = job;
            this.jobContent = jobContent;
        }

        public void Work()
        {
            Console.WriteLine($"{job}{jobContent}");
        }
    }
    /// <summary>
    /// 程序员子类
    /// </summary>
    class Coder : Worker
    {
        public Coder() : base("程序员", "开发")
        {
            Console.WriteLine("我是一个程序员");
        }
    }
    /// <summary>
    /// 策划子类
    /// </summary>
    class Planner : Worker
    {
        public Planner() : base("策划", "组织安排")
        {
            Console.WriteLine("我是一个策划");
        }
    }
    /// <summary>
    /// 美术子类
    /// </summary>
    class Artist : Worker
    {
        public Artist() : base("美术", "设计")
        {
            Console.WriteLine("我是一个美术");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("无参构造函数 练习题");
            Artist art = new Artist();
            art.Work();
            Planner planner = new Planner();
            planner.Work();
            Coder coder = new Coder();
            coder.Work();
        }
    }
}
