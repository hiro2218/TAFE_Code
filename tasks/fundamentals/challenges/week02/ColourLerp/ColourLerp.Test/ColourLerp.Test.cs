namespace ColourLerp.Test;

using System.Reflection;
using System.IO;

using TermControl;
using ColourLerp;

public class ColourLerpTest
{

    private const string ColourLerpProgramName = "Program, ColourLerp";

    private string ConstructPath() {
        string basepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string[] splPath = basepath.Split("/");
        string newPath = "";

        for(int i = 0; i < splPath.Length; i++) {
            if(splPath[i] == "bin") {
                break;
            } else {
                newPath += "/" + splPath[i];
            }
        }

        
        return newPath;
    }

    private string LoadContentsFromFile(string path) {

        string projectPath = ConstructPath();
        string data = "";
        using(StreamReader sr = File.OpenText(projectPath + "/" + path))
        {
            data = sr.ReadToEnd();
        }

        return data;
    }

    private string TermControlOutput(string input, string programStr) {
        
        TermController ctlr = new TermController()
            .ResetStdIn()
            .ResetStdOut()
            .RecordStdOut()
            .SetStringInput(input)
            .FindAndInvokeMain(programStr, new string[] {});

        ctlr.FlushStdOut();
        string output = ctlr.GetRawOutputString();
        ctlr.ResetAll();


        return output;
    }

    [Fact]
    public void Test_TwoColours()
    {
        string inputData = LoadContentsFromFile("./files/two_colours.in");
        string expectedData = LoadContentsFromFile("./files/two_colours.out");
        string assemblyName = ColourLerpProgramName;
        
        string output = TermControlOutput(
            inputData,
            assemblyName);


        Assert.Equal(expectedData, output);

    }
    
    [Fact]
    public void Test_ThreeColours()
    {

        string inputData = LoadContentsFromFile("./files/three_colours.in");
        string expectedData = LoadContentsFromFile("./files/three_colours.out");
        string assemblyName = ColourLerpProgramName;
        
        string output = TermControlOutput(
            inputData,
            assemblyName);


        Assert.Equal(expectedData, output);
    }

    
    [Fact]
    public void Test_SevenMono()
    {

        string inputData = LoadContentsFromFile("./files/7_mono.in");
        string expectedData = LoadContentsFromFile("./files/7_mono.out");
        string assemblyName = ColourLerpProgramName;
        
        string output = TermControlOutput(
            inputData,
            assemblyName);


        Assert.Equal(expectedData, output);
    }
    [Fact]
    public void Test_SevenSameColour()
    {

        string inputData = LoadContentsFromFile("./files/7_same_colour.in");
        string expectedData = LoadContentsFromFile("./files/7_same_colour.out");
        string assemblyName = ColourLerpProgramName;
        
        string output = TermControlOutput(
            inputData,
            assemblyName);


        Assert.Equal(expectedData, output);
    }

//     [Fact]
//     public void Test_SevenMonoReversed()
//     {

//     }
//     [Fact]
//     public void Test_ThreeMulti()
//     {

//     }
//     [Fact]
//     public void Test_ThreeMultiReversed()
//     {

//     }
}
