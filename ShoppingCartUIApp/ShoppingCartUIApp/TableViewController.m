//
//  UITableViewController.m
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-10.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import "TableViewController.h"
#import "Products.h"

@interface TableViewController ()

@property (strong, nonatomic) NSMutableArray<NSString*>* itemsForSection1;
@property (strong, nonatomic) NSMutableArray<NSString*>* itemsForSection2;

@end

@implementation TableViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    self.myTableView.delegate = self;
    self.myTableView.dataSource = self;
    
    self.itemsForSection1 = [@[@"Bob", @"Sam", @"Peter", @"John", @"Mary"] mutableCopy];
    self.itemsForSection2 = [@[@"Canada", @"USA", @"German", @"Greece", @"Italy", @"China", @"Russia"] mutableCopy];

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

- (UITableViewCell*)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    if(indexPath.section == 0) {
        // step1 : cell creation and Reuse
        ImageTableViewCell*cell = [tableView dequeueReusableCellWithIdentifier:@"imageTableViewCellReuse"];
        if(!cell) {
            cell = [[ImageTableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:@"imageTableViewCellReuse"];
        }
        // step2 : data binding
        cell.myImageView.image = [UIImage imageNamed:@"coffee_480"];
        cell.myTextLabel.text = [self.itemsForSection1 objectAtIndex:indexPath.row];
        return cell;
    } else { // section == 1
        TextFieldTableCellTableViewCell* cell = [tableView dequeueReusableCellWithIdentifier:@"textFieldTableViewCellReuse"];
        if(!cell) {
            cell = [[TextFieldTableCellTableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:@"textFieldTableViewCellReuse"];
        }
        cell.myTextField.text =  [self.itemsForSection2 objectAtIndex:indexPath.row];
        return cell;
    }
}

- (CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath {
    if(indexPath.section == 0) {
        return 110;
    } else {
        return 60;
    }
}

- (NSInteger) numberOfSectionsInTableView:(UITableView *)tableView {
    return 2;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    if(section==0) {
        return self.itemsForSection1.count;
    } else { // section = 1
        return self.itemsForSection2.count;
    }
}


@end
