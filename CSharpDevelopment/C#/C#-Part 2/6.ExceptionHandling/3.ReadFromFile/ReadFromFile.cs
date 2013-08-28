using System;
using System.IO;
using System.Security;
using System.Text;

namespace ReadFromFile
{
    class ReadFromFile
    {
        static void Main()
        {
            try
            {
                string path = @"C:\WINDOWS\win.ini";
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only.-or-This operation is not supported on the current platform.-or-path specified a directory.-or-The caller does not have the required permission.");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
        }
    }
}
