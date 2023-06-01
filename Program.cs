using EspacioCalculadora;

internal class Program {
  private static void Main(string[] args) {
    Calculadora calculadora = new Calculadora(0);
    double decision = MostrarMenuYPedirOpcion(0, false);

    if (decision == 6) return;

    double numeroInput = PedirNumeroInput();

    while (decision != 6) {
      switch(decision) {
        case 1:
          calculadora.Sumar(numeroInput);
          break;
        case 2:
          calculadora.Restar(numeroInput);
          break;
        case 3:
          calculadora.Multiplicar(numeroInput);
          break;
        case 4:
          if (numeroInput != 0) {
            calculadora.Dividir(numeroInput);
          } else {
            Console.WriteLine("x No se dividir por 0");
          }
          break;
        case 5:
          calculadora.Limpiar();
          break;
      }

      // Solo mostrar resultado y pedir numero si la opción elegida es una
      // operación aritmetica.
      if (DeberiaPedirNumeroInputOMostrarResultado(decision)) {
        Console.WriteLine("Resultado: " + calculadora.Resultado);
      
        decision = MostrarMenuYPedirOpcion(calculadora.Resultado, false);

        if (DeberiaPedirNumeroInputOMostrarResultado(decision)) {
          numeroInput = PedirNumeroInput();
        }
      }
    }
  }

  static Boolean DeberiaPedirNumeroInputOMostrarResultado(double decision) {
    return decision >= 1 && decision <= 4;
  }

  static double MostrarMenuYPedirOpcion(double numero, Boolean volverAPedir) {
    Console.WriteLine("\n");

    if (!volverAPedir) {
      Console.WriteLine("Ingrese una opción para operar con el numero " + numero + ":");  
    } else {
      Console.WriteLine("Opción invalida, ingrese una opción para operar con el numero " + numero + ":");
    }
    
    Console.WriteLine(" 1- Sumar");
    Console.WriteLine(" 2- Restar");
    Console.WriteLine(" 3- Multiplicar");
    Console.WriteLine(" 4- Dividir");
    Console.WriteLine(" 5- Limpiar (setear valor inicial en 0)");
    Console.WriteLine(" 6- Salir");

    double decision;
    if (double.TryParse(Console.ReadLine(), out decision)) {
      if (decision < 1 || decision > 6) {
        return MostrarMenuYPedirOpcion(numero, true);
      }
      return decision;
    } else {
      return MostrarMenuYPedirOpcion(numero, true);
    }
  }

  static double PedirNumeroInput() {
    double numeroInput;

    Console.WriteLine("Ingrese un numero:");
    if (double.TryParse(Console.ReadLine(), out numeroInput)) {
      return numeroInput;
    } else {
      Console.WriteLine("x Input invalido, por favor ingreso un numero valido:");
      return PedirNumeroInput();
    }
  }
}