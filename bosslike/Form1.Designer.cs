namespace bosslike
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.countGoal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.webBrowser12 = new System.Windows.Forms.WebBrowser();
            this.progress = new System.Windows.Forms.Label();
            this.DoneOutput = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.LastForEnd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(553, 56);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 45);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(554, 275);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(374, 46);
            this.start.TabIndex = 3;
            this.start.Text = "Начать";
            this.start.UseMnemonic = false;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.Location = new System.Drawing.Point(554, 333);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(375, 48);
            this.stop.TabIndex = 4;
            this.stop.Text = "Остановить";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(550, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Заданий выполнено -\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(550, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Баллов заработано - ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(550, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус - ";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(625, 22);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(305, 23);
            this.status.TabIndex = 13;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // countGoal
            // 
            this.countGoal.Location = new System.Drawing.Point(784, 243);
            this.countGoal.Margin = new System.Windows.Forms.Padding(2);
            this.countGoal.Name = "countGoal";
            this.countGoal.Size = new System.Drawing.Size(41, 20);
            this.countGoal.TabIndex = 14;
            this.countGoal.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(550, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Выполнить списков заданий ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(554, 396);
            this.reload.Margin = new System.Windows.Forms.Padding(2);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(374, 46);
            this.reload.TabIndex = 18;
            this.reload.Text = "Перезапустить";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // webBrowser12
            // 
            this.webBrowser12.Location = new System.Drawing.Point(-1, 2);
            this.webBrowser12.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser12.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser12.Name = "webBrowser12";
            this.webBrowser12.Size = new System.Drawing.Size(528, 459);
            this.webBrowser12.TabIndex = 19;
            this.webBrowser12.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress.Location = new System.Drawing.Point(725, 69);
            this.progress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(31, 18);
            this.progress.TabIndex = 20;
            this.progress.Text = "0%";
            // 
            // DoneOutput
            // 
            this.DoneOutput.AutoSize = true;
            this.DoneOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneOutput.Location = new System.Drawing.Point(725, 113);
            this.DoneOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoneOutput.Name = "DoneOutput";
            this.DoneOutput.Size = new System.Drawing.Size(17, 17);
            this.DoneOutput.TabIndex = 21;
            this.DoneOutput.Text = "0";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Points.Location = new System.Drawing.Point(725, 144);
            this.Points.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(17, 17);
            this.Points.TabIndex = 22;
            this.Points.Text = "0";
            // 
            // LastForEnd
            // 
            this.LastForEnd.AutoSize = true;
            this.LastForEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastForEnd.Location = new System.Drawing.Point(725, 177);
            this.LastForEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastForEnd.Name = "LastForEnd";
            this.LastForEnd.Size = new System.Drawing.Size(17, 17);
            this.LastForEnd.TabIndex = 24;
            this.LastForEnd.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(550, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Осталось выполнить - ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Подписки",
            "Лайки"});
            this.comboBox1.Location = new System.Drawing.Point(686, 206);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 25);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Подписки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(550, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тип заданий - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(953, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LastForEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.DoneOutput);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.webBrowser12);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countGoal);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bosslike";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox countGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.WebBrowser webBrowser12;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label DoneOutput;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label LastForEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

