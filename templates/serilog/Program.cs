using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Model;
using MyNamespace.GameStates;
using Serilog.Extensions.Autofac.DependencyInjection;
using System;
using System.IO;

var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
var appDataGameDirectory = $"{appData}{Path.DirectorySeparatorChar}MyNamespace";

Directory.CreateDirectory(appDataGameDirectory);

var gsmBuilder = new GameStateManagerBuilder();

gsmBuilder
    .SetWindowSize(1920 / 4, 1080 / 4, 2)
    .SetInitialGameState<Startup>()
    .SetLostFocusGameState<LostFocus>()

    // TODO: set a better window title
    .SetWindowTitle("MyNamespace")

    // TODO: add any resources needed (refer to PlayPlayMini documentation for more info)
    .AddAssets(new IAsset[]
    {
        new FontMeta("Font", "Graphics/Font", 6, 8),
        new PictureMeta("Cursor", "Graphics/Cursor", true),

        // new FontMeta(...)
        // new PictureMeta(...)
        // new SpriteSheetMeta(...)
        // new SongMeta(...)
        // new SoundEffectMeta(...)
    })

    // TODO: any additional service registration (refer to PlayPlayMini and/or Autofac documentation for more info)
    .AddServices((s, c) => {
        var logPath = $"{appDataGameDirectory}{Path.DirectorySeparatorChar}Log.log";

        s.RegisterSerilog(logPath);
    })
;

gsmBuilder.Run();
