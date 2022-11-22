
public class MenuItemRepository
{
    private readonly List<MenuItem> _miDb = new List<MenuItem>();
    private int _count;

    public MenuItemRepository()
    {
        SeedData();
    }

    public bool AddMiToDb(MenuItem mi)
    {
        return (mi is null) ? false : AddToDatabase(mi);
    }

    public bool AddToDatabase(MenuItem mi)
    {
        AssignId(mi);
        _miDb.Add(mi);
        return true;
    }

    private void AssignId(MenuItem mi)
    {
        _count++;
        mi.Id = _count;
    }
    public List<MenuItem> GetMenuItems()
    {
        return _miDb;
    }
    public MenuItem GetMenuItem(int id)
    {
        foreach (MenuItem mi in _miDb)
        {
            if (mi.Id == id)
            return mi;
        }
        return null;
    }

    public bool UpdateMenuItemData(int miId, MenuItem updatedData)
    {
        MenuItem miInDb = GetMenuItem(miId);

        if (miInDb != null)
        {
            miInDb.MealName = updatedData.MealName;
            miInDb.MealDescr = updatedData.MealDescr;
            miInDb.MealIngr = updatedData.MealIngr;
            miInDb.Price = updatedData.Price;
            return true;
        }
        return false;
    }

    public bool DeleteMenuItemData(int miId)
    {
        MenuItem miInDb = GetMenuItem(miId);
        return _miDb.Remove(miInDb);
    }

    private void SeedData()
    {
        var miA = new MenuItem("Pepperoni Pizza", "Pizza w/ Pepperoni's", "pizza dough, pizza sauce, pepperoni's, & cheese", 9.99m);
        var miB = new MenuItem("Hot Dog", "Hot dog on a bun", "Hot dog & hot dog bun", 1.49m);
        var miC = new MenuItem("Chicken Sandwich", "Fried chicken patty on bun", "chicken patty & bread", 2.75m);
        var miD = new MenuItem("Cheese Burger", "Hamburger w/ cheese", "Hamburger patty, bread, & cheese", 2.50m);
        
        AddMiToDb(miA);
        AddMiToDb(miB);
        AddMiToDb(miC);
        AddMiToDb(miD);
        
    }
}
