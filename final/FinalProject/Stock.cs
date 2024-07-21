class Stock
{
    Ingredient _ingredient;
    float _unitCost;
    public Stock(Ingredient ingredient, float cost)
    {
        _ingredient =ingredient;
        _unitCost = cost;
    }
    public bool ElementExist(Ingredient ingredient)
    {
        return true;
    }
    public void UpdateElement(int quantity, string unitOfMeasure, float cost)
    {
        
    }
    public void DisplayItem()
    {
        _ingredient.DisplayIngredientForInventory();
        Console.WriteLine($" {_unitCost}");
    }
    public float GetQtyAvailable()
    {
        return _ingredient.GetQtyComitted();
    }
    public void UpdateElement(float newQty)
    {
        _ingredient.SetNewQty(newQty);
    }
}

