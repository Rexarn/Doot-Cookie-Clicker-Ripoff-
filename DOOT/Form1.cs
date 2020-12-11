using System;
using System.Drawing;
using System.Threading.Tasks;
using DarkUI.Forms;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Media;
using Timer = System.Threading.Timer;
using System.Linq;

namespace DOOT
{
    public partial class Randomshidd : DarkForm
    {
        public Randomshidd()
        {
            InitializeComponent();

        }


        public void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString("MMM");
            this.doots.Text = ("");


        }
       /*
        // idk if dis work correctly pls check man pls xoxox
        private void spookgenerator()
        {
            var methods = new Action[10];
            var rng = new Random();
            var shuffled = methods.Select(m => Tuple.Create(rng.Next(), m))
                                  .OrderBy(t => t.Item1).Select(t => t.Item2);
            foreach (var action in shuffled)
            {
                Spooksounds();
            }
        }
        
    private void Spooksounds()
        {
            var methods = new Action[10];
            var rng = new Random();
            var shuffled = methods.Select(m => Tuple.Create(rng.Next(), m))
                                  .OrderBy(t => t.Item1).Select(t => t.Item2);

            foreach (var action in shuffled)
            {
                // List of files from directory, sorted by *.wav type.
                string[] filePaths = Directory.GetFiles(@"C:\Users\thomas.svensson9\Downloads\wav", "*.wav", SearchOption.AllDirectories);

                // Random number from 0 to the amount of files you have
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                int choices = rnd.Next(filePaths.Length);

                // Create a new player with a random filepath from the array
                SoundPlayer player = new SoundPlayer(filePaths[choices]);
                player.Play();
            }

        }
        */
        public void PlayDoot()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
            {
                URL = "http://www.rexarn.tk/doot/doot.mp3"
            };
            wplayer.controls.play();
        }

        public void spookyblink()
        {
            Task.Delay(70);
            spookLabel.Visible = true;
            int counter = 0;
            while (counter < 3)
            {
                Application.DoEvents();
                Thread.Sleep(100);
                ++counter;
                spookLabel.ForeColor = Color.Yellow;
            }
            spookLabel.Visible = false;
            spookLabel.ForeColor = Color.White;
        }
        int dootcount = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            PlayDoot();
            spookyblink();
            // spookgenerator();
            dootcount++;
            doots.Text = dootcount.ToString();


        }



        void Button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == ("Oct"))
            {
                MessageBox.Show("It's Spooktober. Watch the fuck out for the spooks. Keep your trumpets hidden and watch out for skellies.");
            }
            else
            {
                MessageBox.Show("It's not spooktober yet my dude, you're good.");
            }

        }

    }
}
