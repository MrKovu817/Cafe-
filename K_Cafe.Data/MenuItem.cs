
public class MenuItem
{
    public MenuItem()
    {
        
    }
    public MenuItem(string mealName, string mealDescr, string mealIngr, decimal price)
    {
        MealName = mealName;
        MealDescr = mealDescr;
        MealIngr = mealIngr;
        Price = price;
    }
    public int Id { get; set; }
    public string MealName { get; set; }
    public string MealDescr { get; set; }
    public string MealIngr { get; set; }
    public decimal Price { get; set; }
}

