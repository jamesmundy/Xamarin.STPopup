using System;
using ObjCRuntime;

namespace STPopup
{
	[Native]
	public enum STPopupStyle : nuint
	{
		FormSheet,
		BottomSheet
	}

	[Native]
	public enum STPopupTransitionStyle : nuint
	{
		SlideVertical,
		Fade
	}

	[Native]
	public enum STPopupLeftBarItemType : nuint
	{
		Cross,
		Arrow
	}
}
