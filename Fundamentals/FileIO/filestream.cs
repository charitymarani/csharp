using System;
using System.IO;

namespace FileStreamApp{
  public class FileStreamExample
  {
    //  write  byte(s) of data into file using OpenOrCreate file mode which can be used for read and write operations.
    public static void WriteBytes(){
      FileStream f = new FileStream("b.txt", FileMode.OpenOrCreate); //creating a file
      f.WriteByte(65);//writing byte into stream  
                      // multiple bytes
      for (int i = 65; i <= 90; i++)
      {
        f.WriteByte((byte)i);
      }
      f.Close();//closing stream 

    }
    // Read bytes of data
    public static void ReadBytes()
    {
      FileStream f = new FileStream("b.txt", FileMode.OpenOrCreate); //creating a file
      int i = 0;
      while ((i = f.ReadByte()) != -1)
      {
        Console.Write((char)i);
      }
      f.Close();//closing stream 

    }
    public static void StreamWriterFunc(){
      FileStream f = new FileStream("output.txt", FileMode.Create);
      StreamWriter s = new StreamWriter(f);

      s.WriteLine("hello c#");
      s.WriteLine("hello again");
      s.Close();
      f.Close();
      Console.WriteLine("File created successfully...");
    }
    public static void StreaReaderFunc(){
      FileStream f = new FileStream("output.txt", FileMode.OpenOrCreate);
      StreamReader s = new StreamReader(f);
      //  Read single line
      string line = s.ReadLine();
      Console.WriteLine(line);
      // Read all lines
      string lines = "";
      while ((lines = s.ReadLine()) != null)
      {
        Console.WriteLine(lines);
      }
      s.Close();
      f.Close();
    }

    // TextWriter is abstract class. It is used to write text or sequential series of characters into file
    public static void TextWriterFunc(){
      using(TextWriter writer= File.CreateText("f.txt")){
        writer.WriteLine("Hello c#");
        writer.WriteLine("c# file handler");
      }
    }
    public static void TextReaderFunc()
    {
      
      using (TextReader reader = File.OpenText("f.txt"))
      {
        // reads data till the end of file.
        Console.WriteLine(reader.ReadToEnd());
        // reads one line.
        Console.WriteLine(reader.ReadLine());
      }
    }

    // write binary data into stream
    public static void BinaryWriterFunc(){

      string name = "binaryFile.dat";
      using(BinaryWriter writer = new BinaryWriter(File.Open(name, FileMode.Create))){
        writer.Write(2.5);
        writer.Write("a string");
        writer.Write("another string");
        writer.Write(true);

      }
    }
    static void BinaryReaderFunc(){
      string name = "binaryFile.dat";
      using(BinaryReader reader = new BinaryReader(File.Open(name, FileMode.Open))){
        Console.WriteLine("Double Value : " + reader.ReadDouble());
        Console.WriteLine("String Value : " + reader.ReadString());
        Console.WriteLine("Boolean Value : " + reader.ReadBoolean());

      }
    }
    public static void Main(string[] args)
    {


      // WriteBytes();
      // ReadBytes();
      // StreamWriterFunc();
      // StreaReaderFunc();
      // TextWriterFunc();
      // TextReaderFunc();
      BinaryWriterFunc();
      BinaryReaderFunc();
    }
  }

}
