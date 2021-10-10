using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileDataTests
{
  [TestClass]
  public class FileDetailsServiceTests
  {
    private readonly IFileDetailsService fileDetailsService;
    public FileDetailsServiceTests()
    {
      fileDetailsService = new FileDetailsService();
    }
    [TestMethod]
    public void GivenVersionAsInput_WhenGetFileDetails_ThenReturnFileVersion()
    {
      //Arrange
      var fileVersionProperty = "-v";
      var filePath = "C:\fileName.cs";

      //Act
      var result = fileDetailsService.GetFileDetails(fileVersionProperty, filePath);

      //Assert
      Assert.IsNotNull(result);
    }
    [TestMethod]
    public void GivenSizeAsInput_WhenGetFileDetails_ThenReturnFileSize()
    {

      //Arrange
      var fileVersionProperty = "-s";
      var filePath = "C:\fileName.cs";

      //Act
      var result = fileDetailsService.GetFileDetails(fileVersionProperty, filePath);

      //Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void GivenWrongSizeNameAsInput_WhenGetFileDetails_ThenReturnNothing()
    {

      //Arrange
      var fileVersionProperty = "-SIZESA";
      var filePath = "C:\fileName.cs";

      //Act
      var result = fileDetailsService.GetFileDetails(fileVersionProperty, filePath);

      //Assert
      Assert.IsNull(result);
    }

    [TestMethod]
    public void GivenWrongVersionNameAsInput_WhenGetFileDetails_ThenReturnNothing()
    {

      //Arrange
      var fileVersionProperty = "-VS";
      var filePath = "C:\fileName.cs";

      //Act
      var result = fileDetailsService.GetFileDetails(fileVersionProperty, filePath);

      //Assert
      Assert.IsNull(result);
    }
  }
}
