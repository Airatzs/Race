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
    public partial class Form_settings : Form
    {
        
        
        public Form_settings()
        {
            InitializeComponent();

            // появляется картинка машины выбранного цвета
            picture_car.Load(Form_main.car.Color);

            // появляется картинка, которая зависит от выбранной скорости
            picture_speed.Load("speed//speed_" + Form_main.car.Speed + ".jpg");
        }

        // меняем картинку при смене цвета машины
        private void Box_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_main.car.Color = "cars//car_"+Box_color.Text+".png";
            picture_car.Load(Form_main.car.Color);
            button_apply.Enabled = true;

        }

        // меняем картинку при смене скорости
        private void Box_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_main.car.Speed = int.Parse(Box_speed.Text);
            picture_speed.Load("speed//speed_" + Form_main.car.Speed + ".jpg");
            button_apply.Enabled = true;
        }

        // отмена всех изменений
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Form_main.car.Color = "cars//car_red.png";
        }
    }
}
