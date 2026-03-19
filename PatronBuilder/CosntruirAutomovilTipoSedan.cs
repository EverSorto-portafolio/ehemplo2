using System;
using System.Collections.Generic;
using System.Text;
using PatronBuilder.Modelos;
using PatronBuilder.PlanoDeAuto;

namespace PatronBuilder
{
    // con la interfaz defino y estandarizo las funcines obligatoria 
    // que debe de tener los elementos que forman porte de la caden 
    // de produccion de los atumoviles tipo sedan 

    // los : nos indican herencia si apuntan a una clase 
    // los : nos indica implementacion si apunta a una interfaz
    public class CosntruirAutomovilTipoSedan : IModeloSedan
    {
        // para que no me indique el error se debe implementar los metodos de menera
        // obligatoria 

        // throw new NotImplementedException();  
        // esta excepcion nos indica que si devuelve algo nos tiera una abvertencia 
        // en lugar de romper el codigo
        public void color(string color)
        {
            throw new NotImplementedException();
        }

        public MedioDeTrasnporte mediodeTransporte()
        {
            throw new NotImplementedException();
        }

        public void numeroDePasajero(int NumeroPasajeros)
        {
            throw new NotImplementedException();
        }

        public void NumeroPuertas(int numeroPuertas)
        {
            throw new NotImplementedException();
        }

        public void tipoMotor(string tipoDeMotor)
        {
            throw new NotImplementedException();
        }
    }
    }

// por que no se puede definir una sobre carga de metodos en este caso 
// no sepuede sobrecargar las interfaz de manera directa para utilizar estalogica 
// de recomienda utilizar las clases y metodos abstractos bajo el indicador en 
// la clase padre virtual 