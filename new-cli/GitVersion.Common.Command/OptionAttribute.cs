namespace GitVersion;

[AttributeUsage(AttributeTargets.Property)]
public class OptionAttribute : Attribute
{
    public string[] Aliases { get; }
    public string Description { get; }

    public OptionAttribute(string alias, string description = "")
        : this(new[] { alias }, description)
    {
    }

    public OptionAttribute(string[] aliases, string description = "")
    {
        Aliases = aliases;
        Description = description;
    }
}
