using game1.Properties;
using Microsoft.VisualBasic;

namespace game1
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging;
        private Point prevMousePos;
        private bool lose = false;
        private int countCoins = 0;
        private int k = 0;
        private int maxScore = 0;
        private Image[] coinImages = { Resources.coin_1, Resources.coin_2, Resources.coin_3, Resources.coin_4,
                                       Resources.coin_5, Resources.coin_6, Resources.coin_7, Resources.coin_8 };
        private Image blueCar = Resources.blue_car;
        private Image greenCar = Resources.green_car;
        private Image yellowCar = Resources.yellow_car;
        private Image orangeCar = Resources.orange_car;
        private Image whiteCar = Resources.white_car;

        public Form1()

        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;
            cointimer.Start();
            timer.Stop();

            prevMousePos = Cursor.Position;
        }

        // Обработка события нажатия кнопки мыши
        // Запоминаются координаты точки, где была нажата кнопка мыши.
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        // Обработка события отпускания кнопки мыши
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Если флаг dragging имеет значение true, то вычисляются изменения координат мыши по осям X и Y.
        // Затем изменяются координаты окна на величину deltaX и deltaY.
        // Новые координаты мыши становятся текущими.
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currMousePos = Cursor.Position;
                int deltaX = currMousePos.X - prevMousePos.X;
                int deltaY = currMousePos.Y - prevMousePos.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);

                prevMousePos = currMousePos;
            }
        }

        // Закрытие окна с игрой при нажатии кнопки Esc
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }


        // Каждый раз при срабатывании таймера происходит изменение изображения на элементе coin. 
        // Происходит анимация монетки
        private void cointimer_Tick(object sender, EventArgs e)
        {

            k++;
            if (k >= coinImages.Length)
            {
                k = 0;
            }
            coin.Image = coinImages[k];
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 4;
            bg1.Top += speed;
            bg2.Top += speed;

            int enemySpeed = 6;
            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            coin.Top += speed;

            // Если фон достигает нижней границы, то он перемещается вверх, чтобы создать эффект бесконечной прокрутки.

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            // Если противник достигает нижней границы, то он перемещается вверх и случайным образом появляется в новом месте на форме.

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -200;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);

            }
            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                Random rand = new Random();
                enemy2.Left = rand.Next(350, 560);
            }

            // Если игрок пересекается с противником, то игра заканчивается и появляются элементы для перезапуска игры.

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
            }

            //Если монетка достигает нижней границы, то она перемещается вверх и случайным образом появляется в новом месте на форме.

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }

            // Обработка столкновения игрока с монеткой в игре. 
            // Если игрок пересекается с монеткой, то количество монет (countCoins) увеличивается на 1
            // Монетка перемещается вверх и случайным образом появляется в новом месте

            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Coins: " + countCoins.ToString();
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }

            // Проверка, превышает ли текущее количество монет максимальный результат, фиксирование рекорда

            if (countCoins > maxScore)
            {
                maxScore = countCoins;
                labelRecord.Text = "Max score: " + maxScore.ToString();
            }
        }


        // Реализация управления по высоте, ширине и по диагонали
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;

            int sidewaysSpeed = 17;
            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
                player.Left -= sidewaysSpeed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
                player.Left += sidewaysSpeed;
            else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && player.Top > 50)
                player.Top -= speed;
            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && player.Bottom < 630)
                player.Top += speed;

        }

        // При нажатии кнопки Restart вражеские машинки и монетка перемещаются далеко вверх, надписи проигрыша и рестарта пропадают
        // Машинка игрока возвращается на исходную позицию, счетчик монеток обнуляется
        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -700;
            enemy2.Top = -1100;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            player.Left = 400;
            player.Top = 500;
            coin.Top = -500;
            countCoins = 0;
            labelCoins.Text = "Coins: " + countCoins.ToString();
        }

        // Выбор цвета машинки в начале.
        // Затем происходит скрытие кнопок выбора цвета машинки, заголовка labelChoose и запускается таймер для начала игры.
        private void btnBlue_Click(object sender, EventArgs e)
        {
            player.Image = blueCar;
            btnBlue.Visible = false;
            btnGreen.Visible = false;
            btnYellow.Visible = false;
            btnOrange.Visible = false;
            btnWhite.Visible = false;
            labelChoose.Visible = false;
            timer.Start();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            player.Image = greenCar;
            btnBlue.Visible = false;
            btnGreen.Visible = false;
            btnYellow.Visible = false;
            btnOrange.Visible = false;
            btnWhite.Visible = false;
            labelChoose.Visible = false;
            timer.Start();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            player.Image = yellowCar;
            btnBlue.Visible = false;
            btnGreen.Visible = false;
            btnYellow.Visible = false;
            btnOrange.Visible = false;
            btnWhite.Visible = false;
            labelChoose.Visible = false;
            timer.Start();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            player.Image = orangeCar;
            btnBlue.Visible = false;
            btnGreen.Visible = false;
            btnYellow.Visible = false;
            btnOrange.Visible = false;
            btnWhite.Visible = false;
            labelChoose.Visible = false;
            timer.Start();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            player.Image = whiteCar;
            btnBlue.Visible = false;
            btnGreen.Visible = false;
            btnYellow.Visible = false;
            btnOrange.Visible = false;
            btnWhite.Visible = false;
            labelChoose.Visible = false;
            timer.Start();
        }

    }
}
