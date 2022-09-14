using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

// sealed classes execute faster than non-sealed, so always seal your game states!
public sealed class Playing: GameState
{
    private GraphicsManager Graphics { get; }
    private KeyboardManager Keyboard { get; }
    private GameStateManager GSM { get; }

    public Playing(GraphicsManager graphics, GameStateManager gsm, KeyboardManager keyboard)
    {
        Graphics = graphics;
        GSM = gsm;
        Keyboard = keyboard;
    }

    // overriding lifecycle methods is optional; feel free to delete any overrides you're not using.
    // note: you do NOT need to call the `base.` for lifecycle methods. so save some CPU cycles,
    // and don't call them :P

    public override void ActiveInput(GameTime gameTime)
    {
        // TODO: get input from keyboard (refer to PlayPlayMini documentation for more info)
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
    }

    public override void AlwaysDraw(GameTime gameTime)
    {
        // TODO: draw game scene (refer to PlayPlayMini documentation for more info)
    }

    public override void Enter()
    {
    }

    public override void Leave()
    {
    }
}