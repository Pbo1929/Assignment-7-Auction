using System;

namespace Assignment_7_Auction
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] Items = new Item[5];
            Items[0] = new Item("Diamond", "A rare diamond.", 100000, 90000, 123);
            Items[1] = new Item("Gold", "A rare gold.", 2000, 1600, 321);
            Items[2] = new Item("Silver", "A rare silver.", 500, 300, 125);

            Items[1].setHighestBid(1000000, 199);

            Items[2].setHighestBid(20000, 199);

            for (int i = 0; i < Items.Length; i++)
                if (Items[i] != null)
            {
                if (Items[i].GetHighestBid() > Items[i].GetReservePrice())
                {
                
                    Console.WriteLine("ITEM NAME:" + Items[i].GetName());
                    Console.WriteLine("SOLD FOR:" + Items[i].GetHighestBid());
                    Console.WriteLine("BIDDER:" + Items[i].GetID());
                }
            }

            
        }
        }
    }