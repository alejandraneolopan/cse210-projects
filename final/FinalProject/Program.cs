using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        char option;
        int quantity, option2, people;
        string unitOfMeasure, productType, description, addMore, unit2, title, meal1;
        float cost, conversion;
        Ingredient ingredient;
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("__   __");
        Console.WriteLine("|    |    ___  , __   ,   .");
        Console.WriteLine("|\\  /|  .'   ` |'  `. |   |");
        Console.WriteLine("| \\/ |  |----' |    | |   |");
        Console.WriteLine("/    /  `.___, /    | `._/|");
        Console.WriteLine("");                            
        Console.WriteLine(".___   .");
        Console.WriteLine("/   \\  |     ___  , __   , __     ___  .___");
        Console.WriteLine("|,_ -' |    /   ` |'  `. |'  `. .'   ` /   \\");
        Console.WriteLine("|      |   |    | |    | |    | |----' |   '");
        Console.WriteLine("/     /\\__ `.__/| /    | /    | `.___, /    ");
        Console.WriteLine("");
        MenuPlanner planner = new MenuPlanner();
        Settings settings = new Settings();
        List<Recipe> recipes = settings.GetRecipes();
        Inventory inventory = new Inventory();
        inventory = settings.GetInventory();
        List<Ingredient> ingredients;
        Recipe recipe;
        
        do{
            Console.WriteLine("1. Manage inventory");
            Console.WriteLine("2. Manage Recipes");
            Console.WriteLine("3. Let's Plan the week");
            Console.WriteLine("4. Look at the Plan");
            Console.WriteLine("5. Quit");

            option = Console.ReadLine()[0];
            switch(option)
            {
                case '1':
                do
                {
                    Console.WriteLine("Inventory of ingredientes:");
                    Console.WriteLine("1) List of ingredients");
                    Console.WriteLine("2) Adding recently bought ingredients");
                    Console.WriteLine("3) Back to menu");
                    option2 = int.Parse(Console.ReadLine());
                    switch(option2)
                    {
                        case 1:
                        inventory.ListItems();   
                        break;
                        case 2:
                        do
                        {
                            Console.Write("Enter qty: ");
                            quantity = int.Parse(Console.ReadLine());
                            Console.Write("Enter Unit of Measure you bought");
                            unitOfMeasure = Console.ReadLine();
                            Console.Write("Description: ");
                            description = Console.ReadLine();
                            Console.Write("Cost: ");
                            cost = int.Parse(Console.ReadLine());
                            Console.WriteLine("Select product: ");
                            Console.WriteLine("a) CARBOHYDRATES");
                            Console.WriteLine("b) VEGETABLES");
                            Console.WriteLine("c) PROTEINS");
                            productType = Console.ReadLine();
                            switch(productType)
                            {
                                case "a":
                                ingredient = new Carbohydrate(1, description, unitOfMeasure);
                                break;
                                case "c":
                                Console.Write("Enter Unit of Measure of inventory (by default empty): ");
                                unit2 = Console.ReadLine();
                                Console.Write("Enter Conversion factor: ");
                                conversion = float.Parse(Console.ReadLine());
                                ingredient = new Protein(1, description, unitOfMeasure, unit2, conversion);
                                break;
                                default:
                                ingredient = new Vegetable(1, description);
                                break;
                                
                            }
                            if (!inventory.ElementExist(ingredient))
                            {
                                inventory.NewElement(ingredient, cost);
                            }
                            else
                            {
                                inventory.UpdateElement(ingredient, quantity, unitOfMeasure, cost);
                            }
                            Console.WriteLine("Do you like to add another product? y/n [y]");
                            addMore = Console.ReadLine();
                        }while (addMore != "n");
                        break;
                    }
                }while (option2 != 3);
                break;

                case '2':
                do
                {
                    Console.WriteLine("Recipes:");
                    Console.WriteLine("1) List of recipes");
                    Console.WriteLine("2) Add a new recipe");
                    Console.WriteLine("3) Back to menu");
                    option2 = int.Parse(Console.ReadLine());
                    switch(option2)
                    {
                        case 1:
                        foreach(Recipe r in recipes)
                        {
                            r.DisplayRecipe();
                        }
                        break;
                        case 2:
                        do
                        {
                            Console.Write("Title: ");
                            title = Console.ReadLine();
                            Console.Write("For x people: ");
                            people = int.Parse(Console.ReadLine());
                            Console.WriteLine("Select category: ");
                            Console.WriteLine("SOUP");
                            Console.WriteLine("DISH");
                            Console.WriteLine("DESERT");
                            productType = Console.ReadLine();
                            ingredients = new List<Ingredient>();
                            do
                            {
                                Console.WriteLine("What do we require to prepare this recipe:");
                                Console.Write("Enter qty: ");
                                quantity = int.Parse(Console.ReadLine());
                                Console.Write("Enter Unit of Measure");
                                unitOfMeasure = Console.ReadLine();
                                Console.Write("Description: ");
                                description = Console.ReadLine();
                                Console.WriteLine("Select product: ");
                                Console.WriteLine("a) CARBOHYDRATES");
                                Console.WriteLine("b) VEGETABLES");
                                Console.WriteLine("c) PROTEINS");
                                productType = Console.ReadLine();
                                switch(productType)
                                {
                                    case "a":
                                    ingredient = new Carbohydrate(1, description, unitOfMeasure);
                                    break;
                                    case "c":
                                    Console.Write("Enter Unit of Measure of inventory (by default empty): ");
                                    unit2 = Console.ReadLine();
                                    Console.Write("Enter Conversion factor: ");
                                    conversion = float.Parse(Console.ReadLine());
                                    ingredient = new Protein(1, description, unitOfMeasure, unit2, conversion);
                                    break;
                                    default:
                                    ingredient = new Vegetable(1, description);
                                    break;
                                    
                                }
                                ingredients.Add(ingredient);
                                Console.WriteLine("Do you like to add another ingredient? y/n [y]");
                                addMore = Console.ReadLine();
                            }while (addMore != "n");
                            recipe = new Recipe(title, productType, people);
                            recipe.SetIngredients(ingredients);
                            recipes.Add(recipe);
                            Console.WriteLine("Do you like to add another recipe? y/n [y]");
                            addMore = Console.ReadLine();
                        }while (addMore != "n");
                        break;
                    }
                }while (option2 != 3);
                break;
                case '3':
                planner.SchedulePlan(recipes);
                break;
                case '4':
                planner.ReviewPlan(inventory);
                break;
            }
        }while (option!='5');        
    }
}