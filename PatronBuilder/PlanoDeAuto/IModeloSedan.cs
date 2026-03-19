using System;
using System.Collections.Generic;
using System.Text;
using PatronBuilder.Modelos;

namespace PatronBuilder.PlanoDeAuto
{
    public interface IModeloSedan
    {
        #region
        // este elemento vamos visualizar como un conjunto de normar
        // que las calses deben cumplir para poder utilizar el modelo 
        // es como si definieramos un portero que inidca que clase puede
        // hacer get y set


        // las clases utilizan propiedades y metodos 
        // las interfaces es que utilicen metodos abstractos 
        // que es un metodo abstracto ? 
        // un metodo abstracto es la capacidad de encapsular los funciones 
        // dentro de un elemento que define con el nombre de la funcion que 
        // se debe de realizar pero no como lo debe de realizar.

        // los metods abstratos son elementos que no con tiene logica en su 
        // interior 
        #endregion

        // nos intereza armar el modelo -> ing mecanico simbre dara los planos

        MedioDeTrasnporte mediodeTransporte();
        // el tipo de dato que regresa -> nombre -> () que este elemento es una funcion
        // es una variable que tene sub dominio donde se ejecuta codigo. 
        // ; indica al procesado que finaliza la instruccion y puede dar un salto de linea

        void NumeroPuertas();
        // como no va a devolver algo no tiene un return 
        // lo definimos como void 

        void numeroDePasajero();
        void tipoMotor();
        void color();
    }
}

//  dentro de esta interfaz 
//  una clase va implementar la interfaz  clase : interfaz
// debe tener todos estos metodos anteriores 
//void tipoCarroceria() {
// modelo. la funcion = argumento
//}