//
//  DrinkViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Drink.h"

@protocol DrinkViewControllerDelegate <NSObject>
@required
-(void)addProductItem:(Products*)item;
@end

@interface DrinkViewController : UIViewController
@property (weak, nonatomic) id<DrinkViewControllerDelegate> delegate;
@property (weak, nonatomic) IBOutlet UITextField *drinkIDTextField;
@property (weak, nonatomic) IBOutlet UITextField *drinkNameTextField;
@property (weak, nonatomic) IBOutlet UITextField *drinkPriceTextField;
@property (weak, nonatomic) IBOutlet UITextField *drinkWhereFromTextField;
@property (weak, nonatomic) IBOutlet UITextField *drinkIsDietTextField;
@property (weak, nonatomic) IBOutlet UITextField *drinkSizeTextField;
@end
