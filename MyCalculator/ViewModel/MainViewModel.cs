using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace MyCalculator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private float _operator1;
        public float Operator1
        {
            get { return _operator1; }
            set { Set(ref _operator1, value); }
        }

        private float _operator2;
        public float Operator2
        {
            get { return _operator2; }
            set { Set(ref _operator2, value); }
        }

        private float _result;
        public float Result
        {
            get { return _result; }
            set { Set(ref _result, value); }
        }

        private string _error;
        public string Error
        {
            get { return _error; }
            set { Set(ref _error, value); }
        }


        public ICommand AddCommand { get; set; }
        public ICommand SubstractCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }
        public ICommand DivideCommand { get; set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            AddCommand = new RelayCommand(Add);
            SubstractCommand = new RelayCommand(Substract);
            MultiplyCommand = new RelayCommand(Multiply);
            DivideCommand = new RelayCommand(Divide);
        }

        public void Add()
        {
            Result = Operator1 + Operator2;
            Error = "";
        }

        public void Substract()
        {
            Result = Operator1 - Operator2;
            Error = "";
        }

        public void Multiply()
        {
            Result = Operator1 * Operator2;
            Error = "";
        }

        public void Divide()
        {
            if (Operator2 == 0)
            {
                Error = "Division by zero";
                Result = float.NaN;
            }
            else
            {
                Result = Operator1 / Operator2;
            }
        }
    }
}