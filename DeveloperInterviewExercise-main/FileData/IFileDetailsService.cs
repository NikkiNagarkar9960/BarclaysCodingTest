namespace FileData
{
  public interface IFileDetailsService
  {
    object GetFileDetails(string filePropertyName, string filePath);
  }
}
