//
//  ShoppingCartViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "FirstViewController.h"

@interface ShoppingCartViewController : UIViewController

- (IBAction)closeShoppingCart:(UIButton *)sender;
@property (weak, nonatomic) IBOutlet UITextView *shoppingCartTextView;

@end
