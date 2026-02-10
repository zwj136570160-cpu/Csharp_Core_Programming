using System;

namespace lesson10_练习题
{
    #region 练习题1
    //定义一个位置结构体或类，为其重载判断是否相等的运算符
    //(x1, y1) == (x2, y2)   =>  两个值同时相等才为true

    //结构体
    struct Position
    {
        public int x;
        public int y;

        public static bool operator ==(Position p1, Position p2)
        {
            if ((p1.x, p1.y) == (p2.x, p2.y))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Position p1, Position p2)
        {
            if ((p1.x, p1.y) != (p2.x, p2.y))
            {
                return false;
            }
            return true;
        }
    }
    #endregion

    #region 练习题2
    //定义一个Vector3类（x,y,z）通过重载运算符实现以下运算
    //(x1, y1, z1) + (x2, y2, z2) = (x1+x2,y1+y2,z1+z2)
    //(x1, y1, z1) - (x2, y2, z2) = (x1-x2,y1-y2,z1-z2)
    //(x1, y1, z1)* num = (x1 * num, y1 * num, z1 * num)

    class Vector3
    {
        public int x;
        public int y;
        public int z;

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            v3.z = v1.z + v2.z;
            return v3;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x - v2.x;
            v3.y = v1.y - v2.y;
            v3.z = v1.z - v2.z;
            return v3;
        }

        public static Vector3 operator *(Vector3 v1, int num)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x * num;
            v3.y = v1.y * num;
            v3.z = v1.z * num;
            return v3;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载 练习题");

            //练习题1
            Position position = new Position();
            position.x = 1;
            position.y = 1;

            Position position1 = new Position();
            position1.x = 1;
            position1.y = 1;

            if (position != position1)
            {
                Console.WriteLine("两值相等");
            }
            else
            {
                Console.WriteLine("两值不相等");
            }

            //练习题2
            Vector3 v1 = new Vector3();
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;
            Vector3 v2 = new Vector3();
            v2.x = 2;
            v2.y = 2;
            v2.z = 2;
            Vector3 v3 = v1 + v2;
            Console.WriteLine((v3.x, v3.y, v3.z));

            v3 = v1 - v2;
            Console.WriteLine((v3.x, v3.y, v3.z));

            v3 = v1 * 2;
            Console.WriteLine((v3.x, v3.y, v3.z));
        }
    }
}
