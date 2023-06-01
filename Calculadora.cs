namespace EspacioCalculadora;

public class Calculadora {
  private double dato;

  public double Resultado { get => this.dato; }

  public Calculadora(double dato) {
    this.dato = dato;
  }

  public void Sumar(double temrino) {
    this.dato += temrino;
  }

  public void Restar(double termino) {
    this.dato -= termino;
  }

  public void Multiplicar(double termino) {
    this.dato *= termino;
  }

  public void Dividir(double termino) {
    this.dato /= termino;
  }

  public void Limpiar() {
    this.dato = 0;
  }
}
