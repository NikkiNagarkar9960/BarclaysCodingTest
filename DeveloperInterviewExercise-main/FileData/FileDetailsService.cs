using System.Linq;
using ThirdPartyTools;

namespace FileData
{
  public class FileDetailsService : IFileDetailsService
  {
    private readonly FileDetails fileDetails;
    public FileDetailsService() : this(new FileDetails())
    {

    }
    public FileDetailsService(FileDetails fileDetails)
    {
      this.fileDetails = fileDetails;
    }

    public object GetFileDetails(string filePropertyName, string filePath)
    {
      if (IsVersionProperty(filePropertyName))
      {
        return fileDetails.Version(filePath);
      }

      if (IsSizeProperty(filePropertyName))
      {
        return fileDetails.Size(filePath);
      }

      return null;
    }

    private static bool IsVersionProperty(string filePropertyName)
    {
      var versionPropertyNames = new[] { "-v", "--v", "/v", "version" };
      return versionPropertyNames.Contains(filePropertyName.ToLower());
    }

    private static bool IsSizeProperty(string filePropertyName)
    {
      var sizePropertyNames = new[] { "-s", "--s", "/s", "size" };
      return sizePropertyNames.Contains(filePropertyName.ToLower());
    }

  }
}
