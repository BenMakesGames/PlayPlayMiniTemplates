using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

// sealed classes execute faster than non-sealed, so always seal your game states!
public sealed class Startup: GameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }
    private MouseManager Mouse { get; }

    public Startup(GraphicsManager graphics, GameStateManager gsm, MouseManager mouse)
    {
        Graphics = graphics;
        GSM = gsm;
        Mouse = mouse;

        Mouse.UseCustomCursor("Cursor", (3, 1));
    }

    // note: you do NOT need to call the `base.` for lifecycle methods. so save some CPU cycles,
    // and don't call them :P

    public override void ActiveUpdate(GameTime gameTime)
    {
        if (Graphics.FullyLoaded)
        {
            // TODO: go to title menu, once that exists; for now, just jump straight into the game:
            GSM.ChangeState<Playing>();
        }
    }

    public override void AlwaysDraw(GameTime gameTime)
    {
        // TODO: draw loading screen
    }

    public override void ActiveDraw(GameTime gameTime)
    {
        Mouse.ActiveDraw(gameTime);
    }
}
