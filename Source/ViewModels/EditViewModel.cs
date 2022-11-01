using Source.Commands;
using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Source.ViewModels;

public class EditViewModel
{
    public Car SelectedCar { get; set; }

    public ICommand AcceptCommand { get; set; }
    public ICommand CancelCommand { get; set; }


    public EditViewModel(Car selectedCar)
    {
        SelectedCar = selectedCar;

        AcceptCommand = new RelayCommand(ExecuteAcceptCommand);
    }

    void ExecuteAcceptCommand(object? parametr)
    {
        if(parametr is bool?)
        {
            parametr = (bool?)true;
        }
    }

}
