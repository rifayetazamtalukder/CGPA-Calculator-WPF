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

namespace CGPA_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int s1Credit = 0;
        /*public int s2Credit = 0;
        public int s3Credit = 0;
        public int s4Credit = 0;
        public int s5Credit = 0;

        public double s1Grade = 0.0D;
        public double s2Grade = 0.0D;
        public double s3Grade = 0.0D;
        public double s4Grade = 0.0D;
        public double s5Grade = 0.0D;*/
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GpaButton_Click(object sender, RoutedEventArgs e)
        {


            GpaValue.Text = "GPA: 4.00";
        }

        private void CgpaButton_Click(object sender, RoutedEventArgs e)
        {
            CgpaValue.Text = "CGPA: 4.00";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Subject1Credit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // var credit = GetCredit(object sender);

            if(this.GpaValue == null)
            {
                return;
            }

            var combobox = (ComboBox)sender;

            var value = (ComboBoxItem)combobox.SelectedValue;

            var content = (string)value.Content;

            try
            {
                s1Credit = int.Parse(content);
            }
            catch (Exception)
            {
                this.GpaValue.Text = content;
                return;

            }

            this.GpaValue.Text = s1Credit.ToString();
        }

        //
        public void showSelectedBox(object sender)
        {
            var combobox = this.Subject1Credit.SelectedValue;

            var val = (string)combobox;

            CgpaValue.Text = val;
        }
    }
}
