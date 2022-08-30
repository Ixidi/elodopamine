using EloDopamine.Api.Game;

namespace EloDopamine.Api.Plugin;

public interface IPluginRegistration
{
    IEnumerable<IPluginDependencyRule> PluginDependencies { get; }
    void AddPluginDependency(string name, string version, VersionRequirement versionRequirement);
    void CoreVersionRequirement(string version, VersionRequirement versionRequirement);
    void WorksWithSpecifiedChampions(params Champion[] champions);
    void WorksWithEveryChampion();
    void RegisterService<T>(T service) where T : IPluginService;
}