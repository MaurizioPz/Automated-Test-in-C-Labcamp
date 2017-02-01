public class Syntax
{
  [Test]
  public void Basic()
  {
    Assert.That(true);
    Assert.That(false);  //fails
  }
  
  [Test]
  public void Simple()
  {
    Assert.That(3, Is.EqualsTo(1 + 2));
    //Assert.That(3 == (1 + 2));
  }
  
  [Test]
  public void Complex()
  {
    Assert.That("Hello!", Does.Not.StartWith("HI").IgnoreCase);
  }
}

public class Environment
{
  private File file;
  [Test]
  public void MakeImportant_WhenGivenUnimportantFile_SetsImportantToTrue()
  {
    MakeImportant(file);
    Assert.That(file.IsImportant);
  }
  
  [SetUp]
  public void SetUp()
  {
    file = CreateAFile();
  }
  
  [TearDown]
  public void Complex()
  {
    CleanUp();
  }
}
