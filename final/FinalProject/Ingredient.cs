abstract class Ingredient
{
    protected float _quantity;
    protected string _description;
    public Ingredient(float qty, string description)
    {
        _quantity = qty;
        _description = description;

    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract void DisplayIngredientForRecipe();
    public abstract void DisplayIngredientForInventory();
    public float GetQtyComitted()
    {
        return _quantity;
    }
    public void SetNewQty(float _qty)
    {
        _quantity =  _qty;
    }

}