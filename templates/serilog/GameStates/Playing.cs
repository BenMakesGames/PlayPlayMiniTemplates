using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Services;
using Microsoft.Xna.Framework;

namespace MyNamespace.GameStates;

public class Playing: IGameState
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
    
    public void ActiveInput(GameTime gameTime)
    {
        // TODO: get input from keyboard (refer to PlayPlayMini documentation for more info)
    }

    public void ActiveUpdate(GameTime gameTime)
    {
        // TODO: update game objects based on user input, AI logic, etc
    }

    public void AlwaysUpdate(GameTime gameTime)
    {
    }

    public void ActiveDraw(GameTime gameTime)
    {
    }

    public void AlwaysDraw(GameTime gameTime)
    {
        // TODO: draw game scene (refer to PlayPlayMini documentation for more info)
    }
}