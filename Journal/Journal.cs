using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Packaging;
using System.Windows.Controls;


namespace Journal
{
    public partial class Journal : Form
    {
        
        public Journal()
        {
            InitializeComponent();

            string defaultdir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Journal");
                        
            if (Properties.Settings.Default.JOURNAL_PATH == "none")
            {
                Properties.Settings.Default.JOURNAL_PATH = defaultdir;
            }

            checkJournalPath();

            DateTime current = cal.SelectionStart;

            existingEntriesThisMonth(current);
            displayEntryFor(current);

            journalentry.KeyUp1 += new System.Windows.Input.KeyEventHandler(this.journalentry_KeyUp);
           
        }

        private void checkJournalPath()
        {
            if (!Directory.Exists(Properties.Settings.Default.JOURNAL_PATH))
                Directory.CreateDirectory(Properties.Settings.Default.JOURNAL_PATH);
        }

        private void existingEntriesThisMonth(DateTime date)
        {
            string thisMonth = date.ToString("yyyy-MM");
            thisMonth = Path.Combine(Properties.Settings.Default.JOURNAL_PATH, thisMonth);

            if (Directory.Exists(thisMonth))
            {
                
                string[] files = Directory.GetFiles(thisMonth);

                DateTime[] dates = new DateTime[files.Length];

                for (int i = 0; i < files.Length; i++)
                {
                    string f = Path.GetFileNameWithoutExtension(files[i]);

                    dates[i] = DateTime.Parse(f);
                }


                cal.BoldedDates = dates;
            }
        }
        

        private void save_Click(object sender, EventArgs e)
        {
            saveEntry();
            journalentry.Focus();
            journalentry.Select();
        }

        public void saveEntry()
        {
            DateTime current = cal.SelectionStart;

            string folder = current.ToString("yyyy-MM");
            string file = current.ToString("yyyy-MM-dd");

            folder = Path.Combine(Properties.Settings.Default.JOURNAL_PATH, folder);
            file = Path.Combine(folder, file + ".txt");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (StreamWriter w = File.CreateText(file))
            {
                w.Write(journalentry.Text);
            }

            checkSizeOnDisk(file);
            computeStats();
            existingEntriesThisMonth(current);
        }

        private void checkSizeOnDisk(string file)
        {
            if (File.Exists(file))
            {
                FileInfo f = new FileInfo(file);
                float size = (float)f.Length / (float) 1024;

                filetime.Text = f.LastWriteTime.ToString("MM/dd/yy hh:mm tt");

                filesize.Text = size.ToString("n2") + " Kb";
                
                
            }
        }

        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime current = cal.SelectionStart;
            displayEntryFor(current);
            existingEntriesThisMonth(current);
            journalentry.Focus();
            journalentry.Select();
        }

        private void displayEntryFor(DateTime current)
        {
            existingEntriesThisMonth(cal.SelectionStart);

            string folder = current.ToString("yyyy-MM");
            string file = current.ToString("yyyy-MM-dd");

            folder = Path.Combine(Properties.Settings.Default.JOURNAL_PATH, folder);
            file = Path.Combine(folder, file + ".txt");

            displayFile(file);
            checkSizeOnDisk(file);
            computeStats();

        }

        private void displayFile(string file)
        {
            if (File.Exists(file))
                journalentry.Text = File.ReadAllText(file);
            else
                journalentry.Text = "";

            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            journalentry.Text = "";
            journalentry.Select();
            computeStats();
        }

      
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog(this);
            a.Dispose();
        }

        private void saveCurrentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveEntry();
            journalentry.Focus();
            journalentry.Select();
        }

        private void changeJournalFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form c = new ChangeFolder();
            c.ShowDialog(this);
            c.Dispose();
            
            checkJournalPath();
            existingEntriesThisMonth(cal.SelectionStart);
            displayEntryFor(cal.SelectionStart);
        }

        private void journalentry_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            computeStats();
        }
                        
        private void computeStats()
        {
            wordcount.Text = (journalentry.Text.Split(' ').Length-1).ToString();
            charcount.Text = journalentry.Text.Length.ToString();
        }
    }
}
