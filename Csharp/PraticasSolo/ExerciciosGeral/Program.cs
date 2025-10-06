﻿using ExerciciosGeral;

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

Order order1 = new Order(1);

order1.AddOrder(new OrderedItem(product1, 3));
order1.AddOrder(new OrderedItem(product2, 10));
order1.AddOrder(new OrderedItem(product3, 20));

Console.WriteLine($"Total do pedido {order1.Id}: {order1.CalcTotal():C}");

//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
