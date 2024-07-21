class Inventory
{
    List<Stock> _ingredients;
    public Inventory()
    {
        _ingredients = new List<Stock>();
    }
    public Inventory(List<Stock> stocks)
    {
        _ingredients = stocks;
    }
    public void ListItems()
    {
        foreach(Stock s in _ingredients)
        {
            s.DisplayItem();
        }
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
    public void NewElement(Ingredient ingredient, float cost)
    {
        Stock stock= new Stock(ingredient, cost);
        _ingredients.Add(stock);
    }
    public void UpdateElement(Ingredient ingredient, int quantity, string unitOfMeasure, float cost)
    {
        foreach(Stock stock in _ingredients)
        {
            if(stock.ElementExist(ingredient))
            {
                stock.UpdateElement(quantity, unitOfMeasure, cost);
            }

        }
    }
    public void UpdateElement(Ingredient ingredient)
    {
        float newQty;
        foreach(Stock stock in _ingredients)
        {
            if(stock.ElementExist(ingredient))
            {
                newQty = stock.GetQtyAvailable() - ingredient.GetQtyComitted();
                if (newQty > 0)
                {
                    //Update qty
                    stock.UpdateElement(newQty);
                }
                else
                {
                    //delete stock object
                    _ingredients.Remove(stock);
                }
            }

        }

    }
    public void RemoveIngredients(Recipe recipe)
    {
        List<Ingredient> ingredients = recipe.GetIngredients();
        foreach(Ingredient ing in ingredients)
        {
            UpdateElement(ing);
        }
    }
    public List<Ingredient> GetMissingItems(Recipe rec)
    {
        List<Ingredient> items =  new List<Ingredient>();
        float newQty;
        bool flagFound;
        foreach(Ingredient i in rec.GetIngredients())
        {
            flagFound = false;
            foreach(Stock stock in _ingredients)
            {
                if(stock.ElementExist(i))
                {
                    flagFound = true;
                    newQty = stock.GetQtyAvailable() - i.GetQtyComitted();
                    if (newQty < 0)
                    {
                        i.SetNewQty(newQty * -1);
                        items.Add(i);
                    }
                    
                }

            }
            if (!flagFound)
            {
                items.Add(i);  
            }
       
           
        }
        
        return items;
    }
}