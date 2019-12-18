using System;
using System.Windows;
using System.Windows.Controls;


namespace CGPA_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int s1Credit;
        public int s2Credit;
        public int s3Credit;
        public int s4Credit;
        public int s5Credit;
         
        public double s1Grade;
        public double s2Grade;
        public double s3Grade;
        public double s4Grade;
        public double s5Grade;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GpaButton_Click(object sender, RoutedEventArgs e)
        {
            // Calculate GPA:

            var gpa = CalculateGpa();

            // MessageBox.Show($"Gpa is: {gpa}");

            GpaValueTextBlock.Text = "GPA: " + gpa.ToString("0.00");
        }

        private void CgpaButton_Click(object sender, RoutedEventArgs e)
        {
            var cgpa = CalculateCgpa();

            CgpaValueTextBlock.Text = "CGPA: " + cgpa.ToString("0.00");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Subject1Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 1 Credit: " + content);
                s1Credit = int.Parse(content);

                //MessageBox.Show("Selected Subject 1 Credit: " + s1Credit.ToString());

            }
            else
            {
                MessageBox.Show("Select a Credit Value for Subject 1");
                s1Credit = 0;
            }

        }

        private void Subject2Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 2 Credit: " + content);
                s2Credit = int.Parse(content);

            }
            else
            {
                MessageBox.Show("Select a Credit Value for Subject 2");
                s2Credit = 0;
            }
        }

        private void Subject3Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 3 Credit: " + content);
                s3Credit = int.Parse(content);

            }
            else
            {
                MessageBox.Show("Select a Credit Value for Subject 3");
                s3Credit = 0;
            }
        }

        private void Subject4Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 4 Credit: " + content);
                s4Credit = int.Parse(content);

            }
            else
            {
                MessageBox.Show("Select a Credit Value for Subject 4");
                s4Credit = 0;
            }
        }

        private void Subject5Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 5 Credit: " + content);
                s5Credit = int.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Credit Value for Subject 5");

                // Set the s5credit val  to 0
                s5Credit = 0;
                
            }
        }

        private void Subject1Grade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 1 Grade: " + content);
                s1Grade = double.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Grade Value for Subject 1");

                // Set the s5credit val  to 0
                s1Grade = 0.0;

            }
        }

        private void Subject2Grade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 2 Grade: " + content);
                s2Grade = double.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Grade Value for Subject 2");

                // Set the s5credit val  to 0
                s2Grade = 0.0;

            }
        }

        private void Subject3Grade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 3 Grade: " + content);
                s3Grade = double.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Grade Value for Subject 3");

                // Set the s5credit val  to 0
                s3Grade = 0.0;

            }
        }

        private void Subject4Grade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 4 Grade: " + content);
                s4Grade = double.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Grade Value for Subject 4");

                // Set the s5credit val  to 0
                s4Grade = 0.0;

            }
        }

        private void Subject5Grade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = GetValueFromComboBox(sender);

            if (content != "--- Select a Credit Value ---")
            {
                // MessageBox.Show("Selected Subject 5 Grade: " + content);
                s5Grade = double.Parse(content);
            }
            else
            {
                MessageBox.Show("Select a Grade Value for Subject 5");

                // Set the s5credit val  to 0
                s5Grade = 0.0;

            }
        }



        //Get the Value of a Combobox and return the value
        public string GetValueFromComboBox(object sender)
        {
            var combobox = (ComboBox)sender;

            var value = (ComboBoxItem)combobox.SelectedValue;

            var content = (string)value.Content;

            return content;
        }

        // Calculate GPA
        public double CalculateGpa()
        {
            double sum_of_credit_and_grade = (s1Credit * s1Grade) + (s2Credit * s2Grade) + (s3Credit * s3Grade) + (s4Credit * s4Grade) + (s5Credit * s5Grade);

            int sum_of_credit = s1Credit + s2Credit + s3Credit + s4Credit + s5Credit;

            double gpa = sum_of_credit_and_grade / sum_of_credit;

            return gpa;
        }

        // Calculate CGPA
        public double CalculateCgpa()
        {
            var gpa = CalculateGpa();

            var currentCgpa = CurrentCgpaTextBox.Text;
            var currentCreditCompleted = CreditEarnedTextBox.Text;

            double currentCgpaDouble = 0.0, creditEarned = 0.0;

            int this_semesters_sum_of_credit = s1Credit + s2Credit + s3Credit + s4Credit + s5Credit;

            if (currentCgpa == "")
            {
                currentCgpaDouble = 0.0;
            }
            else
            {
                try
                {
                    currentCgpaDouble = double.Parse(currentCgpa);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a Valid Current CGPA");
                }
            }

            if (currentCreditCompleted == "")
            {
                creditEarned = 0.0;
            }
            else
            {
                try
                {
                    creditEarned = double.Parse(currentCreditCompleted);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter Valid Credit Earned Value");
                }
            }

            var sum_of_gpa_and_current_cgpa = (currentCgpaDouble * creditEarned) + (gpa * this_semesters_sum_of_credit);

            var cgpa = sum_of_gpa_and_current_cgpa / (this_semesters_sum_of_credit + creditEarned);

            // MessageBox.Show($"CGPA: {cgpa}");

            return cgpa;
        }
    }
}
