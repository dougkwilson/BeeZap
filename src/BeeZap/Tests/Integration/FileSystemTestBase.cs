using System;
using System.Globalization;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace Beeline.BeeZap.Tests.Integration
{
	public abstract class FileSystemTestBase
	{
		private const String TestLocation = "C:\\Temp\\BeeZap";
		private DirectoryInfo _workingDirectory;
		private String _originalCurrentDirectory;

		protected string TimeStamp { get; private set; }

		[SetUp]
		public void SetUp()
		{
			_originalCurrentDirectory = Directory.GetCurrentDirectory();
			TimeStamp = SystemTime.Local().ToString("yyyyMMddHHmmssfffff");
			_workingDirectory = Directory.CreateDirectory(Path.Combine(TestLocation, TimeStamp));
			Directory.SetCurrentDirectory(_workingDirectory.FullName);
			using (StreamWriter streamWriter = new StreamWriter("BeeZap.txt")) {
				streamWriter.Write(GetTestContent(TimeStamp));
				streamWriter.Close();
			}
		}

		[TearDown]
		public void TearDown()
		{
			Directory.SetCurrentDirectory(_originalCurrentDirectory);
			Int32 count = 0;
			do {
				try {
					Directory.Delete(_workingDirectory.FullName, true);
					return;
				}
				catch (IOException) {
					System.Threading.Thread.Sleep(100);
				}
			} while (++count < 10);

			if (Directory.Exists(_workingDirectory.FullName))
				Assert.Inconclusive("Failed to delete the working directory: {0}", _workingDirectory.FullName);
		}

		protected static String GetTestContent(String timeStamp)
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(timeStamp);
			for (int i = 0; i < 10; i++) {
				builder.AppendLine(new String(Char.Parse(i.ToString(CultureInfo.InvariantCulture)), i));
			}
			return builder.ToString();
		}

	}
}
