
namespace FourPillarsApp
{
    public class Hunter : Person
    {
        private string _camera = "";

        //Inheriting via "base" keyword
        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {   //GetFullName() is public. Available within hunter.
            return $"{GetFullName()} took photo with {_camera}";
        }


        //Would already inherits ToString() from Object superclass. Overridden with
        //Override keyword
        public override string ToString()
        {
            return $"{base.ToString()} camera: {_camera}";
        }
    }
}
