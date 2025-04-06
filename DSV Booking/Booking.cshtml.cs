using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static DSV_Booking.M�delokaleModel;

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
                    Dictionary<int, M�delokale> My_dict1 = new Dictionary<int, M�delokale>();
                }
                #region Instance fields

                public string _date;
                public string _m�delokale;
                public bool _available;
                #endregion

                #region Constructor 
                public Booking(string date, string m�delokale, bool available)
                {
                    _date = date;
                    _available = available;
                    _m�delokale = m�delokale;
                }

                #endregion

                #region Properties
                public string date
                {
                    get { return _date; }
                    set { _date = value; }
                }

                public string m�delokale
                {
                    get { return _m�delokale; }
                    set { _m�delokale = value; }
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
                    return $"date : {date} - m�delokale : {m�delokale} - available : {available}";
                }

                #endregion
            }
        }
    }
    

