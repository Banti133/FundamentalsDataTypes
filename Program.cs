// See https://aka.ms/new-console-template for more information
using FundamentalsDataTypes;

Console.WriteLine("Hello, World!");

//code for multilevel inheritance

ConsultingEmployee consultingEmployee = new ConsultingEmployee();
Console.WriteLine("Please enter your ID:");
consultingEmployee.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Employee ID:");
consultingEmployee.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Name:");
consultingEmployee.Name = Console.ReadLine();
Console.WriteLine("Please enter your City:");
consultingEmployee.City = Console.ReadLine();
Console.WriteLine("Please enter your Age:");
consultingEmployee.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Role:");
consultingEmployee.Role = Console.ReadLine();
Console.WriteLine("Please enter your Email:");
consultingEmployee.Email = Console.ReadLine();
Console.WriteLine("Please enter your Salary:");
consultingEmployee.Salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter your Consulting Firm:");
consultingEmployee.ConsultingFirm = Console.ReadLine();
Console.WriteLine("Please enter your Contract Duration (in months):");
consultingEmployee.ContractDuration = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Personal Info: {consultingEmployee.GetPersonInfo()}");

Console.WriteLine($"Employee Info: {consultingEmployee.EmployeeId}, Role: {consultingEmployee.Role}, Email: {consultingEmployee.Email}, Salary: {consultingEmployee.Salary:C}"); // :C formats as currency
Console.WriteLine($"Consulting Firm: {consultingEmployee.ConsultingFirm}, Contract Duration: {consultingEmployee.ContractDuration} months");


//code for single level inheritance

//Inheritance employee = new Inheritance();
//Console.WriteLine("Please enter your ID:");
//employee.Id = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter your Employee ID:");
//employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter your Name:");
//employee.Name = Console.ReadLine();
//Console.WriteLine("Please enter your City:");
//employee.City = Console.ReadLine();
//Console.WriteLine("Please enter your Age:");
//employee.Age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter your Role:");
//employee.Role = Console.ReadLine();
//Console.WriteLine("Please enter your Email:");
//employee.Email = Console.ReadLine();
//Console.WriteLine("Please enter your Salary:");
//employee.Salary = Convert.ToDouble(Console.ReadLine());
//employee.DisplayPersonDetails();
//Console.WriteLine($"Personal Info: {employee.GetPersonInfo()}");
//Console.WriteLine($"Employee Info: {employee.EmployeeId}, Role: {employee.Role}, Email: {employee.Email}, Salary: ${employee.Salary}");    






//value type data ranges
//Console.WriteLine(int.MinValue+ " " + int.MaxValue);
//Console.WriteLine(long.MinValue + " " + long.MaxValue);
//Console.WriteLine(float.MinValue + " " + float.MaxValue);
//Console.WriteLine(double.MinValue + " " + double.MaxValue);
//Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
//Console.WriteLine(bool.FalseString+ " " + bool.TrueString);

//person();
static void person()
{
       //just assign values using auto implemented properties
    PersonDetails person = new PersonDetails
    {
        Name = "John",
        Id = 123456,
        Age = 30,
        City = "123 Main St"
    };
    Console.WriteLine($"Full Name: {person.Name}");
    Console.WriteLine($"Age: {person.Age}");
    person.DisplayPersonDetails();
}

//prodt();
static void prodt()
{
    //just assign values using auto implemented properties
    autoimplementedprop product = new autoimplementedprop
    {
        ProductName = "Laptop",  //in auto implemented we just directly assign values to it
        ProductPrice = 1500.00,
        ProductQuantity = 10
    };
    Console.WriteLine($"Product Name: {product.ProductName}");
    Console.WriteLine($"Product Price: {product.ProductPrice}");
    Console.WriteLine($"Product Quantity: {product.ProductQuantity}");
    Console.WriteLine($"Total Price: ${product.CalculateTotalPrice()}");
    Console.WriteLine($"Price after discount: ${product.ApplyDiscount(10)}");
    product.DisplayProductDetails();
    Console.WriteLine($"New quantity after restock: {product.ProductQuantity}");
   
    product.CheckInventory();
}

//Prod();
static void Prod()
{
    //just using the private properties
    Console.WriteLine("Enter product name:");
    string name=Console.ReadLine();
    Console.WriteLine("Enter product price:");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter product quantity:");
    int quantity = Convert.ToInt32(Console.ReadLine());
    ProductClass product = new ProductClass(name, price, quantity);
    //Console.WriteLine($"Product Name: {product.ProductName}");
    //Console.WriteLine($"Product Price: {product.ProductPrice}");
    //Console.WriteLine($"Product Quantity: {product.ProductQuantity}");
    Console.WriteLine($"Total Price: ${product.CalculateTotalPrice()}");
    Console.WriteLine($"Price after discount: ${product.ApplyDiscount(10)}");
    //product.DisplayProductDetails();
    Console.WriteLine("Enter quantity to restock:");
    int restockquantity= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Restocking with quantity: {restockquantity}");
    if (restockquantity < 0)
    {
        Console.WriteLine("Cannot restock with a negative quantity.");
    }
    else
    {
        product.Restock(restockquantity);
    }
    product.CheckInventory();
}
