namespace Examen_1;

class Ruleta {

    private int numero;
    private bool par;
    private string? color;

    public void girar() {
        
        Random rnd = new Random();
        
        numero = rnd.Next(37);

        if((numero % 2) == 0) {

            par = true;
            color = "Negro";
        } else {
            if(numero != 0) {

                par = false;
                color = "Rojo";
            } else {
                color = "";
            }
        }
    }
    public void Info() {

        Console.WriteLine($"Numero: {numero} Color: {color}");

    }
    public int getNumero() {

        return numero;
    }
    public string getColor() {

        color = (color==null)?"":color;
        return color;
    }
    public bool getPar() {

        return par;
    } 
}