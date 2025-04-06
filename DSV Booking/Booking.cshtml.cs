using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static DSV_Booking.MødelokaleModel;

namespace DSV_Booking
{
    public class BookingModel : PageModel
    {
        public void OnGet()
        { }
            
        
            public class Booking
            {

                static void Start()
                {
                    Dictionary<int, Mødelokale> My_dict1 = new Dictionary<int, Mødelokale>();
                }
                #region Instance fields

                public string _date;
                public string _mødelokale;
                public bool _available;
                #endregion

                #region Constructor 
                public Booking(string date, string mødelokale, bool available)
                {
                    _date = date;
                    _available = available;
                    _mødelokale = mødelokale;
                }

                #endregion

                #region Properties
                public string date
                {
                    get { return _date; }
                    set { _date = value; }
                }

                public string mødelokale
                {
                    get { return _mødelokale; }
                    set { _mødelokale = value; }
                }
                public bool available
                {
                    get { return _available; }
                    set { _available = value; }
                }





                #endregion

                #region Methods

                public override string ToString()
                {
                    return $"date : {date} - mødelokale : {mødelokale} - available : {available}";
                }

                #endregion
            }
        }
    }
    

