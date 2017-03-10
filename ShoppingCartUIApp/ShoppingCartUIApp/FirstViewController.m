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

// automatically called method //
- (void)viewDidLoad
{
    [super viewDidLoad];
    // initial price is 0.
    self.priceLabel.text = @"0";
    
    // make shoppingCartObject before use.
    NSMutableArray<Products*>* productItemArray = [[NSMutableArray alloc] init];
    self.shoppingCart = [[ShoppingCart alloc] initWithProductItemArray:productItemArray totalPricce:0];
}

- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    if([[segue identifier] isEqualToString:@"foodSegue"]) {
        ((FoodViewController*)segue.destinationViewController).delegate = self;
    } else if([[segue identifier] isEqualToString:@"drinkSegue"]) {
        ((DrinkViewController*)segue.destinationViewController).delegate = self;
    } else if([[segue identifier] isEqualToString:@"clothSegue"]) {
        ((ClothViewController*)segue.destinationViewController).delegate = self;
    } else if([[segue identifier] isEqualToString:@"shoppingCartSegue"]) {
        ((ShoppingCartViewController*)segue.destinationViewController).delegate = self;
    }
}

- (void)viewWillAppear:(BOOL)animated
{
    self.priceLabel.text = [NSString stringWithFormat:@"%d",[self.shoppingCart caluculateAllItems]];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(void)addProductItem:(Products*)item
{
    [self.shoppingCart addProductItem:item];
}

-(void)getItemData:(ShoppingCartViewController*)shoppingViewController
{
    NSMutableArray* item = [[NSMutableArray alloc] init];
    item = self.shoppingCart.productItemArray;
    [shoppingViewController updateTextView:item];
}

@end
