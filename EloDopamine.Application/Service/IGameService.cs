using EloDopamine.Api.Game;

namespace EloDopamine.Application.Service;

public interface IGameService
{
    IGame Game { get; }
    void Update();
}