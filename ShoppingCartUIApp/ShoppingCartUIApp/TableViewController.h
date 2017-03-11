//
//  TableViewController.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-10.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "ImageTableViewCell.h"
#import "TextFieldTableCellTableViewCell.h"

@interface TableViewController : UITableViewController<UITableViewDelegate, UITableViewDataSource>

@property (strong, nonatomic) IBOutlet UITableView* myTableView;

@end
