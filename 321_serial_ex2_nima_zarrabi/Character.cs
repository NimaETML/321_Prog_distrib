using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace _321_serial_ex2_nima_zarrabi
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Actor? PlayedBy { get; set; }



        /*[JsonConstructor]
        internal Character(string firstName, string lastName, string description, Actor? linkedActor)
        {
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            PlayedBy = linkedActor;
        }
        
        internal Character()
        {

        }*/
    }
}
