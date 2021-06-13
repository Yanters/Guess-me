using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Guess_me_
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player1 = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        WindowsMediaPlayer player3 = new WindowsMediaPlayer();
        WindowsMediaPlayer player4 = new WindowsMediaPlayer();
        bool haking = false;
        bool wlasnewyrazy = false;
        int i = 0;
        string file;
        string uzytelitery="";
        string target;
        string wyswietlanaodpowiedz = "";
        public int indexslowa;
        public int points = 0;
        public int wrongletter = 0;
        public string[] wordstopickform = { "able", "about", "account", "acid", "across", "act", "addition", "adjustment", "advertisement", "after", "again", "against", "agreement", "air", "all", "almost", "among", "amount", "amusement", "and", "angle", "angry", "animal", "answer", "ant", "any", "apparatus", "apple", "approval", "arch", "argument", "arm", "army", "art", "as", "at", "attack", "attempt", "attention", "attraction", "authority", "automatic", "awake", "baby", "back", "bad", "bag", "balance", "ball", "band", "base", "basin", "basket", "bath", "be", "beautiful", "because", "bed", "bee", "before", "behaviour", "belief", "bell", "bent", "berry", "between", "bird", "birth", "bit", "bite", "bitter", "black", "blade", "blood", "blow", "blue", "board", "boat", "body", "boiling", "bone", "book", "boot", "bottle", "box", "boy", "brain", "brake", "branch", "brass", "bread", "breath", "brick", "bridge", "bright", "broken", "brother", "brown", "brush", "bucket", "building", "bulb", "burn", "burst", "business", "but", "butter", "button", "by", "cake", "camera", "canvas", "card", "care", "carriage", "cart", "cat", "cause", "certain", "chain", "chalk", "chance", "change", "cheap", "cheese", "chemical", "chest", "chief", "chin", "church", "circle", "clean", "clear", "clock", "cloth", "cloud", "coal", "coat", "cold", "collar", "colour", "comb", "come", "comfort", "committee", "common", "company", "comparison", "competition", "complete", "complex", "condition", "connection", "conscious", "control", "cook", "copper", "copy", "cord", "cork", "cotton", "cough", "country", "cover", "cow", "crack", "credit", "crime", "cruel", "crush", "cry", "cup", "cup", "current", "curtain", "curve", "cushion", "damage", "danger", "dark", "daughter", "day", "dead", "dear", "death", "debt", "decision", "deep", "degree", "delicate", "dependent", "design", "desire", "destruction", "detail", "development", "different", "digestion", "direction", "dirty", "discovery", "discussion", "disease", "disgust", "distance", "distribution", "division", "do", "dog", "door", "doubt", "down", "drain", "drawer", "dress", "drink", "driving", "drop", "dry", "dust", "ear", "early", "earth", "east", "edge", "education", "effect", "egg", "elastic", "electric", "end", "engine", "enough", "equal", "error", "even", "event", "ever", "every", "example", "exchange", "existence", "expansion", "experience", "expert", "eye", "face", "fact", "fall", "false", "family", "far", "farm", "fat", "father", "fear", "feather", "feeble", "feeling", "female", "fertile", "fiction", "field", "fight", "finger", "fire", "first", "fish", "fixed", "flag", "flame", "flat", "flight", "floor", "flower", "fly", "fold", "food", "foolish", "foot", "for", "force", "fork", "form", "forward", "fowl", "frame", "free", "frequent", "friend", "from", "front", "fruit", "full", "future", "garden", "general", "get", "girl", "give", "glass", "glove", "go", "goat", "gold", "good", "government", "grain", "grass", "great", "green", "grey", "grip", "group", "growth", "guide", "gun", "hair", "hammer", "hand", "hanging", "happy", "harbour", "hard", "harmony", "hat", "hate", "have", "he", "head", "healthy", "hear", "hearing", "heart", "heat", "help", "high", "history", "hole", "hollow", "hook", "hope", "horn", "horse", "hospital", "hour", "house", "how", "humour", "I", "ice", "idea", "if", "ill", "important", "impulse", "in", "increase", "industry", "ink", "insect", "instrument", "insurance", "interest", "invention", "iron", "island", "jelly", "jewel", "join", "journey", "judge", "jump", "keep", "kettle", "key", "kick", "kind", "kiss", "knee", "knife", "knot", "knowledge", "land", "language", "last", "late", "laugh", "law", "lead", "leaf", "learning", "leather", "left", "leg", "let", "letter", "level", "library", "lift", "light", "like", "limit", "line", "linen", "lip", "liquid", "list", "little", "living", "lock", "long", "look", "loose", "loss", "loud", "love", "low", "machine", "make", "male", "man", "manager", "map", "mark", "market", "married", "mass", "match", "material", "may", "meal", "measure", "meat", "medical", "meeting", "memory", "metal", "middle", "military", "milk", "mind", "mine", "minute", "mist", "mixed", "money", "monkey", "month", "moon", "morning", "mother", "motion", "mountain", "mouth", "move", "much", "muscle", "music", "nail", "name", "narrow", "nation", "natural", "near", "necessary", "neck", "need", "needle", "nerve", "net", "new", "news", "night", "no", "noise", "normal", "north", "nose", "not", "note", "now", "number", "nut", "observation", "of", "off", "offer", "office", "oil", "old", "on", "only", "open", "operation", "opinion", "opposite", "or", "orange", "order", "organization", "ornament", "other", "out", "oven", "over", "owner", "page", "pain", "paint", "paper", "parallel", "parcel", "part", "past", "paste", "payment", "peace", "pen", "pencil", "person", "physical", "picture", "pig", "pin", "pipe", "place", "plane", "plant", "plate", "play", "please", "pleasure", "plough", "pocket", "point", "poison", "polish", "political", "poor", "porter", "position", "possible", "pot", "potato", "powder", "power", "present", "price", "print", "prison", "private", "probable", "process", "produce", "profit", "property", "prose", "protest", "public", "pull", "pump", "punishment", "purpose", "push", "put", "quality", "question", "quick", "quiet", "quite", "rail", "rain", "range", "rat", "rate", "ray", "reaction", "reading", "ready", "reason", "receipt", "record", "red", "regret", "regular", "relation", "religion", "representative", "request", "respect", "responsible", "rest", "reward", "rhythm", "rice", "right", "ring", "river", "road", "rod", "roll", "roof", "room", "root", "rough", "round", "rub", "rule", "run", "sad", "safe", "sail", "salt", "same", "sand", "say", "scale", "school", "science", "scissors", "screw", "sea", "seat", "second", "secret", "secretary", "see", "seed", "seem", "selection", "self", "send", "sense", "separate", "serious", "servant", "sex", "shade", "shake", "shame", "sharp", "sheep", "shelf", "ship", "shirt", "shock", "shoe", "short", "shut", "side", "sign", "silk", "silver", "simple", "sister", "size", "skin", "skirt", "sky", "sleep", "slip", "slope", "slow", "small", "smash", "smell", "smile", "smoke", "smooth", "snake", "sneeze", "snow", "so", "soap", "society", "sock", "soft", "solid", "some", "son", "song", "sort", "sound", "soup", "south", "space", "spade", "special", "sponge", "spoon", "spring", "square", "stage", "stamp", "star", "start", "statement", "station", "steam", "steel", "stem", "step", "stick", "sticky", "stiff", "still", "stitch", "stocking", "stomach", "stone", "stop", "store", "story", "straight", "strange", "street", "stretch", "strong", "structure", "substance", "such", "sudden", "sugar", "suggestion", "summer", "sun", "support", "surprise", "sweet", "swim", "system", "table", "tail", "take", "talk", "tall", "taste", "tax", "teaching", "tendency", "test", "than", "that", "the", "then", "theory", "there", "thick", "thin", "thing", "this", "thought", "thread", "throat", "through", "through", "thumb", "thunder", "ticket", "tight", "till", "time", "tin", "tired", "to", "toe", "together", "tomorrow", "tongue", "tooth", "top", "touch", "town", "trade", "train", "transport", "tray", "tree", "trick", "trouble", "trousers", "true", "turn", "twist", "umbrella", "under", "unit", "up", "use", "value", "verse", "very", "vessel", "view", "violent", "voice", "waiting", "walk", "wall", "war", "warm", "wash", "waste", "watch", "water", "wave", "wax", "way", "weather", "week", "weight", "well", "west", "wet", "wheel", "when", "where", "while", "whip", "whistle", "white", "who", "why", "wide", "will", "wind", "window", "wine", "wing", "winter", "wire", "wise", "with", "woman", "wood", "wool", "word", "work", "worm", "wound", "writing", "wrong", "year", "yellow", "yes", "yesterday", "you", "young", "Bernhard", "Breytenbach", "Android", };
        public static string wylosowaneslowo = "";
        public string litera = "";
        public static bool winwyswietlacz = false;
        public Form1()
        {
            InitializeComponent();
            wpiszlitere.Focus();
            wyraz();
            player.URL = "gamemusic.mp3";
            player1.URL = "wingame.mp3";
            player2.URL = "lossgame.m4a";
            player3.URL = "goodletter.mp3";
            player4.URL = "wrongletter.m4a";
        }
        public void przegrana()
        {
            player2.controls.play();
            winwyswietlacz = false;
            end endd = new end();
            endd.ShowDialog();
            
            
            //MessageBox.Show("Wyczerpałeś limit szans, szukanym słowem było: " + wylosowaneslowo);
            
            wrongletter = 0;

            pictureBox1.Image = Guess_me_.Properties.Resources.brakbledu;
            wyraz();

        }

        public void wygranacheck()
        {
            bool win = true;
            
                if(word.Text.Contains("_"))
                {
                    win = false;
                }
            
            if(win)
            {
                player1.controls.play();
                winwyswietlacz = true;
                end enddd = new end();
                enddd.ShowDialog();
                
                points += 25;
                wrongletter = 0;
               
                                     
                
                
                pictureBox1.Image = Guess_me_.Properties.Resources.brakbledu;
                wyraz();
               
            }
        }
        public void lettercheck()
        {
            wpiszlitere.Text = "";
            bool trafiony = false;
            
            for (int i = 0; i < wylosowaneslowo.Length; i++)
            {
                if (Convert.ToString(wylosowaneslowo[i]) == litera)
                {
                    if (!uzytelitery.Contains(litera))
                    { points += 5;
                        player3.controls.play();
                    }
                    
                    trafiony = true;
                    
                    word.Text = word.Text.Remove(((i * 2)), 1);
                    word.Text = word.Text.Insert(((i * 2)), Convert.ToString(wylosowaneslowo[i]));

                    
                }
               
                
           }
            
            if(!trafiony)
            {
                if (litera!="" && !uzytelitery.Contains(litera))
                {
                    wrongletter++;
                    player4.controls.play();
                }
                
            }
            pointslabel.Text = "Points: " + points;
            wyswietlanaodpowiedz = word.Text;
            if (litera != "" && !uzytelitery.Contains(litera))
            { uzytelitery += litera + ", "; }
            label2.Text = uzytelitery;
            wygranacheck();
            pointslabel.Text = "Points: " + points;
            
        }

        public void chooseword()
        {
            indexslowa = new Random().Next(wordstopickform.Length);
            wylosowaneslowo = wordstopickform[indexslowa];

            //hacks.Visible = false;
            hacks.Text = wordstopickform[indexslowa];

            word.Text = "";
            for (int i = 0; i < wordstopickform[indexslowa].Length; i++)
            {
                word.Text += "_ ";
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                litera = Convert.ToString(wpiszlitere.Text);
                litera = litera.ToUpper();
            }
            catch (Exception)
            {

                litera = " " ;
            }
           
            wpiszlitere.Text = "";
            wpiszlitere.Focus();
          // wpiszlitere.Cursor = wpiszlitere.de
           /* if (litera != "" && !uzytelitery.Contains(litera))
            { uzytelitery += litera + ", "; }
            label2.Text = uzytelitery;*/
            lettercheck();
            switch (wrongletter)
            {
                case 1:
                    pictureBox1.Image = Guess_me_.Properties.Resources.blad1;
                    break;
                case 2:
                    pictureBox1.Image = Guess_me_.Properties.Resources.blad2;
                    break;
                case 3:
                    pictureBox1.Image = Guess_me_.Properties.Resources.blad3;
                    break;
                case 4:
                    pictureBox1.Image = Guess_me_.Properties.Resources.blad4;
                    break;
                case 5:
                    pictureBox1.Image = Guess_me_.Properties.Resources.blad5;
                    przegrana();

                    break;
            }
            
        }
        public void wyraz()
        {
            pictureBox1.Image = Guess_me_.Properties.Resources.brakbledu;
            if (wlasnewyrazy)
            {
                StreamReader sr = new StreamReader(file);
                while (sr.ReadLine() != null)
                {
                    i++;
                }
                sr.Dispose();
                sr = new StreamReader(file);

                Random r = new Random();
                for (int k = 0; k < r.Next(1, i - 1); k++)
                {
                    target = sr.ReadLine();
                }
                sr.Dispose();
                wylosowaneslowo = target;
                wylosowaneslowo = wylosowaneslowo.ToUpper();
                target = target.ToUpper();
                    hacks.Text = target;
                 
                word.Text = "";
                try
                {
                    for (int i = 0; i < target.Length; i++)
                    {
                        word.Text += "_ ";

                    }
                }
                catch (Exception)
                {

                    wyraz();
                }
               /* for (int i = 0; i < target.Length; i++)
                {
                    word.Text += "_ ";

                }
                */
            }
            else
            {
                indexslowa = new Random().Next(wordstopickform.Length);
                wylosowaneslowo = wordstopickform[indexslowa];
                wylosowaneslowo = wylosowaneslowo.ToUpper();
                    hacks.Text = wordstopickform[indexslowa];
                  
               

                word.Text = "";
                for (int i = 0; i < wordstopickform[indexslowa].Length; i++)
                {
                    word.Text += "_ ";

                }
            }
            uzytelitery = "";
            label2.Text = "";
        }
        

        private void własneWyrazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 wl = new Form2();
            if (wl.ShowDialog() == DialogResult.OK)
            {
                file = Form2.path;
            }
            /*if (Form2.path==null|| Form2.path == "")
            {
                wl.Close();
                wyraz();
            }*/
            try
            {
                StreamReader sr = new StreamReader(file);
                while (sr.ReadLine() != null)
                {
                    i++;
                }
                sr.Dispose();
                sr = new StreamReader(file);

                Random r = new Random();
                for (int k = 0; k < r.Next(1, i - 1); k++)
                {
                    target = sr.ReadLine();
                }
                sr.Dispose();
                //MessageBox.Show(target);
                wlasnewyrazy = true;
                //wylosowaneslowo = target;
                //hacks.Text = target;
                wyraz();
            }
            catch (Exception)
            {

                wl.Close();
                wyraz();
            }
            //StreamReader sr = new StreamReader(file);
            
            
            
        }

        private void pointslabel_Click(object sender, EventArgs e)
        {

        }

        private void wyrazySystemoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wlasnewyrazy = false;
            wyraz();
        }

        private void cheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!haking)
            {
                
                haking = true;
                hacks.Visible = true;
            }
            else
            {
                if (haking)
                {
                    
                    haking = false;
                    hacks.Visible = false;
                }
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            player1.controls.stop();
            player2.controls.stop();
            player3.controls.stop();
            player4.controls.stop();
        }

        private void howToCreateWordlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 helpmepls = new Form3();
            helpmepls.ShowDialog();
        }
    }
}
