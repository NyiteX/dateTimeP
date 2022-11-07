namespace WindowsFormsApp5
{
    partial class Basic_Window
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
            this.X_Button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.start_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Seconds_show = new System.Windows.Forms.RadioButton();
            this.Mins_show = new System.Windows.Forms.RadioButton();
            this.Years_show = new System.Windows.Forms.RadioButton();
            this.Days_show = new System.Windows.Forms.RadioButton();
            this.Months_show = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // X_Button
            // 
            this.X_Button.AutoSize = true;
            this.X_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_Button.Location = new System.Drawing.Point(479, 9);
            this.X_Button.Name = "X_Button";
            this.X_Button.Size = new System.Drawing.Size(23, 22);
            this.X_Button.TabIndex = 0;
            this.X_Button.Text = "X";
            this.X_Button.Click += new System.EventHandler(this.X_Button_Click);
            this.X_Button.MouseEnter += new System.EventHandler(this.X_Button_MouseEnter);
            this.X_Button.MouseLeave += new System.EventHandler(this.X_Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 148);
            this.label1.TabIndex = 2;
            this.label1.Text = "2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            this.dateTimePicker1.MouseEnter += new System.EventHandler(this.dateTimePicker1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(183, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 108);
            this.label2.TabIndex = 6;
            this.label2.Text = "=(";
            // 
            // start_1
            // 
            this.start_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.start_1.Location = new System.Drawing.Point(0, 416);
            this.start_1.Name = "start_1";
            this.start_1.Size = new System.Drawing.Size(512, 126);
            this.start_1.TabIndex = 7;
            this.start_1.Text = "START";
            this.start_1.UseVisualStyleBackColor = true;
            this.start_1.Click += new System.EventHandler(this.start_1_Click);
            this.start_1.MouseEnter += new System.EventHandler(this.start_1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(133, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите дату для сравнения:";
            // 
            // Seconds_show
            // 
            this.Seconds_show.AutoSize = true;
            this.Seconds_show.Location = new System.Drawing.Point(52, 308);
            this.Seconds_show.Name = "Seconds_show";
            this.Seconds_show.Size = new System.Drawing.Size(132, 17);
            this.Seconds_show.TabIndex = 9;
            this.Seconds_show.TabStop = true;
            this.Seconds_show.Text = "Показать в секундах";
            this.Seconds_show.UseVisualStyleBackColor = true;
            // 
            // Mins_show
            // 
            this.Mins_show.AutoSize = true;
            this.Mins_show.Location = new System.Drawing.Point(52, 347);
            this.Mins_show.Name = "Mins_show";
            this.Mins_show.Size = new System.Drawing.Size(127, 17);
            this.Mins_show.TabIndex = 10;
            this.Mins_show.TabStop = true;
            this.Mins_show.Text = "Показать в минутах";
            this.Mins_show.UseVisualStyleBackColor = true;
            // 
            // Years_show
            // 
            this.Years_show.AutoSize = true;
            this.Years_show.Location = new System.Drawing.Point(350, 347);
            this.Years_show.Name = "Years_show";
            this.Years_show.Size = new System.Drawing.Size(114, 17);
            this.Years_show.TabIndex = 11;
            this.Years_show.TabStop = true;
            this.Years_show.Text = "Показать в годах";
            this.Years_show.UseVisualStyleBackColor = true;
            // 
            // Days_show
            // 
            this.Days_show.AutoSize = true;
            this.Days_show.Location = new System.Drawing.Point(209, 347);
            this.Days_show.Name = "Days_show";
            this.Days_show.Size = new System.Drawing.Size(109, 17);
            this.Days_show.TabIndex = 12;
            this.Days_show.TabStop = true;
            this.Days_show.Text = "Показать в днях";
            this.Days_show.UseVisualStyleBackColor = true;
            // 
            // Months_show
            // 
            this.Months_show.AutoSize = true;
            this.Months_show.Location = new System.Drawing.Point(350, 308);
            this.Months_show.Name = "Months_show";
            this.Months_show.Size = new System.Drawing.Size(129, 17);
            this.Months_show.TabIndex = 13;
            this.Months_show.TabStop = true;
            this.Months_show.Text = "Показать в месяцах";
            this.Months_show.UseVisualStyleBackColor = true;
            // 
            // Basic_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 542);
            this.Controls.Add(this.Months_show);
            this.Controls.Add(this.Days_show);
            this.Controls.Add(this.Years_show);
            this.Controls.Add(this.Mins_show);
            this.Controls.Add(this.Seconds_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basic_Window";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Seconds_show;
        private System.Windows.Forms.RadioButton Mins_show;
        private System.Windows.Forms.RadioButton Years_show;
        private System.Windows.Forms.RadioButton Days_show;
        private System.Windows.Forms.RadioButton Months_show;
    }
}

