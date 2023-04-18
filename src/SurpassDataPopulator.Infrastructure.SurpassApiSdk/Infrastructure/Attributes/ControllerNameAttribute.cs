namespace SurpassApiSdk.Infrastructure.Attributes
{
    /// <summary>
    /// Presents an <see cref="Attribute"/> that describes the name of the controller in the MVC Map.
    /// Should be used for an entity model that is returned by a controller action.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class ControllerNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerNameAttribute"/> class.
        /// </summary>
        /// <param name="name">Controller name</param>
        /// <param name="apiVersion">version number</param>
        public ControllerNameAttribute(string name, int apiVersion)
        {
            Name = name;
            ApiVersion = apiVersion;
        }

        /// <summary>
        /// The name of the controller
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The api version
        /// </summary>
        public int ApiVersion { get; }
    }
}
