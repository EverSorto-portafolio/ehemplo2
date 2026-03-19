// voy a llamar a la intefaz y a su representate

using PatronBuilder;
using PatronBuilder.mecanco;
using PatronBuilder.Modelos;
using PatronBuilder.PlanoDeAuto;


IModeloSedan sedan = new CosntruirAutomovilTipoSedan();
// este pais envia a -> este representate

Mecanico mecanico = new(sedan); // dentro de la interfaz enviamos el modelo 
mecanico.armarAutomovil();
MedioDeTrasnporte autosedan= sedan.mediodeTransporte();
autosedan.Mostrar();
