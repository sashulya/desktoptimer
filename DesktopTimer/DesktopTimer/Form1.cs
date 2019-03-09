using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace DesktopTimer
{
    public partial class Form1 : Form
    {
        private static void TurnOff(Object sender, System.Timers.ElapsedEventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private static void GoSleep(Object sender, System.Timers.ElapsedEventArgs e)
        {
            Process.Start("shutdown", "/h");
            Process.GetCurrentProcess().Kill();
        }

        private static void ReBoot(Object sender, System.Timers.ElapsedEventArgs e)
        {
           Process.Start("shutdown", "/r /t 0");
        }

        public Form1()
        {
            InitializeComponent();
            main_timer = new System.Timers.Timer();
            second_timer = new System.Timers.Timer();
            second_timer.Interval = 1000;
        }

        int counter;

        private static System.Timers.Timer main_timer;

        private static System.Timers.Timer second_timer;

        private void TimerStart(object sender, EventArgs e)
        {
            if (hours.Text == "")
            {
                hours.Text = "0";
            }
            if (mins.Text == "")
            {
                mins.Text = "0";
            }
            if (seconds.Text == "")
            {
                seconds.Text = "0";
            }
            if ((hours.Text == "0") && (mins.Text == "0") && (seconds.Text == "0"))
            {
                MessageBox.Show("Время таймера не может быть равно 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(hours.Text) > 500)
            {
                MessageBox.Show("Превышение максимального времени", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                hours.Text = "";
                return;
            }
            if (Convert.ToInt32(mins.Text) > 500)
            {
                MessageBox.Show("Превышение максимального времени", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mins.Text = "";
                return;
            }
            if (Convert.ToInt32(seconds.Text) > 500)
            {
                MessageBox.Show("Превышение максимального времени", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                seconds.Text = "";
                return;
            }
            if (act.Text == "")
            {
                MessageBox.Show("Не выбрана операция", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int time = Convert.ToInt32(hours.Text) * 3600000 + Convert.ToInt32(mins.Text) * 60000 + Convert.ToInt32(seconds.Text) * 1000;
            long l_time = time;
            void ShowTime(Object send, System.Timers.ElapsedEventArgs ee)
            {
                this.BeginInvoke(new Action(() =>
                {
                    if (l_time != 0)
                    {
                        l_time -= 1000;
                        TimeSpan interval = new TimeSpan(l_time * 10000);
                        time_left.Text = interval.ToString();
                        counter -= 1000;
                    }
                    else
                    {
                        second_timer.Stop();
                    }
                }));
            }
            if (act.Text == "Завершение работы")
            {
                main_timer.Elapsed += TurnOff;
                label4.Text = "До завершения работы компьютера осталось:";
                time_left.Location = new Point(260, 9);
                button2.Location = new Point(260, 29);
            }
            else if (act.Text == "Сон")
            {
                main_timer.Elapsed += GoSleep;
                label4.Text = "До перехода компьютера в спящий режим осталось:";
                time_left.Location = new Point(295, 9);
                button2.Location = new Point(295, 29);
            }
            else if (act.Text == "Перезагрузка")
            {
                main_timer.Elapsed += ReBoot;
                label4.Text = "До перезагрузки компьютера осталось:";
                time_left.Location = new Point(230, 9);
                button2.Location = new Point(230, 29);
            }
            main_timer.Interval = time;
            counter = time;
            second_timer.Elapsed += ShowTime;
            main_timer.Start();
            second_timer.Start();
            hours.Visible = false;
            seconds.Visible = false;
            mins.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            act.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            time_left.Visible = true;
        }

        private void hours_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(hours.Text, "  ^ [0-9]"))
            {
                hours.Text = "";
            }
        }

        private void hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mins_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mins.Text, "  ^ [0-9]"))
            {
                mins.Text = "";
            }
        }

        private void mins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void seconds_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(seconds.Text, "  ^ [0-9]"))
            {
                seconds.Text = "";
            }
        }

        private void seconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main_timer.Enabled == true)
            {
                main_timer.Enabled = false;
                second_timer.Enabled = false;
                button2.Text = "Запуск";
                main_timer.Interval = counter;
            }
            else
            {
                main_timer.Enabled = true;
                second_timer.Enabled = true;
                button2.Text = "Пауза";
            }
        }
    }
}
