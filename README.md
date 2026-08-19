// ====================== 遍历篇 ======================
// 1.遍历字符串：本质 char[] 字符序列，只读，不能修改字符
string str = "hello";

// ① foreach 最常用
foreach(char c in str)
{
    Console.Write(c + " ");
}

// ② for循环（索引遍历）通过下标访问
for(int i = 0; i < str.Length; i++)
{
    char c = str[i];
    Console.Write(c + " ");
}

// 2.遍历数组 Array（int[] / string[]）
// for遍历：可以修改元素；foreach：只读，不能修改元素
int[] arr = {10,20,30,40};

// ① for索引遍历，可以修改元素
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine($"索引{i} 值={arr[i]}");
    arr[i] +=1; // 支持修改
}

// ② foreach，只能读，不能修改元素
foreach(int item in arr)
{
    Console.WriteLine(item);
    // item = 99; // 报错，不能修改
}

// 3.List<T> 泛型列表
List<int> list = new List<int>(){1,2,3,4};

// ① for索引遍历，可以修改
for(int i=0;i<list.Count;i++)
{
    Console.WriteLine($"下标{i}：{list[i]}");
    list[i] = list[i]*2; // 支持修改
}

// ② foreach只读遍历
foreach(var item in list)
{
    Console.WriteLine(item);
}

/*
✅ 区别重点（考试高频坑）
1. List 使用 .Count，数组使用 .Length
2. List 可以增删元素；数组长度固定不可变
3. for 可以拿索引修改集合元素；foreach 不能修改集合元素
*/

// 4.Dictionary<TKey,TValue> 字典（键值对）
Dictionary<string,int> dic = new Dictionary<string,int>();
dic.Add("张三",18);
dic.Add("李四",22);

// 方式1：foreach遍历每一组键值对 KeyValuePair
foreach(KeyValuePair<string,int> kv in dic)
{
    Console.WriteLine($"键：{kv.Key}  值：{kv.Value}");
}
// KeyValuePair<string,int> 可以直接用 var 代替

// 方式2：只遍历所有key
foreach(string k in dic.Keys)
{
    Console.WriteLine($"key={k} value={dic[k]}");
}

// 方式3：只遍历所有value
foreach(int v in dic.Values)
{
    Console.WriteLine(v);
}

// ====================== 正则篇 Regex ======================
/*
1. Regex.Match(字符串,正则规则)      按照规则从字符串提取单条内容
2. Regex.Matches(字符串,正则规则)    多次提取，返回匹配集合
3. Regex.Replace(字符串,正则,替换内容) 正则替换
4. Regex.IsMatch(字符串,正则规则)    判断字符串是否符合规则（返回bool）

基础符号说明：
@"[0-9]"     任意一个数字
@"[A-Z]"     任意一个大写字母
@"[A-Za-z]"  任意一个字母

⚠️ 注意：a‑b 这种范围语法只在 [] 中括号内生效
*/

// ---------------- 正则量词符号 ----------------
/*
| 符号   | 含义                 |
| ------ | -------------------- |
| *      | 任意个（0个及以上）  |
| +      | 至少1个（1个及以上） |
| ?      | 至多1个（0个或1个）  |
| {m}    | 必须是 m 个          |
| {m,}   | 至少 m 个            |
| {m,n}  | 至少 m 个，至多 n 个 |
*/

// ---------------- 正则元字符 ----------------
/*
| 符号      | 含义                               |
| --------- | ---------------------------------- |
| .         | 任意一个字符                       |
| \d        | 任意一个数字                       |
| \w        | 任意一个字母、数字、下划线         |
| \s        | 一个空格                           |
| \D        | 任意一个非数字字符                 |
| \W        | 任意一个非字母、数字、下划线字符   |
| \S        | 任意一个非空格字符                 |
| [字符]    | 中括号中的任意一个字符             |
| [^字符]   | 非中括号中的任意一个字符           |
*/

// 1.字符串提取
// string reg = @"a";
// string str = "bac";
// Match res = Regex.Match(str, reg);
// Console.WriteLine(res.Value);

// 分组提取：() 代表分组，Groups[0]是完整匹配，Groups[1...]各个括号分组
// string reg = @"(\d{4})-(\d{2})-(\d{2})";
// Match res = Regex.Match("2026-07-22", reg);
// Console.WriteLine(res.Value);                // 2026-07-22
// Console.WriteLine(res.Groups[0]);             // 第0组 = 全部匹配数据
// Console.WriteLine(res.Groups[1]);             // 第1分组 2026

// 2.验证示例：50长度以内，只允许中文、字母、数字的书名
// string reg = @"^[\u4e00-\u9fa5a-zA-Z0-9]{1,50}$";

// 3.正则替换 Regex.Replace
// string reg = @"a";
// string res = Regex.Replace("bac", reg, "e");
// Console.WriteLine(res); // bec

// 4.多次提取 Regex.Matches 获取全部匹配项
// string reg = @"a|b";
// MatchCollection res = Regex.Matches("abc", reg);
// Console.WriteLine(res[0]);
// Console.WriteLine(res[1]);

// ✨常用正则模板
// 整串只能是中文、大小写字母、数字，不能为空
string reg1 = @"^[\u4e00-\u9fa5a-zA-Z0-9]+$";

// 整串只能是中文、大小写字母、数字，1‑50位，不能为空
string reg2 = @"^[\u4e00-\u9fa5a-zA-Z0-9]{1,50}$";

// 1个汉字，后面跟2‑4个数字
string reg3 = @"^[\u4e00-\u9fa5][0-9]{2,4}$";

/*
⚠️大括号长度规则：只管控紧挨着它左边**一个单元**
例：ab{2} 匹配 abb，不是 abab
*/

// 复杂规则示例：
// 第1位：大小写英文字母开头
// 第2位：必须汉字
// 3位往后：汉字/字母/数字
// 总长度：最少3位，最多8位；无特殊符号、无空格；整串严格匹配
string zongreg=@"^[a-zA-Z][\u4e00-\u9fa5][\u4e00-\u9fa5a-zA-Z0-9]{1,6}$";

// 验证测试代码
Console.WriteLine("请验证:");
string input = Console.ReadLine();
bool matchResult = Regex.IsMatch(input, zongreg);
Console.WriteLine(matchResult);






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
Math.sqrt       //开方
Math.Max        //找最大值
Math.Min        //找最小值

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



