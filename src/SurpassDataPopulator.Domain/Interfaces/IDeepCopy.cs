namespace SurpassDataPopulator.Domain.Interfaces;

public abstract class IDeepCopy<T>
{
    public abstract T DeepCopy();
}