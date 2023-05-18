using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySqlConnector;

namespace DocShifting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        private void FrogotPasswordButton_Clicked() 
        { 
        
        }
        private void LogInButton_Clicked(object sender, EventArgs e)
        {
            var wabao = new MySqlConnection();

            var cmd = new MySqlCommand("");
            var rd = cmd.ExecuteReader();

            if (rd.Read()) 
            {
                DisplayAlert("", "", "");
            }
            else 
            {
                DisplayAlert("糟糕", "帳戶或密碼錯誤", "重新輸入");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}