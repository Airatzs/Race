using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{

    public partial class Form_game : Form
    {

        System.Media.SoundPlayer Sound_countdown = new System.Media.SoundPlayer("audio//countdown.wav");
        System.Media.SoundPlayer Sound_race = new System.Media.SoundPlayer("audio//race.wav");
        

        // массив для хранения цветов
        int speed = Form_main.car.Speed + 5;
        public string[] enemy_color = new string[5];
        
     // счётчик для стартового таймера
        private int counter = 0;

     // поражение
        private void Lost()
        {
            timer_main.Stop();                                  // останавливаются все действия
            string s = ((int)Form_main.car.score / 10).ToString();
            if (Form_main.car.score < 70)
            {
                picture_lost.Load("lost//lost_" + s + ".gif");
                if (Form_main.sound)
                {
                    System.Media.SoundPlayer Sound_loose = new System.Media.SoundPlayer("audio//loose_" + s + ".wav");
                    Sound_loose.Play();
                }
            }
            else
            {
                picture_lost.Load("lost//lost_6.gif");
                if (Form_main.sound)
                {
                    System.Media.SoundPlayer Sound_loose = new System.Media.SoundPlayer("audio//loose_6.wav");
                    Sound_loose.Play();
                }
            }
            label_scor.Text = "Your Score: " + Form_main.car.score; // счёт
            button_pause.Visible = false;                      // появляется гифка (зависит от счёта)
            label_scor.Visible = true;                         // надписи о поражении и счёте
            picture_lost.Visible = true;                       // предлоение сыграть снова
            label_over.Visible = true;                         // предложение выйти в меню
            button_menu.Visible = true;
            button_retry.Visible = true;
        }


     // движение встречных машин
      private void MoveEnemy (PictureBox p, int x, int X)
        {
            p.Top += speed;
            if (p.Top >= 442)  // обновляются все данные, когда выходит за пределы поля
            {
                Form_main.car.score += Form_main.car.Speed / (double)5; // очки зависят от скорости
                p.Load(enemy_color[GetRandomNum(0, 4)]); // выбирается случайный цвет
                p.Top = GetRandomNum(-300, -100);        // случайное положение
                p.Left = GetRandomNum(x, X);             // случайная скорость (зависит от заданной)
                int speed = GetRandomNum(Form_main.car.Speed + 5, Form_main.car.Speed + 15);
            }
        }

     // управление своей машиной
        private void MoveMain (Keys k)
        {
            if (k == Keys.D)
                timer_right.Start();

            if (k == Keys.A)
                timer_left.Start();

            if (k == Keys.W)
                timer_up.Start();

            if (k == Keys.S)
                timer_down.Start();
        }

     // пуза/продолжить
        private void Pause ()
        {
            timer_main.Enabled = !timer_main.Enabled;
            button_pause.Visible = !button_pause.Visible;
            button_retry.Visible = !button_retry.Visible;
            button_menu.Visible = !button_menu.Visible;
            button_resume.Visible = !button_resume.Visible;
            this.Focus();
            picture_catch.Visible = false;
            label_bonus.Visible = false;
        }

    

     // функция для получения случайного числа
        private int GetRandomNum(int minValue, int maxValue)
        {

            System.Security.Cryptography.RNGCryptoServiceProvider rnd = new System.Security.Cryptography.RNGCryptoServiceProvider();

            // получаем наш случайный байт
            byte[] randombyte = new byte[1];
            rnd.GetBytes(randombyte);
            // превращаем его в число от 0 до 1
            double random_multiplyer = (randombyte[0] / 255d);
            // получаем разницу между минимальным и максимальным значением 
            int difference = maxValue - minValue;
            // прибавляем к минимальному значение число от 0 до difference
            int result = (int)(minValue + Math.Floor(random_multiplyer * difference));
            return result;
        }

        


        public Form_game()
        {
            InitializeComponent();

         // моментальное срабатывание стартового таймера
            timer_start_Tick(null,null);


         // картинка машины выбранного цвета
            car_main.Load(Form_main.car.Color);
           
 
         // инициализация  
            enemy_color[0] = "cars//car_enemy_red.png";
            enemy_color[1] = "cars//car_enemy_blue.png";
            enemy_color[2] = "cars//car_enemy_yellow.png";
            enemy_color[3] = "cars//car_enemy_green.png";
            enemy_color[4] = "cars//car_enemy_white.png";


         // выбор случайных цветов для встречных машин  
            car_enemy1.Load(enemy_color[GetRandomNum(0, 4)]);
            car_enemy2.Load(enemy_color[GetRandomNum(0, 4)]);
            car_enemy3.Load(enemy_color[GetRandomNum(0, 4)]);
            car_enemy4.Load(enemy_color[GetRandomNum(0, 4)]);
        }


     // обратный отсчёт перед началом игры
        private void timer_start_Tick(object sender, EventArgs e)
        {


            button_pause.Visible = false;
            if (counter == 0)
            {
                label_start.Text = "3...";
                if(Form_main.sound)Sound_countdown.Play();
            }
            if (counter == 1)
                label_start.Text = "2...";
            if (counter == 2)
                label_start.Text = "1...";
            if (counter == 3)
            { label_start.Text = "Go!"; if(Form_main.sound)Sound_race.Play(); }
             if (counter == 4)
            {
                
                label_start.Visible = false;
                button_pause.Visible = true;
                timer_start.Stop();
                timer_main.Start();
            }
            counter++;
        }


     // таймер для управления движением встречных машин
     // управления движением дороги
     // да вообще для всего
        private void timer_main_Tick(object sender, EventArgs e)
        {
            if ((Form_main.car.score >= 5 && Form_main.car.score <=9)||
                (Form_main.car.score >= 15&&Form_main.car.score <=19)||
                (Form_main.car.score >= 45&&Form_main.car.score <=49))
                
            {
                picture_easter.Location = new Point(800, 200);
                timer_easter.Start();

            }

            if (car_main.Bounds.IntersectsWith(picture_easter.Bounds))
            {
                button_pause_Click(sender, e);
                timer_easter.Stop();
                picture_catch.Location = picture_easter.Location;
                picture_catch.Visible = true;
                Form_main.car.score += 20;
                picture_easter.Location = new Point(783, 200);
                label_bonus.Visible = true;
                System.Media.SoundPlayer easter = new System.Media.SoundPlayer("audio//loose_5.wav");
                easter.Play();
            }

            // движение дороги (зависит от заданной скорости)
            p1.Top += Form_main.car.Speed;
            p2.Top += Form_main.car.Speed;
            if (p1.Top == 0)
            {
                p2.Top = -460;
            }
            if (p2.Top == 0)
            {
                p1.Top = -460;
            }

            
         // движение встречных машин
            MoveEnemy (car_enemy1, 130, 220);
            MoveEnemy (car_enemy2, 275, 340);
            MoveEnemy (car_enemy3, 400, 460);
            MoveEnemy (car_enemy4, 520, 610);


           
         // счёт для удобства округляется до десятых
            Form_main.car.score = System.Math.Round(Form_main.car.score, 1);
            label_score.Text = "Score: " + Form_main.car.score;


         // условие поражения - пересечение границ нашей машины с любой из встречных         
            if      (car_main.Bounds.IntersectsWith(car_enemy1.Bounds) ||
                     car_main.Bounds.IntersectsWith(car_enemy2.Bounds) ||
                     car_main.Bounds.IntersectsWith(car_enemy3.Bounds) ||
                     car_main.Bounds.IntersectsWith(car_enemy4.Bounds))

                        Lost();

        }


     // управление нашей машиной с помощью клавиатуры
        private void Form_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (button_pause.Visible == true)
            
                MoveMain(e.KeyCode);
            
        }


     // таймеры для управления машиной  
        private void timer_left_Tick(object sender, EventArgs e)
        {
            if (car_main.Location.X > 135)
                car_main.Left -= Form_main.car.Speed + 10;
        }
        private void timer_right_Tick(object sender, EventArgs e)
        {
            if (car_main.Location.X < 610)
                car_main.Left += Form_main.car.Speed + 10;
        }
        private void timer_up_Tick(object sender, EventArgs e)
        {
            if (car_main.Location.Y > 160)
                car_main.Top -= Form_main.car.Speed + 10;
        }
        private void timer_down_Tick(object sender, EventArgs e)
        {
            if (car_main.Location.Y < 330)
                car_main.Top += Form_main.car.Speed + 10;
        }


     // остановка движения при отпускании кнопки
        private void Form_game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)        // это для паузы
            {
                if (button_pause.Visible == true)
                    button_pause_Click(sender, e);
                else 
                    if (button_resume.Visible == true)
                        button_resume_Click(sender, e);
            }

            if (e.KeyCode == Keys.S)
                timer_down.Stop();
            if (e.KeyCode == Keys.W)
                timer_up.Stop();
            if (e.KeyCode == Keys.A)
                timer_left.Stop();
            if (e.KeyCode == Keys.D)
                timer_right.Stop();
        }

     // выход в главное меню
        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     // сыграть снова
        private void button_retry_Click(object sender, EventArgs e)
        {
            car_main.Location = new Point(417, 320);
            car_enemy1.Top = 460;
            car_enemy2.Top = 460;
            car_enemy3.Top = 460;
            car_enemy4.Top = 460;
            label_bonus.Visible = false;
            picture_catch.Visible = false;
            button_pause.Visible = false;
            button_resume.Visible = false;
            label_scor.Visible = false;
            picture_lost.Visible = false;
            label_over.Visible = false;
            button_menu.Visible = false;
            button_retry.Visible = false;
            this.Focus();
            Form_main.car.score = 4*(-Form_main.car.Speed / (double)5);
            counter = 0;
            timer_start_Tick(null, null);
            label_start.Visible = true;
            label_start.Text = "3...";
            timer_start.Start();

        }

     // пауза
        private void button_pause_Click(object sender, EventArgs e)
        {
            Pause();
            Sound_race.Stop();
        }

     // продолжение после паузы
        private void button_resume_Click(object sender, EventArgs e)
        {
            Pause();
            Sound_race.Play();
        }

        private void timer_easter_Tick(object sender, EventArgs e)
        {
            picture_easter.Left -= 10;
            if (picture_easter.Left <= -120)
            {
                timer_easter.Stop();
               
            }
        }
    }
   
}
