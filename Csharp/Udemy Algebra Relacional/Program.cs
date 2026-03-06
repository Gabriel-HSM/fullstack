//Formalismo que define operações dentro do modelo relacional

//Restrição
//Ex: select * from product inner join categoru cat on product.category_id = cat.id where category.name = 'computers'

//Projeção
//Ex : product.*, category.name from product inner join category cat on product.category_id = cat.id where category.name = 'computers'

//Produto Cartesiano (resultado da combinação, cruzamento literal)
//Ex: Selec * from product,category

//Junção (produto cartesiano + restrição de chaver correspondentes)
//Ex: select * from product inner Join category cat on product.category_id = cat.id
// OU
// Select * from product, category where product.category_id = category.id