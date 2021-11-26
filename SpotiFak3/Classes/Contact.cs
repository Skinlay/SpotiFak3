using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace SpotiFak3.Classes
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]
        //AutoIncrement zorgt ervoor dat ID altijd uniek is.
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
