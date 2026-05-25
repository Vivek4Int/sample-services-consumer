using SampleServices;

var customerService = new CustomerService();
var orderService = new OrderService();
var productService = new ProductService();

var customer = customerService.GetCustomer(1);
Console.WriteLine($"Customer: {customer.Id} - {customer.Name} ({customer.Email})");

var order = orderService.GetOrder(1);
Console.WriteLine($"Order: {order.Id} - Customer {order.CustomerId} - Total: {order.Total:C}");

var product = productService.GetProduct(1);
Console.WriteLine($"Product: {product.Id} - {product.Name} - Price: {product.Price:C}");
