namespace Examen_1;
class Program
{
    static void Main(string[] args) {
        
        Menu menu = new Menu();

        bool MostrarMenu = true;

        while(MostrarMenu){
            MostrarMenu = menu.mostrar();
        }

    }
}
