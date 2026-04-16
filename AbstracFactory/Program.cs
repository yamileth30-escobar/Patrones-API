using AbstracMethod;
using AbstracMethod.Factory;

VehiculoFactory transporte;

//  llega un pedido para repartir en san salvador 

transporte = new MotoFactory();
transporte.selecionar();
Console.WriteLine
    ("se define el tipo como" + transporte.GetType());

// quiero que me lleve esta caja pesada al la monta;a 

transporte = new CarroFactory();
transporte.selecionar();
Console.WriteLine
    ("se define el tipo como" + transporte.GetType());

//Camion --> para mudarse
transporte = new CamionFactory();
transporte.selecionar();
Console.WriteLine
    ("se define el tipo como" + transporte.GetType());

//avion --> para viajes largos
transporte = new AvionFactory();
transporte.selecionar();
Console.WriteLine
    ("se define el tipo como" + transporte.GetType());

//una captura de que este funcionando el programa