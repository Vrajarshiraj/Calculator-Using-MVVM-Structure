using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CalculatorApplicationMVVM.Model;
using CalculatorApplicationMVVM.Command;
using System.Windows;

namespace CalculatorApplicationMVVM.ViewModel
{
    public class ButtonControlViewModel
    {
        public Person Person { get; set; }
        Person _Person;


        private TextViewModel _textView;

        public TextViewModel _TextView     //Assigned for dataContext in MainWindoow.xaml
        {
            get { return _textView; }
            set { _textView = value; NotifyPropertyChanged("_TextView"); }
        }

        

        public ButtonControlViewModel()
        {
            _Person = new Person();
            _TextView = new TextViewModel();


            //Button Operation
            Button0Command = new RelayCommand(Button_0);
            Button1Command = new RelayCommand(Button_1);
            Button2Command = new RelayCommand(Button_2);
            Button3Command = new RelayCommand(Button_3);
            Button4Command = new RelayCommand(Button_4);
            Button5Command = new RelayCommand(Button_5);
            Button6Command = new RelayCommand(Button_6);
            Button7Command = new RelayCommand(Button_7);
            Button8Command = new RelayCommand(Button_8);
            Button9Command = new RelayCommand(Button_9);

            //Arithmetic Operation
            AddCommand = new RelayCommand(Add);
            SubCommand = new RelayCommand(Sub);
            MulCommand = new RelayCommand(Mul);
            DivCommand = new RelayCommand(Div);
            EqualCommand = new RelayCommand(Button_Equal);

            //Clear Button Operation
            C_Command = new RelayCommand(C_Button);
            CE_Command = new RelayCommand(CE_Button);
            BackSpaceCommand = new RelayCommand(Backspace_Button);


        }

        private RelayCommand button0Command;

        public RelayCommand Button0Command
        {
            get { return button0Command; }
            set { button0Command = value; NotifyPropertyChanged("Button0Command"); }
        }

        public void Button_0()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 0;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 0;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button1Command;

        public RelayCommand Button1Command
        {
            get { return button1Command; }
            set { button1Command = value; NotifyPropertyChanged("Button1Command"); }
        }

        public void Button_1()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 1;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 1;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button2Command;

        public RelayCommand Button2Command
        {
            get { return button2Command; }
            set { button2Command = value; NotifyPropertyChanged("Button0Command"); }
        }

        public void Button_2()
        {
            if (_Person.Operation == "")
            {

                _Person.Number1 = (_Person.Number1 * 10) + 2;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 2;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button3Command;

        public RelayCommand Button3Command
        {
            get { return button3Command; }
            set { button3Command = value; NotifyPropertyChanged("Button3Command"); }
        }

        public void Button_3()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 3;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 3;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button4Command;

        public RelayCommand Button4Command
        {
            get { return button4Command; }
            set { button4Command = value; NotifyPropertyChanged("Button0Command"); }
        }

        public void Button_4()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 0;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 0;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button5Command;

        public RelayCommand Button5Command
        {
            get { return button5Command; }
            set { button5Command = value; NotifyPropertyChanged("Button5Command"); }
        }

        public void Button_5()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 5;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 5;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button6Command;

        public RelayCommand Button6Command
        {
            get { return button6Command; }
            set { button6Command = value; NotifyPropertyChanged("Button0Command"); }
        }

        public void Button_6()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 6;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 6;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button7Command;

        public RelayCommand Button7Command
        {
            get { return button7Command; }
            set { button7Command = value; NotifyPropertyChanged("Button7Command"); }
        }

        public void Button_7()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 7;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 7;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button8Command;

        public RelayCommand Button8Command
        {
            get { return button8Command; }
            set { button8Command = value; NotifyPropertyChanged("Button8Command"); }
        }

        public void Button_8()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 8;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 8;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand button9Command;

        public RelayCommand Button9Command
        {
            get { return button9Command; }
            set { button9Command = value; NotifyPropertyChanged("Button9Command"); }
        }

        public void Button_9()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 * 10) + 9;
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 * 10) + 9;
                _TextView.DisplayText = _Person.Number2.ToString();
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; NotifyPropertyChanged("AddCommand"); }
        }

        public void Add()
        {
                _Person.Operation = "+";
                _TextView.DisplayText = "0";
                // objPerson.Operation = (objPerson.Number1 + objPerson.Number2).ToString();
           
        }

        private RelayCommand subCommand;
        public RelayCommand SubCommand
        {
            get { return subCommand; }
            set { subCommand = value; NotifyPropertyChanged("SubCommand"); }
        }


        public void Sub()
        {
            try
            {
                _Person.Operation = "-";
                _TextView.DisplayText = "0";
                // objPerson.Operation = (objPerson.Number1 - objPerson.Number2).ToString();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private RelayCommand mulCommand;
        public RelayCommand MulCommand
        {
            get { return mulCommand; }
            set { mulCommand = value; NotifyPropertyChanged("MulCommand"); }
        }

        public void Mul()
        { 
           _Person.Operation = "*";
           _TextView.DisplayText = "0";
           // objPerson.Operation = (objPerson.Number1 * objPerson.Number2).ToString();
            
        }


        private RelayCommand divCommand;
        public RelayCommand DivCommand
        {
            get { return divCommand; }
            set { divCommand = value; NotifyPropertyChanged("DivCommand"); }
        }

        public void Div()
        {
           _Person.Operation = "/";
           _TextView.DisplayText = "0";
           // objPerson.Operation = (objPerson.Number1 / objPerson.Number2).ToString();
            
        }


        private RelayCommand equalCommand;

        public RelayCommand EqualCommand
        {
            get { return equalCommand; }
            set { equalCommand = value; NotifyPropertyChanged("EqualCommand"); }
        }

        public void Button_Equal()
        {
            switch (_Person.Operation)
            {
                case "+":
                    _TextView.DisplayText = (_Person.Number1 + _Person.Number2).ToString();
                    break;

                case "-":
                    _TextView.DisplayText = (_Person.Number1 - _Person.Number2).ToString();
                    break;

                case "*":
                    _TextView.DisplayText = (_Person.Number1 * _Person.Number2).ToString();
                    break;

                case "/":
                    _TextView.DisplayText = (_Person.Number1 / _Person.Number2).ToString();
                    break;
            }
        }

        private RelayCommand c_Command;

        public RelayCommand C_Command
        {
            get { return c_Command; }
            set { c_Command = value; NotifyPropertyChanged("C_Command"); }
        }

        public void C_Button()
        {
            _Person.Number1 = 0;
            _Person.Number2 = 0;
            _Person.Operation = "";
            _TextView.DisplayText = "0";
        }

        private RelayCommand ce_Command;

        public RelayCommand CE_Command
        {
            get { return ce_Command; }
            set { ce_Command = value; NotifyPropertyChanged("CE_Command"); }
        }

        public void CE_Button()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = 0;
            }
            else
            {
                _Person.Number2 = 0;
            }

            _TextView.DisplayText = "0";
        }

        private RelayCommand backSpaceCommand;

        public RelayCommand BackSpaceCommand
        {
            get { return backSpaceCommand; }
            set { backSpaceCommand = value; NotifyPropertyChanged("BackSpaceCommand"); }
        }

        public void Backspace_Button()
        {
            if (_Person.Operation == "")
            {
                _Person.Number1 = (_Person.Number1 / 10);
                _TextView.DisplayText = _Person.Number1.ToString();
            }
            else
            {
                _Person.Number2 = (_Person.Number2 / 10);
                _TextView.DisplayText = _Person.Number2.ToString();
            }
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
