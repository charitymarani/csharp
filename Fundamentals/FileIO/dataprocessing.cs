using System;
using System.IO;
using System.Collections.Generic;// to use List<>
using System.Text; //to use StringBuilder

public class DataProcessor{
  // public delegate void WriterFunc(string outputfile, List<string> item);
  static void WriteSeparated(string filename, List<string> item, string delimiter)
  {
    var text = new StringBuilder();
    text.AppendLine(string.Join(delimiter, item));
    File.AppendAllText(filename, text.ToString());

  }
  
  static void WriteJson(string filename)
  {

  }
  static void ReadSeparatedFile(string inputfile, string outputfile, string separator){
    using(var reader = new StreamReader(inputfile)){
      List<List<string>> values = new List<List<string>>();
      while(!reader.EndOfStream){
        var line  = reader.ReadLine();
        var row = line.Split(separator);
        List<string> details = new List<string>();
        foreach(string item in row){
          details.Add(item);
        }
        values.Add(details);
        

      }
      // To iterate over it.
      foreach (List<string> subList in values)
      {
        WriteSeparated(outputfile, subList, separator);
      }
    }


  }
  static void ReadCsv(string inputfile, string outputfile){
    ReadSeparatedFile(inputfile,outputfile, "," );

  }
  static void ReadTsv(string inputfile, string outputfile){
    ReadSeparatedFile(inputfile, outputfile, "/t");

  }
  static void ReadJson(string filename){

  }


  public static void Main(string[] args){
    ReadCsv("SoccerGameResults.csv", "SoccerGameOutput.csv");
    ReadTsv("SoccerGameResults.tsv", "SoccerGameOutput.tsv");


  }

}
