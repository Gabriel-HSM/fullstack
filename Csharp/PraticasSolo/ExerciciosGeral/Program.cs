using ExerciciosGeral;

//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - EX 1 PRODUCT - - - - - - - - - - - - - - - -

Product product1 = new Product(1, "Hemmer", 100.00);
Product product2 = new Product(2, "Nails", 1.00);
Product product3 = new Product(3, "Wire", 3.00);

ProductCatalog catalog = new ProductCatalog();
catalog.AddProduct(product1);
catalog.AddProduct(product2);
catalog.AddProduct(product3);

catalog.ShowCatalog();

//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
