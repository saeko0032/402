//
//  SenderViewController.m
//  SampleDelegate
//
//  Created by saeko fukui on 2017-03-09.
//  Copyright © 2017 Saeko Fukui. All rights reserved.
//

#import "SenderViewController.h"

@interface SenderViewController ()

@end

@implementation SenderViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

- (void)viewDidDisappear:(BOOL)animated {
    if([self.delegate respondsToSelector:@selector(eventDidHappen:)]) {
    [self.delegate eventDidHappen:@"Apple"];
    }
}

@end
