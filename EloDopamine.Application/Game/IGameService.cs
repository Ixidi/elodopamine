using EloDopamine.Api.Game;

namespace EloDopamine.Application.Game;

public interface IGameService
{

    IGameManager GameManager { get; }
    
    void Update();

}