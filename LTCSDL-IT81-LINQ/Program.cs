using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LTCSDL_IT81_LINQ
{
    class Program
    {
		delegate int Transformer(int x);

		static int Square(int x) { return x * x; }
		// hoặc
		static int Square1(int x) => x * x;

		static void BuildAnonType(string make, string color, int currSp)
		{
			// Build anon type using incoming args.
			var car = new
			{
				Make = make,
				Color = color,
				Speed = currSp
			};
			// Note you can now use this type to get the property data!
			Console.WriteLine("You have a {0} {1} going {2} MPH",
						car.Color, car.Make, car.Speed);
			// Anon types have custom implementations of each virtual 
			// method of System.Object. For example:
			Console.WriteLine("ToString() == {0}", car.ToString());
		}

		static void QueryOverInts()
		{
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
			// Print only items less than 10.
			IEnumerable<int> subset = from i in numbers
									  where i < 10
									  select i;
			foreach (int i in subset)
				Console.WriteLine("Item: {0}", i);
		}

		static void QueryOverStrings()
		{
			string[] fruits = { "Chuoi", "Thanh Long", "Sau rieng", "Cam", "Dua hau" };

			IEnumerable<string> subset = from g in fruits
										 where g.Contains(" ")
										 orderby g
										 select g;

			foreach (string s in subset)
				Console.WriteLine("Item: {0}", s);
		}

		//Slide 47
		static PetOwner[] GetPetList()
		{
			PetOwner[] petOwners =
				{ new PetOwner { Name="Bảo",
			  Pets = new List<string>{ "Chó", "Mèo" } },
		  new PetOwner { Name="Thảo",
			  Pets = new List<string>{ "Két", "Cá sấu" } },
		  new PetOwner { Name="Tâm",
			  Pets = new List<string>{ "Chuột", "Chó" } } };
			return petOwners;
		}





		static void Main(string[] args)
        {
			//Slide 8
			// Implicitly typed local variables.
			var myInt = 0;
			var myBool = true;
			var myString = "Time, marches on...";
			// Print out the underlying type.
			Console.WriteLine("myInt is a: {0}",
			myInt.GetType().Name);
			Console.WriteLine("myBool is a: {0}",
			myBool.GetType().Name);
			Console.WriteLine("myString is a: {0}",
			myString.GetType().Name);

			/*
			//Slide 10
			// Make a Point by setting each property manually.
			Point firstPoint = new Point();
			firstPoint.X = 10;
			firstPoint.Y = 10;
			firstPoint.DisplayStats();

			// Or make a Point via a custom constructor.
			Point anotherPoint = new Point(20, 20);
			anotherPoint.DisplayStats();

			// Or make a Point using object init syntax.
			Point finalPoint = new Point { X = 30, Y = 30 };
			finalPoint.DisplayStats();

			Console.ReadLine();
			*/

			//Slide 11
			List<Point> myListOfPoints = new List<Point>
			{
				new Point { X = 2, Y = 2 },
				new Point { X = 3, Y = 3 },
			};

			foreach (var pt in myListOfPoints)
			{
				Console.Write("Point: ");
				pt.DisplayStats();
				Console.WriteLine();
			}

			/*
			//Slide 13, 15
			Transformer t = Square1; // Create delegate instance
									// hoặc
									//Transformer t = new Transformer(Square); 

			int result = t(3); // Invoke delegate
							   // hoặc
							   //int result = t.Invoke(3);

			Console.WriteLine(result); // 9
			*/

			/*
			//Slide 20
			int myInt1 = 12345678;
			// Use new integer functionality.
			Console.WriteLine("Value of myInt: {0}", myInt1);
			Console.WriteLine("Reversed digits of myInt: {0}",
			myInt.ReverseDigits());
			Console.ReadLine();
			*/

			/*
			//Slide 23
			// Make an anonymous type representing a car.
			var myCar = new
			{
				Color = "Bright Pink",
				Make = "Saab",
				CurrentSpeed = 55
			};
			// Now show the color and make.
			Console.WriteLine("My car is a {0} {1}.",
				myCar.Color, myCar.Make);
			// Now call our helper method to build anonymous type via args.
			BuildAnonType("BMW", "Black", 90);
			Console.ReadLine();
			*/

			//Slide 27
			QueryOverInts();

			//Slide 29
			QueryOverStrings();

			//Slide 31
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			IEnumerable<int> query = nums.Where(n => n % 2 == 0);

			foreach (var n in query)
			{
				Console.WriteLine("{0}", n);
			}

			//Slide 35
			List<Car> myCars = new List<Car>()
			{
				new Car{ PetName = "Xe1", Color = "Bạc", Speed = 100, Make = "BMW"},
				new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
				new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
				new Car{ PetName = "X4", Color = "Trắng", Speed = 43, Make = "Ford"}
			};

			//Slide 38
			Categories[] categories = new[]
			{
				new Categories {CategoryId = 1, CategoryName = "Nuoc ngot" },
				new Categories {CategoryId = 2, CategoryName = "Van phong pham" },
				new Categories {CategoryId = 3, CategoryName = "Thuc pham" }
			};

			Products[] products = new[]
			{
				new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
				new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
				new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
			};

			/*
			//SLide 39
			var allProducts = from p in products
							  select p;

			foreach (var prod in allProducts)
			{
				Console.WriteLine(prod.ToString());
			}
			*/

			//Slide 40
			var allProducts = products.Select(n => n);

			foreach (var prod in allProducts)
			{
				Console.WriteLine(prod.ToString());
			}

			/*
			//Slide 41
			var nameDesc = from p in products
						   select new
						   {
							   p.ProductId,
							   p.ProductName
						   };

			foreach (var item in nameDesc)
			{
				Console.WriteLine(item.ToString());
			}
			*/

			//Slide 42
			var nameDesc =
			products.Select(p => new { p.ProductId, p.ProductName });

			foreach (var item in nameDesc)
			{
				Console.WriteLine(item.ToString());
			}

            /*
			//Slide 43
			Console.WriteLine("The overstock items!");

			var overstock = from p in products
							where p.NumberInStock > 25
							select p;

			foreach (Products c in overstock)
			{
				Console.WriteLine(c.ToString());
			}
			*/

            //Slide 44
            Console.WriteLine("The overstock items!");

            var overstock = products.Where(p => p.NumberInStock > 25);

            foreach (Products c in overstock)
            {
                Console.WriteLine(c.ToString());
            }


            // Slide 45
            //Extract the ints from the ArrayList.
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });

            var myInts = myStuff.OfType<int>();

            // Prints out 10, 400, and 8.
            foreach (int i in myInts)
            {
                Console.WriteLine("Int value: {0}", i);
            }

            //Slide 46
            ArrayList myCars1 = new ArrayList()
            {
                new Car{ PetName = "Xe1", Color = "Bạc", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
                new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
                new Car{ PetName = "X4", Color = "Trắng", Speed = 43, Make = "Ford"}
            };
            // Transform ArrayList into an IEnumerable<T> compatible type.
            var myCarsEnum = myCars1.OfType<Car>();
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }

            //Slide 47
            PetOwner[] petList = GetPetList();

            var query1 = from O in petList
                         from p in O.Pets
                         select p;

            foreach (var p in query1)
            {
                Console.WriteLine(p);
            }

            //Slide 49
            IEnumerable<string> query2 = petList.SelectMany(petOwner => petOwner.Pets);

            Console.WriteLine("Using SelectMany():");

            foreach (string pet in query2)
            {
                Console.WriteLine(pet);
            }

            //Slide 50
            IEnumerable<List<String>> query3 = petList.Select(petOwner => petOwner.Pets);

            // Notice that two foreach loops are required to 
            // iterate through the results
            // because the query returns a collection of arrays.
            foreach (List<String> petlist in query3)
            {
                foreach (string pet in petlist)
                {
                    Console.WriteLine(pet);
                }
                Console.WriteLine();
            }

            //Slide 51
            var subset = from p in products
						 orderby p.ProductName descending
						 select p;

			Console.WriteLine("Ordered by Name:");
			foreach (var p in subset)
			{
				Console.WriteLine(p.ToString());
			}

			//Slide 52
			var subset1 = products.OrderBy(p => p.ProductName);
			//var subset = 
			products.OrderByDescending(p => p.ProductName);

			Console.WriteLine("Ordered by Name:");
			foreach (var p in subset1)
			{
				Console.WriteLine(p.ToString());
			}

			//SLide 53
			var subset3 = products.OrderBy(p => p.ProductName).ThenBy(p => p.ProductId);
			//var subset = products.OrderByDescending(p => p.ProductName);

			Console.WriteLine("Ordered by Name:");
			foreach (var p in subset3)
			{
				Console.WriteLine(p.ToString());
			}

			//Slide 54
			var query4 = from p in products
						group p by p.CategoryId;

			foreach (var category in query4)
			{
				Console.WriteLine("CategoryId: {0}", category.Key);
				foreach (Products item in category)
				{
					Console.WriteLine(item);
				}
			}

			//SLide 55
			var query5 = products.GroupBy(p => p.CategoryId);

			foreach (var category in query5)
			{
				Console.WriteLine("CategoryId: {0}", category.Key);
				foreach (Products item in category)
				{
					Console.WriteLine(item);
				}
			}

			//Slide 56
			var query6 = from p in products
						join c in categories
						on p.CategoryId equals c.CategoryId
						group p by new
						{
							c.CategoryId,
							c.CategoryName
						};

			foreach (var category in query6)
			{
				Console.WriteLine(category.Key);
				foreach (Products item in category)
				{
					Console.WriteLine(item);
				}
			}

			//Slide 57
			var query7 = from p in products
						group p by p.CategoryId into g
						select new
						{
							Catgory = g.Key,
							Prods = g
						};

			foreach (var item in query7)
			{
				Console.WriteLine(item.Catgory);
				foreach (Products p in item.Prods)
				{
					Console.WriteLine(p);
				}
			}

			//SLide 58
			var query8 = products.GroupBy(p => p.CategoryId, p => p);


			foreach (var item in query8)
			{
				Console.WriteLine(item.Key);
				foreach (Products pa in item)
				{
					Console.WriteLine(pa);
				}
			}

			//Slide 59
			string[] strings =
			{
				"A penny saved is a penny earned.",
				"The early bird catches the worm.",
			};

			var earlyBirdQuery =
				from sentence in strings
				let words = sentence.Split(' ')
				from word in words
				let w = word.ToLower()
				where w[0] == 'a' || w[0] == 'e' || w[0] == 'i'
					|| w[0] == 'o' || w[0] == 'u'
				select word;

			foreach (var v in earlyBirdQuery)
			{
				Console.WriteLine("\"{0}\" starts with a vowel", v);
			}

			//Slide 60
			var query9 = from c in categories
						join p in products
						on c.CategoryId equals p.CategoryId
						select new
						{
							p.ProductId,
							p.ProductName
						};

			foreach (var item in query9)
			{
				Console.WriteLine(item);
			}

			//Slide 61
			var query10 = categories.Join(products, c => c.CategoryId, p => p.CategoryId, (c, p) => new
			{
				p.ProductId,
				p.ProductName,
				c.CategoryId
			});

			foreach (var item in query10)
			{
				Console.WriteLine(item);
			}

			//SLide 64
			var allProducts1 = from p in products
							  select p;

			foreach (var prod in allProducts1.Reverse())
			{
				Console.WriteLine(prod.ToString());
			}

			//Slide 65
			List<string> myCars2 = new List<String> { "Ford", "Honda", "Toyota" };
			List<string> yourCars =
				new List<String> { "BMW", "Toyota", "Hyundai" };

			var carConcat = (from c in myCars2 select c).
				Concat(from c2 in yourCars select c2);

			foreach (string s in carConcat.Distinct())
				Console.WriteLine(s);

			//SLide 66
			var carUnion = (from c in myCars2 select c).
				Union(from c2 in yourCars select c2);

			Console.WriteLine("Here is everything:");
			foreach (string s in carUnion)
				Console.WriteLine(s);

			//SLide 67
			var carIntersect = (from c in myCars2 select c).
			Intersect(from c2 in yourCars select c2);

			Console.WriteLine("Here is what we have in common: ");
			foreach (string s in carIntersect)
				Console.WriteLine(s); // Printa Toyota.

			//Slide 68
			var carDiff = (from c in myCars2 select c).
			Except(from c2 in yourCars select c2);

			Console.WriteLine("Here is what you don’t have, but I do:");
			foreach (string s in carDiff)
				Console.WriteLine(s);

			//Slide 69
			List<int> nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var query11 = (from n in nums
						 select n).Take(3);

			foreach (int num1 in query11)
			{
				Console.WriteLine(num1);
			}

			//SLide 70
			var query12 = (from n in nums
						 select n).Skip(3);

			foreach (int num1 in query12)
			{
				Console.WriteLine(num1);
			}

			// Slide 71
			var query13 = (from n in nums
						 select n).TakeWhile(n => n % 5 != 0);

			foreach (int num1 in query13)
			{
				Console.WriteLine(num1);
			}

			// SLide 72
			List<string> myCars3 = new List<String> { "Ford", "Honda", "Toyota" };
			List<string> yourCars3 = new List<String> { "BMW", "Toyota", "Hyundai" };

			var carConcat3 = (from c in myCars3 select c).Concat(from c2 in yourCars3 select c2);

			foreach (string s in carConcat3)
				Console.WriteLine(s);

			// Slide 73
			double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

			Console.WriteLine("Max temp: {0}",
				(from t in winterTemps select t).Max());

			Console.WriteLine("Min temp: {0}",
				(from t in winterTemps select t).Min());

			Console.WriteLine("Average temp: {0}",
				(from t in winterTemps select t).Average());

			Console.WriteLine("Sum of all temps: {0}",
				(from t in winterTemps select t).Sum());

			Console.WriteLine("Count all temps: {0} ", (from t in winterTemps select t).Count());

			// SLide 75
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

			// Get data RIGHT NOW as int[].
			int[] subsetAsIntArray = (from i in numbers
									  where i < 10
									  select i).ToArray<int>();

			// Get data RIGHT NOW as List<int>.
			List<int> subsetAsListOfInts = (from i in numbers
											where i < 10
											select i).ToList<int>();

			int[] subsetAsIntArray1 = (from i in numbers where i < 10 select i).ToArray();

			// SLide 77
			var values = Enumerable.Range(1, 20);
			foreach (var v in values)
			{
				Console.WriteLine("{0} ", v);
			}

			// SLide 78
			var values1 = Enumerable.Empty<string>();
			foreach (var v in values1)
			{
				Console.WriteLine("{0} ", v);
			}

			// SLide 79
			IEnumerable<int> values2 = Enumerable.Repeat(1, 3);
			foreach (int v in values2)
			{
				Console.WriteLine(v);
			}

			// SLide 81
			List<int> nums4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int first = nums4.First();
			//int first = nums4.First(n => n % 2 == 0);
			Console.WriteLine(first);

			// Slide 82
			string[] fruits1 = { "orange" };
			string fruit1 = fruits1.Single();
			Console.WriteLine(fruit1);

			// Slide 83
			string[] fruits2 = { "orange", "apple" };
			string fruit2 = null;
			try
			{
				fruit2 = fruits2.Single();
			}
			catch (System.InvalidOperationException)
			{
				Console.WriteLine("The collection does not contain exactly one element.");
			}
			Console.WriteLine(fruit2);

			// Slide 85
			List<int> nums5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int num = nums5.ElementAt(2);
			Console.WriteLine(num);

		}









	}
}

