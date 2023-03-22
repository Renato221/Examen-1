namespace Examen_1;

class Casino {

    public Jugador jugador = new Jugador();
    public List<Ruleta> lista = new List<Ruleta>();
    Ruleta ruleta = new Ruleta();

    public void apostar(int numero, int dinero) {

        if(jugador.verfB(dinero)) {
            ruleta.girar();
            lista.Add(ruleta);

            jugador.AgrQuiCant(dinero*-1);
            ruleta.Info();
            if(ruleta.getNumero() == numero) {

                Console.WriteLine($"Se ha ganado: {dinero*10}");
                jugador.AgrQuiCant(dinero*10);
            } else 
                Console.WriteLine($"Se ha perdido: {dinero}");
           
        }
        
    }

    public void apostar(string color, int dinero) {

        if(jugador.verfB(dinero)) {
            ruleta.girar();
            lista.Add(ruleta);

            jugador.AgrQuiCant(dinero*-1);
            ruleta.Info();
            if(ruleta.getColor() == color) {

                Console.WriteLine($"Se ha ganado: {dinero*5}");
                jugador.AgrQuiCant(dinero*5);
            } else 
                Console.WriteLine($"Se ha perdido: {dinero}");
        }
    }
    public void apostar(bool par, int dinero) {

        if(jugador.verfB(dinero)) {
            ruleta.girar();
            lista.Add(ruleta);

            jugador.AgrQuiCant(dinero*-1);
            ruleta.Info();
            if(ruleta.getPar() == par) {

                Console.WriteLine($"Se ha ganado: {dinero*2}");
                jugador.AgrQuiCant(dinero*2);
            } else 
                Console.WriteLine($"Se ha perdido: {dinero}");
        }
       
    }

    public void MostrarInfo() {
        int rojo = 0, par = 0;
        Console.WriteLine($"Balance: {jugador.getBalance()}");
        Console.WriteLine($"Numero de giros: {lista.Count()}");
        
        foreach(Ruleta a in lista) {
            if(a.getColor() == "Rojo") 
                rojo++;
            if(a.getPar() == true) {
                par++;
            }
        }
        Console.WriteLine($"Rojos: {rojo}");
        Console.WriteLine($"Pares: {par}");

    }
    public int balance() {

        return jugador.getBalance();
    }
    public void Fin() {

        Console.WriteLine($"Balance Actual: {jugador.getBalance()}");
        Console.WriteLine($"Numero de giros: {lista.Count()}");

        if(jugador.getBalance() >= jugador.getInicial()) {

            Console.WriteLine($"Se ha ganado {jugador.getBalance()-jugador.getInicial()}");
        } else {
            Console.WriteLine($"Se ha perdido {jugador.getInicial()-jugador.getBalance()}");
        }
        
        
    }


}