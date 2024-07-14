class Carbohydrate:Ingredient
{
    string _inventoryUOM;
    string _purchaseUOM;
    float _conversionFactor;
    public Carbohydrate(string description, string uom1, string uom2, float factor):base(description)
    {
        _inventoryUOM = uom1;
        _purchaseUOM = uom2;
        _conversionFactor = factor;
        
    }

}