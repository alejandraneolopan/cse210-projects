using System.Net.Quic;

class Vegetable:Ingredient
{
    public Vegetable(float qty, string description):base(qty, description)
    {
        
    }
    public override void DisplayIngredientForRecipe()
    {
        Console.WriteLine($"{_quantity}  {_description}");
    }
    public override void DisplayIngredientForInventory()
    {
        Console.Write($"{_quantity}  {_description}");
    }
}