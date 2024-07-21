class Carbohydrate:Ingredient
{
    string _uOM;

    public Carbohydrate(float qty, string description, string uom):base(qty, description)
    {
        _uOM = uom;
        
    }

    public override void DisplayIngredientForRecipe()
    {
        Console.WriteLine($"{_quantity}  {_uOM}  {_description}");
    }
    public override void DisplayIngredientForInventory()
    {
        Console.Write($"{_quantity}  {_uOM}  {_description}");
    }

}