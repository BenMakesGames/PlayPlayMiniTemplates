using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;

namespace MyNamespace.GameStates;

public class Startup: IGameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }

    public Startup(GraphicsManager graphics, GameStateManager gsm)
    {
        GraphicsManager = graphics;
        GSM = gsm;
    }
    
    public void ActiveInput(GameTime gameTime)
    {
    }

    public void ActiveUpdate(GameTime gameTime)
    {
        if (Graphics.FullyLoaded)
        {
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