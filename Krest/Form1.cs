using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krest
{
    public partial class Form1 : Form
    {
        private int player;             // переменная для хранения информации о номере игрока (1 или 2)
        public Form1()
        {
            InitializeComponent();
            this.Height = 800;
            this.Width = 900;
            player = 1;                 // присваиваем по умолчанию значение 1 игрока
            label1.Text = "Текущий ход: игрок 1";   // первый ход у 1 игрока


        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");     // для первого игрока в кнопке появляется х
                    player = 0;                                                     // ход переходит к другому игроку
                    label1.Text = "Текущий ход: игрок 2";                           // изменение текста информации о игроке
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");     // для второго игрока в кнопке появляется о
                    player = 1;                                                     // ход переходит к другому игроку
                    label1.Text = "Текущий ход: игрок 1";                           // изменение текста информации о игроке
                    break;
                   
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);        // выключение кнопки, чтобы нельзя было нажать второй раз
        }
    }
}
