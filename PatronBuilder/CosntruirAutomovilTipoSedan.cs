using System;
using System.Collections.Generic;
using System.Text;
using PatronBuilder.Modelos;
using PatronBuilder.PlanoDeAuto;

namespace PatronBuilder
{
    #region
    // con la interfaz defino y estandarizo las funcines obligatoria 
    // que debe de tener los elementos que forman porte de la caden 
    // de produccion de los atumoviles tipo sedan 

    // los : nos indican herencia si apuntan a una clase 
    // los : nos indica implementacion si apunta a una interfaz
    #endregion
    public class CosntruirAutomovilTipoSedan : IModeloSedan
    {
        #region
        // para que no me indique el error se debe implementar los metodos de menera
        // obligatoria 

        // throw new NotImplementedException();  
        // esta excepcion nos indica que si devuelve algo nos tiera una abvertencia 
        // en lugar de romper el codigo
        #endregion

        // vamos a crear una instancia de la clase de modelo
        // crear la instancia de  clase 
        // pasar la intancia clase por el constructor 

        // las clases tieene que tener un solo trabajo

        private MedioDeTrasnporte _transporte = new();

        // dentro del entorno .net 
        // tipoDeDatato nombreVriable = new tipoDeDatato()
        // que se expandio desde .net 8 que indica que podemos
        // acortar el new tipoDeDatato -> new() 


        public void color(string color)
        {
            // como un caballo de trolla.
            _transporte.color = color;
        }

        public MedioDeTrasnporte mediodeTransporte()
        {
            // este elemento me permite trabajar con la configuracion) 
            return _transporte;
        }

        public void numeroDePasajero(int NumeroPasajeros)
        {
            _transporte.numeroDePasajero = NumeroPasajeros;
        }

        public void NumeroPuertas(int numeroPuertas)
        {
            _transporte.NumeroPuertas = numeroPuertas;
        }

        public void tipoMotor(string tipoDeMotor)
        {
            _transporte.tipoMotor = tipoDeMotor;
        }
    }
}

// por que no se puede definir una sobre carga de metodos en este caso 
// no sepuede sobrecargar las interfaz de manera directa para utilizar estalogica 
// de recomienda utilizar las clases y metodos abstractos bajo el indicador en 
// la clase padre virtual 