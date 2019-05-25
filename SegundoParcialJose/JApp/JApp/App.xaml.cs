using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JApp.Views;
using JApp.ViewModel;

namespace JApp
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();
            NotesViewModel.Inicializador(filename);
            MainPage = new NotesView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
