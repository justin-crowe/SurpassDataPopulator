namespace SurpassDataPopulator.Domain.Entities.Tags
{
    public class Tag
    {
        public Tag(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        public string Name { get; private set; }
        public string Value { get; private set; }
    }

    public class TagCategory
    {
        public TagCategory(string name)
        {
            Name = name;
        }

        private string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}