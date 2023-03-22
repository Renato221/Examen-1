namespace Examen_1;


class Jugador {

    private int inicial;
    private int balance;

    public Jugador(int inicio) {

        balance = inicial = inicio;
    }
    public Jugador() {
        balance = inicial = 300;
    }
    public bool verfB(int dinero) {

        if(dinero >= 10 && dinero%10 == 0 && dinero <= balance) {
            return true;
        } else {
            Console.WriteLine("Error en la cantidad existente introducida");
            return false;
        }

    }
    public void AgrQuiCant(int cantidad) {

        balance = balance + cantidad;
    }

    public int getBalance() {

        return balance;
    }
    public int getInicial() {
        return inicial;
    }
      
}