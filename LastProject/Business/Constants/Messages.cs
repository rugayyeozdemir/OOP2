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
        public static string CategoryLimitExceded = "Kategri limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string Useregistered;

        public static string UserNotFound { get; internal set; }
        public static string PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }

}

