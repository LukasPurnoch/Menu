using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_Menu
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false; //Removes the bliking line
			drawMenu(new string[] {
				"Hello!",
				"Menu item 2",
				"Exit",
			});
		}

		public static int drawMenu(string[] menuItems)
		{
			int selectedItem = 0;
			while (true)
			{
				for (int i = 0; i < menuItems.Length; i++)
				{
					if (selectedItem == i)
					{
						Console.BackgroundColor = ConsoleColor.Gray;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(menuItems[i]);
						Console.ResetColor();
					}
					else
					{
						Console.WriteLine(menuItems[i]);
					}
				}

				ConsoleKeyInfo cki = Console.ReadKey();

				switch (cki.Key)
				{
					case ConsoleKey.UpArrow:
						if ((selectedItem - 1) < 0)
						{
							selectedItem = menuItems.Length - 1;
						}
						else
						{
							selectedItem--;
						}

						break;
					case ConsoleKey.DownArrow:
						if ((selectedItem + 1) > menuItems.Length - 1)
						{
							selectedItem = 0;
						}
						else
						{
							selectedItem++;
						}
						break;


					case ConsoleKey.Enter:

						if (menuItems[selectedItem] == "Exit")
						{
							Environment.Exit(0);
						}
						else if (menuItems[selectedItem] == "Hello!")
						{
							Console.WriteLine("Hello there!");
							Thread.Sleep(10000);
						}

						break;
				}
				Console.Clear();
			}
		}
	}
}

//Third times a charm....
