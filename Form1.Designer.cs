namespace Lob_06
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_show = new System.Windows.Forms.Button();
            this.button_event2 = new System.Windows.Forms.Button();
            this.button_event1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cons = new System.Windows.Forms.Label();
            this.label_Task = new System.Windows.Forms.Label();
            this.label_AllTask = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розглядав завдання:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_show);
            this.groupBox1.Controls.Add(this.button_event2);
            this.groupBox1.Controls.Add(this.button_event1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stydent";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(200, 19);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(59, 77);
            this.button_show.TabIndex = 2;
            this.button_show.Text = "Інформація";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_event2
            // 
            this.button_event2.Location = new System.Drawing.Point(102, 19);
            this.button_event2.Name = "button_event2";
            this.button_event2.Size = new System.Drawing.Size(92, 76);
            this.button_event2.TabIndex = 1;
            this.button_event2.Text = "Перевірити завдання";
            this.button_event2.UseVisualStyleBackColor = true;
            this.button_event2.Click += new System.EventHandler(this.button_event2_Click);
            // 
            // button_event1
            // 
            this.button_event1.Location = new System.Drawing.Point(7, 19);
            this.button_event1.Name = "button_event1";
            this.button_event1.Size = new System.Drawing.Size(88, 77);
            this.button_event1.TabIndex = 0;
            this.button_event1.Text = "Переглянути Завдання та зробити";
            this.button_event1.UseVisualStyleBackColor = true;
            this.button_event1.Click += new System.EventHandler(this.button_event1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Робив завдання:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Всього завдань:";
            // 
            // label_Cons
            // 
            this.label_Cons.AutoSize = true;
            this.label_Cons.Location = new System.Drawing.Point(138, 120);
            this.label_Cons.Name = "label_Cons";
            this.label_Cons.Size = new System.Drawing.Size(59, 13);
            this.label_Cons.TabIndex = 4;
            this.label_Cons.Text = "label_Cons";
            // 
            // label_Task
            // 
            this.label_Task.AutoSize = true;
            this.label_Task.Location = new System.Drawing.Point(137, 151);
            this.label_Task.Name = "label_Task";
            this.label_Task.Size = new System.Drawing.Size(59, 13);
            this.label_Task.TabIndex = 5;
            this.label_Task.Text = "label_Task";
            this.label_Task.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_AllTask
            // 
            this.label_AllTask.AutoSize = true;
            this.label_AllTask.Location = new System.Drawing.Point(136, 180);
            this.label_AllTask.Name = "label_AllTask";
            this.label_AllTask.Size = new System.Drawing.Size(70, 13);
            this.label_AllTask.TabIndex = 6;
            this.label_AllTask.Text = "label_AllTask";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 259);
            this.Controls.Add(this.label_AllTask);
            this.Controls.Add(this.label_Task);
            this.Controls.Add(this.label_Cons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_event2;
        private System.Windows.Forms.Button button_event1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cons;
        private System.Windows.Forms.Label label_Task;
        private System.Windows.Forms.Label label_AllTask;
    }
}

