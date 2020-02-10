using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingItem> shoppingList = new List<ShoppingItem>(20);

            shoppingList.Add(new ShoppingItem() {itemName = "Apples", price = 0.95, quantity = 6});
            shoppingList.Add(new ShoppingItem() {itemName = "Milk", price = 2.25, quantity = 1});
            shoppingList.Add(new ShoppingItem() {itemName = "Sugar", price = 1.75, quantity = 2});
            shoppingList.Add(new ShoppingItem() {itemName = "Bread", price = 3.25, quantity = 1});
            shoppingList.Add(new ShoppingItem() {itemName = "Butter", price = 4.95, quantity = 1});
            shoppingList.Add(new ShoppingItem() {itemName = "Cookies", price = 0.50, quantity = 4});
            shoppingList.Add(new ShoppingItem() {itemName = "Oranges", price = 0.65, quantity = 5});
            shoppingList.Add(new ShoppingItem() {itemName = "Chicken", price = 8.95, quantity = 1});

            foreach (ShoppingItem ge in shoppingList) {
                Console.WriteLine("Item: {0,10}, Price: {1:C}, Quantity: {2}",
                    ge.itemName, ge.price, ge.quantity);
            }
        }
    }

    public class ShoppingItem {
        public String itemName;
        public double price;
        public int quantity;
    }
}
