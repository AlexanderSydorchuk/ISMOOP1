using System;

namespace SimpleClassConsole
{
    class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\\
        public int GetYear() 
        {
            return Year;
        }

        public void SetYear(int Year)
        {
            if (Year >= 2020)
            {
                this.Year = Year;
            }
        }

        ///////////////////////////////////////////////////
        public int GetMonth() 
        {
            return Month;
        }

        public void SetMonth(int Month)
        {
            if (Month > 12)
            {
                this.Month = 12;
            }
            else if (Month < 1)
            {
                this.Month = 1;
            }
            else { this.Month = Month; }
        }

        ///////////////////////////////////////////////////
        public int GetDay() 
        {
            return Day;
        }

        public void SetDay(int Day)
        {
            if (Day > 31)
            {
                this.Day = 31;
            }
            else if (Day < 1)
            {
                this.Day = 1;
            }
            else { this.Day = Day; }
        }

        ///////////////////////////////////////////////////
        public int GetHours()
        {
            return Hours;
        }

        public void SetHours(int Hours)
        {
            if (Hours > 23)
            {
                this.Hours = 23;
            }
            else if (Hours < 0)
            {
                this.Hours = 0;
            }
            else { this.Hours = Hours; }
        }

        ///////////////////////////////////////////////////
        public int GetMinutes()
        {
            return Minutes;
        }

        public void SetMinutes(int Minutes)
        {
            if (Minutes > 59)
            {
                this.Minutes = 59;
            }
            else if (Minutes < 1)
            {
                this.Minutes = 1;
            }
            else { this.Minutes = Minutes; }
        }
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\\



        public Date()
        {
            Year = 2020;
            Month = 11;
            Day = 17;
            Hours = 12;
            Minutes = 00;
        }

        public Date(int Year, int Month, int Day, int Hours, int Minutes)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
        public Date(int Day, int Hours, int Minutes)
        {
            Year = 2020;
            Month = 11;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }

