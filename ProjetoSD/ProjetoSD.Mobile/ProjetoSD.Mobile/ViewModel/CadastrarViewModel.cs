using ProjetoSD.Mobile.BLL;
using ProjetoSD.Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetoSD.Mobile.ViewModel
{
    public class CadastrarViewModel
    {

        private CadastrarBLL CadastrarBLL { get; set; }
        public ICommand CadastrarContaCommand { get; set; }
        public ICommand VoltarLoginCommand { get; set; }

        public List<string> ListarUFs { get { return this.CadastrarBLL.ListarUFs(); } }

        public CadastrarViewModel()
        {
            this.CadastrarBLL = new CadastrarBLL();
            this.CadastrarContaCommand = new Command(() =>
            {
                MessagingCenter.Send<string>("", "CadastrarContaCommand");
            });
            this.VoltarLoginCommand = new Command(() =>
            {
                MessagingCenter.Send<string>("", "GoToLogin");
            });
        }


    }
}
