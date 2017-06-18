using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace JailbreakBinding
{
	// @interface JailbreakBind : NSObject
	[BaseType(typeof(NSObject))]
	interface JailbreakBind
	{
		// +(float)firmwareVersion;
		[Static]
		[Export("firmwareVersion")]
		//Verify(MethodToProperty)]
		float FirmwareVersion { get; }

		// +(BOOL)isDeviceJailbroken;
		[Static]
		[Export("isDeviceJailbroken")]
		//[Verify(MethodToProperty)]
		bool IsDeviceJailbroken { get; }

		// +(BOOL)isAppStoreVersion;
		[Static]
		[Export("isAppStoreVersion")]
		//[Verify(MethodToProperty)]
		bool IsAppStoreVersion { get; }

		// +(NSString *)testMethod;
		[Static]
		[Export("testMethod")]
		//[Verify(MethodToProperty)]
		string TestMethod { get; }
	}
}
