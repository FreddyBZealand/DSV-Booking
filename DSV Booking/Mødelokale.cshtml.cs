using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSV_Booking
{
    public class MødelokaleModel : PageModel
    {
        public void OnGet()
        { }
            
    
  
            public class Mødelokale
            {


                #region Instance fields
                string _name;
                int _id;
                int _capacity;

                #endregion

                #region Constructor
                public Mødelokale(int id, int capacity, string name)
                {
                    _name = name;
                    _id = id;
                    _capacity = capacity;

                }

                #endregion

                #region properties

                public string name
                {
                    get { return _name; }
                    set { _name = value; }

                }


                public int id
                {
                    get { return _id; }
                    set { _id = value; }

                }



                public int capacity
                {
                    get { return _capacity; }
                    set { _capacity = value; }
                }


                #endregion

                #region Methods

                public override string ToString()
                {
                    return $"capacity : {capacity} - id : {id} name : {name}";
                }



                #endregion
            }
        }
    }


    

