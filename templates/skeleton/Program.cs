using Autofac;
using BenMakesGames.PlayPlayMini;
using BenMakesGames.PlayPlayMini.Model;
using MyNamespace.GameStates;

// TODO: any pre-req setup, ex:
/*
 * var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
 * var appDataGameDirectory = @$"{appData}{Path.DirectorySeparatorChar}MyNamespace";
 * 
 * Directory.CreateDirectory(appDataGameDirectory);
 */

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
        
    })
;

gsmBuilder.Run();