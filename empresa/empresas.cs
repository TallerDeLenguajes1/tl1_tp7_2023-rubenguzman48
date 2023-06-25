/*1. Crear una clase para almacenar la siguiente información: una clase Empleado con
los siguientes atributos:
a. Nombre (string), Apellido (string), Fecha de nacimiento (datetime),
Estado civil (char), Género (char), fecha de ingreso en la empresa
(datetime), sueldo Básico (double), Cargo (cargos)
b. La enumeración cargos con los siguientes elementos: Auxiliar;
Administrativo; Ingeniero; Especialista; Investigador. (investigue enum
en c# para realizar esto)
2. Cree los métodos necesarios para poder obtener los datos que se detallan a
continuación:
a. Calcular lo siguiente:
i. La antigüedad del empleado en la empresa.
ii. La edad del empleado,
iii. La cantidad de años que le falta al empleado para poder
jubilarse (para la mujer la edad es 60 años, para el varón es 65
años).
b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
Adicional. Para ello el Adicional contempla la antigüedad en años, el
cargo y si es casado:
i) 1 % del sueldo básico por cada año de antigüedad hasta los
20 años, a partir de este, el porcentaje se fija en 25%.
ii) Si el cargo es Ingeniero o Especialista, el Adicional se
incrementa en un 50%.
iii) Si es casado al Adicional se le aumenta $15000.
Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
$65000, el Adicional es 65000 * 0.15 = 9750. Si además el cargo
es Ingeniero o Especialista, se incrementa el Adicional en un
50%. Esto es: 9750* 1.50 = 14625. Si a su vez es casado el
Adicional será: 14625+ 15000= 29625
c. Cargue los datos para 3 empleados.
d. Obtener el Monto Total de lo que se paga en concepto de Salarios.
e. Muestre por pantalla los datos del empleado que esté más próximo a
jubilarse (incluyendo los datos del apartado 2.a y el salario
correspondiente.
NOTA: Los puntos a y b deben estar definidos dentro de la clase como propiedades o
métodos según corresponda

*/ 


//--------------------------Inicio Punto 1------------------------------

//Creo un namespace para esta clase
namespace espacioEmpresa
{
    //-------Inciso B-------
    //Crear un enum para hacer una lista de Cargos
    public enum Cargos
    {
        Auxiliar, 
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    //------Inciso A-------
    //Creo una clase empleado
    public class Empleado
    {
        //Creo los atributos indicados en private
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadCivil;
        private char genero;
        private DateTime fechIngre;
        private double sueldBasic;
        private Cargos cargo;

        //Creo atributos en public con set para poder asignar los valores
        public string Nombre {set => nombre = value;}
        public string Apellido {set => apellido = value;}
        public DateTime FechaNac {set => fechaNac = value;}
        public char EstadCivil {set => estadCivil = value;}
        public char Genero {set => genero = value;}
        public DateTime FechIngre {set => fechIngre = value;}
        public double SueldBasic {set => sueldBasic = value;}
        public Cargos Cargo {set => cargo = value;} 


        //--------------------------Fin punto 1------------------------------


        //--------------------------Inicio punto 2---------------------------
        //2. Cree los métodos necesarios para poder obtener los datos que se detallan a continuación:
        //Inciso a: Calcular lo siguiente:

        //i- La antigüedad del empleado en la empresa.
        //Creo un metodo
        public int Antiguedad()
        {
            return ((DateTime.Now.Subtract(fechIngre).Days)/365);
        }

        //ii- La edad del empleado,
        public int Edad()
        {
            return ((DateTime.Now.Subtract(fechaNac).Days)/365);
        }

        //iii- La cantidad de años que le falta al empleado para poder 
        //jubilarse (para la mujer la edad es 60 años, para el varón es 65 años).
        public int FaltaParaJub()
        {
            if (genero == 'M')
            {
                return (65 - Edad());
            }else
            {
                return (60 - Edad());
            }
        }
        //----FIn inciso A-----


        //Inciso B: Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
        //Adicional. Para ello el Adicional contempla la antigüedad en años, el
        //cargo y si es casado:

        public double salario()
        {
            return (sueldBasic + adicional());
        }

        //i) 1 % del sueldo básico por cada año de antigüedad hasta los 20 años, 
        //a partir de este, el porcentaje se fija en 25%. 
        //ii) Si el cargo es Ingeniero o Especialista, el Adicional se incrementa en un 50%.
        //iii) Si es casado al Adicional se le aumenta $15000.

        public double adicional()
        {
            double a = 0d;
            if(Antiguedad() < 20) 
            {
                a = sueldBasic * (Antiguedad() / 100d);
            }else
            {
               a = sueldBasic * (25 /100); 
            }
            if (cargo == Cargos.Ingeniero)
            {
                a = a * 1.5d;
            }
            if (estadCivil == 'C')
            {
                a = a +15000d;
            }

            return a;
        }

        public void imprimirSueldo()
        {
            Console.WriteLine("Este es el salario del empleado 1: $"+salario);
        }

        public void MostrarDatos(){
        Console.WriteLine($"Apellido: {apellido}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Fecha de Nacimiento: {fechaNac.ToShortDateString()}");
        Console.WriteLine($"Edad: {Edad()}");
        Console.WriteLine($"Estado civil: {estadCivil}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Fecha de ingreso a la empresa: {fechIngre.ToShortDateString()}");
        Console.WriteLine($"Sueldo básico: {sueldBasic.ToString("NO")}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Antigüedad: {Antiguedad()}");
        Console.WriteLine($"Cantidad de años faltante para jubilarse: {FaltaParaJub()}");
        Console.WriteLine($"Salario: {salario().ToString("N0")}");
    }


    }

    

}