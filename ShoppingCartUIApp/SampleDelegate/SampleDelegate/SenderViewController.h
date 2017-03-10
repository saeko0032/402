//
//  SenderViewController.h
//  SampleDelegate
//
//  Created by saeko fukui on 2017-03-09.
//  Copyright © 2017 Saeko Fukui. All rights reserved.
//

#import <UIKit/UIKit.h>

@protocol SenderDelegate <NSObject>
@required
- (void)eventDidHappen:(NSString*)message;
@optional
- (void)sayHello:(NSString*)hello;
@end

@interface SenderViewController : UIViewController
@property(weak, nonatomic) id<SenderDelegate> delegate;
@end
