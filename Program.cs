using System;
using System.IO;
using System.Collections.Generic;

namespace KaraokeCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Karaoke!");
            var shutiaoSys = new Recorder();
	    shutiaoSys.Album.Add("allthistime");
	    while(true){
		shutiaoSys.ListAllSongs();
		Console.WriteLine("Please choose the song that you'd like song!");
		string request = Console.ReadLine();
		string response = shutiaoSys.SearchSong(request);
		if(response != null){
			var player = new Player();
			player.fileName = response;
			Console.WriteLine("Now playing " + player.fileName);
			player.play();
		}
		else{	
			continue;
		}
		}
	}
    }
}
