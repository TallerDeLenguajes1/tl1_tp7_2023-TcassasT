namespace EspacioEmpleado;

public enum Cargo {
  AUXILIAR,
  ADMINISTRATIVO,
  INGENIERO,
  ESPECIALISTA,
  INVESTIGADOR,
}

public class Empleado {
  private string nombre { get; }
  private string apellido { get; }
  private DateTime fechaDeNacimiento { get; }
  private char estadoCivil { get; }
  private char genero { get; }
  private DateTime fechaDeIngreso { get; }
  private double sueldoBasico { get; }
  private Cargo cargo { get; }

  public Empleado(
    string nombre,
    string apellido,
    DateTime nacimiento,
    char estadoCivil,
    char genero,
    DateTime fechaDeIngreso,
    double sueldoBasico,
    Cargo cargo
  ) {
    this.nombre = nombre;
    this.apellido = apellido;
    this.fechaDeNacimiento = nacimiento;
    this.estadoCivil = estadoCivil;
    this.genero = genero;
    this.fechaDeIngreso = fechaDeIngreso;
    this.sueldoBasico = sueldoBasico;
    this.cargo = cargo;
  }

  public int getAntiguedad() {
    DateTime hoy = new DateTime();
    return hoy.Year - this.fechaDeIngreso.Year;
  }

  public int getEdad() {
    DateTime hoy = new DateTime();
    return hoy.Year - this.fechaDeNacimiento.Year;
  }

  public int getCuantoFaltaParaJubilarse() {
    if (this.genero == 'M') {
      return 65 - this.getAntiguedad();
    }

    return 60 - this.getAntiguedad();
  }
}