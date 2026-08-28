

namespace day05
{
    public partial class Form1 : Form
    {

        //自己打的，老师的思路
        #region
        //private List<Dictionary<string, dynamic>> where = new();
        //public Form1()
        //{
        //    InitializeComponent();

        //    where = new()
        //    {
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 1,
        //            ["name"]= "广西省",
        //            ["prid"]=0

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 2,
        //            ["name"]= "梧州市",
        //            ["prid"]=1

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 3,
        //            ["name"]= "南宁市",
        //            ["prid"]=1

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 4,
        //            ["name"]= "玉林市",
        //            ["prid"]=1

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 5,
        //            ["name"]= "山东省",
        //            ["prid"]=0

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 6,
        //            ["name"]= "济南市",
        //            ["prid"]=5

        //        },
        //        new Dictionary<string, dynamic>
        //        {
        //            [ "id"]= 1,
        //            ["name"]= "烟台市",
        //            ["prid"]=5

        //        },

        //    };
        //    //初始化一级标题 ，即把父id为0的放到ProvinceCb   
        //    List<Dictionary<string,dynamic>> prid = where.FindAll(item => item["prid"] == 0);

        //    //把得到的
        //    dynamic[] arr = prid.ConvertAll(item => item["name"]).ToArray(); 
        //    //把得到list 给到我们的cb1
        //    comboBox1.Items.AddRange(arr);
        //    comboBox1.SelectedIndexChanged += fangfa;
        //    //二级 CityCb
        //}

        //private void fangfa(object sender ,EventArgs e )
        //{
        //    comboBox2.Items.Clear();
        //    comboBox2.Text = "";
        //    //获取这个选择的文本框内容，获取文本框的内容
        //    //根据内容查到他的id ，根据他的id找到他的二级标题
        //    string text= (sender as ComboBox).Text.ToString();
        //    Dictionary<string, dynamic> listname = where.Find(item => item["name"] == text);
        //    //找出二级的那个所有的名字
        //    List<Dictionary<string, dynamic>> cityList=  where.FindAll(item => item["prid"] == listname["id"]);
        // dynamic[]arr  = cityList.ConvertAll(item => item["name"]).ToArray();
        //   // comboBox2.Text = "请输入所有城市";
        //    comboBox2.Items.AddRange(arr);

        //}

        #endregion

        //作业 用字典去实现
        public Dictionary<string, string[] > dic= new ()
            {
                ["广东省"] = ["佛山市", "广州市", "江门市"],
                ["广西省"] = ["南宁市", "玉林市", "梧州市"],
             };
    public Form1()
        {
            InitializeComponent();
            //初始化下拉框，把键名给的一级标题
            //遍历这个字典，
            foreach (var item in dic)
            {
                //item.Key → 省份名字
                comboBox1.Items.Add(item.Key);
            }
            comboBox1.SelectedIndexChanged += fangfa;


        }

        private void fangfa(object sender, EventArgs e)
        {
            string name = (sender as ComboBox).Text.ToString();
            comboBox2.Items.Clear(); //先清空旧数据
            comboBox2.Text = "请输入城市";
            foreach (var item in dic)
            {
                if (item.Key == name)
                {
                    comboBox2.Items.AddRange(item.Value);
                }
            }
        }


    }
}
