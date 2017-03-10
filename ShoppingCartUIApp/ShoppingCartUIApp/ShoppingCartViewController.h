//
//  ShoppingCartViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "ShoppingCart.h"
@class ShoppingCartViewController;

@protocol ShoppingCartViewControllerDelegate
@required
-(void)getItemData:(ShoppingCartViewController*)shoppingViewController;
@end

@interface ShoppingCartViewController : UIViewController
@property (weak, nonatomic) id<ShoppingCartViewControllerDelegate> delegate;
@property (weak, nonatomic) IBOutlet UITextView *shoppingCartTextView;
@property (strong, nonatomic) NSMutableArray<Products*>* productItemList;
- (IBAction)closeShoppingCart:(UIButton *)sender;
- (void)updateTextView:(NSMutableArray<Products*>*)items;

@end
