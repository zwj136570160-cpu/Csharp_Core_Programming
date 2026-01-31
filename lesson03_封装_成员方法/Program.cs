namespace lesson03_封装_成员方法
{
    internal class Program
    {
        #region 1.成员方法申明
        //基本概念
        //成员方法（函数）用来表现对象行为
        //1.申明在类语句块中
        //2.是用来描述对象的行为的
        //3.规则和函数申明规则相同
        //4.收到访问修饰符规则影响
        //5.返回值参数不做限制
        //6.方法数量不做限制

        //注意：
        //1.成员方法不要加static 关键字
        //2.成员方法 必须要实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
        //3.成员方法 收到访问修饰符影响

        /// <summary>
        /// 人类
        /// </summary>
        class Person
        {
            /// <summary>
            /// 姓名
            /// </summary>
            public string name;
            /// <summary>
            /// 年龄
            /// </summary>
            public int age;
            /// <summary>
            /// 朋友
            /// </summary>
            public Person[] friend;

            /// <summary>
            /// 说话的方法
            /// </summary>
            /// <param name="str">说话的内容</param>
            public void Speak(string str)
            {
                Console.WriteLine($"{name}说{str}");
            }

            /// <summary>
            /// 判断是否成年的方法
            /// </summary>
            /// <returns>是否成年</returns>
            public bool IsAdult()
            {
                return age >= 18;
            }

            /// <summary>
            /// 添加朋友的方法
            /// </summary>
            /// <param name="newPlayer">添加的朋友</param>
            public void Addfriend(Person newPlayer)
            {
                if (friend == null)
                {
                    friend = new Person[] { newPlayer };
                }
                else
                {
                    //新建一个数组
                    Person[] newFriend = new Person[friend.Length + 1];
                    //搬家
                    for (int i = 0; i < friend.Length; i++)
                    {
                        newFriend[i] = friend[i];
                    }
                    //把新家的朋友放到最后一个
                    newFriend[newFriend.Length - 1] = newPlayer;
                    //地址重定向
                    friend = newFriend;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法");

            #region 2.成员方法的使用
            Person player = new Person();
            player.name = "味精";
            player.age = 20;
            player.Speak("牛逼！");

            if (player.IsAdult())
            {
                player.Speak("我要耍朋友！！！");
            }

            //创建类的对象
            Person player2 = new Person();
            //初始化
            player2.name = "光耀";
            player2.age = 27;
            //添加朋友
            player.Addfriend(player2);

            for (int i = 0; i < player.friend.Length; i++)
            {
                Console.WriteLine(player.friend[i].name);
            }
            #endregion

            //总结
            //成员方法
            //描述行为
            //类中申明
            //任意数量
            //返回值和参数根据需求决定
        }
    }
}
