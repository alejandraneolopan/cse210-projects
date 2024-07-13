using System;

class Program
{
    static void Main(string[] args)
    {
        char option;
        int quantity;
        string unitOfMeasure, productType, description;
        decimal cost;
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Menu Planner");
        Console.WriteLine("============");
        MenuPlanner planner = new MenuPlanner();
        planner.LoadSettings();
        List<ProductType> product = planner.GetProductTypes();
        Ingredient ingredient;
        Inventory inventory = new Inventory();
        do{
            Console.WriteLine("1. Do Shopping (Add inventory)");
            Console.WriteLine("2. Let's Plan the week");
            Console.WriteLine("3. Let's Execute the Plan");
            Console.WriteLine("4. Manage Recipes");
            Console.WriteLine("5. Settings");
            Console.WriteLine("6. Quit");

            option = Console.ReadLine()[0];
            switch(option)
            {
                case '1':
                    Console.Write("Description");
                    description = Console.ReadLine();
                    Console.Write("Enter qty (by default 1): ");
                    quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter Unit of Measure (by default empty): ");
                    unitOfMeasure = Console.ReadLine();
                    Console.Write("Cost: ");
                    cost = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Select product: ");
                    foreach(ProductType t in product)
                    {
                        Console.WriteLine(t.GetProductType());
                    }
                    productType = Console.ReadLine();
                    ingredient = new Ingredient(productType, description);
                    if (!inventory.ElementExist(ingredient))
                    {
                        inventory.NewElement(ingredient, quantity, unitOfMeasure, cost);
                    }
                    else
                    {
                        inventory.UpdateElement(ingredient, quantity, unitOfMeasure, cost);
                    }

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
        }while (option!='6');        
    }
}