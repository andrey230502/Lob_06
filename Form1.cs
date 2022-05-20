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
    public partial class Form1 : Form
    {
        static Mutex mut = new Mutex();
        static readonly string[] task_names = { "Ab", "Bc", "Cd", "De", "Ef", "Fg", "Gh", "Hi"};
        public List<(string, TimeSpan)> task_answers = new List<(string, TimeSpan)> ();
        
        
        List<Thread> myThreadsList = new List<Thread> ();

        int task_count = task_names.Length;

        delegate void myType();
        event myType TaskEvent1;
        event myType TaskEvent2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; // вимикаємо перевірку в Debug
            button_event2.Enabled = false;

            for (int i = 0; i < task_count; i++)
{
                Thread myThread = new Thread(show_Form2);
                myThreadsList.Add(myThread);
                myThread.Start(task_names[i]);
            }
        }
        void show_Form2(object obj)
        {
            
           if (obj is string str)
           {
                Form2 f2 = new Form2(str, mut, this);
                TaskEvent1 += f2.myFunction1;
                TaskEvent2 += f2.myFunction2;
                Application.Run(f2);
           }
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_event1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime tm = DateTime.Now;
            TaskEvent1();

            TimeSpan ts = DateTime.Now - tm;
            label_Cons.Text = ts.ToString();
            Cursor.Current = Cursors.Default;
            button_event1.Enabled = false;
            button_event2.Enabled = true;
        }

        private void button_event2_Click(object sender, EventArgs e)
        {
            task_answers = new List<(string, TimeSpan)>();
            Cursor.Current = Cursors.WaitCursor;
            DateTime tm = DateTime.Now;
            TaskEvent2();
            TimeSpan ts = DateTime.Now - tm;
            label_Task.Text = ts.ToString();
            label_AllTask.Text = task_answers.Count.ToString();
            Cursor.Current = Cursors.Default;
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (task_answers.Count < 1)
            {
                MessageBox.Show("Нема що робити");
                return;
            }
            else
            {
                string str = "Назва завдання \t Час виконання \t Виконано\n\n";
                foreach ((string, TimeSpan) item in task_answers)
                {
                str += item.Item1 + "\t:" + item.Item2.ToString() + "\n";
                }
                MessageBox.Show(str);
                button_event1.Enabled = true;
            }
        }
    }
}
