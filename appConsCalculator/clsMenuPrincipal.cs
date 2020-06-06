using libServices;

namespace appCalculadora
{
    class clsMenuPrincipal : clsMenu
    {
        private void evSumar()
        {
            clsConsola.EscribirEncabezado("Operacion Suma");
            clsConsola.EscribirLN("\nEl resultado es: " + (clsConsola.leerOperando("Escribir Sumando 1: ") + clsConsola.leerOperando("Escribir Sumando 2: ")));
        }
        private void evRestar()
        {
            clsConsola.EscribirEncabezado("Operacion Resta");
            clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Minuendo: ") - clsConsola.leerOperando("Escribir Sustraendo: ")));
        }
        private void evMultiplicar()
        {
            clsConsola.EscribirEncabezado("Operacion Multiplicacion");
            clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Factor 1: ") * clsConsola.leerOperando("Escribir Factor 2: ")));
        }
        private void evDividir()
        {
            clsConsola.EscribirEncabezado("Operacion Division");
            clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Numerador: ") / clsConsola.leerOperando("Escribir Denominador: ")));
        }
        protected override void Configurar()
        {
            atrItems.Add(" MENU PRINCIPAL");
            atrItems.Add("Operacion Suma");
            atrItems.Add("Operacion Resta");
            atrItems.Add("Operacion Producto");
            atrItems.Add("Operacion Division");
            atrItems.Add("Sub Menu");
            atrItems.Add("Salir\n");
        }
        protected override void Procesar()
        {
            switch (atrOpcionElegida)
            {
                case 1: evSumar();  break;
                case 2: evRestar(); break;
                case 3: evMultiplicar(); break;
                case 4: evDividir(); break;
                case 5: new clsSubMenu(); break;
                case 6: clsConsola.EscribirLN("\nSaliendo de la Calculadora!"); break;
                default: clsConsola.EscribirLN("Opcion no valida!"); break;
            }
        }
    }
}