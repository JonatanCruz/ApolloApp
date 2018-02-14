using Prism.Ioc;
using Prism.Modularity;
using Mod1.Views;
using Mod1.ViewModels;

namespace Mod1
{
    /*
     * Modulo N. 1
     * Contiene las Siguientes Pantallas
     * 1.- Login Users/Talleres
     * 2.- Registro Users/Talleres
     * 
     * Funciones
     * 1.- Envia correo para verificar cuenta.
     */
    public class Mod1Module : IModule
    {
        public void Initialize() { /* deprecated */ }

        public void OnInitialized()
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
