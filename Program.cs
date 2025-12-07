// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Clase Circulo: representa una figura geométrica circular.
// Encapsula el dato primitivo 'radio' (de tipo double) y 
// proporciona métodos para calcular su área y perímetro.
public class Circulo
{
    // Campo privado que almacena el radio del círculo.
    private double _radio;

    // Constructor de la clase. Recibe el valor del radio y lo valida.
    // Lanza una excepción si el radio es cero o negativo.
    public Circulo(double radio)
    {
        if (radio <= 0)
            throw new ArgumentException("El radio debe ser mayor que cero.");
        _radio = radio;
    }

    // CalcularArea es un método que devuelve un valor de tipo double.
    // Se utiliza para calcular el área de un círculo usando la fórmula: π * radio².
    // No recibe parámetros, porque utiliza el radio almacenado en la instancia.
    public double CalcularArea()
    {
        return Math.PI * _radio * _radio;
    }

    // CalcularPerimetro es un método que devuelve un valor de tipo double.
    // Calcula el perímetro (circunferencia) del círculo con la fórmula: 2 * π * radio.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * _radio;
    }
}


// Clase Cuadrado: representa una figura geométrica con cuatro lados iguales.
// Encapsula el dato primitivo 'lado' (de tipo double) y 
// ofrece métodos para calcular su área y perímetro.
public class Cuadrado
{
    // Campo privado que almacena la longitud del lado del cuadrado.
    private double _lado;

    // Constructor de la clase. Recibe la longitud del lado y la valida.
    // Lanza una excepción si el lado es cero o negativo.
    public Cuadrado(double lado)
    {
        if (lado <= 0)
            throw new ArgumentException("El lado debe ser mayor que cero.");
        _lado = lado;
    }

    // CalcularArea es un método que devuelve un valor de tipo double.
    // Calcula el área del cuadrado usando la fórmula: lado * lado.
    public double CalcularArea()
    {
        return _lado * _lado;
    }

    // CalcularPerimetro es un método que devuelve un valor de tipo double.
    // Calcula el perímetro del cuadrado con la fórmula: 4 * lado.
    public double CalcularPerimetro()
    {
        return 4 * _lado;
    }
}
