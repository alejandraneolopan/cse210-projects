class Fat:Ingredient
{
    string _uoM;
    public Fat(string description, string unitOfMeasure): base(description)
    {
        _uoM = unitOfMeasure;   
    }
}