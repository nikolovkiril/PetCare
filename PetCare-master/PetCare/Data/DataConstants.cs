namespace PetCare.Models
{
    public class DataConstants
    {
        public class Pet
        {
            //Pet
            public const int NameMinLength = 2;

            public const int NameMaxLength = 40;

            public const int AgeMinRange = 1;

            public const int AgeMaxRange = 100;

            public const int DescriptionMinLength = 10;

            public const int BreedMinLength = 3;

            public const int BreedMaxLength = 25;
        }

        public class Employee
        {
            public const int FirstNameMinLength = 2;

            public const int FirstNameMaxLength = 20;

            public const int LastNameMinLength = 2;

            public const int LastNameMaxLength = 35;

            public const int AgeMinRange = 16;

            public const int AgeMaxRange = 99;

            public const int AutobiographyMinLength = 10;
        }
        
        public class VetService
        {
            public const int ServiceNameMinLength = 3;

            public const int ServiceNameMaxLength = 30;

            public const int DescriptionMinLength = 5;

        }
    }
}
