using System;

class Program
{
    static void Main(string[] args)
    {
        char option;
        int quantity;
        string unitOfMeasure, productType, description, addMore, unit2;
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
        planner.LoadSettings();
        
        Inventory inventory = new Inventory();
        do{
            Console.WriteLine("1. Do Shopping (Add inventory)");
            Console.WriteLine("2. Let's Plan the week");
            Console.WriteLine("3. Let's Execute the Plan");
            Console.WriteLine("4. Manage Recipes");
            Console.WriteLine("5. Quit");

            option = Console.ReadLine()[0];
            switch(option)
            {
                case '1':
                    do
                    {
                        Console.Write("Description: ");
                        description = Console.ReadLine();
                        Console.Write("Enter qty (by default 1): ");
                        quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter Unit of Measure (by default empty): ");
                        unitOfMeasure = Console.ReadLine();
                        Console.Write("Cost: ");
                        cost = float.Parse(Console.ReadLine());
                        Console.WriteLine("Select product: ");
                        Console.WriteLine("a) FAT");
                        Console.WriteLine("b) CARBOHYDRATES");
                        Console.WriteLine("c) VEGETABLES");
                        Console.WriteLine("d) PROTEINS");
                        productType = Console.ReadLine();
                        switch(productType)
                        {
                            default:
                            ingredient = new Fat(description, unitOfMeasure);
                            break;
                            case "b" or "d":
                            Console.Write("Enter Unit of Measure of inventory (by default empty): ");
                            unit2 = Console.ReadLine();
                            Console.Write("Enter Conversion factor: ");
                            conversion = float.Parse(Console.ReadLine());
                            if (productType == "b")
                                ingredient = new Carbohydrate(description, unitOfMeasure, unit2, conversion);
                            else
                                ingredient = new Protein(description, unitOfMeasure, unit2, conversion);
                            break;
                            case "c":
                            ingredient = new Vegetable(description);
                            break;
                            
                        }
                        if (!inventory.ElementExist(ingredient))
                        {
                            inventory.NewElement(ingredient, quantity, unitOfMeasure, cost);
                        }
                        else
                        {
                            inventory.UpdateElement(ingredient, quantity, unitOfMeasure, cost);
                        }
                        Console.WriteLine("Do you like to add another product? y/n [y]");
                        addMore = Console.ReadLine();
                    }while (addMore != "n");
                break;
                case '2':
                break;
                case '3':
                break;
                case '4':
                break;
                case '5':
                break;
                case '6':
                return;
                
            }
        }while (option!='5');        
    }
}