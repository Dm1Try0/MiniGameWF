namespace GmaeRacing
{
    public partial class Form1 : Form
    {
        private Point position;
        private bool posdragging;
        private bool lose = false;
        private int gas = 30;
        private int coin = 0;
        public Form1()
        {
            InitializeComponent();
            backGround1.MouseDown += MouseClickDown;
            backGround1.MouseMove += MouseClickMove;
            backGround1.MouseUp += MouseClickUp;
            backGround2.MouseDown += MouseClickDown;
            backGround2.MouseMove += MouseClickMove;
            backGround2.MouseUp += MouseClickUp;
            LoseLabel.Visible = false;
            btnRestart.Visible = true;
            KeyPreview = true;
            labelLoseWhy.Visible = false;
            timer.Enabled = false;
            btnRestart.Text = "ÈÃÐÀÒÜ";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            posdragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (posdragging)
            {
                Point point = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(point.X - position.X, point.Y - position.Y + backGround1.Top);
            }
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            posdragging = true;
            position.X = e.X;
            position.Y = e.Y;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int carSpeed = 3;
            backGround1.Top += carSpeed;
            backGround2.Top += carSpeed;

            int enemySpeed = 3;
            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;

            gasPic.Top += carSpeed;

            CoinPic.Top += carSpeed;


            if (backGround1.Top >= 515)
            {
                backGround1.Top = 0;
                backGround2.Top = -650;
                gas--;
                gasLabel.Text = $"Áåíçèí: {gas}";
            }

            if (gasPic.Top >= 650)
            {
                gasPic.Top = -50;
                Random rand = new Random();
                gasPic.Left = rand.Next(150, 560);
            }

            if (CoinPic.Top >= 650)
            {
                CoinPic.Top = -50;
                Random rand = new Random();
                CoinPic.Left = rand.Next(150, 560);
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);
            }
            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                Random rand = new Random();
                enemy2.Left = rand.Next(300, 560);
            }
            if (Car.Bounds.IntersectsWith(enemy1.Bounds) ||
                Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                LoseLabel.Visible = true;
                btnRestart.Visible = true;
                lose = true;
                labelLoseWhy.Visible = true;
                labelLoseWhy.Text = "ÄÒÏ";
            }

            if (Car.Bounds.IntersectsWith(gasPic.Bounds))
            {
                gas += 3;
                gasLabel.Text = $"Áåíçèí: {gas}";
                gasPic.Top = -50;
                Random rand = new Random();
                gasPic.Left = rand.Next(150, 560);
            }

            if (Car.Bounds.IntersectsWith(CoinPic.Bounds))
            {
                coin++;
                CoinsLabel.Text = $"Ìîíåòû: {coin}";
                CoinPic.Top = -50;
                Random rand = new Random();
                CoinPic.Left = rand.Next(150, 560);
            }

            if (gas == 0)
            {
                timer.Enabled = false;
                LoseLabel.Visible = true;
                labelLoseWhy.Visible = true;
                labelLoseWhy.Text = "Ïóñòîé áàê";
                btnRestart.Visible = true;
                lose = true;
                gas = 0;
                gasPic.Top = -500;
                CoinPic.Top = -550;
            }
        }

        private void backGround2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 15;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Car.Left > 150)
                Car.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Car.Right < 700)
                Car.Left += speed;

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            timer.Enabled = true;
            LoseLabel.Visible = false;
            btnRestart.Visible = false;
            lose = false;
            labelLoseWhy.Visible = false;
            gas = 30;
        }
    }
}
