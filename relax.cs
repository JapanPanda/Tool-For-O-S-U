using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowsInput;
namespace Osu_Relax
{
    public partial class Relax : Form
    {
        List<string> songList = new List<string>();
        List<string> hitobjectInfo = new List<string>();
        List<string> circleInfo = new List<string>();
        List<string> sliderInfo = new List<string>();
        List<string> spinnerInfo = new List<string>();
        List<string> timestoPress = new List<string>();
        List<int> _timestoPress = new List<int>();
        List<float> beatsPerMinute = new List<float>();
        List<float> timingPointsInfo = new List<float>();
        List<string> sliderPointsInfo = new List<string>();
        List<int> _sliderPointsInfo = new List<int>();
        List<string> sliderpixelLengthInfo = new List<string>();
        List<float> _sliderpixelLengthInfo = new List<float>();
        List<string> sliderrepeatInfo = new List<string>();
        List<int> _sliderrepeatPointsInfo = new List<int>();
        List<string> Timingpoints = new List<string>();
        Stopwatch relaxitup = new Stopwatch();
        private KeyHandler boop;
        private KeyHandler doop;
        private KeyHandler poop;
        private KeyHandler moop;
        Random keydown = new Random();
        string fullSong;
        string osuTitle;
        string song;
        string difficulty;
        int circles;
        int sliders;
        int spinners;
        int timetoWait;
        int timetoWait2;
        float pixelLength;
        float SliderMultiplier;
        float BPM;
        float modifiedBPM = 1;
        int sliderEndTime;
        bool playingSong = false;
        bool foundHitObjects = false;
        bool foundSliderMultiplier = false;
        bool foundTimingPoint = false;
        bool foundColours = false;
        bool firstCircle = true;
        bool relaxing = true;
        bool lastCircle = false;
        bool primaryClick = true;
        bool needtoOffset = false;
        bool needtoEarlyOffset = false;
        bool sliderOffset = false;
        bool slider = false;
        bool forceEarly;
        bool forceLate;
        string hitObjects;
        public Relax()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("G");
            comboBox1.Items.Add("H");
            comboBox1.Items.Add("I");
            comboBox1.Items.Add("J");
            comboBox1.Items.Add("K");
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("N");
            comboBox1.Items.Add("O");
            comboBox1.Items.Add("P");
            comboBox1.Items.Add("Q");
            comboBox1.Items.Add("R");
            comboBox1.Items.Add("S");
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("U");
            comboBox1.Items.Add("V");
            comboBox1.Items.Add("W");
            comboBox1.Items.Add("X");
            comboBox1.Items.Add("Y");
            comboBox1.Items.Add("Z");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");
            comboBox2.Items.Add("C");
            comboBox2.Items.Add("D");
            comboBox2.Items.Add("E");
            comboBox2.Items.Add("F");
            comboBox2.Items.Add("G");
            comboBox2.Items.Add("H");
            comboBox2.Items.Add("I");
            comboBox2.Items.Add("J");
            comboBox2.Items.Add("K");
            comboBox2.Items.Add("L");
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("N");
            comboBox2.Items.Add("O");
            comboBox2.Items.Add("P");
            comboBox2.Items.Add("Q");
            comboBox2.Items.Add("R");
            comboBox2.Items.Add("S");
            comboBox2.Items.Add("T");
            comboBox2.Items.Add("U");
            comboBox2.Items.Add("V");
            comboBox2.Items.Add("W");
            comboBox2.Items.Add("X");
            comboBox2.Items.Add("Y");
            comboBox2.Items.Add("Z");
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("A");
            comboBox3.Items.Add("B");
            comboBox3.Items.Add("C");
            comboBox3.Items.Add("D");
            comboBox3.Items.Add("E");
            comboBox3.Items.Add("F");
            comboBox3.Items.Add("G");
            comboBox3.Items.Add("H");
            comboBox3.Items.Add("I");
            comboBox3.Items.Add("J");
            comboBox3.Items.Add("K");
            comboBox3.Items.Add("L");
            comboBox3.Items.Add("M");
            comboBox3.Items.Add("N");
            comboBox3.Items.Add("O");
            comboBox3.Items.Add("P");
            comboBox3.Items.Add("Q");
            comboBox3.Items.Add("R");
            comboBox3.Items.Add("S");
            comboBox3.Items.Add("T");
            comboBox3.Items.Add("U");
            comboBox3.Items.Add("V");
            comboBox3.Items.Add("W");
            comboBox3.Items.Add("X");
            comboBox3.Items.Add("Y");
            comboBox3.Items.Add("Z");
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Items.Add("A");
            comboBox4.Items.Add("B");
            comboBox4.Items.Add("C");
            comboBox4.Items.Add("D");
            comboBox4.Items.Add("E");
            comboBox4.Items.Add("F");
            comboBox4.Items.Add("G");
            comboBox4.Items.Add("H");
            comboBox4.Items.Add("I");
            comboBox4.Items.Add("J");
            comboBox4.Items.Add("K");
            comboBox4.Items.Add("L");
            comboBox4.Items.Add("M");
            comboBox4.Items.Add("N");
            comboBox4.Items.Add("O");
            comboBox4.Items.Add("P");
            comboBox4.Items.Add("Q");
            comboBox4.Items.Add("R");
            comboBox4.Items.Add("S");
            comboBox4.Items.Add("T");
            comboBox4.Items.Add("U");
            comboBox4.Items.Add("V");
            comboBox4.Items.Add("W");
            comboBox4.Items.Add("X");
            comboBox4.Items.Add("Y");
            comboBox4.Items.Add("Z");
        }
        [STAThread]
        void Parse()
        {
            outputWindow.Text += "\r\nParsing songs...";
            Process[] proc = Process.GetProcessesByName("osu!");
            Process osu = proc[0];
            osuTitle = osu.MainWindowTitle;
                if (osuTitle.Length > 9)
                {
                    song = osuTitle.Substring(osuTitle.IndexOf('-') + 2);
                    song = song.Remove(song.LastIndexOf('['));
                    difficulty = osuTitle.Substring(osuTitle.IndexOf('['));
                    outputWindow.Text = "Output Window";
                    if (proc.Length > 0)
                    {
                        string dir = proc[0].Modules[0].FileName;
                        dir = dir.Remove(dir.LastIndexOf('\\')) + "\\songs";
                        try
                        {
                            string[] currentSong = Directory.GetFiles(dir, song + "*.osu", SearchOption.AllDirectories);
                            if (currentSong.Count() == 0)
                            {
                                fullSong = currentSong[0].Remove(currentSong[0].LastIndexOf('[')) + difficulty + ".osu";
                                outputWindow.Text += "Found the map.\r\n" + fullSong;
                                playingSong = true;
                            }
                            else if (currentSong.Count() > 0)
                            {
                                foreach (string z in currentSong)
                                {
                                    if (z == z.Remove(z.LastIndexOf('[')) + difficulty + ".osu")
                                    {
                                        songList.Add(z.Remove(z.LastIndexOf('[')) + difficulty + ".osu");
                                        if (songList.Count() == 1)
                                        {
                                            fullSong = songList[0];
                                            playingSong = true;
                                        }
                                        else if (songList.Count() > 1)
                                        {
                                            MessageBox.Show("Found multiple versions. Choose one");
                                            foreach (string c in songList)
                                            {
                                                outputWindow.Text += "\r\nFound the song " + c;
                                                playingSong = true;
                                            }
                                        }
                                        else
                                        {
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Could not find it");
                            }
                        }
                        catch (Exception p)
                        {
                            MessageBox.Show(p.ToString());
                        }
                    }
                    else
                    {
                        outputWindow.Text += "\r\nFailed to find osu!";
                    }
                }
                else
                {
                    outputWindow.Text = "\r\nNot playing a song";
                    playingSong = false;
                }
            if (playingSong == true)
            {
                outputWindow.Text += "\r\nGrabbed: " + fullSong + "\r\nReading it...";
                readFile();
            }
            songList.Clear();
            relaxing = true;
        }

        void readFile()
        {
            getSliderVelocity();
            getTimingPoints();
            StreamReader osuReader = new StreamReader(@fullSong);
            while (foundHitObjects == false)
            {
                if (osuReader.ReadLine() == "[HitObjects]")
                {
                    hitObjects = osuReader.ReadToEnd();
                    string[] Hitobjects = hitObjects.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    for (int s = 0; s < Hitobjects.Count() - 1; s++)
                    {
                        hitobjectInfo.Add(Hitobjects[s]);
                    }
                    foreach (string z in hitobjectInfo)
                    {
                        string[] HitObjectInfo = z.Split(',');
                        if (HitObjectInfo[3] == "1" || HitObjectInfo[3] == "5" || HitObjectInfo[3] == "69" || HitObjectInfo[3] == "37" || HitObjectInfo[3] == "21")
                        {
                            circleInfo.Add(z);
                            timestoPress.Add(HitObjectInfo[2]);
                            circles++;
                        }
                        else if (HitObjectInfo[3] == "2" || HitObjectInfo[3] == "6" || HitObjectInfo[3] == "70" || HitObjectInfo[3] == "38")
                        {
                            sliderInfo.Add(z);
                            timestoPress.Add(HitObjectInfo[2]);
                            sliderPointsInfo.Add(HitObjectInfo[2]);
                            sliderrepeatInfo.Add(HitObjectInfo[6]);
                            sliderpixelLengthInfo.Add(HitObjectInfo[7]);
                            sliders++;
                        }
                        else if (HitObjectInfo[3] == "8" || HitObjectInfo[3] == "12")
                        {
                            spinnerInfo.Add(z);
                            timestoPress.Add(HitObjectInfo[2]);
                            spinners++;
                        }
                    }
                    
                    osuReader.Close();
                    foundHitObjects = true;
                    outputWindow.Text += "\r\nCircles found " + circles.ToString() + "\r\nSliders found " + sliders.ToString() + "\r\nSpinners found " + spinners.ToString();
                    outputWindow.Text += "\r\n" + timestoPress.Count().ToString();
                    outputWindow.Text += "\r\nSlider Multiplier: " + SliderMultiplier;
                    foreach (string p in timestoPress)
                    {
                        _timestoPress.Add(Convert.ToInt32(p));
                    }
                    foreach (string v in sliderPointsInfo)
                    {
                        _sliderPointsInfo.Add(Convert.ToInt32(v));
                    }
                    foreach (string z in sliderpixelLengthInfo)
                    {
                        _sliderpixelLengthInfo.Add(Convert.ToSingle(z));
                    }
                    foreach (string o in sliderrepeatInfo)
                    {
                        _sliderrepeatPointsInfo.Add(Convert.ToInt32(o));
                    }
                }
            }
        }
        void getSliderVelocity()
        {
            StreamReader gimmedatVelocity = new StreamReader(@fullSong);
            while (foundSliderMultiplier == false)
            {
                if (gimmedatVelocity.ReadLine() == "[Difficulty]")
                {
                    gimmedatVelocity.ReadLine();
                    gimmedatVelocity.ReadLine();
                    gimmedatVelocity.ReadLine();
                    gimmedatVelocity.ReadLine();
                    string sliderMultiplier = gimmedatVelocity.ReadLine();
                    string[] slidermultiplier = sliderMultiplier.Split(':');
                    SliderMultiplier = Convert.ToSingle(slidermultiplier[1]);
                    foundSliderMultiplier = true;
                }
            }
            gimmedatVelocity.Close();
        }
        void getTimingPoints()
        {
            try
            {
                int p = 0;
                int c = 0;
                StreamReader gimmedatTimingPoint = new StreamReader(@fullSong);
                while (foundTimingPoint == false)
                {
                    p++;
                    if (gimmedatTimingPoint.ReadLine() == "[TimingPoints]")
                    {
                        foundTimingPoint = true;    
                    }
                }
                gimmedatTimingPoint.DiscardBufferedData();
                gimmedatTimingPoint.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                while (foundColours == false)
                {
                    c++;
                    if (gimmedatTimingPoint.ReadLine() == "[Colours]")
                    {
                        foundColours = true;
                    }
                }
                gimmedatTimingPoint.DiscardBufferedData();
                gimmedatTimingPoint.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                for(int z = 0; z < p; z++)
                {
                    gimmedatTimingPoint.ReadLine();
                }
                for (int k = 0; k <= c - p - 4; k++)
                {
                    Timingpoints.Add(gimmedatTimingPoint.ReadLine());
                }
                foreach (string o in Timingpoints)
                {
                    string[] beats = o.Split(',');
                    if (Convert.ToSingle(beats[1]) > 0)
                    {
                        beatsPerMinute.Add(Convert.ToSingle(beats[1]));
                        timingPointsInfo.Add(Convert.ToSingle(beats[0]));
                    }
                    else if (Convert.ToSingle(beats[1]) < 0)
                    {
                        float a = -1 / (Convert.ToSingle(beats[1]) / 100);
                        beatsPerMinute.Add(a);
                        timingPointsInfo.Add(Convert.ToSingle(beats[0]));
                    }
                }
                gimmedatTimingPoint.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        int calculatingSliderEndTime(int timeappeared, int slidernumber)
        {
            try
            {
                for (int c = 1; c <= beatsPerMinute.Count() - 1; c++)
                {
                    if (beatsPerMinute.Count() - 1 == 0)
                    {
                        BPM = beatsPerMinute[0];
                        break;
                    }
                    else
                    {
                        if (c <= beatsPerMinute.Count() - 2)
                        {
                            if (timeappeared > timingPointsInfo[c - 1] && timeappeared < timingPointsInfo[c + 1])
                            {
                                BPM = beatsPerMinute[0];
                                modifiedBPM = beatsPerMinute[c];
                                c = 1;
                                break;
                            }
                            else if (timeappeared == timingPointsInfo[c])
                            {
                                BPM = beatsPerMinute[0];
                                modifiedBPM = beatsPerMinute[c];
                                c = 1;
                                break;
                            }
                        }
                        else
                        {
                                BPM = beatsPerMinute[0];
                                modifiedBPM = beatsPerMinute[0];
                                c = 1;
                                break;
                        }
                    }
                }
                
                pixelLength = _sliderpixelLengthInfo[slidernumber];
                sliderEndTime = Convert.ToInt32(((BPM * (pixelLength / (SliderMultiplier * modifiedBPM)) / 100f))* Convert.ToSingle(sliderrepeatInfo[slidernumber]));
                return sliderEndTime;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());

            }
            return sliderEndTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foundHitObjects = false;
            hitobjectInfo.Clear();
            circleInfo.Clear();
            sliderInfo.Clear();
            spinnerInfo.Clear();
            timestoPress.Clear();
            _timestoPress.Clear();
            beatsPerMinute.Clear();
            timingPointsInfo.Clear();
            circles = 0;
            sliders = 0;
            spinners = 0;
            Parse();
        }
        public static class Constants
        {
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }
        public class KeyHandler
        {
            [DllImport("user32.dll")]
            private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

            [DllImport("user32.dll")]
            private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
            public int key;
            private IntPtr hWnd;
            public int id;

            public KeyHandler(Keys key, Form form)
            {
                this.key = (int)key;
                this.hWnd = form.Handle;
                id = this.GetHashCode();
            }

            public override int GetHashCode()
            {
                return key ^ hWnd.ToInt32();
            }

            public bool Register()
            {
                return RegisterHotKey(hWnd, id, 0, key);
            }

            public bool Unregister()
            {
                return UnregisterHotKey(hWnd, id);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && m.WParam.ToInt32() == boop.id)
            {
                int q = 0;
                int a = 0;
                relaxing = true;
                int timewaited = 0;
                int holdSlider = 0;
                int timetoWait3 = 0;
                int timetoWait4 = 0;
                int timetoWait5 = 0;
                if (relaxing == true)
                {
                    firstCircle = true;
                    lastCircle = false;
                    holdSlider = 0;
                    timewaited = 0;
                    slider = false;
                    Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            for (int l = 0; l < _timestoPress.Count(); l++)
                            {
                                slider = false;
                                if (l == timestoPress.Count() - 1)
                                {
                                    lastCircle = true;
                                }
                                if (sliderPointsInfo.Count() > 0 && q < sliderPointsInfo.Count() - 1)
                                {
                                    if (firstCircle == true && lastCircle == false)
                                    {
                                        if (timestoPress[l] == sliderPointsInfo[0])
                                        {
                                            slider = true;
                                            timewaited = calculatingSliderEndTime(_timestoPress[l], 0);
                                            q++;
                                        }
                                    }
                                    else if (firstCircle == false && lastCircle == true)
                                    {
                                        if (timestoPress[l] == sliderPointsInfo[q - 1])
                                        {
                                            slider = true;
                                            timewaited = calculatingSliderEndTime(_timestoPress[l], q);
                                        }
                                    }
                                    else if (firstCircle == false && lastCircle == false)
                                    {
                                        if (timestoPress[l] == sliderPointsInfo[q])
                                        {
                                            slider = true;
                                            
                                            timewaited = calculatingSliderEndTime(_timestoPress[l], q);
                                            q++;
                                        }
                                    }
                                }
                                if (relaxing == false)
                                {
                                    continue;
                                }
                                if (l % 2 == 0 && sliderOffset == false)
                                {
                                    needtoOffset = true;
                                    needtoEarlyOffset = false;
                                }
                                else if (l % 2 == 1 && sliderOffset == false)
                                {
                                    needtoOffset = false;
                                    needtoEarlyOffset = true;
                                }
                                else
                                {
                                    needtoEarlyOffset = false;
                                    needtoOffset = false;
                                    sliderOffset = true;
                                }
                                if (firstCircle == true && slider == false)
                                {
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(12);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    firstCircle = false;
                                    timetoWait2 = _timestoPress[l + 1] - _timestoPress[l];
                                    if (timetoWait2 <= 100)
                                        primaryClick = false;
                                    sliderOffset = false;
                                }
                                else if (firstCircle == true && slider == true)
                                {
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(timewaited + 2);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    firstCircle = false;
                                    timetoWait2 = _timestoPress[l + 1] - _timestoPress[l];
                                    if (timetoWait2 <= 100)
                                        primaryClick = false;
                                    holdSlider = timewaited;
                                    sliderOffset = true;
                                }
                                else if (firstCircle == false && lastCircle == false && slider == false && primaryClick == true)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 8 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 11);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 5);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 7);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(12);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    if (l < timestoPress.Count() - 1)
                                    {
                                        timetoWait2 = _timestoPress[l + 1] - _timestoPress[l];
                                        if (timetoWait2 <= 100)
                                            primaryClick = false;
                                    }
                                    holdSlider = 0;
                                    sliderOffset = false;
                                }
                                else if (firstCircle == false && lastCircle == false && slider == true && primaryClick == true)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 8 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 10);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 4);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 8);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(timewaited + 2);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    if (l < timestoPress.Count() - 1)
                                    {
                                        timetoWait2 = _timestoPress[l + 1] - _timestoPress[l];
                                        if (timetoWait2 <= 100)
                                            primaryClick = false;
                                    }
                                    holdSlider = timewaited;
                                    sliderOffset = true;
                                }
                                else if (firstCircle == false && lastCircle == false && slider == false && primaryClick == false)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 7 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 10);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 4);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 8);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);
                                    System.Threading.Thread.Sleep(12);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_D);
                                    primaryClick = true;
                                    holdSlider = 0;
                                    sliderOffset = false;
                                }
                                else if (firstCircle == false && lastCircle == false && slider == true && primaryClick == false)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 7 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 10);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 4);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 8);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);
                                    System.Threading.Thread.Sleep(timewaited + 2);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_D);
                                    primaryClick = true;
                                    holdSlider = timewaited;
                                    sliderOffset = true;
                                }
                                else if (firstCircle == false && slider == false && lastCircle == true)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 8 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 10);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 4);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 8);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(12);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    lastCircle = false;
                                    sliderOffset = false;
                                }
                                else if (firstCircle == false && slider == true && lastCircle == true)
                                {
                                    timetoWait = _timestoPress[l] - _timestoPress[l - 1] - 8 - holdSlider;
                                    if (forceEarly)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 21);
                                        forceEarly = false;
                                    }
                                    else if (forceLate)
                                    {
                                        System.Threading.Thread.Sleep(timetoWait - 2);
                                        forceLate = false;
                                    }
                                    else if (needtoOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 10);
                                    else if (needtoEarlyOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 3);
                                    else if (sliderOffset)
                                        System.Threading.Thread.Sleep(timetoWait - 8);
                                    else
                                        System.Threading.Thread.Sleep(timetoWait - 6);
                                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
                                    System.Threading.Thread.Sleep(timewaited + 2);
                                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
                                    lastCircle = false;
                                    sliderOffset = false;
                                }
                            }

                            q = 0;
                        }
                        catch (Exception d)
                        {
                            MessageBox.Show(d.ToString() + "\r\n" + timetoWait + "\r\n" + timetoWait3 + "\r\n" + holdSlider + "\r\n" + a + "\r\n" + timetoWait4 + "\r\n" + timetoWait5);
                        }
                    });
                }
            }
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && m.WParam.ToInt32() == doop.id)
            {
                relaxing = false;
                System.Threading.Thread.Sleep(2000);
                foundHitObjects = false;
                firstCircle = true;
                lastCircle = false;
                primaryClick = true;
            }
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && m.WParam.ToInt32() == poop.id)
            {
                forceEarly = true;
            }
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && m.WParam.ToInt32() == moop.id)
            {
                forceLate = true;
            }
            base.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poop.Unregister();
            boop.Unregister();
            doop.Unregister();
            moop.Unregister();
            string keypress = comboBox1.Text;
            char[] activeKeypress = keypress.ToCharArray();
            switch(activeKeypress[0])
            {
                case 'A':
                    boop = new KeyHandler(Keys.A, this);
                    break;
                case 'B':
                    boop = new KeyHandler(Keys.B, this);
                    break;
                case 'C':
                    boop = new KeyHandler(Keys.C, this);
                    break;
                case 'D':
                    boop = new KeyHandler(Keys.D, this);
                    break;
                case 'E':
                    boop = new KeyHandler(Keys.E, this);
                    break;
                case 'F':
                    boop = new KeyHandler(Keys.F, this);
                    break;
                case 'G':
                    boop = new KeyHandler(Keys.G, this);
                    break;
                case 'H':
                    boop = new KeyHandler(Keys.H, this);
                    break;
                case 'I':
                    boop = new KeyHandler(Keys.I, this);
                    break;
                case 'J':
                    boop = new KeyHandler(Keys.J, this);
                    break;
                case 'K':
                    boop = new KeyHandler(Keys.K, this);
                    break;
                case 'L':
                    boop = new KeyHandler(Keys.L, this);
                    break;
                case 'M':
                    boop = new KeyHandler(Keys.M, this);
                    break;
                case 'N':
                    boop = new KeyHandler(Keys.N, this);
                    break;
                case 'O':
                    boop = new KeyHandler(Keys.O, this);
                    break;
                case 'P':
                    boop = new KeyHandler(Keys.P, this);
                    break;
                case 'Q':
                    boop = new KeyHandler(Keys.Q, this);
                    break;
                case 'R':
                    boop = new KeyHandler(Keys.R, this);
                    break;
                case 'S':
                    boop = new KeyHandler(Keys.S, this);
                    break;
                case 'T':
                    boop = new KeyHandler(Keys.T, this);
                    break;
                case 'U':
                    boop = new KeyHandler(Keys.U, this);
                    break;
                case 'V':
                    boop = new KeyHandler(Keys.V, this);
                    break;
                case 'W':
                    boop = new KeyHandler(Keys.W, this);
                    break;
                case 'X':
                    boop = new KeyHandler(Keys.X, this);
                    break;
                case 'Y':
                    boop = new KeyHandler(Keys.Y, this);
                    break;
                case 'Z':
                    boop = new KeyHandler(Keys.Z, this);
                    break;
            }
            boop.Register();
            string keypress2 = comboBox2.Text;
            char[] activeKeypress2 = keypress2.ToCharArray();
            switch (activeKeypress2[0])
            {
                case 'A':
                    doop = new KeyHandler(Keys.A, this);
                    break;
                case 'B':
                    doop = new KeyHandler(Keys.B, this);
                    break;
                case 'C':
                    doop = new KeyHandler(Keys.C, this);
                    break;
                case 'D':
                    doop = new KeyHandler(Keys.D, this);
                    break;
                case 'E':
                    doop = new KeyHandler(Keys.E, this);
                    break;
                case 'F':
                    doop = new KeyHandler(Keys.F, this);
                    break;
                case 'G':
                    doop = new KeyHandler(Keys.G, this);
                    break;
                case 'H':
                    doop = new KeyHandler(Keys.H, this);
                    break;
                case 'I':
                    doop = new KeyHandler(Keys.I, this);
                    break;
                case 'J':
                    doop = new KeyHandler(Keys.J, this);
                    break;
                case 'K':
                    doop = new KeyHandler(Keys.K, this);
                    break;
                case 'L':
                    doop = new KeyHandler(Keys.L, this);
                    break;
                case 'M':
                    doop = new KeyHandler(Keys.M, this);
                    break;
                case 'N':
                    doop = new KeyHandler(Keys.N, this);
                    break;
                case 'O':
                    doop = new KeyHandler(Keys.O, this);
                    break;
                case 'P':
                    doop = new KeyHandler(Keys.P, this);
                    break;
                case 'Q':
                    doop = new KeyHandler(Keys.Q, this);
                    break;
                case 'R':
                    doop = new KeyHandler(Keys.R, this);
                    break;
                case 'S':
                    doop = new KeyHandler(Keys.S, this);
                    break;
                case 'T':
                    doop = new KeyHandler(Keys.T, this);
                    break;
                case 'U':
                    doop = new KeyHandler(Keys.U, this);
                    break;
                case 'V':
                    doop = new KeyHandler(Keys.V, this);
                    break;
                case 'W':
                    doop = new KeyHandler(Keys.W, this);
                    break;
                case 'X':
                    doop = new KeyHandler(Keys.X, this);
                    break;
                case 'Y':
                    doop = new KeyHandler(Keys.Y, this);
                    break;
                case 'Z':
                    doop = new KeyHandler(Keys.Z, this);
                    break;
            }
            doop.Register();
            string keypress3 = comboBox3.Text;
            char[] activeKeypress3 = keypress3.ToCharArray();
            switch (activeKeypress3[0])
            {
                case 'A':
                    poop = new KeyHandler(Keys.A, this);
                    break;
                case 'B':
                    poop = new KeyHandler(Keys.B, this);
                    break;
                case 'C':
                    poop = new KeyHandler(Keys.C, this);
                    break;
                case 'D':
                    poop = new KeyHandler(Keys.D, this);
                    break;
                case 'E':
                    poop = new KeyHandler(Keys.E, this);
                    break;
                case 'F':
                    poop = new KeyHandler(Keys.F, this);
                    break;
                case 'G':
                    poop = new KeyHandler(Keys.G, this);
                    break;
                case 'H':
                    poop = new KeyHandler(Keys.H, this);
                    break;
                case 'I':
                    poop = new KeyHandler(Keys.I, this);
                    break;
                case 'J':
                    poop = new KeyHandler(Keys.J, this);
                    break;
                case 'K':
                    poop = new KeyHandler(Keys.K, this);
                    break;
                case 'L':
                    poop = new KeyHandler(Keys.L, this);
                    break;
                case 'M':
                    poop = new KeyHandler(Keys.M, this);
                    break;
                case 'N':
                    poop = new KeyHandler(Keys.N, this);
                    break;
                case 'O':
                    poop = new KeyHandler(Keys.O, this);
                    break;
                case 'P':
                    poop = new KeyHandler(Keys.P, this);
                    break;
                case 'Q':
                    poop = new KeyHandler(Keys.Q, this);
                    break;
                case 'R':
                    poop = new KeyHandler(Keys.R, this);
                    break;
                case 'S':
                    poop = new KeyHandler(Keys.S, this);
                    break;
                case 'T':
                    poop = new KeyHandler(Keys.T, this);
                    break;
                case 'U':
                    poop = new KeyHandler(Keys.U, this);
                    break;
                case 'V':
                    poop = new KeyHandler(Keys.V, this);
                    break;
                case 'W':
                    poop = new KeyHandler(Keys.W, this);
                    break;
                case 'X':
                    poop = new KeyHandler(Keys.X, this);
                    break;
                case 'Y':
                    poop = new KeyHandler(Keys.Y, this);
                    break;
                case 'Z':
                    poop = new KeyHandler(Keys.Z, this);
                    break;
            }
            poop.Register();
            string keypress4 = comboBox4.Text;
            char[] activeKeypress4 = keypress4.ToCharArray();
            switch (activeKeypress4[0])
            {
                case 'A':
                    moop = new KeyHandler(Keys.A, this);
                    break;
                case 'B':
                    moop = new KeyHandler(Keys.B, this);
                    break;
                case 'C':
                    moop = new KeyHandler(Keys.C, this);
                    break;
                case 'D':
                    moop = new KeyHandler(Keys.D, this);
                    break;
                case 'E':
                    moop = new KeyHandler(Keys.E, this);
                    break;
                case 'F':
                    moop = new KeyHandler(Keys.F, this);
                    break;
                case 'G':
                    moop = new KeyHandler(Keys.G, this);
                    break;
                case 'H':
                    moop = new KeyHandler(Keys.H, this);
                    break;
                case 'I':
                    moop = new KeyHandler(Keys.I, this);
                    break;
                case 'J':
                    moop = new KeyHandler(Keys.J, this);
                    break;
                case 'K':
                    moop = new KeyHandler(Keys.K, this);
                    break;
                case 'L':
                    moop = new KeyHandler(Keys.L, this);
                    break;
                case 'M':
                    moop = new KeyHandler(Keys.M, this);
                    break;
                case 'N':
                    moop = new KeyHandler(Keys.N, this);
                    break;
                case 'O':
                    moop = new KeyHandler(Keys.O, this);
                    break;
                case 'P':
                    moop = new KeyHandler(Keys.P, this);
                    break;
                case 'Q':
                    moop = new KeyHandler(Keys.Q, this);
                    break;
                case 'R':
                    moop = new KeyHandler(Keys.R, this);
                    break;
                case 'S':
                    moop = new KeyHandler(Keys.S, this);
                    break;
                case 'T':
                    moop = new KeyHandler(Keys.T, this);
                    break;
                case 'U':
                    moop = new KeyHandler(Keys.U, this);
                    break;
                case 'V':
                    moop = new KeyHandler(Keys.V, this);
                    break;
                case 'W':
                    moop = new KeyHandler(Keys.W, this);
                    break;
                case 'X':
                    moop = new KeyHandler(Keys.X, this);
                    break;
                case 'Y':
                    moop = new KeyHandler(Keys.Y, this);
                    break;
                case 'Z':
                    moop = new KeyHandler(Keys.Z, this);
                    break;
            }
            moop.Register();
            string processName = textBox1.Text;
            Relax.ActiveForm.Text = processName;
        }
    }
}

