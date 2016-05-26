using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace Point3D
{
    static class Storage
    {
        public static void SavePathInFile(string fileName, Path3D path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("File path contains an invalid directory");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized access to specified file path");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }

        public static Path3D LoadPathFromFile(string fileName)
        {
            try
            {
                Path3D path = new Path3D();
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string input = sr.ReadToEnd();
                    string pattern = @"Point\(([\d.]+),([\d.]+),([\d.]+)\)";
                    Regex rgx = new Regex(pattern);
                    MatchCollection matches = rgx.Matches(input);
                    foreach (Match match in matches)
                    {
                        double x = double.Parse(match.Groups[1].Value);
                        double y = double.Parse(match.Groups[2].Value);
                        double z = double.Parse(match.Groups[3].Value);
                        Point3D point = new Point3D(x, y, z);
                        path.AddPoint(point);
                    }
                }
                return path;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }

    }
}
