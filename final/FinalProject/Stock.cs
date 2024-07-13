class Stock
{
    Ingredient _ingredient;
    int _availableQty;
    string _uoM;
    decimal _unitCost;
    public Stock(Ingredient ingredient, int quantity, string unitOfMeasure, decimal cost)
    {
        _ingredient =ingredient;
        _availableQty = quantity;
        _uoM = unitOfMeasure;
        _unitCost = cost;
    }
    public bool ElementExist(Ingredient ingredient)
    {
        return true;
    }
    public void UpdateElement(int quantity, string unitOfMeasure, decimal cost)
    {
        
    }
}

