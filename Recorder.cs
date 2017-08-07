using System.Collections.Generic;
using System;
using System.IO;

public class Recorder{
       public List<string> Album = new List<string>();

       public void ListAllSongs(){
       		Console.WriteLine("======Here is our List==============");
       		foreach(var song in Album){
       			Console.WriteLine(song);
       		}
       		Console.WriteLine("====================================");
       }
       // return song file address.
       public string SearchSong(string songName){
       		var ValidSongName = MatchSongName(songName);
       		if(ValidSongName != null){
       			string SongAddress = FindSongAddress(ValidSongName);
       			if(SongAddress != null){
       				return SongAddress;
       			}
       			else{
       				Console.WriteLine("Vaid" + ValidSongName + ", But Couldn't locate");
       				return null;
       			}
       		}
       		else{
       			Console.WriteLine("Invalid Song Name");
       			return null;
       		}
       }

       private string MatchSongName(string reqSong){
       		string ValidSongName = null;
	       	foreach (var song in Album){
	       		if(song.StartsWith(reqSong)){
	       			Console.WriteLine("Matched to song: " + song);
				ValidSongName = song;
	       		}
	       		else continue;
	       	}
	       	return ValidSongName;
		}

	    private string FindSongAddress(string songName){
	    	string suggestedFileName = songName + ".txt";
	    	if (File.Exists(suggestedFileName)){
			Console.WriteLine("Find " + suggestedFileName + " in the library");
	    		return suggestedFileName;
	    	}
	    	else {
	    		return null;
	    	}
	    }
	}