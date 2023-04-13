using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            var messsage = GetFullName();
            if (Shooter == null)
            {
                messsage += " doesn't have a shooter";
            }
            else
            {
                messsage += $": { Shooter.Shoot()}";
            }
            return messsage;
        }

        public override string ToString()
        {
            var msg = base.ToString();
            if (Shooter != null)
            {
                msg += $" Shooter: {Shooter}";
            }
            return msg;
        }
    }
}
