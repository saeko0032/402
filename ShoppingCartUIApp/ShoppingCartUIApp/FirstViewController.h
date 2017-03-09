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
#import "ClothViewController.h"
#import "DrinkViewController.h"
@interface FirstViewController : UIViewController<FoodViewControllerDelegate,  ClothViewControllerDelegate>


@property (weak, nonatomic) IBOutlet UILabel *pricaLabel;
@property (strong,nonatomic) ShoppingCart* shoppingCart;

- (void)addObject:(Products*)products;
- (void)sendRequest;

@end

