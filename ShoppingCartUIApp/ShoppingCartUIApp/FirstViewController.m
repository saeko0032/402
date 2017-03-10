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

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    self.pricaLabel.text = @"0";
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
    self.pricaLabel.text = [NSString stringWithFormat:@"%d",[self caluculateAllItems]];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (int)caluculateAllItems
{
    int totalPrice = 0;
    for(int i = 0; i < self.shoppingCart.productItemArray.count; i++) {
        totalPrice += [[self.shoppingCart.productItemArray objectAtIndex:i] calculateCost];
    }
    return totalPrice;
}

-(void)mymodalviewcontroller:(NSString*)message
{
    NSLog(@"KAKIKUKEKO");
}

-(void)addProductItem:(Products*)item
{
    [self.shoppingCart addProductItem:item];
}

-(void)getItemData:(ShoppingCartViewController*)shoppingViewController item:(NSMutableArray<Products*>*)item {
    item = self.shoppingCart.productItemArray;
    [shoppingViewController updateTextView:item];
}

@end
