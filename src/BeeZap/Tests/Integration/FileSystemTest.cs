using System;
using Beeline.BeeZap.Model;
using NUnit.Framework;

namespace Beeline.BeeZap.Tests.Integration
{
	[TestFixture, RequiresSTA]
	public class FileSystemTest : FileSystemTestBase
	{
		[Test]
		public void CanReadAFile()
		{
			// Arrange
			IFileSystem fileSystem = new FileSystem(new Preferences());
			IFileInfo fileInfo = fileSystem.GetFileInfo("BeeZap.txt");

			// Act
			String content = fileSystem.ReadAllText(fileInfo);

			// Assert
			Assert.AreEqual(GetTestContent(TimeStamp), content);
		}
	}
}
