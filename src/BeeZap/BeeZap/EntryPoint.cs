using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Beeline.BeeZap.Model;

namespace Beeline.BeeZap
{
	static class EntryPoint
	{
		static EntryPoint()
		{
			Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
			AppDomain.CurrentDomain.UnhandledException += UnhandledException;
		}

		private static void UnhandledException(Object sender, UnhandledExceptionEventArgs ea)
		{
			using (StreamWriter writer = new StreamWriter("BeeZap.log", true, Encoding.Unicode)) {

				Exception ex = ea.ExceptionObject as Exception;
				if (ex == null) {
					writer.WriteLine(ea.ExceptionObject.GetType());
				} else {
					writer.WriteLine("{0}: {1}", ex.GetType(), ex.Message);
					writer.WriteLine(ex.StackTrace);
				}
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Preferences prefs = new Preferences() {
				TextEditorPath = ConfigurationManager.AppSettings["TextEditorPath"] ?? @"C:\Program Files (x86)\TextPad 6\TextPad.exe",
				TextEditorArguments = ConfigurationManager.AppSettings["TextEditorArguments"] ?? "{path} ({line},{col})",
				OutputEncoding = ConfigurationManager.AppSettings["OutputEncoding"] ?? "UseDetected"
			};

			IFileSystem fileSystem = new FileSystem(prefs);

			MainPresenter presenter = new MainPresenter(fileSystem);

			MainView view = new MainView(presenter);

			Application.Run(view);
		}
	}

	public static class SystemTime
	{
		/// <summary>
		/// Default implementation returns DateTime.UtcNow;
		/// </summary>
		public static Func<DateTime> UtcNow = () => DateTime.UtcNow;

		public static DateTime Local()
		{
			return UtcNow().ToLocalTime();
		}

		public static void Reset()
		{
			UtcNow = () => DateTime.UtcNow;
		}
	}
}
