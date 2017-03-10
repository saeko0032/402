//
//  ReceiverViewController.m
//  SampleDelegate
//
//  Created by saeko fukui on 2017-03-09.
//  Copyright © 2017 Saeko Fukui. All rights reserved.
//

#import "ReceiverViewController.h"

@interface ReceiverViewController ()

@end

@implementation ReceiverViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    SenderViewController* senderVC = [[SenderViewController alloc] init];
    senderVC.delegate = self;
}


- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)eventDidHappen:(NSString*)message
{
    self.messageLabel.text = message;

}
@end
