namespace lesson17_练习题
{
    #region 练习题1
    //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫
    class TrueDuck
    {
        public virtual void Speak()
        {
            Console.WriteLine("嘎嘎");
        }
    }
    class WoodDuck : TrueDuck
    {
        public override void Speak()
        {
            Console.WriteLine("吱吱");
        }
    }
    class EraserDuck : TrueDuck
    {
        public override void Speak()
        {
            Console.WriteLine("唧唧");
        }
    }
    #endregion

    #region 练习题2
    //所有员工9点打卡
    //但经理十一点打卡，程序员不打卡

    //所有员工
    class Staff
    {
        public string position;
        public int time;
        public Staff(string position, int time)
        {
            this.position = position;
            this.time = time;
        }
        public Staff(string position)
        {
            this.position = position;
        }
        public virtual void ClockIn()
        {
            Console.WriteLine($"{time}点：{position}打卡");
        }
    }
    //员工
    class Employee : Staff
    {
        public Employee() : base("员工", 9)
        {

        }
        public override void ClockIn()
        {
            Console.WriteLine($"{time}点：{position}打卡");
        }
    }
    //经理
    class Manager : Staff
    {
        public Manager() : base("经理", 11)
        {

        }
        public override void ClockIn()
        {
            Console.WriteLine($"{time}点：{position}打卡");
        }
    }
    //程序员
    class Developer : Staff
    {
        public Developer() : base("老子")
        {

        }
        public override void ClockIn()
        {
            Console.WriteLine($"{position}不打卡");
        }
    }
    #endregion

    #region 练习题3
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长

    //图形类
    class Shape
    {
        public int length;
        public int width;
        public float area;
        public float perimeter;
        //面积
        public virtual void Area()
        {
            
        }
        //周长
        public virtual void Perimeter()
        {

        }
    }
    //矩形
    class Rectangle : Shape
    {
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        //矩形的面积
        public override void Area()
        {
            area = length * width;
            Console.WriteLine($"长：{length}，宽：{width}，矩形的面积为：{area}");
        }
        //矩形的周长
        public override void Perimeter()
        {
            perimeter = (length + width) * 2;
            Console.WriteLine($"长：{length}，宽：{width}，矩形的周长为：{perimeter}");
        }
    }
    //正方形
    class Square : Shape
    {
        public int sideLength;
        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }
        //正方形的面积
        public override void Area()
        {
            area = sideLength * sideLength;
            Console.WriteLine($"边长：{sideLength}，正方形的面积为：{area}");
        }
        //正方形的周长
        public override void Perimeter()
        {
            perimeter = sideLength  * 4;
            Console.WriteLine($"边长：{sideLength}，正方形的周长为：{perimeter}");
        }
    }
    //圆形
    class Circle : Shape
    {
        public float pi;
        public int r;
        public Circle(int r)
        {
            pi = 3.14f;
            this.r = r;
        }
        //圆的面积
        public override void Area()
        {
            area = pi * r * r;
            Console.WriteLine($"半径为：{r},圆的面积为{area}");
        }
        //圆的周长
        public override void Perimeter()
        {
            perimeter = 2 * pi * r;
            Console.WriteLine($"半径为：{r},圆的周长为{perimeter}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vob 练习题");

            #region 练习题1
            TrueDuck t = new TrueDuck();
            t.Speak();
            TrueDuck w = new WoodDuck();
            w.Speak();
            TrueDuck e = new EraserDuck();
            e.Speak();
            Console.WriteLine("--------------------------------");
            #endregion

            #region 练习题2
            //员工
            Staff employee = new Employee();
            employee.ClockIn();
            Staff manager = new Manager();
            manager.ClockIn();
            Staff developer = new Developer();
            developer.ClockIn();
            Console.WriteLine("--------------------------------");
            #endregion

            #region 练习题3
            //矩形
            Shape rectangle = new Rectangle(3, 5);
            rectangle.Area();
            rectangle.Perimeter();
            //正方形
            Shape square = new Square(5);
            square.Area();
            square.Perimeter();
            //圆形
            Shape circle = new Circle(4);
            circle.Area();
            circle.Perimeter();
            #endregion
        }
    }
}
