namespace EloDopamine.Api.Plugin;

public interface IPluginDependencyRule
{
    bool Match(IPlugin plugin);

    string ToString();
}