namespace Config {
    public static class Database {
        private static readonly string DATABASE = "PROJECT_MANAGEMENT.mdf";
        private static readonly string DATABASE_PATH = System.IO.Path.GetFullPath(DATABASE);
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DATABASE_PATH + ";Integrated Security=True";
    }
}