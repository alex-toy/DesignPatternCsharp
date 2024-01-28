using BuilderOk;
using BuilderOk.CarBuilders;
using BuilderOk.Options;

Console.WriteLine("Builder Ok");

Car car;

var aCarBuilder = new ACarBuilder("base model")
{
    AOptions = new List<AOption>() {
        new AOption(){ Name = "optionA1", Price = 25 },
        new AOption(){ Name = "optionA2", Price = 25 },
    }
};
car = CarMaker.MakeCar(aCarBuilder);
Console.WriteLine(car.ToString());


var bCarBuilder = new BCarBuilder("sport model")
{
    BOptions = new List<BOption>() {
        new BOption(){ Name = "optionB1", Price = 200 },
        new BOption(){ Name = "optionB2", Price = 200 },
    }
};
car = CarMaker.MakeCar(bCarBuilder);
Console.WriteLine(car.ToString());


var bcCarBuilder = new BCCarBuilder("luxury model")
{
    BOptions = new List<BOption>() {
        new BOption(){ Name = "optionB1", Price = 300 },
        new BOption(){ Name = "optionB2", Price = 300 },
    },
    COptions = new List<COption>() {
        new COption(){ Name = "optionC1", Price = 300 },
        new COption(){ Name = "optionC2", Price = 300 },
    }
};
car = CarMaker.MakeCar(bcCarBuilder);
Console.WriteLine(car.ToString());


var adCarBuilder = new ADCarBuilder("mixed model")
{
    AOptions = new List<AOption>() {
        new AOption(){ Name = "optionA1", Price = 150 },
        new AOption(){ Name = "optionA2", Price = 150 },
    },
    DOptions = new List<DOption>() {
        new DOption(){ Name = "optionD1", Price = 150 },
        new DOption(){ Name = "optionD2", Price = 150 },
    }
};
car = CarMaker.MakeCar(adCarBuilder);
Console.WriteLine(car.ToString());