using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using PatronBuilder.PlanoDeAuto;

namespace PatronBuilder.mecanco
{
    public  class Mecanico 
    {
        #region
        // si tenenmos una clase que implemene una interfaz 
        // esta clase si la podemos instanciar  y sustituir por otras 
        // clases que lo implementen



        // una inyeccion de dependencias es cuando
        // tomamos un objeto ya creado y lo utilizamos en otra clase
        // esto puede ser mediante app.cs o el cosntructor 
        #endregion

        private IModeloSedan _ImodeloSedan;

        // si tenemos ina implementacion != de una instancia de clase 
        // las interfaz por logica pero las clases que la implementen 
        // pueden ser del tipo de la interfaz
        //cuando una clase implementa la una interfaz la clase puede 
        // ser reconocida desde el espacio de nombre de la funcion
        // ( carateristicas de la interfaz)

        public Mecanico(IModeloSedan imodeloSedan)
        {
            // que desde otra clase van a enviar el representate de la interfaz
            // el representante de la interfaz es quien la implementa

            _ImodeloSedan = imodeloSedan; 
            // => caracteriscasl del modelo ( tipo sedan) 
        }

        public void armarAutomovil() {
            // todas las caracteristicas del modelo 
            _ImodeloSedan.tipoMotor("Gasolina");
            _ImodeloSedan.color("Aranjado fosforo 23");
            _ImodeloSedan.NumeroPuertas(2);
            _ImodeloSedan.numeroDePasajero(2);
            
        }

    }
}          
