# FileOrganizer

A simple, standalone `.exe` that automatically sorts files into categorized folders based on their extensions.

## Features
✅ **Automatically organizes files into the following categories:**
- 📷 **[FO] Images**  
  - `.png`, `.jpg`, `.jpeg`, `.gif`, `.bmp`, `.tiff`, `.tif`, `.webp`, `.svg`, `.ico`, `.heic`, `.raw`, `.psd`
- 📄 **[FO] Documents**  
  - `.pdf`, `.doc`, `.docx`, `.txt`, `.rtf`, `.odt`, `.html`, `.htm`, `.xls`, `.xlsx`, `.csv`, `.ppt`, `.pptx`, `.odp`, `.md`, `.epub`
- 🛠️ **[FO] Executables**  
  - `.exe`, `.msi`, `.jar`, `.py`, `.vsix`, `.dll`, `.bat`, `.cmd`, `.sh`, `.apk`, `.app`, `.deb`, `.rpm`, `.bin`, `.run`
- 🎥 **[FO] Videos**  
  - `.mp4`, `.avi`, `.mkv`, `.mov`, `.wmv`, `.flv`, `.mpg`, `.mpeg`, `.webm`, `.ogv`, `.3gp`
- 🎵 **[FO] Music**  
  - `.mp3`, `.wav`, `.flac`, `.aac`, `.ogg`, `.m4a`, `.wma`, `.aiff`, `.alac`, `.opus`, `.mid`, `.midi`
- 📂 **[FO] Misc** (everything else)

✅ **Standalone `.exe`** (no installation required)  
✅ **Ignores itself** to prevent accidental self-move  
✅ **Logs errors instead of crashing**  
✅ **Creates `[FO]` folders dynamically based on detected file types**  

---

## Installation
1. **Download the latest release** from [Releases](https://github.com/PhenixHD/FileOrganizer/releases).
2. Place `FileOrganizer.exe` inside the folder you want to organize.
3. **Double-click to run!** 🖱️

---

## Usage
1. Place `FileOrganizer.exe` in a folder containing files you want to organize.
2. Run the program.
3. It will **automatically move files into appropriate `[FO]` subfolders**.

---

## Building from Source
To compile the project yourself, use the following:
```sh
git clone https://github.com/YOUR_USERNAME/FileOrganizer.git
cd FileOrganizer
dotnet publish -r win-x64 -c Release --self-contained true /p:PublishSingleFile=true
```
The compiled .exe will be found in:
```sh
bin\Release\net8.0\win-x64\publish\FileOrganizer.exe
```

---

## Notes
- **Files in use (locked by another program) will be skipped.**
- **The program ignores itself (`FileOrganizer.exe`) to prevent self-move.**
- **If a file type is not listed, it will go to `[FO] Misc`.**

---

## License
📝 MIT License – Feel free to use and modify this project.

---

🎉 **Enjoy your automatically organized files!** 🚀
