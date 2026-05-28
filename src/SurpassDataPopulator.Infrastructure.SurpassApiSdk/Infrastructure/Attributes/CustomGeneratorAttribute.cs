namespace SurpassApiSdk.Infrastructure.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class CustomGeneratorAttribute : Attribute
{
    public CustomGeneratorAttribute(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Name of the custom generator
    /// </summary>
    public string Name { get; }
}