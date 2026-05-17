using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CustomerVehicleManagementSystem
{
    public class DemoUser
    {
        public int UserID;
        public string Name;
        public string Username;
        public string Password;
        public string Email;
        public string Phone;
        public string Address;
        public string Gender;
        public DateTime DateOfBirth;
    }

    public class DemoCar
    {
        public int CarID;
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public string Engine;
        public decimal Price;
        public string Status;
    }

    public class DemoOrder
    {
        public int OrderID;
        public int UserID;
        public int CarID;
        public DateTime OrderDate;
        public string OrderStatus;
        public decimal PaidAmount;
    }

    public static class DemoRepository
    {
        private static int nextUserId = 2;
        private static int nextOrderId = 1;

        private static List<DemoUser> users = new List<DemoUser>
        {
            new DemoUser
            {
                UserID = 1,
                Name = "Kaif",
                Username = "kaif",
                Password = "1234",
                Email = "kaif@gmail.com",
                Phone = "01700000000",
                Address = "Dhaka",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 1, 1)
            }
        };

        private static List<DemoCar> cars = new List<DemoCar>
        {
            new DemoCar { CarID = 1, Brand = "Toyota", Model = "Corolla", Color = "White", Year = 2021, Engine = "1500 CC", Price = 2450000, Status = "Available" },
            new DemoCar { CarID = 2, Brand = "Honda", Model = "Civic", Color = "Black", Year = 2020, Engine = "1800 CC", Price = 3350000, Status = "Available" },
            new DemoCar { CarID = 3, Brand = "Nissan", Model = "X-Trail", Color = "Red", Year = 2019, Engine = "2000 CC", Price = 4200000, Status = "Available" },
            new DemoCar { CarID = 4, Brand = "BMW", Model = "X1", Color = "Blue", Year = 2022, Engine = "2000 CC", Price = 7800000, Status = "Sold" },
            new DemoCar { CarID = 5, Brand = "Toyota", Model = "Premio", Color = "Black", Year = 2018, Engine = "1500 CC", Price = 2900000, Status = "Available" }
        };

        private static List<DemoOrder> orders = new List<DemoOrder>();

        public static DemoUser Login(string username, string password)
        {
            return users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);
        }

        public static bool UsernameExists(string username)
        {
            return users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public static void Register(string name, string username, string password, string email, string phone, string address, string gender, DateTime dob)
        {
            users.Add(new DemoUser
            {
                UserID = nextUserId++,
                Name = name,
                Username = username,
                Password = password,
                Email = email,
                Phone = phone,
                Address = address,
                Gender = gender,
                DateOfBirth = dob
            });
        }

        public static DataTable GetAvailableCars(string search)
        {
            DataTable table = CreateCarTable();
            search = (search ?? "").ToLower();

            foreach (DemoCar car in cars.Where(c => c.Status == "Available"))
            {
                if (search != "" &&
                    !car.Brand.ToLower().Contains(search) &&
                    !car.Model.ToLower().Contains(search) &&
                    !car.Color.ToLower().Contains(search) &&
                    !car.Engine.ToLower().Contains(search))
                {
                    continue;
                }

                table.Rows.Add(car.CarID, car.Brand, car.Model, car.Color, car.Year, car.Engine, car.Price, car.Status);
            }

            return table;
        }

        public static DemoCar GetAvailableCar(int carId)
        {
            return cars.FirstOrDefault(c => c.CarID == carId && c.Status == "Available");
        }

        public static bool PlaceOrder(int userId, int carId)
        {
            DemoCar car = GetAvailableCar(carId);
            if (car == null)
            {
                return false;
            }

            orders.Add(new DemoOrder
            {
                OrderID = nextOrderId++,
                UserID = userId,
                CarID = carId,
                OrderDate = DateTime.Now,
                OrderStatus = "Pending",
                PaidAmount = 0
            });

            car.Status = "Booked";
            return true;
        }

        public static DataTable GetOrders(int userId)
        {
            DataTable table = CreateOrderTable();

            foreach (DemoOrder order in orders.Where(o => o.UserID == userId))
            {
                DemoCar car = cars.First(c => c.CarID == order.CarID);
                table.Rows.Add(order.OrderID, car.Brand, car.Model, car.Color, car.Price, order.PaidAmount, car.Price - order.PaidAmount, order.OrderStatus, order.OrderDate);
            }

            return table;
        }

        public static DataTable GetPayments(int userId)
        {
            DataTable table = new DataTable();
            table.Columns.Add("OrderID", typeof(int));
            table.Columns.Add("Car", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("PaidAmount", typeof(decimal));
            table.Columns.Add("DueAmount", typeof(decimal));
            table.Columns.Add("OrderStatus", typeof(string));

            foreach (DemoOrder order in orders.Where(o => o.UserID == userId))
            {
                DemoCar car = cars.First(c => c.CarID == order.CarID);
                table.Rows.Add(order.OrderID, car.Brand + " " + car.Model, car.Price, order.PaidAmount, car.Price - order.PaidAmount, order.OrderStatus);
            }

            return table;
        }

        public static bool CancelOrder(int userId, int orderId)
        {
            DemoOrder order = orders.FirstOrDefault(o => o.UserID == userId && o.OrderID == orderId && o.OrderStatus == "Pending");
            if (order == null)
            {
                return false;
            }

            order.OrderStatus = "Cancelled";
            cars.First(c => c.CarID == order.CarID).Status = "Available";
            return true;
        }

        public static bool RemoveOrder(int userId, int orderId)
        {
            DemoOrder order = orders.FirstOrDefault(o => o.UserID == userId && o.OrderID == orderId && o.OrderStatus == "Pending");
            if (order == null)
            {
                return false;
            }

            cars.First(c => c.CarID == order.CarID).Status = "Available";
            orders.Remove(order);
            return true;
        }

        public static DemoUser GetUser(int userId)
        {
            return users.FirstOrDefault(u => u.UserID == userId);
        }

        public static void UpdateProfile(int userId, string name, string email, string phone, string address)
        {
            DemoUser user = GetUser(userId);
            if (user == null) return;

            user.Name = name;
            user.Email = email;
            user.Phone = phone;
            user.Address = address;
        }

        private static DataTable CreateCarTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("CarID", typeof(int));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Color", typeof(string));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Engine", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Status", typeof(string));
            return table;
        }

        private static DataTable CreateOrderTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("OrderID", typeof(int));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Color", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("PaidAmount", typeof(decimal));
            table.Columns.Add("DueAmount", typeof(decimal));
            table.Columns.Add("OrderStatus", typeof(string));
            table.Columns.Add("OrderDate", typeof(DateTime));
            return table;
        }
    }
}
