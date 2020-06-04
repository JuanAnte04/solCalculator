using libServices;

namespace appCalculadora
{
    class clsMenuPrincipal:clsMenu
    {
        protected override void Configurar()
        {
            atrItems.Add(" *** MENU PRINCIPAL ***");
            atrItems.Add("1. Operacion Suma");
            atrItems.Add("2. Operacion Resta");
            atrItems.Add("3. Operacion Producto");
            atrItems.Add("4. Operacion Division");
            atrItems.Add("5. Sub Menu");
            atrItems.Add("6. Salir\n");
        }
        protected override void Procesar()
        {
            switch (atrOpcionElegida)
            {
                case 1:
                    clsConsola.EscribirEncabezado("Operacion Suma");
                    clsConsola.EscribirLN("\nEl resultado es: " + (clsConsola.leerOperando("Escribir Sumando 1: ") + clsConsola.leerOperando("Escribir Sumando 2: ")));
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;

                case 2:
                    clsConsola.EscribirEncabezado("Operacion Resta");
                    clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Minuendo: ") - clsConsola.leerOperando("Escribir Sustraendo: ")));
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;

                case 3:
                    clsConsola.EscribirEncabezado("Operacion Multiplicacion");
                    clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Factor 1: ") * clsConsola.leerOperando("Escribir Factor 2: ")));
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;

                case 4:
                    clsConsola.EscribirEncabezado("Operacion Division");
                    clsConsola.EscribirLN("El resultado es: " + (clsConsola.leerOperando("Escribir Numerador: ") / clsConsola.leerOperando("Escribir Denominador: ")));
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;

                case 5:
                    new clsSubMenu();
                    break;

                case 6:
                    clsConsola.EscribirLN("\nSaliendo de la Calculadora!");
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;

                default:
                    clsConsola.EscribirLN("Opcion no valida!");
                    clsConsola.Pausa("Presione una tecla para continuar...");
                    break;
            }
        }
    }
}