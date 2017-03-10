//
//  ShoppingCartViewController.m
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-07.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import "ShoppingCartViewController.h"

@interface ShoppingCartViewController ()

@end

@implementation ShoppingCartViewController

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

- (void)viewWillAppear:(BOOL)animated
{
    self.productItemList = [[NSMutableArray alloc] init];
    [self.delegate getItemData:self];
}

- (void)updateTextView:(NSMutableArray<Products*>*)items
{
    NSString* text = [[NSString alloc] init];
    for(int i = 0; i<items.count; i++) {
        Products* p1 = [items objectAtIndex:i];
        text = [[text stringByAppendingString:p1.productName] stringByAppendingString:@" "];
    }
    self.shoppingCartTextView.text = text;
}

- (IBAction)closeShoppingCart:(UIButton *)sender {
    [self dismissViewControllerAnimated:YES completion:NULL];
}
@end
