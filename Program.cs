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
				Console.WriteLine("Please choose the song that you'd like sung!");
				string request = Console.ReadLine();
				string response = shutiaoSys.SearchSong(request);
				if(response != null){
					Console.WriteLine("Let's play " + response);
					Console.WriteLine("====================================");
					Console.WriteLine("!@#$%^&*()");
					Console.WriteLine("!@#$%^&*()");
					Console.WriteLine("===============END=====================");
				}
				else{
					continue;
				}
			}
	}
}
}
