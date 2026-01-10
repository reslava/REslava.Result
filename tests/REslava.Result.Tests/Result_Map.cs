using System;
using System.Collections.Generic;
using System.Text;

namespace REslava.Result.Tests;

[TestClass]
public sealed class Result_Map
{
    [TestMethod]
    public void Map_OnSuccesResult_TransforValue()
    {
        // Arrange
        var result = Result<int>.Ok(7);
        // Act
        var mapped = result.Map<string>(x => (x * 2).ToString());
        // Assert
        Assert.IsTrue(mapped.IsSuccess);
        Assert.AreEqual("14", mapped.Value);
    }
    [TestMethod]
    public void Map_OnFailureResult_ReturnSameReasons()
    {
        // Arrange
        var result = Result<int>.Fail("test");
        // Act
        var mapped = result.Map<string>(x => x.ToString());
        // Assert
        Assert.IsTrue(mapped.IsFailed);
        Assert.HasCount(1, mapped.Errors);
    }
    [TestMethod]
    public void Map_WithNullMapper_Throw()
    {
        // Arrange
        var result = Result<int>.Fail("test");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() =>
            result.Map<string>(null!));
    }
    [TestMethod]
    public void Map_WhenThrows_ReturnFailed()
    {
        // Arrange
        var result = Result<int>.Ok(value: 37);
        // Act
        var mapped = result.Map<string>(x => throw new InvalidOperationException("test"));

        // Assert
        Assert.IsTrue(mapped.IsFailed);
        Assert.IsTrue(mapped.Errors.Any(e => e.Message == "Exception: test"));
    }
}
