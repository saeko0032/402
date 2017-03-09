//
//  FirstViewController.m
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import "FirstViewController.h"
#import "ShoppingCart.h"
#import "FoodViewController.h"

@interface FirstViewController ()

@end

@implementation FirstViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    self.pricaLabel.text = @"0";
    NSMutableArray<Products*>* productItemArray = [[NSMutableArray alloc] init];
    self.shoppingCart = [[ShoppingCart alloc] initWithProductItemArray:productItemArray totalPricce:0];
}


- (void)viewWillAppear:(BOOL)animated {
    self.pricaLabel.text = [NSString stringWithFormat:@"%d",[self caluculateAllItems]];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (void)addObject:(Products*)products{
    [self.shoppingCart addProductItem:products];
}

- (int)caluculateAllItems
{
    int totalPrice = 0;
    for(int i = 0; i < self.shoppingCart.productItemArray.count; i++) {
        totalPrice += [[self.shoppingCart.productItemArray objectAtIndex:i] calculateCost];
    }
    return totalPrice;
}

- (void)sendRequest
{
    FoodViewController* foodVC = [[FoodViewController alloc] init];
    foodVC.foodViewDelegate = self;
}


@end
