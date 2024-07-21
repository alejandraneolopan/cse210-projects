class Recipe
{
    string _title;
    string _category;
    int _people;
    List<Ingredient> _ingredients;
    
    public Recipe(string title, string category, int qty)
    {
        _title = title;
        _category = category;
        _people = qty;
        _ingredients = new List<Ingredient>();
        
    }
    public void DisplayRecipe()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Category: {_category}");
        Console.WriteLine($"For {_people} people");
        foreach(Ingredient i in _ingredients)
        {
            i.DisplayIngredientForRecipe();
        }
    }
    public void SetIngredients(List<Ingredient> ingredients)
    {
        _ingredients = ingredients;
    }
    public string GetTitle()
    {
        return _title;
    }
    public List<Ingredient> GetIngredients()
    {
        return _ingredients;
    }
}