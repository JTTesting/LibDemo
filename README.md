The Version number listed in the csproj file will need to be updated to process a build

To test locally with local library builds use the following
  Replace
      <PackageReference Include="LibDemo" Version="1.0.5"/>
  
  with
      <Reference Include="LibDemo">
        <HintPath>..\..\Path\to\Library\LibDemo.dll</HintPath>
      </Reference>
