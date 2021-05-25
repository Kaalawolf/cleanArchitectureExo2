public class Beverage {
    public string size { get; set; }
    double priceSmall = 2;
    double priceMedium = 3;
    double priceLarge = 4;

    public Beverage(string size) {
        this.size = size;
    }

    public double price() {
        if (size == "small") return priceSmall;
        else if (size == "medium") return priceMedium;
        else if (size == "large") return priceLarge;
        else Console.WriteLine("La boisson doit être small, medium ou large");
    }

}