// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;

List<Product> products = new List<Product>() {

    new Product("101", "телевизор", 30000, 10, Category.Electronic),
    new Product("102", "футболка", 2500, 50, Category.Clothing),
    new Product("103", "яблоки", 100, 100, Category.Food),
    new Product("104", "молоко", 50, 20, Category.Food),
    new Product("105", "ноутбук", 55000, 5, Category.Electronic)

};


bool exit = false;

while (!exit)
{
    Console.WriteLine("\nВыберите команду:");
    Console.WriteLine("1. Добавить товар");
    Console.WriteLine("2. Удалить товар");
    Console.WriteLine("3. Заказать поставку товара");
    Console.WriteLine("4. Продать товар");
    Console.WriteLine("5. Поиск товара по коду, названию и категории");
    Console.WriteLine("6. Выход");
    Console.Write("Введите номер команды: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddProduct();
            break;
        case "2":
            RemoveProduct();
            break;
        case "3":
            OrderProduct();
            break;
        case "4":
            SellProduct();
            break;
        case "5":
            FindProduct();
            break;
        case "6":
            exit = true;
            break;
        default:
            Console.WriteLine("Некорректный ввод. Введите снова.");
            break;
    }
}
public enum Category
{
    Electronic,
    Clothing,
    Food,

}
class Product
{



    public string code { get; private set; } // код товара
    public string name { get; set; }       //get получает значение свойства 
    public decimal price { get; set; }    //set записывает значение свойства
    public int quantity { get; set; }
    public bool IsAvailable => quantity > 0; // есть ли остаток
    public Category ProductCategory;



    public Product(string code, string name, decimal price, int quantity, Category category)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Код не может быть пустым");
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название не может быть пустым");
        if (price < 0)
            throw new ArgumentException("Цена не может быть отрицательной");
        if (quantity < 0)
            throw new ArgumentException("Количество не может быть отрицательным");
        code = code;
        name = name;
        price = price;
        quantity = quantity;
        ProductCategory = category;
    }
}

