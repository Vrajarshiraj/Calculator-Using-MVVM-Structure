using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalculatorApplicationMVVM.Model
{
    public class Person:INotifyPropertyChanged
    {
        private long number1;

        public long Number1
        {
            get { return number1; }
            set { number1 = value; OnPropertyChanged("Number1"); }
        }


        private long number2;
        public long Number2
        {
            get { return number2; }
            set { number2 = value; OnPropertyChanged("Number2"); }
        }

        private string operation;

        public string Operation
        {
            get { return operation; }
            set { operation = value; OnPropertyChanged("operation"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
