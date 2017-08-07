using System;
using System.IO;

public class Player{
       public string fileName;
       public void play(){
       	      var lines = File.ReadAllLines(fileName);
	      foreach (var line in lines){
	      	      Singer.WriteLine(line);
		      }
	}
}		      


       