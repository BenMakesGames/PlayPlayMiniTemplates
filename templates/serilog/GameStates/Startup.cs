using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

public class Startup: IGameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }
    private ILogger<Startup> Logger { get; }

    public Startup(GraphicsManager graphics, GameStateManager gsm, ILogger<Startup> logger)
    {
        Graphics = graphics;
        GSM = gsm;
        Logger = logger;
    }
    
    public void ActiveInput(GameTime gameTime)
    {
    }

    public void ActiveUpdate(GameTime gameTime)
    {
        if (Graphics.FullyLoaded)
        {
            Logger.LogInformation("Assets loaded.");
            
            // TODO: go to title menu, once that exists; for now, just jump straight into the game:
            GSM.ChangeState<Playing>();
        }
    }

    public void AlwaysUpdate(GameTime gameTime)
    {
    }

    public void ActiveDraw(GameTime gameTime)
    {
    }

    public void AlwaysDraw(GameTime gameTime)
    {
        // TODO: draw loading screen
    }
}