using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookManger
{
    internal class BookManager
    {
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        // 新增数据：强制要求 ==> 将list写入文件中
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {

            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            List<Dictionary<string, dynamic>> bookList = new();
            if (File.Exists(path))
            {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                // 在将新增图书字典之前判断  // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
                // 根据list的Exists方法判断 
                bool resBoool = bookList.Exists(item => item["name"].ToString() == bookDic["name"]);
                if (resBoool) return "该书籍已经存！！！";
            }

            bookList.Add(bookDic);
            //序列化
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            // 写入文件
            File.WriteAllText(path, jsonStr);

            return "新增数据成功!!!";
        }
        // 编辑数据
        public string EditBook(Dictionary<string, dynamic> bookDic)
        {
            // 判断文件是否存在====》不存在 return "暂时没有书籍，请先添加"
            if (!File.Exists(this.path)) return "暂时没有书籍，请先添加";
            // 存在===> 读取文件====>反序列化得到list===>根据书名在list中查找 要修改的书籍字典
            string str = File.ReadAllText(this.path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(str);
            Dictionary<string, dynamic> findBookDic = list.Find(item => item["name"].ToString() == bookDic["name"]); // 如果找不到则返回null 
            //  找不到了 ====》要修改的书籍不存在，请先添加
            if (findBookDic == null) return "要修改的书籍不存在，请先添加";
            //  找到了 ====》将lsit中的这个字典中的所用对应的键名数据修改
            // 遍历 bookDic 将对应键名的值 赋值给 findBookDic
            foreach (var item in bookDic)
            {
                findBookDic[item.Key] = bookDic[item.Key];
            }
            // 修改了findBookDic 那么就是修改了list （因为findBookDic中的字典是应用类型）

            // 将修改后的list序列化写回文件中
            File.WriteAllText(this.path, JsonSerializer.Serialize(list,this.JsonOpts));
            // 编辑的逻辑处理
            return "编辑成功！！！";
        }
        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            // 判断文件是否存在====》不存在 return "暂时没有书籍，请先添加"
            if (!File.Exists(this.path)) return "暂时没有书籍，请先添加";
            // 存在===> 读取文件====>反序列化得到list===>根据书名在list中查找 要删除的书籍字典
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            int index = list.FindIndex(item => item["name"].ToString() == bookName);
            //  找不到了 ====》要删除的书籍不存在，请先添加
            if (index == -1) return "要删除的书籍不存在，请先添加";
            //  找到了 ====》将lsit中的这个字典删除====》删除后的list序列化写入文件
            list.RemoveAt(index);
            File.WriteAllText(this.path, JsonSerializer.Serialize(list, this.JsonOpts));
            return "删除成功";
        }
        // 查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook() // 返回值根据情况修改
        {
            // 查询所有的逻辑处理
            // 定义一个list
            List<Dictionary<string, dynamic>> list = new();
            // 判断文件是否存在====>不存在，返回空list
            if (!File.Exists(path)) return list;
            // 存在===> 读取文件====>反序列化===>将list返回
            var json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            return list;
        }
        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string, dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            // 查询单个图书的逻辑处理
            // 定义一个图书字典
            Dictionary<string, dynamic> bookDic = new();
            // 判断文件是否存在====>不存在，返回空字典
            if (!File.Exists(path)) return bookDic;
            // 存在===> 读取文件====>反序列化===>根据名称查找====>找不到 ===> 返回空字典
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> resDic = list.Find(item => item["name"].ToString() == bookName);
            if (resDic == null) return bookDic;
            //  找到了===>将查找到的字典返回
            return resDic;
        }

        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }

}
