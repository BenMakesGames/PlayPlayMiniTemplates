using Autofac;
using Autofac.Extras.NLog;
using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Model;
using NLog;
using NLog.Config;
using NLog.Targets;
using MyNamespace.GameStates;

var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
var appDataGameDirectory = @$"{appData}/MyNamespace";

Directory.CreateDirectory(appDataGameDirectory);

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
            FileName = $"{appDataGameDirectory}/Logs.txt",
            DeleteOldFileOnStartup = true,
        };
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, fileTarget, "*");
        LogManager.Configuration = config;
    })
;

gsmBuilder.Run();

