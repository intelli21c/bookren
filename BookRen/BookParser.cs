using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookRen
{
	public class BookEntry
	{
		public string title;
		public string path;
		public string category;
		public string author;
		public string publisher;
		public string description;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
	}

	internal static class BookParser
	{
		public static List<BookEntry> books;
		//supposed to be file tree traversial parser, but will use preparsed one for now.
		//entry created by processing "find . -type f" and ran through ChatGPT
		public static void parse(string file)
		{
			books = JsonConvert.DeserializeObject<BookEntry[]>(file).ToList<BookEntry>();
		}

		public static string toString()
		{
			return JsonConvert.SerializeObject(books);
		}
	}
}
