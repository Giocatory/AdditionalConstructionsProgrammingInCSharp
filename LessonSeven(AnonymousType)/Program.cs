var purchaseItem = new
{
    TimeBought = DateTime.Now,
    ItemBought = new
    {
        Color = "Red",
        Make = "Saab",
        CurrentSpeed = 55
    }
};
Console.WriteLine(purchaseItem);
Console.WriteLine(purchaseItem.TimeBought);
Console.WriteLine(purchaseItem.ItemBought.Color);