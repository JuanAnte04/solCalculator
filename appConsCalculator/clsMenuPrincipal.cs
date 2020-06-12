using libServices;

namespace appCalculadora
{
    class clsMenuPrincipal : clsMenu
    {
        protected override void Configurar()
        {
            atrItems.Add(" MENU PRINCIPAL");
            atrItems.Add("Operacion Suma para enteros");
            atrItems.Add("Operacion Suma para flotantes");
            atrItems.Add("Operacion Resta para enteros");
            atrItems.Add("Operacion Resta para flotantes");
            atrItems.Add("Operacion Producto para enteros");
            atrItems.Add("Operacion Producto para flotantes");
            atrItems.Add("Operacion Division para enteros");
            atrItems.Add("Operacion Division para flotantes");
            atrItems.Add("Sub Menu");
            atrItems.Add("Salir\n");
        }
        private void evSumar<Tipo>()
        {
            clsConsola.EscribirEncabezado("OPERACION SUMA");
            clsConsola.EscribirLN("\nEl resultado es: " + ((dynamic)clsConsola.Leer<Tipo>("Escribir Sumando 1: ") + (dynamic)clsConsola.Leer<Tipo>("Escribir Sumando 2: ")));
        }
        private void evRestar<Tipo>()
        {
            clsConsola.EscribirEncabezado("OPERACION RESTA");
            clsConsola.EscribirLN("El resultado es: " + ((dynamic)clsConsola.Leer<Tipo>("Escribir Minuendo: ") - (dynamic)clsConsola.Leer<Tipo>("Escribir Sustraendo: ")));
        }
        private void evMultiplicar<Tipo>()
        {
            clsConsola.EscribirEncabezado("OPERACION MULTIPLICACION");
            clsConsola.EscribirLN("El resultado es: " + ((dynamic)clsConsola.Leer<Tipo>("Escribir Factor 1: ") * (dynamic)clsConsola.Leer<Tipo>("Escribir Factor 2: ")));
        }
        private void evDividir<Tipo>()
        {
            clsConsola.EscribirEncabezado("Operacion Division");
            clsConsola.EscribirLN("El resultado es: " + ((dynamic)clsConsola.Leer<Tipo>("Escribir Numerador: ") / (dynamic)clsConsola.Leer<Tipo>("Escribir Denominador: ")));
        }
        protected override void Procesar()
        {
            switch (atrOpcionElegida)
            {
                case 1: evSumar<int>(); break;
                case 2: evSumar<float>(); break;
                case 3: evRestar<int>(); break;
                case 4: evRestar<float>(); break;
                case 5: evMultiplicar<int>(); break;
                case 6: evMultiplicar<float>(); break;
                case 7: evDividir<int>(); break;
                case 8: evDividir<float>(); break;
                case 9: new clsSubMenu(); break;
                case 10: clsConsola.EscribirLN("\nSaliendo de la Calculadora!"); break;
                default: clsConsola.EscribirLN("Opcion no valida!"); break;
            }
        }
    }
}