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

namespace BlackBoxTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Grid_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Grid_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c, d;

            try
            {
                a = Convert.ToInt32(x1.Text);
                if (x2.Text.Length == 0)
                    x2.Text = "0";
                b = Convert.ToInt32(x2.Text);
                c = Convert.ToInt32(y1.Text);
                d = Convert.ToInt32(y2.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели недопустимый символ!", "Caption");
                 return;
            }
           

            double s = Math.Abs(c - a) + Math.Abs(d - b);

            answer.Content = "Суммарная длина тени = " + s.ToString();


            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x1, x2, x3;

            try
            {
            x1 = Convert.ToInt32(a.Text);
            x2 = Convert.ToInt32(b.Text);
            x3 = Convert.ToInt32(c.Text);
       
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели недопустимый символ!", "Caption");
                return;
            }

            if (x1 == x2 && x1 == x3)
                type.Content = "Треугольник равносторонний";
            else if (x1 == x2 || x1 == x3 || x2 == x3)
                type.Content = "Треугольник равнобедренный";
            else 
                type.Content = "Треугольник разносторонний";
            if (x1 * x1 + x2 * x2 == x3 * x3 || x3 * x3 + x2 * x2 == x1 * x1 || x1 * x1 + x3 * x3 == x2 * x2)
                type.Content += " и прямоугольный";


        }

        private void y2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.NumPad0 || e.Key > Key.NumPad9) 
                || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = true;
        }

        private void y1_KeyDown(object sender, KeyEventArgs e)
        {   e.Handled = true;
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = false;   
        }

       

        private void x1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && (e.Key<Key.A && e.Key>Key.Z)  && (e.Key <= Key.NumPad0 || e.Key >= Key.NumPad9)
                || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = true;
        }

        private void a_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                  || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = true;
        }

        private void b_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = false;
        }

        private void c_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.A && e.Key > Key.Z) && (e.Key <= Key.NumPad0 || e.Key >= Key.NumPad9)
                || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && (e.Key >= Key.D0 || e.Key <= Key.D9)))
                e.Handled = true;
        }

        private void x2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
