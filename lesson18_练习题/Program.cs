namespace lesson18_练习题
{
    #region 练习题1
    //写一个动物抽象类，写三个子类
    //人叫，狗叫，猫叫

    //动物类
    abstract class Animal
    {
        public abstract void Speak(string words);
    }
    class Person : Animal
    {
        public override void Speak(string words)
        {
            Console.WriteLine($"{words}");
        }
    }
    class Dog : Animal
    {
        public override void Speak(string words)
        {
            Console.WriteLine($"{words}");
        }
    }
    class Cat : Animal
    {
        public override void Speak(string words)
        {
            Console.WriteLine($"{words}");
        }
    }
    #endregion

    #region 练习题2
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长

    //图形类
    abstract class Shape
    {
        //面积
        abstract public float Area();
        //周长
        abstract public float Perimeter();
    }
    //矩形
    class Rectangle : Shape
    {
        public int length;
        public int width;
        public Rectangle( int length, int width )
        {
            this.length = length;
            this.width = width;
        }
        public override float Area()
        {
            return length * width;
        }

        public override float Perimeter()
        {
            return (length + width) * 2;
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
        public override float Area()
        {
            return sideLength * sideLength;
        }

        public override float Perimeter()
        {
            return sideLength * 4;
        }
    }
    class Circle : Shape
    {
        public float pi;
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
            pi = 3.14f;
        }
        public override float Area()
        {
            return pi * radius * radius;
        }

        public override float Perimeter()
        {
            return 2 * pi * radius;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类 练习题");

            #region 练习题1
            //人
            Animal person = new Person();
            person.Speak("我是人");
            //狗
            Animal dog = new Dog();
            dog.Speak("旺旺");
            //猫
            Animal cat = new Cat();
            cat.Speak("喵喵~");
            Console.WriteLine("-------------------------");
            #endregion

            #region 练习题2
            //矩形
            Shape rectangle = new Rectangle(3, 5);
            Console.WriteLine($"长：{(rectangle as Rectangle).length}，宽：{(rectangle as Rectangle).width}的矩形，面积：{rectangle.Area()}，周长：{rectangle.Perimeter()}");
            //正方形
            Shape square = new Square(6);
            Console.WriteLine($"边长：{(square as Square).sideLength}，面积：{square.Area()}的正方形，周长：{square.Perimeter()}");
            //圆形
            Shape circle = new Circle(5);
            Console.WriteLine($"半径：{(circle as Circle).radius}的圆，面积：{circle.Area()}，周长：{circle.Perimeter()}");
            #endregion

        }
    }
}
