# Hair Salon

#### _C#, .NET: Hair Salon, 01/17/2020_

## Description
Create a web application of a hair salon called Eau Claire's Salon. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. Tye stylist have specific specialties, so each client can only belong to a single stylist.

## About this application
- Claire can see a list of all stylists.

- Claire can select a stylist, see the details, and see a list of all clients that belong to that stylist.

- Claire can edit the details of specific stylist's information.

- Claire can add a new stylists to the system when they are hired.

- Claire can see a list of all stylists.

- Claire can add a new client to the specific stylist. Claire should not be able to add a client if no stylists have been added.

- Claire can edit the details of specific customer's information.


## SQL Command
Please use these following command to create tables on MySQL


For `stylists` table:
```
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

```

For `customers` table:
```
CREATE TABLE `customers` (
  `CustomerId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

```

## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/BestRestaurant.Solution.git
```

2. Use the following codes:

a) Command to build the BestRestaurant. Run this in BestRestaurant directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in BestRestaurant.Tests directory:
```
$ dotnet restore && dotnet test
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, CSS, Bootstrap, C#, ASP.NET Core MVC, Entity and MySQL

## License
Copyright © 2020 under the MIT License
