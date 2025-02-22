﻿using System;
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

        private void button1_Click(object sender, EventArgs e)      // обработчик нажатия кнопки
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
            checkwin();                                                             // проверка выигрыша
        }
        private void checkwin()                                                     // функция обработки проверки выигрыша
        {
            if(button1.Text==button2.Text && button2.Text == button3.Text)
            {
                if(button1.Text!="")
                    MessageBox.Show("Вы победили");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили");
            }
        }
    }
}
