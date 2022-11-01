using Source.Commands;
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
using System.Windows.Shapes;

namespace Source.Views;

public partial class MainView : Window
{

    public ICommand ShowCommand { get; set; }

    public MainView()
    {
        InitializeComponent();

        DataContext = this;

        ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteCommand);
    }

    void ExecuteShowCommand(object? parametr) => MessageBox.Show("Test");

    bool CanExecuteCommand(object? parametr) => txt.Text.Length > 2;
}
