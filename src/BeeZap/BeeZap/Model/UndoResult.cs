using System;

namespace Beeline.BeeZap.Model
{
	public class UndoResult
	{
		public UndoResult(Boolean failed, String message, String original, String backup) {
			Failed = failed;
			Message = message;
			Backup = backup;
			Original = original;
		}

		public Boolean Failed { get; private set; }
		public String Message { get; private set; }
		public String Backup { get; private set; }
		public String Original { get; private set; }

		public override string ToString() {
			if (Failed) {
				return "Restore Failed: " + Message + Environment.NewLine + "\tOriginal: " + Original + Environment.NewLine + "\tBackup: " + Backup;
			}
			return "Restored " + Original;
		}
	}
}