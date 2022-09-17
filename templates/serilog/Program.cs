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
    
    // TODO: set a better window title
    .SetWindowTitle("MyNamespace")
    
    // TODO: add any resources needed (refer to PlayPlayMini documentation for more info)
    .AddFonts(new FontMeta[] {
        
    })
    .AddPictures(new PictureMeta[] {
        
    })
    .AddSpriteSheets(new SpriteSheetMeta[] {
        
    })
    .AddSongs(new SongMeta[] {
        
    })
    .AddSoundEffects(new SoundEffectMeta[] {
        
    })
    
    // TODO: any additional service registration (refer to PlayPlayMini documentation for more info)
    .AddServices(s => {
        var logPath = $"{appDataGameDirectory}{Path.DirectorySeparatorChar}Log.log";

        s.RegisterSerilog(logPath);
    })
;

gsmBuilder.Run();