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

static void AddProduct()
{
    try
    {
        Console.Write("Введите название товара: ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Вы ввели пустое поле!");
            return;
        }

        Console.Write("Введите цену товара: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
        {
            Console.WriteLine("Некорректная цена!");
            return;
        }

        Console.Write("Введите количество товара: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
        {
            Console.WriteLine("Некорректное количество!");
            return;
        }

        Console.WriteLine("Выберите категорию:");
        Console.WriteLine("1. Electronics");
        Console.WriteLine("2. Clothing");
        Console.WriteLine("3. Food");
        Console.Write("Введите номер категории: ");
        string catInput = Console.ReadLine();

        Category category;
        switch (catInput)
        {
            case "1":
                category = Category.Electronic;
                break;
            case "2":
                category = Category.Clothing;
                break;
            case "3":
                category = Category.Food;
                break;
            default:
                Console.WriteLine("Некорректная категория");
                return;
        }

        Product newProduct = new Product(name, price, quantity, category);
        products.Add(newProduct);
        Console.WriteLine($"Товар добавлен: {newProduct.code} - {newProduct.name}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}
static void RemoveProduct()
{
    Console.Write("Введите код товара для удаления: ");
    string code = Console.ReadLine();

    Product productToRemove = products.Find(p => p.code == code);
    if (productToRemove != null)
    {
        products.Remove(productToRemove);
        Console.WriteLine($"Товар {code} успешно удален.");
    }
    else
    {
        Console.WriteLine("Товар с таким кодом не найден.");
    }
}

static void OrderProduct();
{
    Console.WriteLine("Введите код для заказа товара");
    string code = Console.ReadLine();

    Product productToOrder = 
}

static void SellProduct();

static void FindProduct();

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

