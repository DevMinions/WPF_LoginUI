﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class RelayCommond : ICommand
    {

        readonly Func<bool> _canExecute;

        readonly Action _execute;

        public RelayCommond(Action action,Func<bool> canExecute)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) { 
                return true;
            }
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add {
                if(_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove { 
                if(_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }
    }
}
