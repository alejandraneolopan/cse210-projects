class Inventory
{
    List<Stock> _ingredients;
    public Inventory()
    {
        _ingredients = new List<Stock>();
    }

    public bool ElementExist(Ingredient ingredient)
    {
        foreach(Stock stock in _ingredients)
        {
            if(stock.ElementExist(ingredient))
            {
                return true;
            }

        }
        return false;
    }
    public void NewElement(Ingredient ingredient, int quantity, string unitOfMeasure, decimal cost)
    {
        Stock stock= new Stock(ingredient, quantity, unitOfMeasure, cost);
        _ingredients.Add(stock);
    }
    public void UpdateElement(Ingredient ingredient, int quantity, string unitOfMeasure, decimal cost)
    {
        foreach(Stock stock in _ingredients)
        {
            if(stock.ElementExist(ingredient))
            {
                stock.UpdateElement(quantity, unitOfMeasure, cost);
            }

        }
    }
}