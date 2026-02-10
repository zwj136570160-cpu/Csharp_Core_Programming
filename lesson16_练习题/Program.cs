using System;

namespace lesson16_练习题
{
    //定义一个载具类，速度，最大速度，可乘人数，司机和乘客等，有上车，下车，行驶，车祸等方法，用载具类声明一个对象，并将若干人装载上车

    /// <summary>
    /// 载具类
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// 速度
        /// </summary>
        public int speed;
        /// <summary>
        /// 最大速度
        /// </summary>
        public int maxSpeed;
        /// <summary>
        /// 可乘人数
        /// </summary>
        public int maxPassengers;
        /// <summary>
        /// 当前人数
        /// </summary>
        public int[] nowPassengers;
        /// <summary>
        /// 驾驶员
        /// </summary>
        public string driver;
        /// <summary>
        /// 乘客
        /// </summary>
        public string passenger;

        public Vehicle(int speed, int maxSpeed, int maxPassengers, int[] nowPassengers)
        {
            this.speed = speed;
            this.maxSpeed = maxSpeed;
            this.maxPassengers = maxPassengers;
            this.nowPassengers = new int[maxPassengers];
            driver = "驾驶员";
            passenger = "乘客";
        }
        /// <summary>
        /// 上车
        /// </summary>
        /// <param name="person">上车的人</param>
        public void PassengerBoard()
        {
            for (int i = 0; i < nowPassengers.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{driver}上车了");
                    maxPassengers -= 1;
                }
                else
                {
                    Console.WriteLine($"{passenger}上车了");
                    maxPassengers -= 1;
                }
                if (maxPassengers <= 0)
                {
                    Console.WriteLine("满载了，无法上车");
                    return;
                }
            }
        }
        /// <summary>
        /// 下车
        /// </summary>
        /// <param name="person">下车的人</param>
        public void PassengerAlight()
        {
            Console.WriteLine($"乘客下车了");
            maxPassengers += 1;
        }
        /// <summary>
        /// 行驶
        /// </summary>
        public void DriveVehicle()
        {
            if (maxPassengers == 10)
            {
                Console.WriteLine("人满了，开始行驶");
            }
            else
            {
                Console.WriteLine("还没满，请继续等待");
            }
        }
        /// <summary>
        /// 车祸
        /// </summary>
        public void VehicleAccidentOccur()
        {
            Console.WriteLine("糟糕，出现车祸了");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Vehicle vehicle = new Vehicle(50, 50, 10, new int[10]);
            vehicle.PassengerBoard();
            vehicle.PassengerAlight();
            vehicle.DriveVehicle();
            vehicle.PassengerBoard();

        }
    }
}
