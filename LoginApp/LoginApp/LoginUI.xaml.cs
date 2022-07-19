using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (KullaniciAdi.Text == "admin" && Parola.Text == "admin") 
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Kullanıcı adını veya parolayı yanlış girdiniz !!!","Lütfen Tekrar Deneyiniz","");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kaydol());
        }
    }
}