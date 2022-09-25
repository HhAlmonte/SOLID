using OpenClosedRefactor;

List<CBaseInventario> productos = new List<CBaseInventario>
{
    new CInventarioAlimento(new CProducto("Papas", 1, 12.5)),
    new CInventarioAlimento(new CProducto("Refresco", 2, 12.5)),
    new CInventarioAlimento(new CProducto("Papas", 3, 12.5)),
    new CInventarioMedicamento(new CProducto("Paracetamol", 4, 12.5)),
    new CInventarioMedicamento(new CProducto("Analgesico", 4, 12.5)),
    new CInventarioMedicamento(new CProducto("Acetaminofen", 4, 12.5)),
};

CTienda tienda = new CTienda(productos);
tienda.calcularInventario();
