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
#import "FoodViewController.h"
#import "DrinkViewController.h"
#import "ClothViewController.h"
#import "ShoppingCartViewController.h"

@interface FirstViewController : UIViewController<FoodViewControllerDelegate, DrinkViewControllerDelegate, ClothViewControllerDelegate, ShoppingCartViewControllerDelegate>

@property (weak, nonatomic) IBOutlet UILabel *priceLabel;
@property (strong,nonatomic) ShoppingCart* shoppingCart;

- (void)addProductItem:(Products*)item;

@end

