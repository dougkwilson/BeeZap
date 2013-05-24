using System;
using System.Collections.Generic;
using System.Text;

namespace Beeline.BeeZap.Model
{
	public interface IFileSystem
	{
		IFileInfo GetFileInfo(String filename);

		IEnumerable<IFileInfo> EnumerateFileInfo(String path, String searchPattern, Boolean includeSubDirectories);

		String ReadAllText(IFileInfo fileInfo);
		void WriteFileContent(IFileInfo fileInfo, String content);

		Boolean CanUndo();
		void Commit();
		IEnumerable<UndoResult> Undo(Boolean haltOnError);
		Int32 GetPendingUndoCount();
		Boolean Exists(String path);
		
		Boolean OpenInEditor(String path, String lineNumber, String column);
		Encoding GetEncoding(IFileInfo fileInfoWrapper);

	}
}