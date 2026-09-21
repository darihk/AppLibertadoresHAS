using AppLibertadoresHAS.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppLibertadoresHAS.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;
        public ICommand AutenticarCommand { get; set; }

        #region AtributosPropriedades

        private string login = string.Empty;
        public string Login 
        { 
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        private string senha = string.Empty;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                OnPropertyChanged();

            }
        }
        #endregion

        public async Task AutenticarUsuario()
        {
            try
            {

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + "Detalhes; " + ex.InnerException, "Ok");
            }
        }
    }
}