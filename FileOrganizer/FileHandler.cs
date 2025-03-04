using System.Diagnostics;

namespace FileOrganizer {
    internal class FileHandler {
        public string[] allFiles { get; private set; }
        private string currentDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        private HashSet<string> imageExtensions = new HashSet<string>
        {
    ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".tiff", ".tif", ".webp", ".svg", ".ico", ".heic", ".raw", ".psd"
};

        private HashSet<string> documentExtensions = new HashSet<string>
        {
    ".pdf", ".doc", ".docx", ".txt", ".rtf", ".odt", ".html", ".htm", ".xls", ".xlsx", ".csv", ".ppt", ".pptx", ".odp", ".md", ".epub"
};

        private HashSet<string> executableExtensions = new HashSet<string>
        {
    ".exe", ".msi", ".jar", ".py", ".vsix", ".dll", ".bat", ".cmd", ".sh", ".apk", ".app", ".deb", ".rpm", ".bin", ".run"
};

        private HashSet<string> videoExtensions = new HashSet<string>
        {
    ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".mpg", ".mpeg", ".webm", ".ogv", ".3gp"
};

        private HashSet<string> musicExtensions = new HashSet<string>
        {
    ".mp3", ".wav", ".flac", ".aac", ".ogg", ".m4a", ".wma", ".aiff", ".alac", ".opus", ".mid", ".midi"
};

        public FileHandler() {
            allFiles = Directory.GetFiles(currentDirectory);
        }

        //Hello Stranger looking though my code :> Enjoy!
        public void SortFiles() {
            string programExecutable = Process.GetCurrentProcess().MainModule.FileName;

            foreach (string filename in allFiles) {
                if (Path.GetFileName(filename).Equals(Path.GetFileName(programExecutable), StringComparison.OrdinalIgnoreCase)) {
                    continue;
                }

                try {
                    FileInfo fi = new FileInfo(filename);
                    string targetFolder;
                    string file = Path.GetExtension(filename);

                    if (imageExtensions.Contains(file)) {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Images");
                    } else if (documentExtensions.Contains(file)) {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Documents");
                    } else if (executableExtensions.Contains(file)) {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Executables");
                    } else if (videoExtensions.Contains(file)) {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Videos");
                    } else if (musicExtensions.Contains(file)) {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Music");
                    } else {
                        targetFolder = Path.Combine(currentDirectory, "[FO] Misc");
                    }

                    Directory.CreateDirectory(targetFolder);
                    fi.MoveTo(Path.Combine(targetFolder, fi.Name));
                } catch {
                    Console.WriteLine($"Error moving file: {filename}");
                }
            }
        }
    }
}