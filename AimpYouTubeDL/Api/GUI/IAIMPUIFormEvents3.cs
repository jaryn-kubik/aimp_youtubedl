﻿using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIFormEvents3_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIFormEvents3
	{
		[PreserveSig] void OnStyleChanged(IAIMPUIForm Sender, int Style);
	}
}