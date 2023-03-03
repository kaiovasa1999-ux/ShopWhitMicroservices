namespace Shop.Data
{
    public class DataConstants
    {
        public class ItemAddCOnstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 255;
            public const decimal MinPrice = 0m;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
        }

        public class CategoryConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
        }

        public class DealerConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
            public const int PhoneMinLength = 4;
            public const int PhoneMaxLength = 16;

        }
    }
}
