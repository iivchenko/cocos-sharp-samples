using System.Reflection;
using Microsoft.Xna.Framework;
using CocosSharp;
using CocosDenshion;

namespace spine_cocossharp
{
	public class AppDelegate : CCApplicationDelegate
	{

		int preferredWidth;
		int preferredHeight;

		/// <summary>
		///  Implement CCDirector and CCScene init code here.
		/// </summary>
		/// <returns>
		///  true  Initialize success, app continue.
		///  false Initialize failed, app terminate.
		/// </returns>

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {

#if WINDOWS
            CCLog.Logger = System.Console.WriteLine;
#else
            CCLog.Logger = System.Diagnostics.Debug.WriteLine;
#endif

            preferredWidth = 1024;
			preferredHeight = 768;

			application.PreferMultiSampling = true;
			application.ContentRootDirectory = "Content";

			//CCSpriteFontCache.FontScale = 0.5f;
			//CCSpriteFontCache.RegisterFont("MarkerFelt", 22);
			//CCSpriteFontCache.RegisterFont("arial", 12, 24);

			CCSize designSize = new CCSize(480, 320);

//			if (CCDrawManager.FrameSize.Height > 320)
//			{
//				//CCSize resourceSize = new CCSize(960, 640);
//				CCSize resourceSize = new CCSize(480, 320);
//				application.ContentSearchPaths.Add("hd");
//				director.ContentScaleFactor = resourceSize.Height / designSize.Height;
//			}

            CCScene.SetDefaultDesignResolution(designSize.Width, designSize.Height, CCSceneResolutionPolicy.ShowAll);

			// turn on display FPS
			mainWindow.DisplayStats = true;
            mainWindow.StatsScale = 2;

            CCScene pScene = GoblinLayer.Scene(mainWindow);

			mainWindow.RunWithScene(pScene);
		}

		/// <summary>
		/// The function be called when the application enters the background
		/// </summary>
//		public override void ApplicationDidEnterBackground()
//		{
//			// stop all of the animation actions that are running.
//			CCDirector.SharedDirector.Pause();
//
//			// if you use SimpleAudioEngine, your music must be paused
//			//CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = true;
//		}

		/// <summary>
		/// The function be called when the application enter foreground  
		/// </summary>
//		public override void ApplicationWillEnterForeground()
//		{
//			CCDirector.SharedDirector.Resume();
//
//			// if you use SimpleAudioEngine, your background music track must resume here. 
//			//CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = false;
//
//		}
	}
}