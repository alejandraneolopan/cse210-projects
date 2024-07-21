using System.Globalization;

class MenuPlanner
{
    List<string> _week;
    List<Recipe> _recipes;
    
    public MenuPlanner()
    {
        _week = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
        _recipes = new List<Recipe>();
    }
    public void SchedulePlan(List<Recipe> externalRecipes)
    {
        string meal;
        
        foreach(string day in _week)
        {
            Console.WriteLine($"{day}: ");
            foreach(Recipe rec in externalRecipes)
            {
                Console.WriteLine(rec.GetTitle());
            }
            Console.WriteLine();
            meal = Console.ReadLine();
            Console.WriteLine();
            foreach(Recipe recipe1 in externalRecipes)
            {
                if (recipe1.GetTitle() == meal)
                {
                    _recipes.Add(recipe1);
                }
            }
            
        }
    }
    public void ReviewPlan(Inventory inventory)
    {
        Console.WriteLine("=========================================================================");
        for(int i = 0; i < 7; i++ )
        {
            Console.Write($"{_week[i]}   |");
        }
        Console.WriteLine();
        Console.WriteLine("=========================================================================");
        for(int i = 0; i < 7; i++ )
        {
            Console.Write($"{_recipes[i].GetTitle()}   |");
        }
        Console.WriteLine();
        Console.WriteLine("=========================================================================");
        Console.WriteLine($"You need to buy below ingredients to complete this schedule:");
        MissingIngredients(inventory);
    }
    
    public void MissingIngredients(Inventory inventoryx)
    {
        List<Ingredient> missing =  new List<Ingredient>();
        missing = inventoryx.GetMissingItems(_recipes[0]);
        List<Ingredient> missing2;
        //Look at the inventory
        for(int i = 1; i < 7; i++ )
        {
            missing2 = inventoryx.GetMissingItems(_recipes[i]);
            foreach(Ingredient ingredient2 in missing2)
            {
                missing.Add(ingredient2);
            }
        }
        foreach(Ingredient ingredient3 in missing)
        {
            ingredient3.DisplayIngredientForInventory();
        }
        Console.WriteLine();
    }
                
}