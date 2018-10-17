/*

##### REVERB Project ######## Polytech Sorbonne - 2018/2019 #########

Encadrant : François PÊCHEUX 

Participants : Yassine ABBAR - Aurélien ABEL - Fatine BENTIRES ALJ - Geng REN - Alexia ZOUNIAS-SIRABELLA

*/

using System; 
using System.Collections.Generic;
using System.IO; 

namespace class_key
{
	static class Keys  
	{  

		static Dictionary<int, string> dictionary = new Dictionary<int, string>(); 

		public static void generation_keys()
		{
			string dirPath = @"./public_keys/";
			string [] string_files = Directory.GetFiles(dirPath); //correspond to the number of files in the directory
			int number_files = string_files.Length; 
			for (int i=1; i< number_files; i++)
			{
				string public_key = File.ReadAllText(@"./public_keys/public{" + i + "}.pem");
				dictionary.Add(i,public_key);
				Console.WriteLine(public_key); 
			}
			
			//open the files with the public keys created

		}
		//RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); 

 
	}  
} 

 