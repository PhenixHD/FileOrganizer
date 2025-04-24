namespace FileOrganizer {
    internal class Program {
        private static void Main(string[] args) {
            FileHandler fh = new FileHandler();
            fh.SortFiles();
            return;
        }
    }
}