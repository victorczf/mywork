using kaoshi1;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace kaoshi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";// 输入的操作编号  
            Employee EM = new Employee(1, "", "", 10.1);// 实例化车辆管理对象

            while (num != "6")
            {

                Tips();  // 提示界面
                // 提示输入
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        // 输入车辆信息提示
                        // 输入车辆信息提示
                        Console.WriteLine("请输员工编号：");

                        string empIdStr = Console.ReadLine(); // 先拿字符串

                        //正则校验，传字符串empIdStr，不是int的EmpId
                        if (!Regex.IsMatch(empIdStr, @"^[1-9]\d*$"))
                        {
                            Console.WriteLine("员工编号错误！必须输入大于等于1的正整数");
                            break;
                        }
                        //校验通过才转int
                        int EmpId = int.Parse(empIdStr);

                        Console.WriteLine("请输入姓名：");
                        string EmpName = Console.ReadLine();
                        Console.WriteLine("请输入部门：");
                        string Department = Console.ReadLine();
                        Console.WriteLine("请输入薪水：");
                        double Salary = double.Parse(Console.ReadLine());

                        string salaryStr = Console.ReadLine();
                        //正则：0及以上，可以带小数
                        if (!Regex.IsMatch(salaryStr, @"^\d+(\.\d+)?$"))
                        {
                            Console.WriteLine("薪资输入错误！必须大于等于0，可以输入小数，不能输入负数、字母");
                            break;
                        }
                         Salary = double.Parse(salaryStr);

                        //if

                        string resAdd = EM.Add(EmpId, EmpName, Department, Salary);
                        Console.WriteLine(resAdd);

                        break;
                    case "2":
                        EM.SearchAll();
                        break;
                    case "3":
                        EM.Update();
                        break;
                    case "4":
                        EM.Remove();
                        break;
                    case "5":
                        EM.SearchFind();
                        break;
                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Tips()
        {
            // 提示界面
            Console.WriteLine("==欢迎来到员工薪资管理控制台系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("1：新增员工");
            Console.WriteLine("2：查看全部员工");
            Console.WriteLine("3：根据编号调整薪资");
            Console.WriteLine("4：根据编号删除员工");
            Console.WriteLine("5：按薪资条件筛选员工");
            Console.WriteLine("6：退出系统");
        }

    }
}

