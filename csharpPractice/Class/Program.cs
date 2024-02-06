using Classes;

WaterBottle waterBottle = new WaterBottle(100);
waterBottle.Water = 10;
waterBottle.AddWater(30);

WaterBottle waterBottle2 = new WaterBottle(200);
waterBottle2.Water = 20;
waterBottle2.AddWater(50);

Console.WriteLine("Water in Bottle 1:" + waterBottle.Water);
Console.WriteLine("Water in Bottle 2:" + waterBottle2.Water);