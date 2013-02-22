using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace _3D_Space
{
    static class PathStorage
    {
        public static Path LoadPath()
        {
            Console.WriteLine("Input full path to a text file containing a Path:");
            string filePath = Console.ReadLine();

            Path newPath = new Path();

            try
            {
                StreamReader reader = new StreamReader(filePath);

                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string[] strCoords = reader.ReadLine().Split(' ');

                        double[] coords = new double[strCoords.Length];
                        for (int i = 0; i < strCoords.Length; i++)
                        {
                            coords[i] = double.Parse(strCoords[i]);
                        }

                        newPath.AddPoint(new Point3D(coords[0], coords[1], coords[2]));
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect file path was entered.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The entered directory wasn't found.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file wasn't found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An Error occured while trying to read the file.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while trying to load a Path.");
            }

            return newPath;
        }

        public static void SavePath(Path path)
        {
            Console.WriteLine("Enter the full file path for the save file.");
            string filePath = Console.ReadLine();

            try
            {
                StreamWriter writer = new StreamWriter(filePath);

                using (writer)
                {
                    foreach (Point3D point in path.ThePath)
                    {
                        writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid file path entered.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The entered directory wasn't found.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long.");
            }
            catch (IOException)
            {
                Console.WriteLine("An Error occured while trying to read the file.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while trying to save the path.");
            }
        }
    }
}
