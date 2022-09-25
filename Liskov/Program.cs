using Liskov;

// Primera prueba de Liskov

Noticiero noticiero = new Noticiero("El presidente habla (noticiero)");
noticiero.Mostrar();

Radio radio = new Radio("El presidente habla (radio)");
radio.Mostrar();

Console.WriteLine("-------------------");

// Segunda prueba de Liskov
// No existe un error de compilación, pero no se cumple el principio de sustitución de Liskov
// Es un problema de diseño

Noticiero noticiero2 = new Radio("Hola radio desde un noticiero (noticiero-radio)");
noticiero2.Mostrar();