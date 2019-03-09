namespace DesktopTimer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
    
        private void InitializeComponent()
        {
            this.act = new System.Windows.Forms.ComboBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.mins = new System.Windows.Forms.TextBox();
            this.seconds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.time_left = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // act
            // 
            this.act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.act.FormattingEnabled = true;
            this.act.Items.AddRange(new object[] {
            "Завершение работы",
            "Сон",
            "Перезагрузка"});
            this.act.Location = new System.Drawing.Point(289, 58);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(174, 24);
            this.act.TabIndex = 0;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(21, 60);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(51, 22);
            this.hours.TabIndex = 1;
            this.hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            this.hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hours_KeyPress);
            // 
            // mins
            // 
            this.mins.Location = new System.Drawing.Point(100, 60);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(51, 22);
            this.mins.TabIndex = 2;
            this.mins.TextChanged += new System.EventHandler(this.mins_TextChanged);
            this.mins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mins_KeyPress);
            // 
            // seconds
            // 
            this.seconds.Location = new System.Drawing.Point(196, 60);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(51, 22);
            this.seconds.TabIndex = 3;
            this.seconds.TextChanged += new System.EventHandler(this.seconds_TextChanged);
            this.seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seconds_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TimerStart);
            // 
            // time_left
            // 
            this.time_left.AutoSize = true;
            this.time_left.Location = new System.Drawing.Point(394, 9);
            this.time_left.Name = "time_left";
            this.time_left.Size = new System.Drawing.Size(12, 17);
            this.time_left.TabIndex = 5;
            this.time_left.Text = " ";
            this.time_left.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ч";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "мин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "сек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите время работы таймера и выберите желаемую операцию.\r\nЗатем нажмите на кноп" +
    "ку \'Старт\'.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Пауза";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 101);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_left);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.mins);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.act);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox act;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox mins;
        private System.Windows.Forms.TextBox seconds;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label time_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

