// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;

bool exit = false;

List<Product> products = new List<Product>() {

    new Product("101", "телевизор", 30000, 10, Category.Electronic),
    new Product("102", "футболка", 2500, 50, Category.Clothing),
    new Product("103", "яблоки", 100, 100, Category.Food),
    new Product("104", "молоко", 50, 20, Category.Food),
    new Product("105", "ноутбук", 55000, 5, Category.Electronic)

};
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

