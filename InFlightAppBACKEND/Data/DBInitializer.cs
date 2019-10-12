using InFlightAppBACKEND.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data
{
    public class DBInitializer
    {
        private DBContext _dbContext;
        private UserManager<IdentityUser> _userManager;

        public DBInitializer(DBContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task seedDatabase()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                #region Flight
                Flight flight1 = new Flight("BRUSJO-871X", "Boeing 737", DateTime.Now, DateTime.Now.AddHours(8), "BRU", "SJO");
                _dbContext.Flights.Add(flight1);
                #endregion

                #region Product
                Product product1 = new Product("Diet Coke", "Coca-cola formula with zero sugar!", 3.00M, ProductType.BEVERAGE);
                Product product2 = new Product("Fries with steak", "Fresh French fries with great steak!", 25.50M, ProductType.FOOD);
                Product product3 = new Product("Marbloro Red 20", "20-pack of Marbloro Red", 7M, ProductType.CIGARETTES);
                Product product4 = new Product("Jack Daniels 70cl", "70cl's of pure finesse Whisky!", 29.99M, ProductType.LIQUOR);
                Product product5 = new Product("Swatch watch", "The newest Swiss watch on the market!", 149.99M, ProductType.OTHER);
                _dbContext.Products.Add(product1);
                _dbContext.Products.Add(product2);
                _dbContext.Products.Add(product3);
                _dbContext.Products.Add(product4);
                _dbContext.Products.Add(product5);
                #endregion

                #region CrewMember
                CrewMember crewMember1 = new CrewMember("Bram", "De Bleecker");
                CrewMember crewMember2 = new CrewMember("Johanna", "De Bruycker");
                _dbContext.CrewMembers.Add(crewMember1);
                _dbContext.CrewMembers.Add(crewMember2);
                #endregion

                #region Passenger
                Passenger passenger1 = new Passenger("Tybo", "Vanderstraeten");
                Passenger passenger2 = new Passenger("Rob", "De Putter");
                Passenger passenger3 = new Passenger("Tim", "Geldof");
                Passenger passenger4 = new Passenger("Michiel", "Schoofs");
                Passenger passenger5 = new Passenger("Lars", "Vandenberghe");
                _dbContext.Passengers.Add(passenger1);
                _dbContext.Passengers.Add(passenger2);
                _dbContext.Passengers.Add(passenger3);
                _dbContext.Passengers.Add(passenger4);
                _dbContext.Passengers.Add(passenger5);
                #endregion

                #region Seat
                Seat seat1 = new Seat(SeatType.BUSINESS, passenger1);
                Seat seat2 = new Seat(SeatType.ECONOMY, passenger2);
                Seat seat3 = new Seat(SeatType.FIRST_CLASS, passenger3);
                Seat seat4 = new Seat(SeatType.BUSINESS, passenger4);
                Seat seat5 = new Seat(SeatType.BUSINESS, passenger5);
                Seat seat6 = new Seat(SeatType.BUSINESS, null);
                Seat seat7 = new Seat(SeatType.BUSINESS, null);
                Seat seat8 = new Seat(SeatType.BUSINESS, null);
                Seat seat9 = new Seat(SeatType.BUSINESS, null);
                Seat seat10 = new Seat(SeatType.BUSINESS, null);
                flight1.AddSeat(seat1);
                flight1.AddSeat(seat2);
                flight1.AddSeat(seat3);
                flight1.AddSeat(seat4);
                flight1.AddSeat(seat5);
                flight1.AddSeat(seat6);
                flight1.AddSeat(seat7);
                flight1.AddSeat(seat8);
                flight1.AddSeat(seat9);
                flight1.AddSeat(seat10);
                #endregion

                _dbContext.SaveChanges();
            }
        }
    }
}
