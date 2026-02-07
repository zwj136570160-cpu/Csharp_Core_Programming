namespace lesson06_练习题
{
    //自定义一个整形数组类，该类中有一个整形数组变量
    //为它封装增删查改的方法

    /// <summary>
    /// 整数类
    /// </summary>
    class IntArray
    {
        /// <summary>
        /// 整数数组
        /// </summary>
        private int[] array;
        //房间容量
        private int capacity;
        //当前放了几个房间
        private int length;

        /// <summary>
        /// 整数类初始化
        /// </summary>
        public IntArray()
        {
            capacity = 5;
            length = 0;
            array = new int[capacity];
        }

        /// <summary>
        /// 增加方法
        /// </summary>
        /// <param name="value">需要增加的整数</param>
        public void Add(int value)
        {
            //如果要增加就涉及扩容
            //扩容就需要“搬家”
            if (length < capacity)
            {
                array[length] = value;
                ++length;
            }
            //扩容“搬家”
            else
            {
                capacity *= 2;
                int[] tempArray = new int[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;

                //往后面放
                array[length] = value;
                ++length;
            }
        }

        /// <summary>
        /// 根据下标删除对应数字
        /// </summary>
        /// <param name="value"></param>
        public void RemoveAt(int index)
        {
            if (index > length - 1)
            {
                Console.WriteLine($"当前数组只有{array.Length}，你越界了");
                return;
            }
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            --length;
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="value">需要删除的整数</param>
        public void Remove(int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == value)
                {
                    RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"没有在数组中找到{value}");
        }

        /// <summary>
        /// 查改
        /// </summary>
        /// <param name="index">需要查找的数组下标</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if (index >= length || index < 0)
                {
                    Console.WriteLine("越界");
                    return 0;
                }
                return array[index];
            }
            set
            {
                if (index >= length || index < 0)
                {
                    Console.WriteLine("越界");
                }
                array[index] = value;

            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器 练习题");

            IntArray intArray = new IntArray();
            intArray.Add(5);
            intArray.Add(6);
            intArray.Add(7);
            intArray.Add(8);
            intArray.Add(9);
            intArray.RemoveAt(1);
            intArray.Remove(7);
            Console.WriteLine(intArray[1]);



        }
    }
}
