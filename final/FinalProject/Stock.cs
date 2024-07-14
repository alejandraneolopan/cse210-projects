class Stock
{
    Ingredient _ingredient;
    int _availableQty;
    string _uoM;
    float _unitCost;
    public Stock(Ingredient ingredient, int quantity, string unitOfMeasure, float cost)
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
    public void UpdateElement(int quantity, string unitOfMeasure, float cost)
    {
        
    }
}

