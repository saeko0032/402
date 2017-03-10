//
//  ReceiverViewController.h
//  SampleDelegate
//
//  Created by saeko fukui on 2017-03-09.
//  Copyright © 2017 Saeko Fukui. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "SenderViewController.h"

@interface ReceiverViewController : UIViewController<SenderDelegate>

@property (weak, nonatomic) IBOutlet UILabel *messageLabel;

@end

