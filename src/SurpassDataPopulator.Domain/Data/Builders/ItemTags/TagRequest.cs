using System;
using System.Linq;
using Ardalis.GuardClauses;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Tags;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public class TagRequest : ITagRequest
    {
        private string _name;
        private string _value;
        private Func<Item, string> _generationFunc;

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
            _name = name;
            _generationFunc = generationFunc;
        }

        public Tag Build(Item context)
        {
            return new Tag
            {
                Name = _name,
                Value = _value ?? _generationFunc.Invoke(context)
            };
        }
    }
}