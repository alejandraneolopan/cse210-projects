class Protein:Ingredient
{
    string _inventoryUOM;
    string _purchaseUOM;
    float _conversionFactor;
    public Protein(float qty, string description, string uom1, string uom2, float factor):base(qty, description)
    {
        _inventoryUOM = uom1;
        _purchaseUOM = uom2;
        _conversionFactor = factor;
        
    }
    public Protein(float qty, string uom, string description):base(qty, description)
    {
        _inventoryUOM = "";
        _purchaseUOM = uom;
        _conversionFactor = 0;
        
    }
    public override void DisplayIngredientForRecipe()
    {
        Console.WriteLine($"{_quantity}  {_purchaseUOM}  {_description}");
    }
    public override void DisplayIngredientForInventory()
    {
        float qty = _quantity * _conversionFactor;
        Console.Write($"{qty:F2}  {_inventoryUOM}  {_description}");
    }

} 