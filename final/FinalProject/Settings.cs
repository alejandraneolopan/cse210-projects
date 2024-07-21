class Settings
{
    string RECIPES_FILE = "Recipes.txt";
    string INVENTORY_FILE = "Inventory.txt";
    public void LoadSettings()
    {
        //Load the file by default to load the main objects
    }
    public void SaveSettings(Inventory inventory, List<Recipe> recipes)
    {
        
    }
    public Inventory GetInventory()
    {
        string[] lines = System.IO.File.ReadAllLines(INVENTORY_FILE);
        string[] parts;
        Inventory inventory;
        Ingredient ingredient;
        Stock stock;
        List<Stock> stocks = new List<Stock>();
        foreach(string line in lines)
        {
            parts = line.Split(",");
            switch(parts[0])
                {
                    case "P":
                    ingredient = new Protein(int.Parse(parts[1]), parts[2], parts[3]);
                    break;
                    case "C":
                    ingredient = new Carbohydrate(int.Parse(parts[1]), parts[2], parts[3]);
                    break;
                    default:
                    ingredient = new Vegetable(int.Parse(parts[1]), parts[2]);
                    break;
                    
                }
                stock = new Stock(ingredient, float.Parse(parts[4]));
                stocks.Add(stock);
        }
        inventory = new Inventory(stocks);
        return inventory;

    }
    public List<Recipe> GetRecipes()
    { 
        string[] parts;
        Recipe recipe;
        List<Recipe> recipes = new List<Recipe>();
        string line;
        string[] lines = System.IO.File.ReadAllLines(RECIPES_FILE);
        Ingredient ingredient;
        List<Ingredient> ingredients = null;
        int i = 0;
        while(i < lines.Length)
        {
            parts = lines[i].Split(",");
            //recipe
            recipe = new Recipe(parts[0], parts[1], int.Parse(parts[2]));
            //ingredients
            i++;
            line = lines[i];
            while (line[0] == '[')
            {
                ingredients = new List<Ingredient>();
                line = line.Substring(1, line.Length - 2);
                parts = line.Split(",");
                switch(parts[0])
                {
                    case "P":
                    ingredient = new Protein(float.Parse(parts[1]), parts[2], parts[3]);
                    break;
                    case "C":
                    ingredient = new Carbohydrate(float.Parse(parts[1]), parts[2], parts[3]);
                    break;
                    default:
                    ingredient = new Vegetable(float.Parse(parts[1]), parts[3]);
                    break;
                    
                }
                ingredients.Add(ingredient);
                i++;
                if (i < lines.Length )
                {
                    line = lines[i];
                }
            }

            if (ingredients is not null)
                recipe.SetIngredients(ingredients);
            recipes.Add(recipe);    
        }
        return recipes;
    }                
}