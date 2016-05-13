using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab6
{
    

    class SalesCenter
    {
        private BuyersEntities context = new BuyersEntities();

        public SalesCenter()
        {
            AddTestData();
        }

        // добавление тестовых данных
        private void AddTestData()
        {
           if (context.Clients.Count() == 0)
           {
               AddClient("Иванов", "Иван", "Иванович", "г. Москва, ул. Ленина 1");
               AddClient("Бэггинс", "Бильбо", "", "г. Шир, Торба-на-круче");
               AddClient("Бэггинс", "Фродо", "", "г. Шир, Торба-на-круче");
               AddClient("Серый", "Гендальф", "", "нет прописки");
               AddClient("Поттер", "Гарри", "", "г. Литтл Уиндинг, ул. Тисовая 4");

               AddMerchandise("Палочка с волосом", 116);
               AddMerchandise("Хлеб", 12);
               AddMerchandise("Кольцо всевластия", 440);
               AddMerchandise("Табак", 23);
               AddMerchandise("Летучий порох", 56);
               AddMerchandise("Тушенка", 30);
               AddMerchandise("Конфеты", 18);
               AddMerchandise("Меч", 180);

               AddDiscount("Скидка для хоббитов", 15);
               AddDiscount("Скидка для магов", 10);
               AddDiscount("Общая цена", 0);

               context.SaveChanges();

               Buy buy = AddBuy("Бэггинс", "Фродо", "Скидка для хоббитов", DateTime.Today.Subtract(TimeSpan.FromDays(4)));
               AddBuyMerch(buy, "Конфеты", 5);
               AddBuyMerch(buy, "Тушенка", 2);
               AddBuyMerch(buy, "Кольцо всевластия", 1);
               AddBuyMerch(buy, "Хлеб", 3);

               buy = AddBuy("Иванов", "Иван", "Общая цена", DateTime.Today.Subtract(TimeSpan.FromDays(15)));
               AddBuyMerch(buy, "Тушенка", 20);
               AddBuyMerch(buy, "Хлеб", 10);

               buy = AddBuy("Бэггинс", "Бильбо", "Скидка для хоббитов", DateTime.Today.Subtract(TimeSpan.FromDays(55)));
               AddBuyMerch(buy, "Табак", 12);

               buy = AddBuy("Бэггинс", "Бильбо", "Общая цена", DateTime.Today.Subtract(TimeSpan.FromDays(433)));
               AddBuyMerch(buy, "Меч", 1);
               AddBuyMerch(buy, "Кольцо всевластия", 1);

               buy = AddBuy("Серый", "Гендальф", "Скидка для магов", DateTime.Today.Subtract(TimeSpan.FromDays(433)));
               AddBuyMerch(buy, "Меч", 1);
               AddBuyMerch(buy, "Табак", 10);

               buy = AddBuy("Серый", "Гендальф", "Скидка для магов", DateTime.Today.Subtract(TimeSpan.FromDays(411)));
               AddBuyMerch(buy, "Хлеб", 10);
               AddBuyMerch(buy, "Конфеты", 15);

               buy = AddBuy("Поттер", "Гарри", "Скидка для магов", DateTime.Today);
               AddBuyMerch(buy, "Хлеб", 3);
               AddBuyMerch(buy, "Конфеты", 11);
               AddBuyMerch(buy, "Летучий порох", 3);
               AddBuyMerch(buy, "Палочка с волосом", 1);

               context.SaveChanges();
           }
        }

        #region Добавление объектов

        private void AddBuyMerch(Buy b, Merchandise m, int Count)
        {
            context.BuyMerchandises.Add(new BuyMerchandise() { Buy = b, Merchandise = m, Count = (short)Count });
        }

        private void AddBuyMerch(Buy b, string MerchName, int Count)
        {
            AddBuyMerch(b, context.Merchandises.Where(x => (x.Name == MerchName)).First(), Count);
        }

        private void AddDiscount(string Name, int Percents)
        {
            context.Discounts.Add(new Discount() { Name = Name, Percents = (short)Percents });
        }

        public void AddClient(string LName, string FName, string Patr, string Address)
        {
            context.Clients.Add(new Client() {FirstName = FName, LastName = LName, Patronymic = Patr, Address = Address}); 
        }

        public void AddMerchandise(string Name, double Price)
        {
            context.Merchandises.Add(new Merchandise() { Name = Name, Price = Price});
        }

        public Buy AddBuy(Client cl, Discount dsc, DateTime dt)
        {
            return context.Buys.Add(new Buy() {Client = cl, Date = dt, Discount = dsc });
        }

        public Buy AddBuy(string ClientLastName, string ClientFirstName, string DiscountName, DateTime Date)
        {
            return AddBuy(context.Clients.Where(x => (x.LastName == ClientLastName) && (x.FirstName == ClientFirstName)).First(), context.Discounts.Where(x => x.Name == DiscountName).First(), Date);
        }

        	#endregion Добавления элементов

        public void DeleteClient(string LName)
        {
            Client ToBeDeleted = context.Clients.First(p => p.LastName == LName);
            context.Clients.Remove(ToBeDeleted);
        }

        public void ShowClients(ListBox lb, string address)
        {
            List<Client> cls = context.Clients.Where(x => x.Address.Contains(address)).ToList();
            lb.Items.Clear();

            foreach (Client c in cls)
                lb.Items.Add(c.GetFullName());
        }

        public void TestingStuff()
        {
            /*var BreadBuys = context.MerchandiseНабор.Where(x => x.Name == "Хлеб").SelectMany(x => x.BuyMerchandise).ToArray();
            var buys = BreadBuys.Select(x=> x.Buy);
            var BreadBuyers = buys.Select(x => x.Client);

            var SwordBuyers = context.MerchandiseНабор.Where(x => x.Name == "Меч").SelectMany(x => x.BuyMerchandise).ToArray().Select(x => x.Buy).Select(x => x.Client);*/

            var buys = context.Buys.Select(x => x.BuyMerchandises).Select(x => new
            {
                stoim = x.Sum(y => y.Merchandise.Price * y.Count),
                buy = x.FirstOrDefault().Buy,
                price = x.FirstOrDefault().Merchandise.Price
            }).Where(x => x.price > 150);

            var b1 = buys.ToList();

            foreach (var b in buys)
            {
                MessageBox.Show(b.price.ToString()); 

            }
            

            var min = buys.Min(x => x.stoim);
            var client = buys.Where(x => x.stoim == min).Select(x => x.buy.Client);
            string k = "";
            foreach (var c in client)
            {
                k += "Минимальная покупка у " + c.FirstName + " " + c.LastName + " " + min;

            }
            MessageBox.Show(k);

            //List<int> nums = new List<int>() { 0, 9, 2 , 6};
            //List<int> nums2 = new List<int>() { 5, 6, 7, 8};
            //List<int> LessThen5 = nums.SelectMany(x => nums2.Where(p => p < x)).ToList();

        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void ShowClientsBuyedMerchendise(ListBox lb, string product)
        {
            var clients = context.BuyMerchandises
                .Where(x => x.Merchandise.Name == product)
                .Select(x => x.Buy.Client)
                .ToList();

            var clientNames = clients.Select(x => x.GetFullName()).ToList();

            lb.DataSource = clientNames;
        }

        public void ShowMerchendises(ComboBox cb) =>
            cb.DataSource = context.Merchandises.Select(x => x.Name).ToList();

        public void ShowClientsCountWithDiscount(decimal discount, Label l)
        {
            l.Text = context.Buys
                .Where(x => x.Discount.Percents >= discount)
                .Select(x => x.Client)
                .Distinct()
                .Count()
                .ToString();
        }

        public void ShowBiggestMerchendiseClient(Label l)
        {
            var data = context.Buys
                .Select(x => new
                {
                    x.Client,
                    Sum = x.BuyMerchandises.Sum(y => y.Count*y.Merchandise.Price)*x.Discount.Percents/100
                })
                .OrderByDescending(x => x.Sum)
                .FirstOrDefault();
            l.Text = $"{data?.Client.GetFullName() ?? ""}\n{data?.Sum ?? 0:C}";
        }

        public void ShowBuysHigherAvg(DataGridView dgvData, Label lAvg)
        {
            var data = context.Buys
                .Select(x => new
                {
                    x.Client,
                    Sum = x.BuyMerchandises.Sum(y => y.Count*y.Merchandise.Price)*x.Discount.Percents/100
                });
            var avg = data.Average(y => y.Sum);

            lAvg.Text = $"{avg:C}";

            dgvData.DataSource = data
                .Where(x => x.Sum > avg)
                .ToList()
                .Select(x => new
                {
                    FullName = x.Client.GetFullName(),
                    x.Sum
                })
                .ToList();

            dgvData.Columns[0].HeaderText = @"Имя клиента";
            dgvData.Columns[1].HeaderText = @"Сумма";
            dgvData.Columns[1].DefaultCellStyle.Format = "C";
        }
    }
}
