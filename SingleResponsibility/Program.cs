using SingleResponsibility;

CEmpleado empleado = new CEmpleado("Hector", "Programador", 25, 10000);

Console.WriteLine(empleado);
Console.WriteLine(CHacienda.CalcularImpuesto(empleado));
CHacienda.PagarImpuesto(empleado);