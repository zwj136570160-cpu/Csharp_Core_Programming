namespace lesson19_练习题
{
    #region 练习题1
    //人、汽车、房子都需要登记，人需要到派出所登记，汽车需要去车管所登记，房子需要去房管局登记
    //使用接口实现登记方法

    //登记接口
    interface IRecord
    {
        public void Record();
    }
    //人
    class Person : IRecord
    {
        public string Name
        { 
            get
            {
                return "人";
            }
        }

        public string PublicOffices
        {
            get
            {
                return "派出所";
            }
        }

        public void Record()
        {
            Console.WriteLine($"{Name}需要到{PublicOffices}登记");
        }
    }
    //汽车
    class Car : IRecord
    {
        public string Name
        {
            get
            {
                return "汽车";
            }
        }

        public string PublicOffices
        {
            get
            {
                return "房管局";
            }
        }

        public void Record()
        {
            Console.WriteLine($"{Name}需要到{PublicOffices}登记");
        }
    }
    //房子
    class House : IRecord
    {
        public string Name
        {
            get
            {
                return "房子";
            }
        }

        public string PublicOffices
        {
            get
            {
                return "车管所";
            }
        }

        public void Record()
        {
            Console.WriteLine($"{Name}需要到{PublicOffices}登记");
        }
    }
    #endregion

    #region 练习题2
    //麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅
    //直升机和部分鸟能飞
    //鸵鸟和企鹅不能飞
    //企鹅和天鹅能游泳
    //除直升机，其它都能走
    //请用面向对象相关知识实现

    //鸟类
    abstract class Bird
    {
        public string name;
        public abstract void Walk();
    }

    //接口
    //飞
    interface IFly
    {
        public void Fly();
    }
    //游泳
    interface ISwim
    {
        public void Swim();
    }

    //麻雀
    class Sparrow : Bird, IFly
    {
        public Sparrow(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }

        public override void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }

    //鸵鸟
    class Ostrich : Bird
    {
        public Ostrich(string name)
        {
            this.name = name;
        }

        public override void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }

    //企鹅
    class Penguin : Bird, ISwim
    {
        public Penguin(string name)
        {
            this.name = name;
        }

        public void Swim()
        {
            Console.WriteLine($"{name}会游泳");
        }

        public override void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }

    //鹦鹉
    class Parrot : Bird, IFly
    {
        public Parrot(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }

        public override void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }

    //天鹅
    class Swan : Bird, ISwim
    {
        public Swan(string name)
        {
            this.name = name;
        }

        public void Swim()
        {
            Console.WriteLine($"{name}会走");
        }

        public override void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }

    //直升机
    class Helicopter : IFly
    {
        public string name;

        public Helicopter(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }
    }

    #endregion

    #region 练习题3
    //多态来模拟移动硬盘、U盘、MP3查到电脑上读取数据
    //移动硬盘与U盘都属于存储设备
    //MP3属于播放设备
    //但他们都能插在电脑上传输数据
    //电脑提供了一个USB接口
    //请实现电脑的传输数据的功能

    //接口
    interface IUsb
    {
        public void TransferData();
    }
    //电脑
    class Pc
    {
        public IUsb usb;
    }
    //存储设备
    abstract class Storage : IUsb
    {
        public abstract void TransferData();
        
    }
    //移动硬盘
    class External : Storage
    {
        public override void TransferData()
        {
            Console.WriteLine("移动硬盘传输数据");
        }
    }
    //u盘
    class UPan : Storage
    {
        public override void TransferData()
        {
            Console.WriteLine("u盘传输数据");
        }
    }
    //播放设备
    class MP3 : IUsb
    {
        public void TransferData()
        {
            Console.WriteLine("MP3传输数据");
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("接口 练习题");

            #region 练习题1
            IRecord[] records = new IRecord[] {new Person(), new Car(), new House()};
            for (int i = 0; i < records.Length; i++)
            {
                records[i].Record();
            }
            Console.WriteLine("------------------------------");
            #endregion

            #region 练习题2
            //麻雀
            Bird bird = new Sparrow("麻雀");
            (bird as IFly).Fly();
            bird.Walk();
            //鸵鸟
            Bird ostrich = new Ostrich("鸵鸟");
            ostrich.Walk();
            //企鹅
            Bird penguin = new Penguin("企鹅");
            (penguin as ISwim).Swim();
            penguin.Walk();
            Console.WriteLine("------------------------------");

            #endregion

            #region 练习题3
            IUsb[] usb = new IUsb[] { new External(), new UPan(), new MP3() };
            Pc pc = new Pc();
            for (int i = 0; i < usb.Length; i++)
            {
                pc.usb = usb[i];
                pc.usb.TransferData();
            }

            #endregion

        }
    }
}
