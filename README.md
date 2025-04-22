The Version number listed in the csproj file will need to be updated to process a build

# Testing Locally with Local Library Builds

To test locally with local library builds, use the following steps:

Replace the NuGet package reference:
   ```xml
   <PackageReference Include="LibDemo" Version="1.0.5"/>
  
  with

   <Reference Include="LibDemo">
     <HintPath>..\..\Path\to\Library\LibDemo.dll</HintPath>
   </Reference>
