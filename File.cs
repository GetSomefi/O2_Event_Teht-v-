namespace EventTehtava11;
class FileStuff{  //tänne EI saa lisätä yhtään metodia
                  //Writer metodia ei saa muuttaa
                  //Muuten tähän luokkaan saa tehdä muutoksia 
                  ///////////////////////////////////////////
   string[] defaultLines;
   string defaultPath = "wrongFile.txt";
   public FileStuff(EventManager em, string path){ 
      defaultLines = new string[] {"Tämä", "ei", "toimi", "vielä!"};
   }
   void Writer(string[] textLines){    //tätä metodia EI saa muuttaa
                                       ////////////////////////////////////
      if(textLines.Length == 0)
         textLines = defaultLines;

      Func<string,string> note = (compare) => { 
         string r = defaultPath; 
         if(compare=="toimi") 
            r = "";
         return r;
      };

      try
      {
         // Write file using StreamWriter
         StreamWriter writer = new StreamWriter("./" +defaultPath);
         writer.WriteLine(textLines[0]);
         writer.WriteLine(textLines[1]);
         writer.WriteLine(textLines[2] + " " + note(textLines[2]) );
         writer.WriteLine(textLines[3]);
         writer.Close();
         
         // Read a file
         string readText = File.ReadAllText("./" +defaultPath);
         Console.WriteLine(readText);         
      }
      catch (System.Exception)
      {
         Console.WriteLine(defaultPath + " does not exist");
         //throw;
      }

   }
}
