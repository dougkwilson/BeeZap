using System;
using System.Text;

namespace Beeline.BeeZap.Model
{
	public interface IFileInfo
	{
		String Name { get; }
		String Extension { get; }
		Int64 Length { get; }
		String DirectoryName { get; }

		String RootPath { get; }
		String ChildPath { get; }

		String FullName { get; }

		void SetContent(String value);
		String GetContent();
		Boolean HasChanged { get; }

		String StatusText { get; set; }
		FileStatus Status { get; }
		Encoding Encoding { get; }

		void SaveChanges();
		void Release();
	}
}
