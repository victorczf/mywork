namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /***************************************/
            //数组
            //int[] arr = new int[5];
            //// 创建了长度为5的数组
            //Console.WriteLine(arr[0]);
            //arr[0] = 666;
            //Console.WriteLine(arr[0]);
            
            // 创建有数据的数组
            //int[] arr = new int[] { 10,20,30};
            //foreach (int i in arr) { Console.WriteLine(i); }
            //foreach (int i in arr)  Console.WriteLine(i);
            //for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);

            // 简化初始创建
            //int[] arr = { 10,20,30};
            //foreach (int i in arr) Console.WriteLine(i);

            // 高版本C# 中初始化 数组  此方式也可以初始化 list
            //int[] arr = [10,20,30];

            //List<int> list = [100,200,300];
            //foreach (int i in list) Console.WriteLine(i);


            // 创建字典 并初始化数据
            //Dictionary<string, dynamic> dic = new()
            //{
            //    ["name"] = "zs",
            //    ["age"] = 18,
            //};


            /******************************************/
            // 字典中的键名必须是唯一的
            Dictionary<string, dynamic> dic = new()
            {
                ["name"] = "张三",
                ["age"] = 12
            };

            // Add增加键值对
            dic.Add("height", 180);
            Console.WriteLine(dic["height"]);
            dic.Add("name", "李四"); // 报错, 不能添加同名键名

            ContainsKey / ContainsValue  判断键或值是否存在
            Console.WriteLine(dic.ContainsKey("name")); // True
            Console.WriteLine(dic.ContainsKey("gender")); // False
            Console.WriteLine(dic.ContainsValue("张三")); // True
            Console.WriteLine(dic.ContainsValue("李四")); // False

            Remove通过指定的键将键值对从字典中删除
            dic.Remove("name");
            foreach (dynamic item in dic) Console.WriteLine(item);
            [age, 12]
             [height, 180]

             Clear清空字典中的键值对
            dic.Clear();
            Console.WriteLine(dic.Count);

            Count获取字典长度
            Console.WriteLine(dic.Count); // 3

            Keys获取字典中所有键的集合
           var dicKyes = dic.Keys;
            ////Console.WriteLine(dicKyes);
            ////string[] keyArr = dicKyes.ToArray(); // 将键集合转为数组
            ////foreach (string key in keyArr) Console.WriteLine(key);
            //List<string> keylist = dicKyes.ToList(); // 将键集合转为list集合
            //foreach (string key in keylist) Console.WriteLine(key);

            // Values获取字典中所有值的集合           
            //var dicValues = dic.Values; // 获取所有字典中 键值 的集合
            //dynamic[] valArr = dicValues.ToArray(); // 将键值集合转为数组
            //foreach (dynamic val in valArr) Console.WriteLine(val);

            //List<dynamic> vallist = dicValues.ToList(); // 将键值集合转为list集合
            //foreach (dynamic val in vallist) Console.WriteLine(val);


            // TryAdd ==> 不存在才添加，存在了就添加失败，但不报错
            //Console.WriteLine(dic.TryAdd("gender", true)) ; // 添加成功则返回True
            //Console.WriteLine(dic.TryAdd("name", "adsa")) ; // 添加失败则返回False
            //foreach (dynamic item in dic) Console.WriteLine(item);

            /******************************************/
            // 遍历字典
            //// 方式1：遍历 KeyValuePair
            //foreach (dynamic item in dic)
            //{
            //    //Console.WriteLine(item);
            //    //Console.WriteLine(item.Key); // 获取对应的键名
            //    Console.WriteLine(item.Value); // 获取对应的键值
            //}

            //// 方式2：遍历所有键
            //foreach (dynamic item in dic.Keys)
            //{
            //    Console.WriteLine(item); // 键名
            //    //Console.WriteLine(dic[item]); // 键值
            //}

            //// 方式3：遍历所有值
            //foreach (dynamic item in dic.Values)
            //{
            //    Console.WriteLine(item);
            //}

            /******************************************/

            //List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            // List去重
            // List中的数据是可以重复的，去重就是将重复的数据删掉，让List中保留唯一的数据。
            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    // ints[i]
            //    // 从 i + 1 开始循环
            //    for (int j = i + 1; j < ints.Count; j++)
            //    {
            //        // 判断 ints[i] 和ints[j] 如果相同则删除
            //        if (ints[i] == ints[j])
            //        {
            //            ints.RemoveAt(j);
            //            j--; // 解决删除后 索引塌陷问题
            //        }
            //    }
            //}
            // 验证去重效果
            //foreach (int n in ints) Console.WriteLine(n);


            //for (int i = 0; i < ints.Count; i++)
            //{
            //    // ints[i]
            //    // 从后往前循环 
            //    for (int j = ints.Count - 1; j > i; j--)
            //    {
            //        if (ints[i] == ints[j]) ints.RemoveAt(j);
            //    }
            //}
            //// 验证去重效果
            //foreach (int n in ints) Console.WriteLine(n);


            //List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //// 思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    // ints[i]    // 第一个
            //    while (true)
            //    {
            //        int index = ints.LastIndexOf(ints[i]); // 查找ints[i] 最后一次出现的下标
            //        if (ints.LastIndexOf(ints[i]) != i)
            //        {
            //            ints.RemoveAt(index);
            //        }
            //        else {
            //            break; // 如果找到的就是本身 说明重复的就删完了
            //        }
            //    }
            //}
            //// 验证去重效果
            //foreach (int n in ints) Console.WriteLine(n);

            //List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            // 思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            ////创建一个字典
            //Dictionary<int, dynamic> tmpDic = new();
            //foreach (int item in ints)
            //{
            //    // 遍历ints 将 其中的数据 作为 tmpDic的键名, 键值无所谓
            //    tmpDic[item] = "无所谓";
            //}

            //// 取出字典中的键 转为List
            //List<int> newList = tmpDic.Keys.ToList();
            //// 验证去重效果
            //foreach (int n in newList) Console.WriteLine(n);


            // List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //// 思路4：创建一个新的List，遍历原本的List，原本List中的每一个元素，放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加
            //List<int> newInts = [];
            //// 遍历原本的List
            //foreach (int item in ints)
            //{
            //    // 判断 item在 newInsts中是否存在
            //    if (!newInts.Contains(item)) {
            //        newInts.Add(item);
            //    }
            //}
            //// 验证去重效果
            //foreach (int n in newInts) Console.WriteLine(n);

            /******************************************/
            // 冒泡排序
            // 概念：让每相邻的两个元素比较大小，如果不满足顺序，就交换他俩的位置。
            List<int> ints = [5, 3, 4, 6, 7, 8, 9, 1, 2];
            //int i = 0;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            //i++;
            //if (ints[i] > ints[i + 1])
            //{
            //    int tmp = ints[i];
            //    ints[i] = ints[i + 1];
            //    ints[i + 1] = tmp;
            //}

            // 一轮循环 就将最大值 放到最后了
            //for (int i = 0; i < ints.Count-1; i++)
            //{
            //    if (ints[i] > ints[i + 1])
            //    {
            //        int tmp = ints[i];
            //        ints[i] = ints[i + 1];
            //        ints[i + 1] = tmp;
            //    }
            //}
            //foreach (int n in ints) Console.WriteLine(n);

            //第二轮循环  将倒数第二大的放到 倒数第二位置  j = 1
            //for (int i = 0; i < ints.Count-1 - 1; i++)
            //{
            //    if (ints[i] > ints[i + 1])
            //    {
            //        int tmp = ints[i];
            //        ints[i] = ints[i + 1];
            //        ints[i + 1] = tmp;
            //    }
            //}

            //第三轮循环  将倒数第二大的放到 倒数第二位置  j = 2
            //for (int i = 0; i < ints.Count-1 - 2; i++)
            //{
            //    if (ints[i] > ints[i + 1])
            //    {
            //        int tmp = ints[i];
            //        ints[i] = ints[i + 1];
            //        ints[i + 1] = tmp;
            //    }
            //}

            // .....



            // 外层循环次数  是 数量-1 
            //for (int j = 0; j < ints.Count - 1; j++)
            //{
            //    for (int i = 0; i < ints.Count - 1 - j; i++)
            //    {
            //        if (ints[i] > ints[i + 1])
            //        {
            //            int tmp = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = tmp;
            //        }
            //    }
            //}

            //foreach (int n in ints) Console.WriteLine(n);




            //商品按照价格排序：
            // 商品集合 就是一个List集合 ===> 按照价格排序(和之前的冒泡排序一样的)
            //List<Dictionary<string, dynamic>> goodsList = new ()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘"},
            //        {"price", 299.99},
            //        {"code", "G001"},
            //        {"stock", 120}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标"},
            //        {"price", 89.50},
            //        {"code", "G002"},
            //        {"stock", 356}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器"},
            //        {"price", 1299.00},
            //        {"code", "G003"},
            //        {"stock", 48}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机"},
            //        {"price", 199.00},
            //        {"code", "G004"},
            //        {"stock", 85}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架"},
            //        {"price", 69.90},
            //        {"code", "G005"},
            //        {"stock", 210}
            //    }
            //};
            //// 按照价格做排序
            //for (int j = 0; j < goodsList.Count - 1; j++)
            //{
            //    for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //    {
            //        if (goodsList[i]["price"] > goodsList[i + 1]["price"])
            //        {
            //            dynamic tmp = goodsList[i];
            //            goodsList[i] = goodsList[i + 1];
            //            goodsList[i + 1] = tmp;
            //        }
            //    }
            //}
            //foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");


            // 通过歌手查找歌曲集合
            List<Dictionary<string, dynamic>> singerList = new()
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new()
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };
            // 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
            Console.WriteLine("请输入歌手姓名：");
            string singer = Console.ReadLine(); // 周杰伦
            // 先根据歌手名字 找到对应的 字典
            int singerId = 0; // 歌手ID

            // 遍历歌手集合  根据歌手名字 获取歌手ID
            foreach (Dictionary<string, dynamic> item in singerList)
            {
                // item 就是循环中 歌手列表的 数据字典
                if (item["singerName"] == singer) singerId = item["singerId"];
            }

            // 遍历歌曲集合  根据拿到的歌手id 去判断获取对应的歌曲字典并 存储到新list中
            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> item in songList)
            {
                if (item["singerId"] == singerId) singerSongs.Add(item);
            }

            // 遍历歌手的歌曲
            foreach (dynamic item in singerSongs)
            {
                Console.WriteLine(item["songName"]);
            }

     

        }
    }
}
