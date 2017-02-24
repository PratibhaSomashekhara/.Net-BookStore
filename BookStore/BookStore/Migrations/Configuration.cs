namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookStore.Models;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BookStore.Models.ProductContext";
        }

        protected override void Seed(BookStore.Models.ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.AddOrUpdate(c));
            GetProducts().ForEach(p => context.Products.AddOrUpdate(p));
            //base.Seed(context);
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
            new Category
            {
                CategoryID=1,
                CategoryName = "Comic"
            },
            new Category
            {
                CategoryID=2,
                CategoryName = "Magazines"
            },
            new Category
            {
                CategoryID=3,
                CategoryName = "Novel"
            },
            new Category
            {
                CategoryID=4,
                CategoryName = "General Knowledge"
            },
            new Category
            {
                CategoryID=5,
                CategoryName = "Fiction"
            },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    ProductName="Batman:The Killing Joke" ,
                    Description ="Batman: The Killing Joke is a 1988 DC Comics one-shot graphic novel featuring the characters Batman and the Joker written by Alan Moore and illustrated by Brian Bolland ",
                    ImagePath="batman.jpg",
                    unitPrice=26,
                    CategoryID=1
                },
                 new Product
                {
                    ProductID=2,
                    ProductName="Born Again" ,
                    Description ="Born Again is a 1986 comic book story arc that appeared in the Marvel Comics series Daredevil. Written by Frank Miller, and drawn by David Mazzucchelli, the storyline first appeared in Daredevil",
                    ImagePath="BornAgain.jpg",
                    unitPrice=12,
                    CategoryID=1
                },
               new Product
                {
                    ProductID=3,
                    ProductName="Locke & Key" ,
                    Description ="Joe Hill and Gabriel Rodriguez's Locke & Key unwinds into its fourth volume in Keys to the Kingdom",
                    ImagePath="LK.jpg",
                    unitPrice=6.23,
                    CategoryID=1
                },
             new Product
                {
                    ProductID=4,
                    ProductName="Absolute Planetary" ,
                    Description ="Collecting the adventures of Elijah Snow, a powerful, hundred year old man, Jakita Wagner, an extremely powerful but bored woman, and The Drummer, a man with the ability to communicate with machines",
                    ImagePath="AP.jpg",
                    unitPrice=12.89,
                    CategoryID=1
                },
               new Product
                {
                    ProductID=5,
                    ProductName="Discover Magazine-The Origins of Dogs" ,
                    Description ="Most of us agree that dogs are our best friends, but scientists don't agree on when that bond was forged. New genetic research is helping pinpoint the roots of canine domestication. Did you know that nothing really matters — at least when it comes to studying space? The barren voids out there are more important than you'd think. And, speaking of space, USSR cosmonaut Sergei Krikalev was stranded aboard the Mir space station while his country unraveled and modern Russia was born. This is his story",
                    ImagePath="dog.jpg",
                    unitPrice=15.90,
                    CategoryID=2
                },
               new Product
                {
                    ProductID=6,
                    ProductName="Discover Magazine-Mystery on MAMMOTH ISLAND" ,
                    Description ="Long ago, a special population of mammoths once called an island in the Bering Sea home. Now, researchers are digging into the mud at St. Paul Island to discover what drove them to extinction. Then, meet James Allison, a doctor who is fighting cancer his own way: hacking patients' immune systems. Learn how he is changing the cancer game.",
                    ImagePath="dm.jpg",
                    unitPrice=6.78,
                    CategoryID=2
                },
              new Product
                {
                    ProductID=7 ,
                    ProductName="The Missing Moon files" ,
                    Description ="Seiichi Nagihara began to sweat as he dug through long-forgotten boxes in a cluttered basement storeroom at a Columbia University outpost in Palisades, N.Y. But the trim 54-year-old kept working. It was June 2013, and he had come all the way from Texas to search for decades-old clues about the moon. Nagihara pawed through the yellowing files of Marcus Langseth, a Columbia geologist who died in 1997. ",
                    ImagePath="mm.jpg",
                    unitPrice=15.12,
                    CategoryID=2
                },
               new Product
                {
                    ProductID=8,
                    ProductName="Cooking up  early earth conditions" ,
                    Description ="In Jeffrey Bada’s laboratory at the University of California, San Diego, there’s a cardboard box containing the earliest evidence of how life began on Earth. The box holds hundreds of tiny vials filled with grimy, brown residues collected in the early 1950s by a University of Chicago graduate student named Stanley Miller",
                    ImagePath="dq.jpg",
                    unitPrice=12.12,
                    CategoryID=2
                },
             new Product
                {
                    ProductID=9,
                    ProductName="In Search of Lost Time by Marcel Proust" ,
                    Description ="Swann's Way, the first part of A la recherche de temps perdu, Marcel Proust's seven-part cycle, was published in 1913. In it, Proust introduces the themes that run through the entire work.",
                    ImagePath="mp.jpg",
                    unitPrice=17.67,
                    CategoryID=3
                },
                new Product
                {
                    ProductID=10,
                    ProductName="Don Quixote by Miguel de Cervantes" ,
                    Description ="Alonso Quixano, a retired country gentleman in his fifties, lives in an unnamed section of La Mancha with his niece and a housekeeper. He has become obsessed with books of chivalry, and believes their every word to be true, despite the fact that many of the events in them are clearly impossible. Quixano eventually appears to other people to have lost his mind from little sleep and food and because of so much reading.",
                    ImagePath="dq.jpg",
                    unitPrice=19.67,
                    CategoryID=3
                },
                 new Product
                {
                    ProductID=11,
                    ProductName="Hamlet" ,
                    Description ="The Tragedy of Hamlet, Prince of Denmark, or more simply Hamlet, is a tragedy by William Shakespeare, believed to have been written between 1599 and 1601. The play, set in Denmark, recounts how Prince Hamlet exacts revenge on his uncle Claudius, who has murdered Hamlet's father, the King, and then taken the throne and married Gertrude, Hamlet's mother. The play vividly charts the course of real and feigned madness—from overwhelming grief to seething rage—and explores themes of treachery, revenge, incest, and moral corruption.",
                    ImagePath="h.jpg",
                    unitPrice=21.68,
                    CategoryID=3
                },
                 new Product
                {
                    ProductID=12,
                    ProductName=" Lolita" ,
                    Description ="The book is internationally famous for its innovative style and infamous for its controversial subject: the protagonist and unreliable narrator, middle aged Humbert Humbert, becomes obsessed and sexually involved with a twelve-year-old girl named Dolores Haze.",
                    ImagePath="l.jpg",
                    unitPrice=18.28,
                    CategoryID=3
                },
               new Product
                {
                    ProductID=13,
                    ProductName=" Pride and Prejudice" ,
                    Description ="The book is narrated in free indirect speech following the main character Elizabeth Bennet as she deals with matters of upbringing, marriage, moral rightness and education in her aristocratic society. Though the book's setting is uniquely turn of the 19th century, it remains a fascination of modern readership, continuing to remain at the top of lists titled most loved books of all time, and receiving considerable attention from literary critics. This modern interest has resulted in a number of dramatic adaptations and a plethora of books developing Austen's memorable characters further.",
                    ImagePath="pp.jpg",
                    unitPrice=18.45,
                    CategoryID=3
                },
               new Product
                {
                    ProductID=14,
                    ProductName="Student's Encyclopedia of General Knowledge",
                    Description ="This encyclopedia is the best source of information and reference in a single volume, particularly for students of classes III to VIII. It provides the best of GK to its readers. Every piece of information is authentic - culled together from several areas of knowledge ranging from encyclopedias, fact books, year books, official government releases, internet and other reliable sources - and verified for accuracy. ",
                    ImagePath="gk.jpg",
                    unitPrice=18.23,
                    CategoryID=4
                },
              new Product
                {
                    ProductID=15,
                    ProductName="The Book of Werewolves" ,
                    Description ="Eclectic British scholar SABINE BARING-GOULD (1834-1924) inspired My Fair Lady, wrote the hymn Onward Christian Soldiers, and published more than five hundred literary works. Among his foremost folkloric studies is 1865's The Book of Werewolves, the first serious academic study of the shape-shifters of mythological lore. This work is the most frequently cited early study of lycanthropy and is regarded by most scholars as the foundation work in the field, says cryptozoologist Loren Coleman in his new introduction. The Book of Werewolves was so visionary that it foresaw that future discussions within werewolf studies would necessarily travel down many side paths. Indeed, midway through The Book of Werewolves, Baring-Gould treks into the shadowy world of crimes vaguely connected to werewolves, including serial murders, grave desecration, and cannibalism. This new edition, complete with the original illustrations, is part of Cosimos Loren Coleman Presents series. LOREN COLEMAN is author of numerous books of cryptozoology, including Bigfoot!: The True Story of Apes in America and Mothman and Other Curious Encounters.",
                    ImagePath="ww.jpg",
                    unitPrice=18.67,
                    CategoryID=4
                },
                new Product
                {
                    ProductID=16,
                    ProductName="Mastering the World of Selling: The Ultimate Training Resource from the Biggest Names in Sales" ,
                    Description ="Of the 17 million people in the U.S. who are involved directly or indirectly in sales, many repeatedly acknowledge facing four major challenges:No prior sales education or training Lack of formalized sales training, resources, and methodologies provided by their companies Due to the recession and downsizing era, lack of 12-18 month professional sales training for new hires provided by Fortune 500 companies A consistent struggle to keep their sales force, distributors, manufacturers reps and affiliates motivated and focused on effectively selling their products and services Mastering the World of Selling helps companies and entrepreneurs overcome these four major obstacles with candid advice and winning strategies from the leading sales trainers and training companies in the world",
                    ImagePath ="mw.jpg",
                    unitPrice=18.26,
                    CategoryID=4
                },
                new Product
                {
                    ProductID=17,
                    ProductName="National Geographic Kids Why?: Over 1,111 Answers to Everything" ,
                    Description ="The concept is simple. Got a question? Well now you have an answer! 1,111 of them, in fact. Want to know why your snot is yellow? Flip to the human body chapter. What's on the inside of a turtle shell? The animal section's got you covered. What's in the deepest part of the ocean? Why doesn't Earth just float off into space? Check, check, and check. With hundreds of topics ranging from silly to serious, we've got the expert information you need in a fun and entertaining format that will keep kids digging for answers. Answers include all kinds of fascinating extra info like top ten lists, weird-but-true facts, explorer profiles, and cool activities. Now, go stump your parents!",
                    ImagePath="why.jpg",
                    unitPrice=10.78,
                    CategoryID=4
                },
                new Product
                {
                    ProductID=18,
                    ProductName="The Perfect Girl" ,
                    Description ="Gilly Macmillan is the Edgar Nominated and New York Times bestselling author of What She Knew. She grew up in Swindon, Wiltshire and lived in Northern California in her late teens. She worked at The Burlington Magazine and the Hayward Gallery before starting a family. Since then she's worked as a part-time lecturer in photography, and now writes full-time. She resides in Bristol, England.",
                    ImagePath="pg.jpg",
                    unitPrice=9.50,
                    CategoryID=5
                },
                new Product
                {
                    ProductID=19,
                    ProductName="Fahrenheit 451" ,
                    Description ="Fahrenheit 451 is a dystopian novel by Ray Bradbury, published in 1953. It is regarded as one of his best works. The novel presents a future American society where books are outlawed and firemen burn any that are found.",
                    ImagePath="F.jpg",
                    unitPrice=21.67,
                    CategoryID=5
                },
                new Product
                {
                    ProductID=20,
                    ProductName="The Book Thief" ,
                    Description ="This is a devastatingly powerful book that bears several re-readings, and should become a staple of literature discussion groups for sophisticated teen and adult readers",
                    ImagePath="book.jpg",
                    unitPrice=12.90,
                    CategoryID=5
                },
            };
            return products;
        }
    }
}
