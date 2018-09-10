namespace MadLibs.Models
{
  public class MadLibVariable
  {
    private string _name;
    private string _anotherName;
    private string _animal;
    private string _exclamation;
    private string _noun;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetAnotherName()
    {
      return _anotherName;
    }

    public void SetAnotherName(string anotherName)
    {
      _anotherName = anotherName;
    }

    public string GetAnimal()
    {
      return _animal;
    }

    public void SetAnimal(string animal)
    {
      _animal = animal;
    }

    public string GetExclamation()
    {
      return _exclamation;
    }

    public void SetExclamation(string exclamation)
    {
      _exclamation = exclamation;
    }

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string noun)
    {
      _noun = noun;
    }
  }
}
