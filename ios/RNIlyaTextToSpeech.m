
#import "RNIlyaTextToSpeech.h"

@implementation RNIlyaTextToSpeech

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

RCT_EXPORT_METHOD(greetFromNative:(RCTResponseSenderBlock)callback)
{
    NSString * const MyExampleNotification = @"Greeting from iOS Native";
    callback(@[MyExampleNotification]);
}

@end
  
 
