namespace PetCare.Models
{
    public class DataConstants
    {
        public class User
        {
            public const int NickNameMinLenght = 2;
            public const int NickNameMaxLenght = 25;
            public const int PasswordMinLenght = 6;
            public const int PasswordMaxLenght = 100;
        }
        public class Pet
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 40;

            public const int AgeMinRange = 1;
            public const int AgeMaxRange = 100;

            public const int DescriptionMinLength = 5;

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

        public class Clinic
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int PhoneNumberMinLength = 8;
            public const int PhoneNumberMaxLength = 25;

            public const int StreetMinLength = 10;
            public const int StreetMaxLength = 50;
        }

        public class City
        {
            public const int CityMinLength = 3;
            public const int CityMaxLength = 30;
        }

        public class AdoptPet
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 40;

            public const int AgeMinRange = 1;
            public const int AgeMaxRange = 100;

            public const int DescriptionMinLength = 5;

            public const int BreedMinLength = 3;
            public const int BreedMaxLength = 25;
        }
    }
}
