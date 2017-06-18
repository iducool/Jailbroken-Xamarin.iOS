//
//  JBroken.h
//
//  Created by Sathish Venkatisan on 12/10/13.
//
#import <Foundation/Foundation.h>


@interface JailbreakBind : NSObject

+ (float)firmwareVersion;
+ (BOOL)isDeviceJailbroken;
+ (BOOL)isAppStoreVersion;
+ (NSString*)testMethod;

@end
