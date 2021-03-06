﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoSD.Mobile.ViewModel
{
    public class MasterViewModel
    {

        public ICommand CadastrarDoencaCommand { get; set; }
        public ICommand AlterarDadosContaCommand { get; set; }
        public ICommand SairCommand { get; set; }

        public MasterViewModel()
        {
            this.CadastrarDoencaCommand = new Command(() =>
            {
                MessagingCenter.Send<string>("", "CadastrarDoencaCommand");
            });
            this.AlterarDadosContaCommand = new Command(() =>
            {
                MessagingCenter.Send<string>("", "AlterarDadosContaCommand");
            });
            this.SairCommand = new Command(() =>
            {
                MessagingCenter.Send<string>("", "GoToLogin");
            });
        }
    }
}
