using System.ComponentModel;

namespace BookRen
{
	public partial class Form1 : Form
	{
		string filepath;
		string bookfolerpath;
		HashSet<string> paths = new();

		BindingList<BookEntry> blbk;

		public Form1()
		{
			InitializeComponent();
			blbk = new BindingList<BookEntry>();
			listBox1.DataSource = blbk;
			listBox1.DisplayMember = "Title";
			bookfolerpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Books").ToString();
			filepath = Path.Combine(bookfolerpath, "books.json").ToString();
			if (!Directory.Exists(bookfolerpath) || !File.Exists(filepath)) checkBox1.Checked = true;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//selection dialog
			if (checkBox1.Checked)
			{
				if (Directory.Exists(bookfolerpath)) openFileDialog1.InitialDirectory = bookfolerpath;
				openFileDialog1.FileName = "books.json";
				if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
				{
					filepath = openFileDialog1.FileName;
				}
			}

			//bookfolerpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Books").ToString();
			//filepath = Path.Combine(bookfolerpath, "books.json").ToString();
			StreamReader sr = new StreamReader(filepath);
			BookParser.parse(sr.ReadToEnd());
			sr.Close();
			blbk = new BindingList<BookEntry>(BookParser.books);
			foreach (BookEntry entry in blbk)
			{
				paths.Add(entry.path);
			}

			/*
			foreach (BookEntry b in BookParser.books)
			{
				listBox1.Items.Add(b.path);
			}*/

			listBox1.DataSource = blbk;
			listBox1.DisplayMember = "Title";
			listBox1.Refresh();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//looks weird but has to "swap out" bound list to change text of listbox
			int si = listBox1.SelectedIndex;
			BookEntry be = blbk[si];
			if (be.path != textBox4.Text)
			{
				if (MessageBox.Show("Path Changed. Move?", "Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					//check for file, or already existing file...
					if (File.Exists(bookfolerpath + blbk[si].path.Substring(1)))
					{
						if (File.Exists(bookfolerpath + textBox4.Text.Substring(1)))
						{
							if (MessageBox.Show("Dest. file already exists. Write over?", "Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
								File.Move(bookfolerpath + blbk[si].path.Substring(1), bookfolerpath + textBox4.Text.Substring(1));
						}
						else File.Move(bookfolerpath + blbk[si].path.Substring(1), bookfolerpath + textBox4.Text.Substring(1));
					}
					else MessageBox.Show("File not present. Aborting.");
				}

			}
			be.title = textBox1.Text;
			be.category = comboBox1.Text;
			be.author = textBox3.Text;
			be.path = textBox4.Text;
			be.description = richTextBox1.Text;
			blbk.RemoveAt(si);
			blbk.Insert(si, be);
			listBox1.SelectedIndex = si;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox1.Text = blbk[listBox1.SelectedIndex].title;
			textBox1.Text = blbk[listBox1.SelectedIndex].title;
			comboBox1.Text = blbk[listBox1.SelectedIndex].category;
			textBox3.Text = blbk[listBox1.SelectedIndex].author;
			textBox4.Text = blbk[listBox1.SelectedIndex].path;
			richTextBox1.Text = blbk[listBox1.SelectedIndex].description;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int si = listBox1.SelectedIndex;
			blbk.RemoveAt(listBox1.SelectedIndex);
			if (blbk.Count > 0) listBox1.SelectedIndex = si;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "\"file:///" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Books").ToString() + blbk[listBox1.SelectedIndex].path.Substring(1) + "\"");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(bookfolerpath)) openFileDialog1.InitialDirectory = bookfolerpath;
			openFileDialog1.FileName = "books.json";
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				filepath = openFileDialog1.FileName;
			}
			if (MessageBox.Show("Save?", "Dialog", MessageBoxButtons.YesNo) == DialogResult.No) return;

			BookParser.books = blbk.ToList();
			StreamWriter sw = new StreamWriter(filepath);
			sw.Write(BookParser.toString());
			sw.Close();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var be = new BookEntry();
			be.title = textBox1.Text;
			be.category = comboBox1.Text;
			be.author = textBox3.Text;
			be.path = textBox4.Text;
			be.description = richTextBox1.Text;
			//should I check whether PDF exists?
			blbk.Insert(listBox1.SelectedIndex + 1, be);
		}

		void recursive_add(string path)
		{
			foreach (var f in Directory.GetFiles(path))
			{
				//check if file is pdf or epub?
				if (f.Substring(f.Length - 3) == "pdf" || f.Substring(f.Length - 4) == "epub")
				{
					string relpath = ("." + f.Substring(bookfolerpath.Length)).Replace('\\', '/');
					if (paths.Add(f)) //true -> not on the list, create new Entry.
					{
						//var be = new BookEntry { path = "." + f.Substring(f.IndexOf("Books") + 5) };
						var be = new BookEntry { title = relpath.Substring(relpath.LastIndexOf('/') + 1), path = relpath };
						blbk.Add(be);
					}

				}
			}
			foreach (var d in Directory.EnumerateDirectories(path))
			{
				recursive_add(d);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//folder traverse, scan and add if not exists
			recursive_add(bookfolerpath);

		}
	}
}
