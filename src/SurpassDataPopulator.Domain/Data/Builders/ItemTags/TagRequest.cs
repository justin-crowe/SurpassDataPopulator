using System;
using System.Linq;
using Ardalis.GuardClauses;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Tags;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags;

public class TagRequest : ITagRequest
{
    private string _value;
    private Func<Item, string> _generationFunc;
        
    public string Name { get; private set; }

    public TagRequest(string nameAndValue)
    {
        Guard.Against.NullOrEmpty(nameAndValue);
            
        var split = nameAndValue.Split(':');
        SetValues(split.First(), split.Last());
    }

    public TagRequest(string name, Func<Item, string> generationFunc)
    {
        SetValues(name, null, generationFunc);
    }
        
    public TagRequest(string name, string value)
    {
        SetValues(name, value);
    }

    private void SetValues(string name, string value, Func<Item, string> generationFunc = null)
    {
        _value = value;
        Name = name;
        _generationFunc = generationFunc;
    }

    public Tag Build(Item context)
    {
        var value = _value ?? _generationFunc.Invoke(context);

        return new Tag(Name, value);
    }
}