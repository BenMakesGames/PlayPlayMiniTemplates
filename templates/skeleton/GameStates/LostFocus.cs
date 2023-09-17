using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Model;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

// inheriting game states is a path that leads to madness, so always seal your game states!
public sealed class LostFocus: GameState
{
    private GraphicsManager Graphics { get; }
    private GameStateManager GSM { get; }
    private MouseManager Mouse { get; }
    private GameState PreviousState { get; }

    public LostFocus(
        GraphicsManager graphics, GameStateManager gsm, MouseManager mouse,
        LostFocusConfig config
    )
    {
        Graphics = graphics;
        GSM = gsm;
        Mouse = mouse;

        PreviousState = config.PreviousState;
    }

    public override void ActiveInput(GameTime gameTime)
    {
        if(Mouse.LeftClicked)
            GSM.ChangeState(PreviousState);
    }

    public override void ActiveDraw(GameTime gameTime)
    {
        Mouse.ActiveDraw(gameTime);
    }

    public override void AlwaysDraw(GameTime gameTime)
    {
        PreviousState.AlwaysDraw(gameTime);

        Graphics.Clear(Color.DarkSlateGray);

        Graphics.DrawText("Font", Graphics.Width / 2 - 70, Graphics.Height / 2 - 4, "Paused! Click to resume.", Color.White);
    }
}
