using libServices;

namespace appCalculadora
{
    class clsSubMenu:clsMenu
    {
        protected override void Configurar()
        {
            atrItems.Add("*** Titulo del Sub Menu ***");
            atrItems.Add("1. Opcion 1.1");
            atrItems.Add("2. Opcion 1.2");
            atrItems.Add("3. Regresar al menu principal");
        }
        protected override void Procesar()
        {
            switch(atrOpcionElegida)
            {
                case 1: break;
                case 2: break;
                case 3: break;
            }
        }
    }
}