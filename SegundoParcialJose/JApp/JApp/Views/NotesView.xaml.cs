using JApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesView : ContentPage
    {
        public NotesView()
        {
            InitializeComponent();
        }

        private void BInsertar_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            NotesViewModel.Instance.AddNewNote(dContents.Text);
            StatusMessage.Text = NotesViewModel.Instance.EstadoMensaje;
        }
            
        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allNotes = NotesViewModel.Instance.GetAllNotes();
            listanotas.ItemsSource = allNotes;
            StatusMessage.Text = NotesViewModel.Instance.EstadoMensaje;
        }
    }
}