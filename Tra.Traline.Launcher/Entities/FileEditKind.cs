namespace Tra.Traline.Launcher.Entities;
public enum FileEditKind
{
	None = 0,
	_Main = 1,
	_Variables = 2,
	_Folder = 4,
	_Item = 8,
	_All = _Main | _Variables | _Folder | _Item,

	AddItem = _Variables | _Item,
	RemoveItem = AddItem,
	MoveItem = AddItem,
	EditItem = _Variables,
	AddFolder = _Main | _Variables | _Folder,
	RemoveFolder = AddFolder,
	MoveFolder = _All,
	EditFolder = _Variables,
}
