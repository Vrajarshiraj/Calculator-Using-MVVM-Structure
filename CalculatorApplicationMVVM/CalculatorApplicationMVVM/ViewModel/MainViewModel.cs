
using CalculatorApplicationMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using CalculatorApplicationMVVM.Command;
namespace CalculatorApplicationMVVM.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public Person Person { get; set; }
        Person objPerson;

        private TextViewModel textView;
        public TextViewModel objTextView
        {
            get { return textView; }
            set { textView = value; NotifyPropertyChanged("objTextView"); }
        }

        private ButtonControlViewModel buttonControlViewModel;

        public ButtonControlViewModel objButtonControlViewModel
        {
            get { return buttonControlViewModel; }
            set { buttonControlViewModel = value; NotifyPropertyChanged("objButtonControlViewModel"); }
        }




        public MainViewModel()
        {
            objPerson = new Person();
            objTextView = new TextViewModel();
            objButtonControlViewModel = new ButtonControlViewModel();
            objTextView.DisplayText = "0";

            //objButtonControlViewModel.Button0Command = new RelayCommand(objButtonControlViewModel.Button_0);
            //objButtonControlViewModel.Button1Command = new RelayCommand(objButtonControlViewModel.Button_1);
            //objButtonControlViewModel.Button2Command = new RelayCommand(objButtonControlViewModel.Button_2);
            //objButtonControlViewModel.Button3Command = new RelayCommand(objButtonControlViewModel.Button_3);
            //objButtonControlViewModel.Button4Command = new RelayCommand(objButtonControlViewModel.Button_4);
            //objButtonControlViewModel.Button4Command = new RelayCommand(objButtonControlViewModel.Button_5);
            //objButtonControlViewModel.Button6Command = new RelayCommand(objButtonControlViewModel.Button_6);
            //objButtonControlViewModel.Button7Command = new RelayCommand(objButtonControlViewModel.Button_7);
            //objButtonControlViewModel.Button8Command = new RelayCommand(objButtonControlViewModel.Button_8);
            //objButtonControlViewModel.Button9Command = new RelayCommand(objButtonControlViewModel.Button_9);

            ////Arithmetic Operation Command
            //objButtonControlViewModel.AddCommand = new RelayCommand(objButtonControlViewModel.Add);
            //objButtonControlViewModel.SubCommand = new RelayCommand(objButtonControlViewModel.Sub);
            //objButtonControlViewModel.MulCommand = new RelayCommand(objButtonControlViewModel.Mul);
            //objButtonControlViewModel.DivCommand = new RelayCommand(objButtonControlViewModel.Div);

            ////Equal Operation Command
            //objButtonControlViewModel.EqualCommand = new RelayCommand(objButtonControlViewModel.Button_Equal);

            ////Other Operations
            //objButtonControlViewModel.CE_Command = new RelayCommand(objButtonControlViewModel.CE_Button);
            //objButtonControlViewModel.C_Command = new RelayCommand(objButtonControlViewModel.C_Button);
            //objButtonControlViewModel.BackSpaceCommand = new RelayCommand(objButtonControlViewModel.Backspace_Button);



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

        
       
    

