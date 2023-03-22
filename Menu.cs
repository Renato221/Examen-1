namespace Examen_1;

class Menu {

    Casino casino = new Casino();
    public bool mostrar() {

        Console.Clear();
        Console.WriteLine($"Balance: {casino.balance()}");
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("[1] Apostar");
        Console.WriteLine("[2] Ver Info");
        Console.WriteLine("[3] Salir");
        Console.Write("Opcion: ");
        
        switch(Console.ReadLine()){

            case "1":
                menu_apuestas();
                Console.ReadLine();
                return true;
            case "2":
                casino.MostrarInfo();
                Console.ReadLine();
                return true;
            case "3":
                casino.Fin();
                return false;
            default:
                return true;
        }
    }
    public void menu_apuestas() {
        int numero, dinero;
        string? color, tex;
        bool par;
        Console.Clear();
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("[1] Por numero");
        Console.WriteLine("[2] Por Color");
        Console.WriteLine("[3] Par o impar");
        Console.WriteLine("[4] Salir"); 
        Console.Write("Opcion: ");

        switch(Console.ReadLine()){

            case "1":
                Console.Write("Cantidad a apostar: ");
                tex = Console.ReadLine();
                if(tex == null) 
                    break;
                dinero = int.Parse(tex);
                Console.Write("Numero: ");
                tex = Console.ReadLine();
                if(tex == null) 
                    break;
                numero = int.Parse(tex);
                casino.apostar(numero, dinero);
                break;
            case "2":
                Console.Write("Cantidad a apostar: ");
                tex = Console.ReadLine();
                if(tex == null) 
                    break;
                dinero = int.Parse(tex);
                Console.WriteLine("Color: ");
                Console.WriteLine("[1] Rojo");
                Console.WriteLine("[2] Negro");
                
                tex = Console.ReadLine();

                if(tex == "1") {
                    color = "Rojo";
                } else {
                    if(tex == "2") {
                        color = "Negro";
                    } else 
                        break;
                }
                casino.apostar(color, dinero);
                break;
            case "3":
                Console.Write("Cantidad a apostar: ");
                tex = Console.ReadLine();
                if(tex == null) 
                    break;
                dinero = int.Parse(tex);
                Console.WriteLine("Opciones: ");
                Console.WriteLine("[1] Par");
                Console.WriteLine("[2] Impar");
                Console.Write("Opcion: ");
                tex = Console.ReadLine();
                if(tex == "1") {
                    par = true;
                } else {
                    if(tex == "2") {
                        par = false;
                    } else 
                        break;
                }
                casino.apostar(par, dinero);
                break;
            default:
                break;
        }
    }
}