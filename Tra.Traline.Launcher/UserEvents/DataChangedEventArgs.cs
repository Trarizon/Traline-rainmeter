using System;
using Tra.Traline.Launcher.Entities;

namespace Tra.Traline.Launcher.UserEvents;
public class DataChangedEventArgs : EventArgs
{
	public FileEditKind FileEditKind { get; }

	public DataChangedEventArgs(FileEditKind storeFileKind)
	{
		FileEditKind = storeFileKind;
	}
}
