//
//  ImageTableViewCell.h
//  ShoppingCartUIApp
//
//  Created by saekof on 2017-03-10.
//  Copyright © 2017 CICCC. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ImageTableViewCell : UITableViewCell
@property (weak, nonatomic) IBOutlet UIImageView *myImageView;
@property (weak, nonatomic) IBOutlet UILabel *myTextLabel;

@end
