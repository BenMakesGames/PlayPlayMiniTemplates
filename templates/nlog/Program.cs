using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Model;
using NLog;
using NLog.Config;
using NLog.Targets;
using MyNamespace.GameStates;

// TODO: any pre-req setup, ex:
/*
 * var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
 * Directory.CreateDirectory(@$"{appData}\MyGame");
 */

var gsmBuilder = new GameStateManagerBuilder();

gsmBuilder
    .SetWindowSize(1920 / 4, 1080 / 4, 2)
    .SetInitialGameState<Startup>()
    
    // TODO: set a window title
    //.SetWindowTitle("Word × Word")
    
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
        s.RegisterModule<NLogModule>();

        var config = new LoggingConfiguration();
        var fileTarget = new FileTarget()
        {
            AutoFlush = true,
            FileName = "MyGame.log",
            DeleteOldFileOnStartup = true,
        };
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, fileTarget, "*");
        LogManager.Configuration = config;
    })
;

gsmBuilder.Run();