        public Date(Date d)
        {
            Year = d.Year;
            Month = d.Month;
            Day = d.Day;
            Hours = d.Hours;
            Minutes = d.Minutes;
        }
    }








    class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;




        public Date GetStartDate()
        {
            return StartDate;
        }

        public void SetStartDate(Date StartDate)
        {
            if (StartDate.GetDay() >= 1 && StartDate.GetDay() <= 31
                 && StartDate.GetHours() >= 0 && StartDate.GetHours() <= 23
                 && StartDate.GetMonth() >= 1 && StartDate.GetMonth() <= 12
                 && StartDate.GetMinutes() >= 1 && StartDate.GetMinutes() < 60)
            {
                this.StartDate = StartDate;
            }
        }


        public Date GetFinishDate()
        {
            return FinishDate;
        }

        public void SetFinishDate(Date FinishDate)
        {
            if (FinishDate.GetDay() >= 1 && FinishDate.GetDay() <= 31
                && FinishDate.GetHours() >= 0 && FinishDate.GetHours() <= 23
                && FinishDate.GetMonth() >= 1 && FinishDate.GetMonth() <= 12
                && FinishDate.GetMinutes() >= 1 && FinishDate.GetMinutes() < 60)
            {
                this.FinishDate = FinishDate;
            }
        }

        public string GetStartCity()
        {
            return StartCity;
        }

        public void SetStartCity(string StartCity)
        {
            this.StartCity = StartCity;
        }

        public string GetFinishCity()
        {
            return FinishCity;
        }

        public void SetFinishCity(string FinishCity)
        {
           this.FinishCity = FinishCity;
        }




        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "London";
            Date StartDate = new Date();
            Date FinishDate = new Date(17,15,00);
        }

        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
        }
        public Airplane(Airplane plane)
        {
            StartCity = plane.StartCity;
            FinishCity = plane.FinishCity;
            StartDate = plane.StartDate;
            FinishDate = plane.FinishDate;
        }

        public double GetTotalTime()
        {
            double minutes = 0;
            DateTime start_time = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            DateTime finish_time = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);

            minutes = (finish_time - start_time).TotalMinutes;

            return minutes;
        }

        public bool IsArrivingToday()
        {
            bool IsArriving;

            if (StartDate.GetDay() == FinishDate.GetDay())
            {
                IsArriving = true;
            }
            else
            {
                IsArriving = false;
            }

            return IsArriving;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"StartCity: {StartCity}");
            Console.WriteLine($"FinishCity: {FinishCity}");
            Console.WriteLine($"Total flight time in minutes: {GetTotalTime()}");
            Console.WriteLine($"IsArrivingToday: {IsArrivingToday()}");

            Console.WriteLine();
        }

    }







    class Product
    {
        protected string Name;
        protected float Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected float Weight;


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\\

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
                this.Name = Name;
        }

        /////////////////////////////////////////////////// 
        public float GetPrice()
        {
            return Price;
        }

        public void SetPrice(float Price)
        {
            this.Price = Price;
        }

        /////////////////////////////////////////////////// 
        public Currency GetCost()
        {
            return Cost;
        }

        public void SetCost(Currency Cost)
        {
            this.Cost = Cost;
        }


        /////////////////////////////////////////////////// 
        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int Quantity)
        {
            if (Quantity < 1)
            {
                this.Quantity = 1;
            }
            else
            {
                this.Quantity = Quantity;
            }
        }

        /////////////////////////////////////////////////// 
        public string GetProducer()
        {
            return Producer;
        }

        public void SetProducer(string Producer)
        {
                this.Producer = Producer;
        }

        /////////////////////////////////////////////////// 
        public float GetWeight()
        {
            return Weight;
        }

        public void SetWeight(float Weight)
        {
            this.Weight = Weight;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\\


        public Product()
        {
            Name = "Default";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "NA";
            Weight = 0;
        }

        public Product(string Name, float Price, Currency Cost, int Quantity, string Producer, float Weight)
        {
            this.Name = Name;
            this.Price = Price;
            this.Cost = Cost;
            this.Quantity = Quantity;
            this.Producer = Producer;
            this.Weight = Weight;
        }

        public Product(string Name, float Price)
        {
            this.Name = Name;
            this.Price = Price;
            Cost = new Currency();
            Quantity = 0;
            Producer = "NA";
            Weight = 0;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        
        public float GetPriceInUAH()
        {
            float price = GetPrice() * Cost.GetExRate();
            return price;
        }

        public float GetTotalPriceInUAH()
        {
            float price = GetPrice() * GetQuantity() * Cost.GetExRate();
            return price;
        }

        public float GetTotalWeight()
        {
            return GetQuantity() * GetWeight();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Producer: {Producer}");
            Console.WriteLine($"Weight: {Weight}");

            Console.WriteLine($"Price in UAH: {GetPriceInUAH()} grn");
            Console.WriteLine($"Total price in UAH: {GetTotalPriceInUAH()} grn");
            Console.WriteLine($"Total weight: {GetTotalWeight()} kg");

            Console.WriteLine();
        }

    }










    class Currency
    {
        protected string Name;
        protected float ExRate;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public float GetExRate()
        {
            return ExRate;
        }

        public void SetExRate(float ExRate)
        {
            this.ExRate = ExRate;
        }

        public Currency()
        {
            Name = "usd";
            ExRate = 8.00f;
        }
        public Currency(string Name, float ExRate)
        {
            this.Name = Name;
            this.ExRate = ExRate;
        }

        public Currency(float ExRate)
        {
            Name = "usd";
            this.ExRate = ExRate;
        }

        public Currency(Currency cur)
        {
            Name = cur.Name;
            ExRate = cur.ExRate;
        }
    }












    class Program
    {
        static void Main(string[] args)
        {

            Airplane B52 = new Airplane("Kyiv", "Berlin", new Date(2020,11,17,11,00), new Date(2020, 11, 17, 12, 05));
            Product support = new Product("Kinder", 1.5f, new Currency("usd", 28), 15000,"USA", 0.1f);

            B52.ShowInfo();
            support.ShowInfo();
        }
    }
}
