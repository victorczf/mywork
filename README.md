<details>
<summary>📌 易混淆知识点 / 踩坑提醒（点击展开）</summary>

遍历篇 ：
1.遍历字符串：（本质：char[]字符序列，只读，不能修改字符）
string str = "hello";

//① foreach 最常用
foreach(char c in str)
{
    Console.Write(c + " ");
}


//② for循环（用索引）通过下标索引去遍历
for(int i = 0; i < str.Length; i++)
{
    char c = str[i];
    Console.Write(c + " ");
}

2.遍历 数组 Array（int [] /string []）
//注意数组for循环遍历时是可以修改里面的元素的
//foreash 只能读，不能改元素
//定义一个数组
int[] arr = {10,20,30,40};

//① for 索引遍历，可以修改元素
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine($"索引{i} 值={arr[i]}");
    arr[i] +=1; //可以修改
}

//② foreach，只能读，不能改元素
foreach(int item in arr)
{
    Console.WriteLine(item);
    // item = 99; //报错，不能修改
}


3. List<T> 泛型列表

List<int> list = new List<int>(){1,2,3,4};

//① for索引遍历，可以修改
for(int i=0;i<list.Count;i++)
{
    Console.WriteLine($"下标{i}：{list[i]}");
    list[i] = list[i]*2; //支持修改
}

//② foreach只读遍历
foreach(var item in list)
{
    Console.WriteLine(item);
}

区别重点：
List 用 .Count，数组用 .Length（考试高频坑）
List 可以增删元素；数组长度固定
for 可以拿索引修改；foreach 不能修改集合元素


4. Dictionary<TKey,TValue> 字典（键值对）

Dictionary<string,int> dic = new Dictionary<string,int>();
dic.Add("张三",18);
dic.Add("李四",22);

//方式1 foreach遍历每一对 KeyValuePair
foreach(KeyValuePair<string,int> kv in dic)
{
    Console.WriteLine($"键：{kv.Key}  值：{kv.Value}");
}
这里面的KeyValuePair<string,int>代表每一组键值对的类型，可以用var代替

//方式2 只遍历所有key
foreach(string k in dic.Keys)
{
    Console.WriteLine($"key={k} value={dic[k]}");
}

//方式3 只遍历所有value
foreach(int v in dic.Values)
{
    Console.WriteLine(v);
}

</details>

# Day1

<img width="314" height="351" alt="image" src="https://github.com/user-attachments/assets/8e4072e0-f6e6-4923-b1ba-5ac8a0ade33f" />

- **一：注释**：单行注释：`//`  多行注释：`/* */`

- **二：输出**
  - 分为换行输出和不换行输出：`Console.WriteLine("换行")` | `Console.Write("不换行")`
  - 数字占位输出：`Console.WriteLine("{0} {1}", 0位置的值, 1位置的值);`
  - 字符插值输出：`Console.WriteLine($"{变量}");`

- **三：简单数据类型**
  - `int`：整型
  - `string`：字符串型
  - `double`：浮点型
  - `bool`：布尔型

四： 变量：
 * 变量的命名规则
    - 变量名由 数字字母下划线组成
    - 不可以数字开头
    - 严格区分大小写
    - 不能关键字当做变量名
        + 关键字: 语言层面已经使用了的名字
            - 比如: int, false,true .....
    变量命名规范:
        - 变量命名尽量语义化
            + 看到变量名 就大概知道 变量的数据是干嘛的
        - 多单词变量名 遵守 驼峰写法
            + 除了第一个单词后续每个单词首字母大写
五：输入（简略）
string 变量名 = Console.ReadLine();
注意：用户输入的数据可以用变量接收，接收到的输入都是字符串

六：基础数学运算 +-*/% 略
注意：++ 和 -- 在碰到运算和输出时，有前置和后置的区别，前置就先`++ --`，后置就后`++ --`
//当自增(自减)运算符  遇见 赋值,输出,运算 时候 前置和后置有区别
// 当遇见 赋值 / 输出 / 运算, 前置操作会 先进行 自增(自减) 操作 然后将结果参与后续的执行
// 当遇见 赋值 / 输出 / 运算, 后置操作会 先将变量的值参与执行,  然后完成自操作
七：数学对象
Math.PI         // 圆周率π常量
Math.Abs()      // 求绝对值
Math.Pow()      // 求幂，Pow(底数,指数)
Math.Sqrt()     // 求平方根
Math.Round()    // 四舍五入
Math.Floor()    // 向下取整（往小的整数靠）
Math.Ceiling()  // 向上取整（往大的整数靠）

# Day2
<img width="300" height="504" alt="image" src="https://github.com/user-attachments/assets/3402aee1-1d10-4fce-ac05-439917e2d334" />
一.变量和集合
1.任意类型
dynamic 变量名 = 值 //不限制变量的类型  给任意类型的值，且可以修改成其他类型的值
var 变量名 =值 // 自动捕获变量类型 ，不用主动声明，不可以修改其他类型的值
2.匿名类型（略）
3.数字字典
Dictionly<键名的类型，键值的类型 >变量名 = new Dictionary<数据类型，数据类型>(){};
或者简易写法 Dictionly<键名的类型，键值的类型> 变量名=new(){};
注意事项：字典不像数组一样，他没有数字下标
Dictionary<string, dynamic> dic = new()
{
    ["name"] = "陈三岁",
    ["age"] = 21,
    ["gender"] = "nan"
};

//①先把所有key提取出来转List，才能用i拿第i个键
var keyList = dic.Keys.ToList(); 

//②for循环遍历序号i
for(int i = 0; i < dic.Count; i++)
{
    string key = keyList[i];    //先拿第i个键
    var value = dic[key];       //再用键去字典拿值
    Console.WriteLine($"键：{key}，值：{value}");
}
4.数组 

















# Day9

一：委托



