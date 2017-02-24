using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setEnabled();
        }

        private void setEnabled()
        {
            btnNext.IsEnabled = false;
            btnPrevious.IsEnabled = false;
        }

        List<Student> studentList = new List<Student>();

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text) || !string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                Student student = new Student();
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.City = txtCity.Text;
                studentList.Add(student);

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtCity.Text = "";

                MessageBox.Show("Student Created");
                if (studentList.Count > 0)
                {
                    btnNext.IsEnabled = true;
                    btnPrevious.IsEnabled = true;
                }
                else
                {
                    btnNext.IsEnabled = false;
                    btnPrevious.IsEnabled = false;
                }
            }
            else
            {
                MessageBox.Show("You must enter at least a student's first or last name");
            }
        }

        private int nextClickCount = -1;

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            nextClickCount++;

            if (nextClickCount >= studentList.Count)
            {
                nextClickCount = 0;
            }

            txtFirstName.Text = studentList[nextClickCount].FirstName;
            txtLastName.Text = studentList[nextClickCount].LastName;
            txtCity.Text = studentList[nextClickCount].City;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            nextClickCount--;

            if (nextClickCount < 0)
            {
                nextClickCount = studentList.Count - 1;
            }

            txtFirstName.Text = studentList[nextClickCount].FirstName;
            txtLastName.Text = studentList[nextClickCount].LastName;
            txtCity.Text = studentList[nextClickCount].City;
        }
    }
}
