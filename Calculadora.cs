/*Dentro de este proyecto, crear un nuevo archivo llamado Calculadora.cs y defina un
espacio de nombres al comienzo del archivo (ej. namespace EspacioCalculadora;
en la linea 1 del archivo) . Cree la clase Calculadora que permita encadenar
operaciones sobre un mismo resultado guardado en un atributo llamado dato,
utilizando los siguientes métodos.
● void Sumar(double termino)
● void Restar(double termino)
● void Multiplicar(double termino)
● void Dividir(double termino)
● void Limpiar()
Cree también una propiedad llamada Resultado para obtener el valor del atributo
dato. (Es decir solo defina el get).
Para utilizar esta clase desde Program.cs, no olvide incorporar al mismo el espacio de
nombres definido en el archivo Calculadora.cs, utilizando la palabra reservada using.
Realice una interfaz de usuario para operar la calculadora que permita continuar
solicitando operaciones hasta que el usuario ingrese un comando de escape.
*/

//Con "namespace" creo un contenedor de clases, variables, funciones, etc.
namespace EspacioCalculadora
{

    //Creo una clase llamada "Calculadora"
    public class Calculadora
    {
        //creo un atributo llamado "dato" que solo sera accesible en esta clase por eso lo defino como "private"
        private double dato = 0;

        //Defino los metodos
        public void Sumar(double termino)
        {
            dato = termino + termino;
    
        }
        public void Restar(double termino)
        {
            dato = termino - termino;
        }
        public void Multiplicar(double termino)
        {
            dato = termino * termino;
        }
        public void Dividir(double termino)
        {
            dato = termino / termino;
        }
        public void Limpiar()
        {
            dato = 0;
        }

        //creo una propiedad de nombre "Resultado" donde solo obtengo el valor de dato con "get"
        public double Resultado 
        { 
            get 
            {
                return dato;
            }
        }
    }
}