#import "IosVideoPlayer.h"
#import "IosVideoPlayerWrapper.h"

NSString* CreateNSString (const char* string)
{
    if (string)
        return [NSString stringWithUTF8String: string];
    else
        return [NSString stringWithUTF8String: ""];
}

void playVideo(const char* url) {
    [IosVideoPlayer playVideo:CreateNSString(url)];
}

