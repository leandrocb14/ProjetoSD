using ProjetoSD.Mobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoSD.Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        public DetailView()
        {
            this.BindingContext = new DetailViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>(this, "CadastrarDoencaCommand", (msg) =>
            {
                MessagingCenter.Send<string>("", "MasterDescollapse");
                Navigation.PushAsync(new CadastrarDoencaView());
            });
            MessagingCenter.Subscribe<string>(this, "AlterarDadosContaCommand", (msg) =>
            {
                MessagingCenter.Send<string>("", "MasterDescollapse");
                Navigation.PushAsync(new AlterarDadosContaView());                
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<string>(this, "SairCommand");
            MessagingCenter.Unsubscribe<string>(this, "CadastrarDoencaCommand");
            MessagingCenter.Unsubscribe<string>(this, "AlterarDadosContaCommand");
            MessagingCenter.Unsubscribe<string>(this, "MasterDescollapse");
        }
    }
}