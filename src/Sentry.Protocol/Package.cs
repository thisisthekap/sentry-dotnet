namespace Sentry.Protocol
{
    /// <summary>
    /// Represents a package used to compose the SDK
    /// </summary>
    public class Package
    {
        /// <summary>
        /// The name of the package
        /// </summary>
        /// <example>
        /// nuget:Sentry
        /// nuget:Sentry.AspNetCore
        /// </example>
        public string Name { get; }

        /// <summary>
        /// The version of the package
        /// </summary>
        /// <example>
        /// 1.0.0-rc1
        /// </example>
        public string Version { get; }

        /// <summary>
        /// Creates a new instance of a <see cref="Package"/>
        /// </summary>
        /// <param name="name">The package name.</param>
        /// <param name="version">The package version.</param>
        public Package(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }
}
