namespace SerialisationApp
{
    public class Trainee { 
        public string? FirstName { get; init; } 
        public string? LastName { get; init; } 
        public int? SpartaNo { get; init; } 
        public string FullName => $"{FirstName} {LastName}"; 
        public override string ToString() 
        {
            return $" {base.ToString()} {SpartaNo} - {FullName}"; } 
         }
}
