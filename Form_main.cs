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
    public partial class Form_main : Form
    {
        public static bool sound = true;
        System.Media.SoundPlayer Sound_main = new System.Media.SoundPlayer("audio//main.wav");


        // при запуске программы создаём объект класса машина
        // и задаём начальные параметры скорости и цвета (можно изменить из настроек)
        public static Car car = new Car(5, "cars//car_red.png",0);

        public Form_main()
        {
            
            InitializeComponent();
            
            
        }
       

        // кнопка для начала игры
        private void button_start_Click(object sender, EventArgs e)
        {
            car.score = 0;
            Form_game s = new Form_game();
            this.Hide();
            s.ShowDialog();
            this.Show();
            if(sound)
                Sound_main.Play();
        }

        // кнопка для открытия настроек
        private void button_settings_Click(object sender, EventArgs e)
        {
            
            Form_settings s = new Form_settings();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        // выход из игры
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // показывает текст с правилами игры
        private void button_help_Click(object sender, EventArgs e)
        {
            label_help.Visible = true;
            button_ok.Visible = true;
        }

        // скрывает текст с правилами игры
        private void button_ok_Click(object sender, EventArgs e)
        {
            label_help.Visible = false;
            button_ok.Visible = false;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            if(sound)
                Sound_main.Play();
        }

        // настройка звука
        private void checkBox_audio_CheckedChanged(object sender, EventArgs e)
        {
            sound = checkBox_audio.Checked;
            if (sound)
                Sound_main.Play();
            if (!sound)
                Sound_main.Stop();
        }
    }
}
