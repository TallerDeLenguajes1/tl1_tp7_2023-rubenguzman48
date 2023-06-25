/*2. Cree los métodos necesarios para poder obtener los datos que se detallan a
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

using System;
using espacioEmpresa;

namespace mainProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-
            //c. Cargue los datos para 3 empleados.
            //Creo un array de objetos de la clase Empleados de nombre empleados
            //pongo Empleado[3] para decir que el array tiene 3 objetos que seran referenciados del 0 al 2
            Empleado[] empleados = new Empleado[3];

            //Creo el empleado 1 con sus datos
            empleados[0] = new Empleado(); //creo un objeto de tipo Empleado en el array empleados
            empleados[0].Apellido = "Guzman";
            empleados[0].Nombre = "Ruben";
            empleados[0].FechaNac = new DateTime(1997, 7, 13);
            empleados[0].EstadCivil = 'C';
            empleados[0].Genero = 'M';
            empleados[0].FechIngre = new DateTime(2021, 8, 2);
            empleados[0].SueldBasic = 202000d;
            empleados[0].Cargo = Cargos.Auxiliar;

            //Creo el empleado 2
            empleados[1] = new Empleado(); //creo un objeto de tipo Empleado en el array empleados
            empleados[1].Apellido = "Romero";
            empleados[1].Nombre = "Antonio";
            empleados[1].FechaNac = new DateTime(1988, 1, 4);
            empleados[1].EstadCivil = 'C';
            empleados[1].Genero = 'M';
            empleados[1].FechIngre = new DateTime(2022, 3, 5);
            empleados[1].SueldBasic = 220000d;
            empleados[1].Cargo = Cargos.Especialista;

            //Creo el empleado 3
            empleados[2] = new Empleado(); //creo un objeto de tipo Empleado en el array empleados
            empleados[2].Apellido = "Nieva";
            empleados[2].Nombre = "Carla";
            empleados[2].FechaNac = new DateTime(1957, 8, 4);
            empleados[2].EstadCivil = 'S';
            empleados[2].Genero = 'F';
            empleados[2].FechIngre = new DateTime(1985, 9, 21);
            empleados[2].SueldBasic = 270000d;
            empleados[2].Cargo = Cargos.Ingeniero;

            //Recorro el arreglo empleados y mando la informacion a la funcion salario()
            //la informacion de cada empleado para devolver el sueldo y sumarlo a montotal
            double montoTotal = 0d;
            foreach (Empleado emp in empleados)
            {
                montoTotal += emp.salario();
            }
            //Imprimo el monto total de salarios pagados
            Console.WriteLine($"MONTO TOTAL A PAGAR EN CONCEPTO DE SALARIOS: {montoTotal.ToString("N0")}\n");
            //Imprimo el sueldo de un empleado en especifico
            Console.WriteLine("Salario empleado 1: $"+empleados[2].salario());
            
            empleados[2].MostrarDatos();


            void proxJubilarse(Empleado[] empleados)
            {
                int proximo = int.MaxValue;
                int j = 0;

                for (int i = 0; i < empleados.Count(); i++)
                {
                    if (empleados[i].FaltaParaJub() <= proximo)
                    {
                        proximo = empleados[i].FaltaParaJub();
                        j = i;
                    }
                }
                empleados[1].MostrarDatos();
            }


        }

    }
}
