//
//  FoodViewController.m
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import "FoodViewController.h"

@interface FoodViewController ()

@end

@implementation FoodViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    //[previousViewController addObject:Product];
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
- (IBAction)addFoodItem:(UIButton *)sender {
    NSString *list = self.foodIngredientTextField.text;
    NSArray<NSString*>* foodIngredientsList = [list componentsSeparatedByString:@", "];
    
    Food* food = [[Food alloc] initWithFoodSize:[self.foodIDTextField.text intValue]
                                    productName:self.foodNameTextField.text
                                   productPrice:[self.foodPriceTextField.text floatValue]
                           productMadeInCountry:self.foodWhereFromTextField.text
                                       foodSize:[self.foodSizeTextField.text intValue]
                                   foodCalories:[self.foodCalorieTextField.text intValue]
                                foodIngredients:foodIngredientsList];
    
    UIViewController* previousViewController = [self presentingViewController];
    [(FirstViewController*)previousViewController addObject:food];
    [self dismissViewControllerAnimated:YES completion:NULL];
}

- (IBAction)closePage:(UIButton *)sender {
    [self dismissViewControllerAnimated:YES completion:NULL];
}
@end
