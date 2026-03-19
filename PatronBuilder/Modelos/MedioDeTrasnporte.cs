using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder.Modelos
{
    // internal es para que las clases qu hereden de esta pueda acceder 
    // a sus funciones 

    // que las propiedades no deben ser accededidas desde afuera de la clase
    // la unica excepcion es cuando se marcan como static
    public  class MedioDeTrasnporte
    {
        public int NumeroPuertas { get; set; }
        public int numeroDePasajero { get; set; }
        public string tipoMotor { get; set; } // de gasolina y electricos
        public string color { get; set; }
        public string  tipoCarroceria { get; set; }

        // con esta parte el patron nos indica que tenemos 
        // una instrucciones definidas para la construccion 
        // es decir tenemos unos elementos tipo lego que podemos armar

        // print( f({}) -> $"   "

        // cuando dentro de un string queremos dar un salto de linea podemos 
        // utilizar el comando para ello que es \n para indicar que el string
        // saltara a la siguiente linea sin cortar el proceso que muestra
        //en pantalla
        public void Mostrar() {
            Console.WriteLine($"El auto debe tener {tipoCarroceria} tipo de carroceria c" +
                $"El auto debe tener almenos {NumeroPuertas} numeroPuertas \n" +
                $"el auto motor del auto debe ser {tipoMotor} \n" +
                $"El auto debe poder llevar almenos {numeroDePasajero} numeor de pasajeros \n" +
                $"El auto debe ser de color {color}");
        }

    }
}
