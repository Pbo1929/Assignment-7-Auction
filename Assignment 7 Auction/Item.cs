using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7_Auction
{
    class Item
    {
        private string name;
        private string description;
        private double ReservePrice;
        private double HighestBid;
        private int ID;
        public bool ChangeID = false;

        public Item(string name, string description, double ReservePrice, double HighestBid, int ID)
        {
            this.name = name;
            this.description = description;
            this.ReservePrice = ReservePrice;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }
        public double GetReservePrice()
        {
            return ReservePrice;
        }
        public double GetHighestBid()
        {
            return HighestBid;
        }
        public int GetID()
        {
            return ID;
        }
        public bool setHighestBid(int newBid, int newID)
        {
            if (newBid > HighestBid)
            {
                HighestBid = newBid;
                ID = newID;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetID(int newID)
        {
            if (ChangeID == true)
            {
                ID = newID;
            }
        }
    }
}
