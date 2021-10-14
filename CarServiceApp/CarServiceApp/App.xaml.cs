using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarServiceApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.CarServiceBaseEntities Context
        { get; } = new Entities.CarServiceBaseEntities();

        public static Entities.User CurrentUser = null;
    }
}
