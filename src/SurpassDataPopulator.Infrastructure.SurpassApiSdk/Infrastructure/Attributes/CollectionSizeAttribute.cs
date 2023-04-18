namespace SurpassApiSdk.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class CollectionSizeAttribute : Attribute
    {
        public CollectionSizeAttribute(int itemsCount)
        {
            ItemsCount = itemsCount;
        }

        /// <summary>
        /// Count of items in collection
        /// </summary>
        public int ItemsCount { get; set; }
    }
}
