﻿using AimpYouTubeDL.Api.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIDrawEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIDrawEvents
	{
		[PreserveSig] void OnDraw([MarshalAs(UnmanagedType.IUnknown)] object Sender, IntPtr DC, RECT R);
	}
}