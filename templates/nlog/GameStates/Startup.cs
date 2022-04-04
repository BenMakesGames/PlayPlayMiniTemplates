using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using NLog;

namespace MyNamespace.GameStates;

public class Startup: IGameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }
    private ILogger Logger { get; }

    public Startup(GraphicsManager graphics, GameStateManager gsm, ILogger logger)
    {
        GraphicsManager = graphics;
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
            Logger.Info("Assets loaded.");
            
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