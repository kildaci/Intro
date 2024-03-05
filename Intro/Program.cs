// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000.5;


bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton--> Hoşgeldin engin");
}
else
{
    Console.WriteLine("Buton--> sisteme giriş yap");
}

      
string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3" , "Kredi 4", "Kredi 5", "kredi 6" };

     //start    condition        //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}




CourseManager courseManager = new (new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndıvıdualCustomer customer1= new IndıvıdualCustomer();
customer1.Id= 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "arife";
customer1.LastName = "Kıldacı";
customer1.CustomerNumber = "123456";

IndıvıdualCustomer customer2 = new IndıvıdualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5674895412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "654799";
customer4.TaxNumber = "12345678985";

int number1 = 10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

BaseCustomer[] customers = {customer1, customer2,customer3, customer4 };


foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);

}
