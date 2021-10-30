using LibMas;
using Microsoft.Win32;
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
using Lib_4;

namespace Практическая_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private MyArray _myArray = new MyArray(3, 3);


        private void Calculation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{_myArray.GetColumnsProduct()}", "Произведение столбцов матрицы", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            _myArray.Initialize();
            myDataGrid.ItemsSource = _myArray.ToDataTable().DefaultView;
        }

        private void ClearArray_Click(object sender, RoutedEventArgs e)
        {
            _myArray.Clear();
            myDataGrid.ItemsSource = _myArray.ToDataTable().DefaultView;
        }

        private void SaveArray_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Сохранение матрицы";

            if (saveFileDialog.ShowDialog() == true)
            {
                _myArray.Save(saveFileDialog.FileName);
            }
            myDataGrid.ItemsSource = null;
        }

        private void OpenArray_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "Открытие матрицы";

            if (openFileDialog.ShowDialog() == true)
            {
                _myArray.Open(openFileDialog.FileName);
            }
            myDataGrid.ItemsSource = _myArray.ToDataTable().DefaultView;
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Дударев И. В. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
