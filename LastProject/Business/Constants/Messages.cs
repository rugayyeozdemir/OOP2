namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvaild = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError= "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists= "Bu isimde zaten başka bir ürün var";

        public static string UnitPriceInvalid { get; internal set; }
        public static string CategoryLimitExceded = "Kategri limiti aşıldığı için yeni ürün eklenemiyor";
    }

}

