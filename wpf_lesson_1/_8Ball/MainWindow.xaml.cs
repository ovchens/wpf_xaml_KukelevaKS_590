using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _8Ball
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string GetRandomAnswer()
        {   
            string[] answer = { "Вероятно", 
                                    "Мало вероятно", 
                                            "Однозначно да", 
                                                    "Однозначно нет",
                                                               "Скорее нет" };

            Random  r = new Random();
         
                int a = r.Next(4);
                return answer[a];

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            txtAnswer.Text = GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;

        }
    }
}
