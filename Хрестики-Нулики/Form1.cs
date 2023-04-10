namespace Хрестики_Нулики
{
    public partial class Form1 : Form
    {
        Button[,] button;
        string hod;
        public Form1()
        {
            hod = "X";
            InitializeComponent();
            button = new Button[10, 10];
            int count = 0;

            for(int i=0; i<10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Parent = panel1;
                    button[i, j].Width = panel1.Width / 10;
                    button[i, j].Height = panel1.Height / 10;
                    button[i, j].Top = j*panel1.Height / 10;
                    button[i, j].Left = i*panel1.Width / 10;
                    button[i, j].Click += new EventHandler(onclick);
                    button[i, j].Tag = count;
                    count++;
                }
            }
        }
        public void check()
        {

        }
        private void onclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                b.Text = hod;
            }
            if (hod == "X")
            {
                hod = "0";
            }
            else
            {
                hod = "X";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}