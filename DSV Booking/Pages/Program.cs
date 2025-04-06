using static DSV_Booking.BookingModel;
using static DSV_Booking.KalenderModel;
using static DSV_Booking.MødelokaleModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;




namespace DSV_Booking.Pages

{

  
    internal class Program 
    {

        static void Main(string[] args)
        {




            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();


                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthorization();

                app.MapRazorPages();

                app.Run();
               
                Mødelokale førsteMødelokale = new Mødelokale(1, 50, "Lokale 1");
                Mødelokale andetMødelokale = new Mødelokale(2, 22, "Lokale 2");
                Mødelokale tredjeMødelokale = new Mødelokale(3, 15, "Lokale 3");

                førsteMødelokale.name = "Lokale 1";
                andetMødelokale.name = "Lokale 2";
                tredjeMødelokale.name = "Lokale 3";


                Booking førsteBooking = new Booking("14/3 - 2025", "Roskilde", true);
                Booking andenBooking = new Booking("15/4 - 2025", "Roskilde", false);
                Booking tredjeBooking = new Booking("07/07 - 2025", "Roskilde", true);

                Kalender førsteKalender = new Kalender("arbejdsmail@dsv.dk", "15:30-16:30");
                Kalender andenKalender = new Kalender("Booking@dsv.dk", "14-15");
                Kalender tredjeKalender = new Kalender("ceo@dsv.dk", "10-14:30");



                Console.WriteLine($"Booking 1,{førsteBooking}, {førsteMødelokale} , {førsteKalender}");
                Console.WriteLine($"Booking 2, {andenBooking}, {andetMødelokale} {andenKalender}");
                Console.WriteLine($"Booking 3,{tredjeBooking}, {tredjeMødelokale}{tredjeKalender}");


                Console.WriteLine("Add Booking");
                Dictionary<int, Mødelokale> My_dict1 = new Dictionary<int, Mødelokale>();
                My_dict1.Add(1, førsteMødelokale);
                My_dict1.Add(2, andetMødelokale);
                My_dict1.Add(3, tredjeMødelokale);

                Console.WriteLine($"add Booking, {førsteMødelokale}");
                Console.WriteLine($"add Booking, {andetMødelokale}");
                Console.WriteLine($"add Booking, {tredjeMødelokale}");




                Console.WriteLine("DSV Bookingsystem");



            }

        }



    }
}





