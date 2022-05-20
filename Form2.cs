using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lob_06
{
    public partial class Form2 : Form
    {
        Mutex mut;
        Form1 form1;

        delegate void myType();
        event myType TaskEvent1;

        public Form2(string task_names, Mutex mut, Form1 form1)
        {
            InitializeComponent();
            groupBox1.Text = "Task " + task_names;
            this.mut = mut;
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            myType myDeligate = this.doTaskFromStudents;
            TaskEvent1 += myDeligate;

        }
        public void myFunction1()
        {
            this.label_event1.BackColor = Color.Green;
            TaskEvent1();
        }
        private void doTaskFromStudents()
        {
            this.dateTimePicker_Start.Value = DateTime.Now;
            Thread.Sleep(1000);
            this.dateTimePicker_Stop.Value = DateTime.Now;
            this.label_end.BackColor = Color.Green;
            TimeSpan myTime = this.dateTimePicker_Stop.Value - this.dateTimePicker_Start.Value;
            this.label_TimeSpan.Text= myTime.ToString();
        
        }
        public void myFunction2()
        {
            string name = groupBox1.Text;
            TimeSpan myWork = TimeSpan.Parse(this.label_TimeSpan.Text);
            var result = (nameOfStudents: name, workOfStudents: myWork);
            mut.WaitOne();
            Thread.Sleep(1000);
            this.form1.task_answers.Add(result);
            this.label_wait.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fffffff");
            this.label_event2.BackColor = Color.Green;
            mut.ReleaseMutex();
        }
    }
}
