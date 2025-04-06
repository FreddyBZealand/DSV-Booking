using static DSV_Booking.BookingModel;
using static DSV_Booking.KalenderModel;
using static DSV_Booking.M�delokaleModel;
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
               
                M�delokale f�rsteM�delokale = new M�delokale(1, 50, "Lokale 1");
                M�delokale andetM�delokale = new M�delokale(2, 22, "Lokale 2");
                M�delokale tredjeM�delokale = new M�delokale(3, 15, "Lokale 3");

                f�rsteM�delokale.name = "Lokale 1";
                andetM�delokale.name = "Lokale 2";
                tredjeM�delokale.name = "Lokale 3";


                Booking f�rsteBooking = new Booking("14/3 - 2025", "Roskilde", true);
                Booking andenBooking = new Booking("15/4 - 2025", "Roskilde", false);
                Booking tredjeBooking = new Booking("07/07 - 2025", "Roskilde", true);

                Kalender f�rsteKalender = new Kalender("arbejdsmail@dsv.dk", "15:30-16:30");
                Kalender andenKalender = new Kalender("Booking@dsv.dk", "14-15");
                Kalender tredjeKalender = new Kalender("ceo@dsv.dk", "10-14:30");



                Console.WriteLine($"Booking 1,{f�rsteBooking}, {f�rsteM�delokale} , {f�rsteKalender}");
                Console.WriteLine($"Booking 2, {andenBooking}, {andetM�delokale} {andenKalender}");
                Console.WriteLine($"Booking 3,{tredjeBooking}, {tredjeM�delokale}{tredjeKalender}");


                Console.WriteLine("Add Booking");
                Dictionary<int, M�delokale> My_dict1 = new Dictionary<int, M�delokale>();
                My_dict1.Add(1, f�rsteM�delokale);
                My_dict1.Add(2, andetM�delokale);
                My_dict1.Add(3, tredjeM�delokale);

                Console.WriteLine($"add Booking, {f�rsteM�delokale}");
                Console.WriteLine($"add Booking, {andetM�delokale}");
                Console.WriteLine($"add Booking, {tredjeM�delokale}");




                Console.WriteLine("DSV Bookingsystem");



            }

        }



    }
}





