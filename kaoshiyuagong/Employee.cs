using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;

namespace kaoshi1
{
    internal class Employee
    {
        private int EmpId;
        private string EmpName;
        private string Department;
        private double Salary;

        public int _EmpId
        {
            get { return EmpId; }
            set { this.EmpId = value; }
        }
        public string _EmpName
        {
            get { return EmpName; }
            set { this.EmpName = value; }
        }

        public string _Department
        {
            get { return Department; }
            set { this.Department = value; }
        }

        public double _Salary
        {
            get { return Salary; }
            set { this.Salary = value; }
        }

        public Employee(int _EmpId, string _EmpName, string _Department, double _Salary)
        {
            this._EmpId = _EmpId;
            this._EmpName = _EmpName;
            this._Department = _Department;
            this._Salary = _Salary;
        }

        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号 : {this._EmpId} -- 名字 : {this._EmpName} -- 部门 : {this._Department} -- 薪水 : {this._Salary} ");
        }

        //public Employee() { }

        // 控制台依次提示用户输入：员工编号、姓名、部门、薪资，自动创建员工对象，添加到List集合，自动保存数据到emp.json。
        // 属性的赋值器 ===> 直接给属性初始值
        private string Path { get; } = "./emp.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        // 新增车辆 方法
        public string Add(int EmpId, string EmpName, string Department, double Salary)
        {

            // 定义一个空的 list 
            List<Employee> Employees = new();
            // 判断存储文件是否存在 ==> 存在 -----》读取文件内容，并反序列化并将得到的数据列表赋值给list
            if (File.Exists(Path))
            {
                string jsonStr = File.ReadAllText(this.Path);
                Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);

            }
            // 将接受的数据组装成Car实例对象，然后添加到list中 ---> 序列化list---》写入json文件
            Employee CAdd = new Employee(EmpId, EmpName, Department, Salary);
            // true 表示空闲 false表示已租出
            Employees.Add(CAdd);
            string resStr = JsonSerializer.Serialize(Employees, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);

            return "新员工成功！！！";
        }

        //根据编号调整薪资（改）用户输入员工编号，程序遍历集合匹配数据：
        //- 匹配成功：提示输入新薪资，修改对应员工的薪资数据，自动保存到JSON文件
        //- 匹配失败：控制台提示“未查询到该编号的员工”
        public void Update()
        {
            // 不存在====》
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("无员工！！！！");
                return;

            }
            Console.WriteLine("请输入员工编号");
            int id = int.Parse(Console.ReadLine());

            // 判断文件是否存在===存在，读取文件，反序列化 ===》根据id查找车辆对象===》找不到则提示
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            // 使用列表的Find 实现查找
            Employee EmployeeObj = Employees.Find(item => item._EmpId == id);


            if (EmployeeObj == null)
            {
                Console.WriteLine("未查询到该编号的员工");
                return;
            }
            // 
            Console.WriteLine("请输调整后的薪资");
            double saraly = double.Parse(Console.ReadLine());
            EmployeeObj._Salary = saraly;

            // 写回文件
            string resStr = JsonSerializer.Serialize(Employees, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);
            Console.WriteLine("ok!!!");
        }

        // 查看全部员工（查-全部） 循环遍历List集合，调用员工ShowEmpInfo()方法，打印所有员工信息；若无员工数据，提示“暂无员工数据”。
        public void SearchAll()
        {

            // 不存在====》
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请先添加");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ===遍历输出
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            if (Employees.Count == 0)
            {
                Console.WriteLine("暂无员工数据");
                return;
            }

            foreach (Employee item in Employees)
            {

                item.ShowEmpInfo();
            }

        }

        // 按薪资条件筛选员工（查-条件）
        // 查看所有车辆信息 方法
        public void SearchFind()
        {
            Console.WriteLine("请输入薪资数值");
            double salary = double.Parse(Console.ReadLine());
            // 不存在====》
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请先添加");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ===遍历输出
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            // 查找  Employees  中 _Salary 大于 salary
            List<Employee> ResEmployees = Employees.FindAll(item => item._Salary > salary);
            if (ResEmployees.Count == 0)
            {
                Console.WriteLine("无对应薪资条件的员工");
                return;
            }

            foreach (Employee item in ResEmployees)
            {

                Console.WriteLine($"员工编号 : {item._EmpId} -- 名字 : {item._EmpName} -- 部门 : {item._Department} -- 薪水 : {item._Salary} ");
            }

        }

        //根据编号删除员工（删）
        //用户输入员工编号，遍历集合查找：
        //- 查找成功：从List集合中移除该员工，自动保存最新数据到JSON文件，提示“删除成功”
        //- 查找失败：提示“未查询到该编号的员工，删除失败”
        public void Remove()
        {
            // 不存在====》
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("无员工！！！！");
                return;

            }
            Console.WriteLine("请输入员工编号");
            int id = int.Parse(Console.ReadLine());

            // 判断文件是否存在===存在，读取文件，反序列化 ===》根据id查找车辆对象===》找不到则提示
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            // 使用列表的Find 实现查找
            int index = Employees.FindIndex(item => item._EmpId == id);

            if (index == -1)
            {
                Console.WriteLine("未查询到该编号的员工，删除失败");
                return;
            }
            //  删除
            Employees.RemoveAt(index);


            // 写回文件
            string resStr = JsonSerializer.Serialize(Employees, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);
            Console.WriteLine("删除成功!!!");
        }

    }
}
