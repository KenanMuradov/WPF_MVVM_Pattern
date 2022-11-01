using Source.Commands;
using Source.Models;
using Source.Repositories.Abstracts;
using Source.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Source.ViewModels;

public class MainViewModel
{
    private readonly ICarRepository _carRepository;
    public ObservableCollection<Car> Cars { get; set; }
    public Car? SelectedCar { get; set; }

    public ICommand ShowCommand { get; set; }

    public MainViewModel(ICarRepository carRepository)
    {
        _carRepository = carRepository;
        Cars = new(_carRepository.GetList() ?? new());

        ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
    }


    void ExecuteShowCommand(object? parametr) => MessageBox.Show(SelectedCar?.Make);
    bool CanExecuteShowCommand(object? parametr) => SelectedCar is not null;

}
