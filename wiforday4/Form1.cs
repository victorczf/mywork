namespace day04
{
    public partial class Form1 : Form
    {
         private int speen = 5;
        
        public Form1()
        {
            InitializeComponent();
           init ();     
        }
        private void init()
        {
            this.KeyDown += keydowm;   
        }
        private void keydowm(object sender , KeyEventArgs e) 
        {
            Point b1 = panel1.Location;
               switch (e.KeyCode) { 

                case Keys.W:
                    b1.Y -= speen;

                break;
                case Keys.S:
                    b1.Y += speen;

                break;
                case Keys.A:
                    b1.X -= speen;

                break;
                case Keys.D:
                    b1.X += speen;

                break;

            }
            panel1.Location = b1;
        }

    }
}
