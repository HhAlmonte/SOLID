using OpenClosed;

List<CProducto> productos = new List<CProducto>
{
    new CProducto("Coca Cola", 1, 1.5),
    new CProducto("Papas",2, 12.5),
    new CProducto("Tomates", 3, 30)
};

CTienda tienda = new CTienda(productos);
tienda.calcularInventario();