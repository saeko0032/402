//
//  FirstViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Products.h"
#import "ShoppingCart.h"

@interface FirstViewController : UIViewController

@property (weak, nonatomic) IBOutlet UILabel *pricaLabel;
@property (strong,nonatomic) ShoppingCart* shoppingCart;

- (void)addObject:(Products*)products;

@end

