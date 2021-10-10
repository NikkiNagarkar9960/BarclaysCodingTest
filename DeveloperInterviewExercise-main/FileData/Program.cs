using System;

namespace FileData
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        var filePropertyName = args[0];
        var filePath = args[1];
        IFileDetailsService fileDetailsService = new FileDetailsService();
        Console.WriteLine(fileDetailsService.GetFileDetails(filePropertyName, filePath));
      }
      catch(Exception ex)
      {
        Console.WriteLine("Error occurred while getting file details:\n" + ex.Message);
      }
      Console.ReadKey();
    }
  }


}
