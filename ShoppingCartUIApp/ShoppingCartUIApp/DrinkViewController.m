//
//  DrinkViewController.m
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import "DrinkViewController.h"

@interface DrinkViewController ()

@end

@implementation DrinkViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/
- (IBAction)addDrinkItem:(UIButton *)sender {
    Drink* drink = [[Drink alloc] initWithIsDrinkDiet:[self.drinkIDTextField.text intValue]
                                          productName:self.drinkNameTextField.text
                                         productPrice:[self.drinkPriceTextField.text floatValue] productMadeInCountry:self.drinkWhereFromTextField.text
                                          isDrinkDiet:self.drinkIsDietTextField.text
                                            drinkSize:[self.drinkSizeTextField.text intValue]];
    UIViewController* previousViewController = [self presentingViewController];
    [(FirstViewController*)previousViewController addObject:drink];
    [self dismissViewControllerAnimated:YES completion:NULL];
}

- (IBAction)closePage:(UIButton *)sender {
    [self dismissViewControllerAnimated:YES completion:NULL];
}
@end
