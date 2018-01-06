var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var verbosity = Argument("verbosity", "Minimal");

var solutions = new ConvertableFilePath[] {
  File("AddinProjectHelper/AddinProjectHelper.sln"),
  File("AddinRemovalTool/AddinRemovalTool.sln"),
  File("ExampleBase/ExampleBase.sln"),
};

var excelSamples = GetFiles("./Excel/*.sln");
var wordSamples = GetFiles("./Word/*.sln");
var outlookSamples = GetFiles("./Outlook/*.sln");
var powerPointSamples = GetFiles("./PowerPoint/*.sln");

Task("Build")
  .DoesForEach(solutions, (solutionFile) =>
  {
    Information("Building solution file {0}", solutionFile.Path.GetFilename());
    NuGetRestore(solutionFile);

    MSBuild(solutionFile, settings => settings
      .SetConfiguration(configuration)
      .WithTarget("Rebuild")
      .SetVerbosity(GetMSBuildVerbosity(verbosity)));
  });

Task("Build:Excel")
  .DoesForEach(excelSamples, (solutionFile) =>
  {
    Information("Building solution file {0}", solutionFile.GetFilename());
    NuGetRestore(solutionFile);

    MSBuild(solutionFile, settings => settings
      .SetConfiguration(configuration)
      .WithTarget("Rebuild")
      .SetVerbosity(GetMSBuildVerbosity(verbosity)));
  });

Task("Build:Word")
  .DoesForEach(wordSamples, (solutionFile) =>
  {
    Information("Building solution file {0}", solutionFile.GetFilename());
    NuGetRestore(solutionFile);

    MSBuild(solutionFile, settings => settings
      .SetConfiguration(configuration)
      .WithTarget("Rebuild")
      .SetVerbosity(GetMSBuildVerbosity(verbosity)));
  });
  
Task("Build:Outlook")
  .DoesForEach(outlookSamples, (solutionFile) =>
  {
    Information("Building solution file {0}", solutionFile.GetFilename());
    NuGetRestore(solutionFile);

    MSBuild(solutionFile, settings => settings
      .SetConfiguration(configuration)
      .WithTarget("Rebuild")
      .SetVerbosity(GetMSBuildVerbosity(verbosity)));
  });
  
Task("Build:PowerPoint")
  .DoesForEach(powerPointSamples, (solutionFile) =>
  {
    Information("Building solution file {0}", solutionFile.GetFilename());
    NuGetRestore(solutionFile);

    MSBuild(solutionFile, settings => settings
      .SetConfiguration(configuration)
      .WithTarget("Rebuild")
      .SetVerbosity(GetMSBuildVerbosity(verbosity)));
  });

Task("Default")
  .IsDependentOn("Build")
  .IsDependentOn("Build:Excel")
  .IsDependentOn("Build:Word")
  .IsDependentOn("Build:Outlook")
  .IsDependentOn("Build:PowerPoint");

RunTarget(target);

/// <summary>
/// Gets the MSBuild <see cref="Verbosity"/> from string value.
/// </summary>
/// <param name="verbosity">The verbosity string value.</param>
/// <returns>MSBuild <see cref="Verbosity"/> enumeration.</returns>
public static Verbosity GetMSBuildVerbosity(string verbosity)
{
  switch (verbosity?.ToLower())
  {
    case "quiet":
      return Verbosity.Quiet;
    case "minimal":
      return Verbosity.Minimal;
    case "normal":
      return Verbosity.Normal;
    case "detailed":
      return Verbosity.Verbose;
    case "diagnostic":
      return Verbosity.Diagnostic;
    default:
      throw new CakeException("Encountered unknown MSBuild build log verbosity.");
  }
}
