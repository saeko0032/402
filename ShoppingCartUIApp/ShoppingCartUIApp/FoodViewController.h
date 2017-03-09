//
//  FoodViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "FirstViewController.h"
#import "Food.h"

@interface FoodViewController : UIViewController
@property (weak, nonatomic) IBOutlet UITextField *foodIDTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodNameTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodPriceTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodWhereFromTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodCalorieTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodSizeTextField;
@property (weak, nonatomic) IBOutlet UITextField *foodIngredientTextField;

@end
