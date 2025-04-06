using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSV_Booking
{
    public class KalenderModel : PageModel
    {
        public void OnGet()
        { }





        public class Kalender
        {

            #region Instance fields
            private string _username;
            private string _timeslot;
            #endregion

            #region Constructor
            public Kalender(string username, string timeslot)
            {

                _username = username;
                _timeslot = timeslot;
            }
            #endregion

            #region Properties

            public string username
            {
                get { return _username; }
                set { _username = value; }

            }


            public string timeslot
            {
                get { return _timeslot; }
                set { _timeslot = value; }
            }
            #endregion

            #region Methods
            public override string ToString()
            {
                return $" - timeslot : {timeslot} - username {username} ";
            }
            #endregion

        }

    }
}


    

