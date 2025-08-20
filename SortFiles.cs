using System;
using System.IO;
namespace SortFiles
{
    class FileSort
    {
        // Documents files 
        private List<string> Documents = new List<string>() { ".txt", ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".rtf" };
        // Image files 
        private List<string> Images = new List<string>() { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".svg", ".webp" };
        // Audio files 
        private List<string> Audio = new List<string>() { ".mp3", ".wav", ".flac", ".aac", ".ogg", ".m4a" };
        // Video files
        private List<string> Video = new List<string>() { ".mp4", ".avi", ".mov", ".mkv", ".wmv", ".flv" };
        // Compressed files
        private List<string> Compressed = new List<string>() { ".zip", ".rar", ".7z", ".tar", ".gz" };
        // Code files
        private List<string> Code = new List<string>() { ".py", ".cs", ".cpp", ".c", ".java", ".js", ".html", ".css", ".json", ".xml" };
        // Executable files
        private List<string> Executable = new List<string>() { ".exe", ".msi", ".apk", ".bat", ".sh" };
        public void SortingFiles()
        {
            int movedFiles = 0;
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine("This program will only check the desktop directory currently, future updates will expand on scanning more directories");
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string[] files = Directory.GetFiles(filePath);
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    // if statements for file checking
                    if (Documents.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine(filePath, fileName);
                        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string newPath = Path.Combine(documentsPath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {documentsPath}");
                        movedFiles++;
                    }
                    // Check for image extensions 
                    if (Images.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine (filePath, fileName);
                        string picturePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        string newPath = Path.Combine(picturePath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {picturePath}");
                        movedFiles++;
                    }
                    // Audio files
                    if (Audio.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine(filePath, fileName);
                        string audioPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);  
                        string newPath = Path.Combine(audioPath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {audioPath}");
                        movedFiles++;
                    }
                    // Video files
                    if (Video.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine(filePath, fileName);
                        string videoPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                        string newPath = Path.Combine(videoPath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {videoPath}");
                        movedFiles++;
                    }
                    if (Compressed.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine (filePath, fileName);
                        string compressedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Compressed Files");
                        string newPath = Path.Combine(compressedPath, fileName);
                        File.Move (oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {compressedPath}");
                        movedFiles++;
                    }
                    if (Code.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine(filePath,fileName);
                        string codePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Code Files");
                        string newPath = Path.Combine(codePath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {codePath}");
                        movedFiles++;
                    }
                    if (Executable.Contains(ext))
                    {
                        string fileName = Path.GetFileName(file);
                        string oldPath = Path.Combine(filePath, fileName);
                        string exePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Executable Files");
                        string newPath = Path.Combine(exePath, fileName);
                        File.Move(oldPath, newPath);
                        Console.WriteLine($"{file} has been moved to {exePath}");
                        movedFiles++;
                    }
                }
                if (movedFiles == 0)
                {
                    Console.WriteLine("Could not find any files to sort");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
