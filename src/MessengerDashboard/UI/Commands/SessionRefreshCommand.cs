﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MessengerDashboard.UI.ViewModels;

namespace MessengerDashboard.UI.Commands
{
    public class SessionRefreshCommand : ICommand
    {
        public SessionRefreshCommand(SessionsViewModel viewModel) { }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
        }
    }
}
