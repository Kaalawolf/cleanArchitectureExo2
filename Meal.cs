public class Meal {
    public string type { get; set; }
    double priceAssiette = 15;
    double priceSandwich = 10;

    public Meal(string type) {
        this.type = type;
    }

    public double price() {
        if (type == "assiette") return priceAssiette;
        else if (type == "sandwich") return priceSandwich;
        else Console.WriteLine("Le plat doit être assiette ou sandwich");
    }
}