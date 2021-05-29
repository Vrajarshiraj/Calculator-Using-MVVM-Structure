using CalculatorApplicationMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CalculatorApplicationMVVM.Command;

namespace CalculatorApplicationMVVM.ViewModel
{
    public class TextViewModel : INotifyPropertyChanged
    {
        public Person Person { get; set; }

   

        private string displayText;

        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value;NotifyPropertyChanged("DisplayText"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
