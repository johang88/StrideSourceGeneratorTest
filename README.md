# Stride source generator example

Has a simple source generator that adds a string property named dummy do any class with the attribute `DummyAttribute`.

Projects:
* StrideSourceGeneratorTest.Generators - Source generator project
* StrideSourceGeneratorTest.csproj - Game project, references the generator project
* StrideSourceGeneratorTest.Windows.csproj - Windows executable project, references the game project

There are two sln files

* StrideSourceGeneratorTest.sln used in GameStudio, does not contain an explicit reference to the generator project, only references through the project reference in `StrideSourceGeneratorTest.csproj`
* StrideSourceGeneratorTest.Full.sln used in visual studio when developing the source generator, contains all projects