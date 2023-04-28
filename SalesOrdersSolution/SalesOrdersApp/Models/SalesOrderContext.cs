using System;
using Microsoft.EntityFrameworkCore;
using SalesOrdersApp.Models.DomainModels;

namespace SalesOrdersApp.Models
{
    public class SalesOrderContext : DbContext
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options)
    : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "AeroFlo ATB Wheels",
                    ProductDescShort = "01-AeroFlo-ATB-Wheels",
                    ProductDescLong = "This is a fun flowy trail! The trail starts with a test- a skinny with a 2 ft. The area is mostly wooded but there are several places that offer spectacular views.",
                    ProductImage = "~/images/01-AeroFlo-ATB-Wheels.jpg",
                    ProductPrice = 189M,
                    ProductQty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Clear Shade 85-T Glasses",
                    ProductDescShort = "02-Clear-Shade-85-T-Glasses",
                    ProductDescLong = "There is no preferred direction and the trail is a great connector for several other fun loops. Two wheel drifting is likely if you have speed.",
                    ProductImage = "~/images/02-Clear-Shade-85-T-Glasses.jpg",
                    ProductPrice = 45M,
                    ProductQty = 14,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Cosmic Elite Road Warrior Wheels",
                    ProductDescShort = "03-Cosmic-Elite-Road-Warrior-Wheels",
                    ProductDescLong = "Rowdy little downhill/freeride track. 16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008.",
                    ProductImage = "~/images/03-Cosmic-Elite-Road-Warrior-Wheels.jpg",
                    ProductPrice = 165M,
                    ProductQty = 22,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Cycle-Doc Pro Repair Stand",
                    ProductDescShort = "04-Cycle-Doc-Pro-Repair-Stand",
                    ProductDescLong = "The State of Alaska installed a more user friendly course in 2012. Mostly dry with some small mud puddles. The trails are well drained and suitable for riding when wet.",
                    ProductImage = "~/images/04-Cycle-Doc-Pro-Repair-Stand.jpg",
                    ProductPrice = 166M,
                    ProductQty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Dog Ear Aero-Flow Floor Pump",
                    ProductDescShort = "05-Dog-Ear-Aero-Flow-Floor-Pump",
                    ProductDescLong = "It packs in a lot of excitement in a short amount of time. IMO it is a better ride to turn around and follow the same trail down. Removable by hand saw.",
                    ProductImage = "~/images/05-Dog-Ear-Aero-Flow-Floor-Pump.jpg",
                    ProductPrice = 5M,
                    ProductQty = 25,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Dog Ear Cycle Computer",
                    ProductDescShort = "06-Dog-Ear-Cycle-Computer",
                    ProductDescLong = "This is just a brute of a climb. Short and fast, with a few small jumps and some loose rocks to keep you on your toes.",
                    ProductImage = "~/images/06-Dog-Ear-Cycle-Computer.jpg",
                    ProductPrice = 75M,
                    ProductQty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Dog Ear Helmet Mount Mirrors",
                    ProductDescShort = "07-Dog-Ear-Helmet-Mount-Mirror",
                    ProductDescLong = "There may be an optional dropspot 1/2 way down. The turns may be smooth berms that will be easy riding. It has few real technical features.",
                    ProductImage = "~/images/07-Dog-Ear-Helmet-Mount-Mirror.jpg",
                    ProductPrice = 7.45M,
                    ProductQty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Dog Ear Monster Grip Gloves",
                    ProductDescShort = "08-Dog-Ear-Monster-Grip-Gloves",
                    ProductDescLong = "Since being redesigned, it is a lot of fun to ride this glassy smooth and generally well-bermed trail. Logs embedded in the trail have been installed.",
                    ProductImage = "~/images/08-Dog-Ear-Monster-Grip-Gloves.jpg",
                    ProductPrice = 15M,
                    ProductQty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Eagle FS-3 Mountain Bike",
                    ProductDescShort = "09-Eagle-FS-3-Mountain-Bike",
                    ProductDescLong = "Installed to signal technical terrain. This trail begins with a small pump section with two smaller jumps and a third larger hip jump.",
                    ProductImage = "~/images/09-Eagle-FS-3-Mountain-Bike.jpg",
                    ProductPrice = 1800M,
                    ProductQty = 8,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Eagle SA-120 Clipless Pedals",
                    ProductDescShort = "10-Eagle-SA-120-Clipless-Pedals",
                    ProductDescLong = "Fun! Chewed up, lots of braking bumps, but still fun. Winding trail with dips, climbs and descents. The turns are all smooth berms and easy to ride.",
                    ProductImage = "~/images/10-Eagle-SA-120-Clipless-Pedals.jpg",
                    ProductPrice = 139.95M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Glide-O-Matic Cycling Helmet",
                    ProductDescShort = "11-Glide-O-Matic-Cycling-Helmet",
                    ProductDescLong = "Easy to ride and not wash out. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.",
                    ProductImage = "~/images/11-Glide-O-Matic-Cycling-Helmet.jpg",
                    ProductPrice = 125M,
                    ProductQty = 24,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "GT RTS-2 Mountain Bike",
                    ProductDescShort = "12-GT-RTS-2-Mountain-Bike",
                    ProductDescLong = "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).",
                    ProductImage = "~/images/12-GT-RTS-2-Mountain-Bike.jpg",
                    ProductPrice = 1650M,
                    ProductQty = 5,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "HP Deluxe Panniers",
                    ProductDescShort = "13-HP-Deluxe-Panniers",
                    ProductDescLong = "Large group of trees down on northern section of trail, between buckhorn and club gap. There is no preferred direction and the trail is a great connector for several other fun loops.",
                    ProductImage = "~/images/13-HP-Deluxe-Panniers.jpg",
                    ProductPrice = 39M,
                    ProductQty = 10,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "King Cobra Helmet",
                    ProductDescShort = "14-King-Cobra-Helmet",
                    ProductDescLong = "This area has a high density of trails for all ability levels and serves as the unofficial hub of mountain bike activity in the South Shore.",
                    ProductImage = "~/images/14-King-Cobra-Helmet.jpg",
                    ProductPrice = 139M,
                    ProductQty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Kool Breeze Rocket Top Jersey",
                    ProductDescShort = "15-Kool-Breeze-Rocket-Top-Jersey",
                    ProductDescLong = "Mountain bike activity in the South Shore. By the end of the 45-50 miles youll be plenty tired from the constant up and down nature of Mana Road.",
                    ProductImage = "~/images/15-Kool-Breeze-Rocket-Top-Jersey.jpg",
                    ProductPrice = 4.99M,
                    ProductQty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Kryptonite Advanced 2000 U-Lock",
                    ProductDescShort = "16-Kryptonite-Advanced-2000-U-Lock",
                    ProductDescLong = "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.",
                    ProductImage = "~/images/16-Kryptonite-Advanced-2000-U-Lock.jpg",
                    ProductPrice = 50M,
                    ProductQty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Nikoma Lok-Tight U-Lock",
                    ProductDescShort = "17-Nikoma-Lok-Tight-U-Lock",
                    ProductDescLong = "Third Divide makes up part of the classic Downieville downhill route. A little overgrown on the seward side, but totlaly manageable.",
                    ProductImage = "~/images/17-Nikoma-Lok-Tight-U-Lock.jpg",
                    ProductPrice = 33M,
                    ProductQty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "ProFormance ATB All-Terrain Pedal",
                    ProductDescShort = "18-Proformance-ATB-All-Terrain-Pedal",
                    ProductDescLong = "Overgrown on the seward side, but totlaly manageable. Trail full of berms and fun features! But this trail does not relent for one second.",
                    ProductImage = "~/images/18-Proformance-ATB-All-Terrain-Pedal.jpg",
                    ProductPrice = 28M,
                    ProductQty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "ProFormance Toe Klips 2G",
                    ProductDescShort = "19-ProFormance-Toe-Klips-2G",
                    ProductDescLong = "It doesnt get much use though so is sometimes a bit overgrown. Out here you will find the most legal features including log rides.",
                    ProductImage = "~/images/19-ProFormance-Toe-Klips-2G.jpg",
                    ProductPrice = 28M,
                    ProductQty = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Pro-Sport Dillo Shades",
                    ProductDescShort = "20-Pro-Sport-Dillo-Shades",
                    ProductDescLong = "Jumps and rock rolls in South Tahoe including the new jumps, berms, rollers and hips TAMBA and SBTS built in 2014. As the valley begins to close",
                    ProductImage = "~/images/20-Pro-Sport-Dillo-Shades.jpg",
                    ProductPrice = 82M,
                    ProductQty = 18,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Road Warrior Hitch Pack",
                    ProductDescShort = "21-Road-Warrior-Hitch-Pack",
                    ProductDescLong = "The route transitions to a section of open forest. Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny.",
                    ProductImage = "~/images/21-Road-Warrior-Hitch-Pack.jpg",
                    ProductPrice = 175M,
                    ProductQty = 6,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Shinoman 105 SC Brakes",
                    ProductDescShort = "22-Shinoman-105-SC-Brakes",
                    ProductDescLong = "Elevated bridges and a long-straight skinny. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.",
                    ProductImage = "~/images/22-Shinoman-105-SC-Brakes.jpg",
                    ProductPrice = 23.50M,
                    ProductQty = 16,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 23,
                    ProductName = "Shinoman Deluxe TX-30 Pedal",
                    ProductDescShort = "23-Shinoman-Deluxe-TX-30-Pedal",
                    ProductDescLong = "The trail is somewhat wide for singletrack and a bit technical with roots and rocks. Several high speed, low risk sections take you down the sandy open trail.",
                    ProductImage = "~/images/23-Shinoman-Deluxe-TX-30-Pedal.jpg",
                    ProductPrice = 45M,
                    ProductQty = 60,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 24,
                    ProductName = "Shinoman Dura Ace Headset",
                    ProductDescShort = "24-Shinoman-Dura-Ace-Headset",
                    ProductDescLong = "The sandy open trail for some of the most fun downhills in the area. Lost Lake starts at its namesake trailhead. Several high speed, low risk sections take you down the sandy open trail",
                    ProductImage = "~/images/24-Shinoman-Dura-Ace-Headset.jpg",
                    ProductPrice = 67.50M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "StaDry Cycling Pants",
                    ProductDescShort = "25-StaDry-Cycling-Pants",
                    ProductDescLong = "Take you down the sandy open trail for some of the most fun downhills in the area. Ridgeline is a crown jewel of Dupont State Recreational Forest.",
                    ProductImage = "~/images/25-StaDry-Cycling-Pants.jpg",
                    ProductPrice = 69M,
                    ProductQty = 22,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 26,
                    ProductName = "TransPort Bicycle Rack",
                    ProductDescShort = "26-TransPort-Bicycle-Rack",
                    ProductDescLong = "You now have to ride down an asphalt trail and cut off onto a gravel trail before getting back to the old single track. Watch that you dont overshoot the switchback",
                    ProductImage = "~/images/26-TransPort-Bicycle-Rack.jpg",
                    ProductPrice = 27M,
                    ProductQty = 14,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 27,
                    ProductName = "Trek 9000 Mountain Bike",
                    ProductDescShort = "27-Trek-9000-Mountain-Bike",
                    ProductDescLong = "Stay the black diamond descent - the blue route was completely overgrown. This was a legitimate expert trail, but much difficulty can be mitigated slowing down, picking your line carefully.",
                    ProductImage = "~/images/27-Trek-9000-Mountain-Bike.jpg",
                    ProductPrice = 1200M,
                    ProductQty = 6,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 28,
                    ProductName = "True Grip Competition Gloves",
                    ProductDescShort = "28-True-Grip-Competition-Gloves",
                    ProductDescLong = "The start of the dirt road is marked on the Google Map directions on this page. Im slow and a little chicken top hit some of the gap jumps but this was super fun.",
                    ProductImage = "~/images/28-True-Grip-Competition-Gloves.jpg",
                    ProductPrice = 22M,
                    ProductQty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 29,
                    ProductName = "Turbo Twin Tires",
                    ProductDescShort = "29-Turbo-Twin-Tires",
                    ProductDescLong = "Logs embedded in the trail have been installed to signal technical terrain. Out of the parking lot, take your first left. Trail contains a rope-suspended ladder bridge.",
                    ProductImage = "~/images/29-Turbo-Twin-Tires.jpg",
                    ProductPrice = 29M,
                    ProductQty = 18,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 30,
                    ProductName = "Ultimate Export 2G Car Rack",
                    ProductDescShort = "30-Ultimate-Export-2G-Car-Rack",
                    ProductDescLong = "Elevated bridges and a long-straight skinny. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.",
                    ProductImage = "~/images/30-Ultimate-Export-2G-Car-Rack.jpg",
                    ProductPrice = 180M,
                    ProductQty = 8,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 31,
                    ProductName = "Ultra-2K Competition Tire",
                    ProductDescShort = "31-Ultra-2K-Competition-Tire",
                    ProductDescLong = "Road ride is absolutely beautiful and worth the ride. Watch that you dont overshoot the switchback to stay on the black diamond descent - the blue route is completely overgrown.",
                    ProductImage = "~/images/31-Ultra-2K-Competition-Tire.jpg",
                    ProductPrice = 34M,
                    ProductQty = 22,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 32,
                    ProductName = "Ultra-Pro Rain Jacket",
                    ProductDescShort = "32-Ultra-Pro-Rain-Jacket",
                    ProductDescLong = "Super loose after second intersection. The bottom portion of the trail is fast, loose and tight. Landings are getting a little rotted but the overall condition is good.",
                    ProductImage = "~/images/32-Ultra-Pro-Rain-Jacket.jpg",
                    ProductPrice = 85M,
                    ProductQty = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 33,
                    ProductName = "Victoria Pro All Weather Tires",
                    ProductDescShort = "33-Victoria-Pro-All-Weather-Tires",
                    ProductDescLong = "The overall condition is good. The start of the dirt road is marked on the Google Map directions on this page. Pretty dry and fast.",
                    ProductImage = "~/images/33-Victoria-Pro-All-Weather-Tires.jpg",
                    ProductPrice = 54.95M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 34,
                    ProductName = "Viscount C-500 Wireless Bike Computer",
                    ProductDescShort = "34-Viscount-C-500-Wireless-Bike-Computer",
                    ProductDescLong = "At almost 20 miles with almost everything tahoe has to offer. I need to learn how to jump! By the end of the 45-50 miles youll be plenty tired from the constant up and down.",
                    ProductImage = "~/images/34-Viscount-C-500-Wireless-Bike-Computer.jpg",
                    ProductPrice = 49M,
                    ProductQty = 30,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 35,
                    ProductName = "Viscount CardioSport Sport Watch",
                    ProductDescShort = "35-Viscount-CardioSport-Sport-Watch",
                    ProductDescLong = "The constant up and down nature of Mana Road. There are actually three trails which make up the loop: Horse Creek-Cattle Creek-Lower Twin Lake. Logs are gone!",
                    ProductImage = "~/images/35-Viscount-CardioSport-Sport-Watch.jpg",
                    ProductPrice = 179M,
                    ProductQty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 36,
                    ProductName = "Viscount Microshell Helmet",
                    ProductDescShort = "36-Viscount-Microshell-Helmet",
                    ProductDescLong = "Third Divide makes up part of the classic Downieville downhill route. There is no preferred direction and the trail is a great connector for several other fun loops.",
                    ProductImage = "~/images/36-Viscount-Microshell-Helmet.jpg",
                    ProductPrice = 36M,
                    ProductQty = 20,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 37,
                    ProductName = "Viscount Mountain Bike",
                    ProductDescShort = "37-Viscount-Mountain-Bikes",
                    ProductDescLong = "A trail & parking area reconstruction project completed in July 17. Long pedal up form town but best when shuttled to the top.",
                    ProductImage = "~/images/37-Viscount-Mountain-Bikes.jpg",
                    ProductPrice = 635M,
                    ProductQty = 5,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 38,
                    ProductName = "Viscount Tru-Beat Heart Transmitter",
                    ProductDescShort = "38-Viscount-Tru-Beat-Heart-Transmitter",
                    ProductDescLong = "One of the best downhills in the area. This ridge is more rugged than the other two ridges. The trail has good flow with some spicy sections.",
                    ProductImage = "~/images/38-Viscount-Tru-Beat-Heart-Transmitter.jpg",
                    ProductPrice = 47M,
                    ProductQty = 20,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 39,
                    ProductName = "Wonder Wool Cycle Socks",
                    ProductDescShort = "39-Wonder-Wood-Cycle-Socks",
                    ProductDescLong = "There are also several sections of slickrock that are fun to ride and allow you to pick your own line. The trails all run parallel to the Fountain Place paved road.",
                    ProductImage = "~/images/39-Wonder-Wood-Cycle-Socks.jpg",
                    ProductPrice = 19M,
                    ProductQty = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 40,
                    ProductName = "X-Pro All Weather Tires",
                    ProductDescShort = "40-X-Pro-All-Weather-Tires",
                    ProductDescLong = "Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features.",
                    ProductImage = "~/images/40-X-Pro-All-Weather-Tires.jpg",
                    ProductPrice = 24M,
                    ProductQty = 20,
                    CategoryID = 6
                });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Accessories" },
                new Category { CategoryID = 2, CategoryName = "Bikes" },
                new Category { CategoryID = 3, CategoryName = "Clothing" },
                new Category { CategoryID = 4, CategoryName = "Components" },
                new Category { CategoryID = 5, CategoryName = "Car racks" },
                new Category { CategoryID = 6, CategoryName = "Wheels" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    CustomerFirstName = "Suzanne",
                    CustomerLastName = "Viescas",
                    CustomerAddress = "15127 NE 24th, #383",
                    CustomerCity = "Redmond",
                    CustomerState = "WA",
                    CustomerZipCode = "98052",
                    CustomerPhone = "425-555-2686"
                },
                new Customer
                {
                    CustomerID = 2,
                    CustomerFirstName = "William",
                    CustomerLastName = "Thompson",
                    CustomerAddress = "122 Spring River Drive",
                    CustomerCity = "Duvall",
                    CustomerState = "WA",
                    CustomerZipCode = "98019",
                    CustomerPhone = "425-555-2681"
                },
                new Customer
                {
                    CustomerID = 3,
                    CustomerFirstName = "Gary",
                    CustomerLastName = "Hallmark",
                    CustomerAddress = "Route 2 Road", 
                    CustomerCity = "Auburn",
                    CustomerState = "WA",
                    CustomerZipCode = "98002",
                    CustomerPhone = "253-555-2676"
                },
                new Customer
                {
                    CustomerID = 4,
                    CustomerFirstName = "Robert",
                    CustomerLastName = "Brown",
                    CustomerAddress = "672 Lamont Ave",
                    CustomerCity = "Houston",
                    CustomerState = "TX",
                    CustomerZipCode = "77201",
                    CustomerPhone = "713-555-2491"
                },
                new Customer
                {
                    CustomerID = 5,
                    CustomerFirstName = "Dean",
                    CustomerLastName = "McCrae",
                    CustomerAddress = "4110 Redmond Rd.",
                    CustomerCity = "Redmond",
                    CustomerState = "WA",
                    CustomerZipCode = "98052",
                    CustomerPhone = "425-555-2506"
                },
                new Customer
                {
                    CustomerID = 6,
                    CustomerFirstName = "John",
                    CustomerLastName = "Viescas",
                    CustomerAddress = "15127 NE 24th, #383",
                    CustomerCity = "Redmond",
                    CustomerState = "WA",
                    CustomerZipCode = "98052",
                    CustomerPhone = "425-555-2511"
                },
                new Customer
                {
                    CustomerID = 7,
                    CustomerFirstName = "Mariya",
                    CustomerLastName = "Sergienko",
                    CustomerAddress = "901 Pine Avenue",
                    CustomerCity = "Portland",
                    CustomerState = "OR",
                    CustomerZipCode = "97208",
                    CustomerPhone = "503-555-2526"
                },
                new Customer
                {
                    CustomerID = 8,
                    CustomerFirstName = "Neil",
                    CustomerLastName = "Patterson",
                    CustomerAddress = "233 West Valley Hwy",
                    CustomerCity = "San Diego",
                    CustomerState = "CA",
                    CustomerZipCode = "92199",
                    CustomerPhone = "619-555-2541"
                },
                new Customer
                {
                    CustomerID = 9,
                    CustomerFirstName = "Andrew",
                    CustomerLastName = "Cencini",
                    CustomerAddress = "507 - 20th Ave. E. Apt. 2A",
                    CustomerCity = "Seattle",
                    CustomerState = "WA",
                    CustomerZipCode = "98105",
                    CustomerPhone = "206-555-2601"
                },
                new Customer
                {
                    CustomerID = 10,
                    CustomerFirstName = "Angel",
                    CustomerLastName = "Kennedy",
                    CustomerAddress = "667 Red River Road",
                    CustomerCity = "Austin",
                    CustomerState = "TX",
                    CustomerZipCode = "78710",
                    CustomerPhone = "512-555-2571"
                },
                new Customer
                {
                    CustomerID = 11,
                    CustomerFirstName = "Alaina",
                    CustomerLastName = "Hallmark",
                    CustomerAddress = "Route 2, Box 203B",
                    CustomerCity = "Woodinville",
                    CustomerState = "WA",
                    CustomerZipCode = "98072",
                    CustomerPhone = "425-555-2631"
                },
                new Customer
                {
                    CustomerID = 12,
                    CustomerFirstName = "Liz",
                    CustomerLastName = "Keyser",
                    CustomerAddress = "13920 S.E. 40th Street",
                    CustomerCity = "Bellevue",
                    CustomerState = "WA",
                    CustomerZipCode = "98006",
                    CustomerPhone = "425-555-2556"
                },
                new Customer
                {
                    CustomerID = 13,
                    CustomerFirstName = "Rachel",
                    CustomerLastName = "Patterson",
                    CustomerAddress = "2114 Longview Lane",
                    CustomerCity = "San Diego",
                    CustomerState = "CA",
                    CustomerZipCode = "92199",
                    CustomerPhone = "619-555-2546"
                },
                new Customer
                {
                    CustomerID = 14,
                    CustomerFirstName = "Sam",
                    CustomerLastName = "Abolrous",
                    CustomerAddress = "611 Alpine Drive",
                    CustomerCity = "Palm Springs",
                    CustomerState = "CA",
                    CustomerZipCode = "92263",
                    CustomerPhone = "760-555-2611"
                },
                new Customer
                {
                    CustomerID = 15,
                    CustomerFirstName = "Darren",
                    CustomerLastName = "Gehring",
                    CustomerAddress = "2601 Seaview Lane",
                    CustomerCity = "Chico",
                    CustomerState = "CA",
                    CustomerZipCode = "95926",
                    CustomerPhone = "530-555-2616"
                },
                new Customer
                {
                    CustomerID = 16,
                    CustomerFirstName = "Jim",
                    CustomerLastName = "Wilson",
                    CustomerAddress = "101 NE 88th",
                    CustomerCity = "Salem",
                    CustomerState = "OR",
                    CustomerZipCode = "97301",
                    CustomerPhone = "503-555-2636"
                },
                new Customer
                {
                    CustomerID = 17,
                    CustomerFirstName = "Manuela",
                    CustomerLastName = "Seidel",
                    CustomerAddress = "66 Spring Valley Drive",
                    CustomerCity = "Medford",
                    CustomerState = "OR",
                    CustomerZipCode = "97501",
                    CustomerPhone = "541-555-2641"

                },
                new Customer
                {
                    CustomerID = 18,
                    CustomerFirstName = "David",
                    CustomerLastName = "Smith",
                    CustomerAddress = "311 20th Ave. N.E.",
                    CustomerCity = "Fremont",
                    CustomerState = "CA",
                    CustomerZipCode = "94538",
                    CustomerPhone = "510-555-2646"
                },
                new Customer
                {
                    CustomerID = 19,
                    CustomerFirstName = "Zachary",
                    CustomerLastName = "Ehrlich",
                    CustomerAddress = "12330 Kingman Drive",
                    CustomerCity = "Glendale",
                    CustomerState = "CA",
                    CustomerZipCode = "91209",
                    CustomerPhone = "818-555-2721"
                },
                new Customer
                {
                    CustomerID = 20,
                    CustomerFirstName = "Joyce",
                    CustomerLastName = "Bonnicksen",
                    CustomerAddress = "2424 Thames Drive",
                    CustomerCity = "Bellevue",
                    CustomerState = "WA",
                    CustomerZipCode = "98006",
                    CustomerPhone = "425-555-2726"
                },
                new Customer
                {
                    CustomerID = 21,
                    CustomerFirstName = "Estella",
                    CustomerLastName = "Pundt",
                    CustomerAddress = "2500 Rosales Lane",
                    CustomerCity = "Dallas",
                    CustomerState = "TX",
                    CustomerZipCode = "75260",
                    CustomerPhone = "972-555-9938"
                },
                new Customer
                {
                    CustomerID = 22,
                    CustomerFirstName = "Caleb",
                    CustomerLastName = "Viescas",
                    CustomerAddress = "4501 Wetland Road",
                    CustomerCity = "Long Beach",
                    CustomerState = "CA",
                    CustomerZipCode = "90809",
                    CustomerPhone = "562-555-0037"
                },
                new Customer
                {
                    CustomerID = 23,
                    CustomerFirstName = "Julia",
                    CustomerLastName = "Schnebly",
                    CustomerAddress = "2343 Harmony Lane",
                    CustomerCity = "Seattle",
                    CustomerState = "WA",
                    CustomerZipCode = "99837",
                    CustomerPhone = "206-555-9936"
                },
                new Customer
                {
                    CustomerID = 24,
                    CustomerFirstName = "Mark",
                    CustomerLastName = "Rosales",
                    CustomerAddress = "323 Advocate Lane",
                    CustomerCity = "El Paso",
                    CustomerState = "TX",
                    CustomerZipCode = "79915",
                    CustomerPhone = "915-555-2286"
                },
                new Customer
                {
                    CustomerID = 25,
                    CustomerFirstName = "Maria",
                    CustomerLastName = "Patterson",
                    CustomerAddress = "3445 Cheyenne Road",
                    CustomerCity = "El Paso",
                    CustomerState = "TX",
                    CustomerZipCode = "79915",
                    CustomerPhone = "915-555-2291"
                },
                new Customer
                {
                    CustomerID = 26,
                    CustomerFirstName = "Kirk",
                    CustomerLastName = "DeGrasse",
                    CustomerAddress = "455 West Palm Ave",
                    CustomerCity = "San Antonio",
                    CustomerState = "TX",
                    CustomerZipCode = "78284",
                    CustomerPhone = "210-555-2311"
                },
                new Customer
                {
                    CustomerID = 27,
                    CustomerFirstName = "Luke",
                    CustomerLastName = "Patterson",
                    CustomerAddress = "877 145th Ave SE",
                    CustomerCity = "Portland",
                    CustomerState = "OR",
                    CustomerZipCode = "97208",
                    CustomerPhone = "503-555-2316"
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {

                });
        }
    }
}
