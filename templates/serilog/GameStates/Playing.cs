using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

// sealed classes execute faster than non-sealed, so always seal your game states!
public sealed class Playing: GameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }
    private MouseManager Mouse { get; }

    public Playing(GraphicsManager graphics, GameStateManager gsm, MouseManager mouse)
    {
        Graphics = graphics;
        GSM = gsm;
        Mouse = mouse;
    }

    // overriding lifecycle methods is optional; feel free to delete any overrides you're not using.
    // note: you do NOT need to call the `base.` for lifecycle methods. so save some CPU cycles,
    // and don't call them :P

    public override void ActiveInput(GameTime gameTime)
    {
        // TODO: get input from keyboard, mouse, or gamepad (refer to PlayPlayMini documentation for more info)
    }

    public override void ActiveUpdate(GameTime gameTime)
    {
        // TODO: update game objects based on user input, AI logic, etc
    }

    public override void AlwaysUpdate(GameTime gameTime)
    {
    }

    public override void ActiveDraw(GameTime gameTime)
    {
        Mouse.ActiveDraw(gameTime);
    }

    public override void AlwaysDraw(GameTime gameTime)
    {
        // TODO: draw game scene (refer to PlayPlayMini documentation for more info)

        Graphics.Clear(Color.DarkSlateGray);

        Graphics.DrawText("Font", Graphics.Width / 2 - 30, Graphics.Height / 2 - 4, "Oh, hi! :D", Color.White);
    }

    public override void Enter()
    {
    }

    public override void Leave()
    {
    }
}
