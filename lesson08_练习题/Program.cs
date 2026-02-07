namespace lesson08_练习题
{
    //写一个用于数学计算的静态类
    //该类中提供计算圆面积，圆周长，矩形面积，矩形周长，取一个数的绝对值等方法

    /// <summary>
    /// 数学计算
    /// </summary>
    static class MathTool
    {
        public static float pi = 3.14f;

        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r">半径</param>
        /// <returns>圆的面积</returns>
        public static float CalacCircularArea(float r)
        {
            return pi * r * r;
        }
        /// <summary>
        /// 计算圆的周长
        /// </summary>
        /// <param name="r">半径</param>
        /// <returns>圆的周长</returns>
        public static float CalacCircularLength(float r)
        {
            return 2 * pi * r;
        }
        /// <summary>
        /// 计算矩形的面积
        /// </summary>
        /// <param name="length">长</param>
        /// <param name="width">宽</param>
        /// <returns>矩形的面积</returns>
        public static float CalcRectArea(float length, float width)
        {
            return length * width;
        }
        /// <summary>
        /// 计算矩形的周长
        /// </summary>
        /// <param name="length">长</param>
        /// <param name="width">宽</param>
        /// <returns>矩形的周长</returns>
        public static float CalcRectangLength(float length, float width)
        {
            return (length + width) * 2;
        }
        /// <summary>
        /// 取绝对值的方法
        /// </summary>
        /// <param name="value">需要取绝对值的数</param>
        /// <returns>绝对值</returns>
        public static float GetABS(float value)
        {
            if (value < 0)
            {
                return -value;
            }
            return value;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态类和静态构造函数 练习题");

            Console.WriteLine(MathTool.GetABS(-5));
        }
    }
}
