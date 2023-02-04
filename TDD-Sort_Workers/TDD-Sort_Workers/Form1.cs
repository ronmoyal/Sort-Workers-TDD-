using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD_Sort_Workers
{
    public partial class Form1 :  System.Windows.Forms.Form
    {
        List<Worker> workers = new List<Worker>();              // list of workers for dynamic memory

        public Form1()
        {
            InitializeComponent();
        }

        private void addWorker_button_Click(object sender, EventArgs e)         // adding a single worker to list
        {
            if (ID_Box.Text == "" || Address_Box.Text == "" || FirstName_Box.Text == "" || LastName_Box.Text == "" || Telephone_Box.Text == "" || Email_Box.Text == "" || Salary_Box.Text == "")
            {
                MessageBox.Show("!שגיאה, אנא מלא את כל פרטי העובד");
                return;
            }

            workers.Add(new Worker(Int32.Parse(ID_Box.Text), FirstName_Box.Text, LastName_Box.Text, Int32.Parse(Salary_Box.Text)));

            ID_Box.Clear();
            Address_Box.Clear();
            FirstName_Box.Clear();
            LastName_Box.Clear();
            Telephone_Box.Clear();
            Email_Box.Clear();
            Salary_Box.Clear();

            MessageBox.Show("העובד נוסף בהצלחה");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomWorkers_button_Click(object sender, EventArgs e)         // adding 10,000 random workers to list
        {
            Random random = new Random();

            string[] firstName = { "אבי", "בן", "גיא", "דולב", "הדר", "ויקטור", "אביבית", "גלי", "לאה", "מאיה", "לוטם", "שביט", "תום" };
            string[] lastName = { "אגסי", "מזרחי", "לוי", "ביטון", "דהן", "זילבר", "אדמוני", "סלע", "גבאי ", "מאיה", "ברק", "בר", "שוורצמן" };

            string temp_firstName, temp_lastName;
            int temp_ID, temp_salary;

            for (int i = 0; i < 10000; i++)
            {
                if (workers.Count >= 10000)
                {
                    MessageBox.Show("עשרת אלפים עובדים נוספו בהצלחה למערכת");
                    return;
                }

                temp_ID = random.Next(100000000, 999999999);
                temp_firstName = firstName[random.Next(0, 12)];
                temp_lastName = lastName[random.Next(0, 12)];
                temp_salary = random.Next(3000, 50000);

                workers.Add(new Worker(temp_ID, temp_firstName, temp_lastName, temp_salary));
            }

            MessageBox.Show("עשרת אלפים עובדים נוספו בהצלחה למערכת");
        }

        private void show_button_Click(object sender, EventArgs e)          // show all workers in list to the visible list view in 3 categories (salary, ID, full name)
        {
            listView1.Items.Clear();
            taxValue.Text = "XXXXX";


            if (workers != null)
            {
                foreach (Worker w in workers)
                {
                    ListViewItem lvitem = new ListViewItem(w.GetSalary().ToString());
                    lvitem.SubItems.Add(w.GetId().ToString());
                    lvitem.SubItems.Add(w.GetFullName());
                    listView1.Items.Add(lvitem);
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)         // close the app (form) button
        {
            Application.Exit();
        }

        public void sort_button_Click(object sender, EventArgs e)           // TDD - sorting the workers by thier salary's (from low to high)
        {
            // return 0;                                        ***** 1 failed test *****


            //                                                  ***** Bubble Sort (n^2) - slower *****
            /*
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();
            Bubble_Sort(arrWorkers);
            workers = arrWorkers.ToList();

            watch.Stop();
            var elapsed_Ms = watch.ElapsedMilliseconds;

            MessageBox.Show(elapsed_Ms.ToString() + " :הזמן שלקח למיון העובדים להתבצע (במילי שניות) הוא");
            */


            /*
            //                                                  ***** Quick Sort (n log n) - faster but no time check *****
            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();

            Quick_Sort(arrWorkers, 0, workers.Count - 1);

            workers = arrWorkers.ToList();
            */


            /*
             *                                                  ***** Quick Sort (n log n) - with time but no help message *****
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();
            Quick_Sort(arrWorkers, 0, workers.Count - 1);
            workers = arrWorkers.ToList();

            watch.Stop();
            var elapsed_Ms = watch.ElapsedMilliseconds;
            */



            //                                                  ***** best refactored *****

            if (workers.Count == 0)
            {
                MessageBox.Show("רשימת העובדים ריקה, אנא הכנס עובדים לרשימה");
                return;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();
            Quick_Sort(arrWorkers, 0, workers.Count - 1);
            workers = arrWorkers.ToList();

            watch.Stop();
            var elapsed_Ms = watch.ElapsedMilliseconds;

            MessageBox.Show(elapsed_Ms.ToString() + " :הזמן שלקח למיון העובדים להתבצע (במילי שניות) הוא");
            MessageBox.Show("להצגת רשימה ממוינת לפי שכר, יש ללחוץ על הצג רשימת עובדים");

        }

        private void refresh_button_Click(object sender, EventArgs e)           // clear all fields of boxes (if needed) button when trying to insert single worker
        {
            ID_Box.Clear();
            Address_Box.Clear();
            FirstName_Box.Clear();
            LastName_Box.Clear();
            Telephone_Box.Clear();
            Email_Box.Clear();
            Salary_Box.Clear();
        }

        private void calcTax_button_Click(object sender, EventArgs e)           // calculate the tax button
        {
            //                                                  ***** before refactoring *****
            /*              
            int calcTax;
            calcTax = (int)TaxCal(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
            taxValue.Text = calcTax.ToString();
            */

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("יש ללחוץ על משכורת של עובד מרשימת העובדים");
                return;
            }

            int calcTax;
            calcTax = (int)TaxCal(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));

            taxValue.Text = calcTax.ToString();
        }

        public float TaxCal(int salary)         // TDD - Tax calculation function
        {
            // return 0;                                        ***** 1 failed test *****

            if (salary <= 6450)
                return (float)(salary * 0.10);
            if (salary <= 9240)
                return (float)(salary * 0.14);
            if (salary <= 14840)
                return (float)(salary * 0.20);
            if (salary <= 20620)
                return (float)(salary * 0.31);
            if (salary <= 42910)
                return (float)(salary * 0.35);
            return (float)(salary * 0.47);

        }

        private void timer1_Tick(object sender, EventArgs e)            // setting the loading screen timer (Just for creativity and realistic beautiful design...)
        {
            timer1.Stop();
            pictureBox1.Dispose();


        }

        //                                                  ***** Help Functions - Bubble Sort *****
        public void Bubble_Sort(Worker[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
                for (int j = 0; j < len - i - 1; j++)
                    if (arr[j].salary > arr[j + 1].salary)
                    {
                        Worker temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }


        //                                                  ***** Help Functions - Quick Sort *****
        public void Quick_Sort(Worker[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        public int Partition(Worker[] arr, int left, int right)
        {
            float pivot = arr[left].GetSalary();
            while (true)
            {

                while (arr[left].GetSalary() < pivot)
                {
                    left++;
                }

                while (arr[right].GetSalary() > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left].GetSalary() == arr[right].GetSalary()) return right;

                    Worker temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                }
                else
                {
                    return right;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
