using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;

namespace PasswordGame
{
    
    public partial class Form1 : Form
    {
        #region variables
        public static CheckBox lastChecked1; 
        public static CheckBox lastChecked2; 

        public static int counterForThreeClue = 10;
        public static int counterForBlitz = 15;
        public static int passwordNumber = 1;

        public static List<string> current;
        public static List<string> currentUsed;

        public static bool RandomIsRunning = false;
        #endregion

        #region timers
        //its the one timer1 corresponds to
        int timeLeft;

        public int pictionaryTimer = 45;
        public int charadesTimer = 40;
       // public int classicTimer;
        public int threeClueTimer = 90;
        public int blitzTimer = 30;
        #endregion

        #region wordLists
        public static List<string> basic;
        public static List<string> basicUsed;
        public static List<string> hard;
        public static List<string> hardUsed;
        public static List<string> sport;
        public static List<string> sportUsed;
        public static List<string> middleearth;
        public static List<string> middleearthUsed;
        public static List<string> starwars;
        public static List<string> starwarsUsed;
        public static List<string> movies;
        public static List<string> moviesUsed;
        public static List<string> hero;
        public static List<string> heroUsed;
        public static List<string> tech;
        public static List<string> techUsed;
        public static List<string> write;
        public static List<string> writeUsed;
        public static List<string> villain;
        public static List<string> villainUsed;
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.Text = "Password Game";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region fillingwithwords
            basic = new List<string>();
            basicUsed = new List<string>();
            basic.FillWithWords(@"words/basic.txt");
            basic.Shuffle();

            hard = new List<string>();
            hardUsed = new List<string>();
            hard.FillWithWords(@"words/hard.txt");
            hard.Shuffle();

            sport = new List<string>();
            sportUsed = new List<string>();
            sport.FillWithWords(@"words/sport.txt");
            sport.Shuffle();

            middleearth = new List<string>();
            middleearthUsed = new List<string>();
            middleearth.FillWithWords(@"words/middleearth.txt");
            middleearth.Shuffle();

            starwars = new List<string>();
            starwarsUsed = new List<string>();
            starwars.FillWithWords(@"words/starwars.txt");
            starwars.Shuffle();

            movies = new List<string>();
            moviesUsed = new List<string>();
            movies.FillWithWords(@"words/movies.txt");
            movies.Shuffle();

            hero = new List<string>();
            heroUsed = new List<string>();
            hero.FillWithWords(@"words/hero.txt");
            hero.Shuffle();

            tech = new List<string>();
            techUsed = new List<string>();
            tech.FillWithWords(@"words/tech.txt");
            tech.Shuffle();

            write = new List<string>();
            writeUsed = new List<string>();
            write.FillWithWords(@"words/write.txt");
            write.Shuffle();

            villain = new List<string>();
            villainUsed = new List<string>();
            villain.FillWithWords(@"words/villain.txt");
            villain.Shuffle();
            #endregion
            
        }
        
        private void btnEndRound_Click(object sender, EventArgs e)
        {
                #region CancelButton
                timer1.Stop();
                lblPassword.Text = string.Empty;
                lblHint.Text = string.Empty;
                lblRemaining.Text = string.Empty;
                lblTimeLeft.Text = string.Empty;
                
                btnNext.Text = "Password";
                btnNext.Enabled = false;
                btnNext.Visible = false;

                btnRandom.Enabled = true;
                cbBasic.Enabled = true;
                cbHard.Enabled = true;
                cbSport.Enabled = true;
                cbStarWars.Enabled = true;
                cbMiddleEarth.Enabled = true;
                cbMovies.Enabled = true;
                cbHero.Enabled = true;
                cbWrite.Enabled = true;
                cbVillain.Enabled = true;
                cbTech.Enabled = true;

                cbPictionary.Enabled = true;
                cbCharades.Enabled = true;
                cbClassic.Enabled = true;
                cbThreeClue.Enabled = true;
                cbBlitz.Enabled = true;

                if(lastChecked1.Checked == true)
                lastChecked1.Checked = false;
                if (lastChecked2.Checked == true)
                lastChecked2.Checked = false;

                btnEndRound.Enabled = false;
                btnEndRound.Visible = false;

                lastChecked1 = null;
                lastChecked2 = null;
                #endregion
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Password")
            {
                #region SettingStuff
                if (lastChecked1.Name == cbBasic.Name)
                {
                    current = basic;
                    currentUsed = basicUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbHard.Name)
                {
                    current = hard;
                    currentUsed = hardUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbSport.Name)
                {
                    current = sport;
                    currentUsed = sportUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbMiddleEarth.Name)
                {
                    current = middleearth;
                    currentUsed = middleearthUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbStarWars.Name)
                {
                    current = starwars;
                    currentUsed = starwarsUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbWrite.Name)
                {
                    current = write;
                    currentUsed = writeUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbMovies.Name)
                {
                    current = movies;
                    currentUsed = moviesUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbHero.Name)
                {
                    current = hero;
                    currentUsed = heroUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbVillain.Name)
                {
                    current = villain;
                    currentUsed = villainUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                else if (lastChecked1.Name == cbTech.Name)
                {
                    current = tech;
                    currentUsed = techUsed;
                    #region inside
                    if (lastChecked2.Name == cbPictionary.Name)
                    {
                        timeLeft = pictionaryTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbCharades.Name)
                    {
                        timeLeft = charadesTimer;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbClassic.Name)
                    {
                        lblTimeLeft.Text = string.Empty;
                        passwordNumber = 1;
                    }
                    else if (lastChecked2.Name == cbThreeClue.Name)
                    {
                        timeLeft = threeClueTimer;
                        passwordNumber = 10;
                    }
                    else if (lastChecked2.Name == cbBlitz.Name)
                    {
                        timeLeft = blitzTimer;
                        passwordNumber = 15;
                    }
                    #endregion
                }
                #endregion
                btnEndRound.Enabled = true;
                btnEndRound.Visible = true;
                lblStatus.Text = string.Empty;
                if (lastChecked2.Name == cbThreeClue.Name)
                {
                    counterForThreeClue = passwordNumber;
                    btnNext.Text = "Next";
                    counterForThreeClue -= 1;
                    lblRemaining.Text = counterForThreeClue.ToString() + " passwords left";
                    btnNext.Focus();
                }
                else if (lastChecked2.Name == cbBlitz.Name)
                {
                    counterForBlitz = passwordNumber;
                    btnNext.Text = "Next";
                    counterForBlitz -= 1;
                    btnNext.Focus();
                }

                try
                {
                    string aux = current.First();
                    lblHint.Text = string.Empty;
                    if (aux.Contains('#'))
                    {
                        Regex r1 = new Regex(@".+[#]");
                        string aux1 = r1.Match(aux).ToString();
                        aux1 = aux1.Remove(aux.IndexOf('#'), 1);
                        Regex r2 = new Regex(@"[#].+");
                        string aux2 = r2.Match(aux).ToString();
                        aux2 = aux2.Remove(0, 1);
                        lblPassword.Text = aux1;
                        lblHint.Text = aux2;
                        currentUsed.Add(aux1);
                        current.RemoveAt(0);
                    }
                    else
                    {
                        lblPassword.Text = aux;
                        currentUsed.Add(aux);
                        current.RemoveAt(0);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); btnNext.Enabled = false; btnNext.Visible = false; btnNext.Text = "Password"; }

                if (btnNext.Text == "Password")
                {
                    btnNext.Enabled = false;
                    btnNext.Visible = false;
                    btnEndRound.Focus();
                }

                timer1.Start();
                #region enabledFalse1
                btnRandom.Enabled = false;
                cbBasic.Enabled = false;
                cbHard.Enabled = false;
                cbSport.Enabled = false;
                cbStarWars.Enabled = false;
                cbMiddleEarth.Enabled = false;
                cbMovies.Enabled = false;
                cbHero.Enabled = false;
                cbWrite.Enabled = false;
                cbVillain.Enabled = false;
                cbTech.Enabled = false;

                cbPictionary.Enabled = false;
                cbCharades.Enabled = false;
                cbClassic.Enabled = false;
                cbThreeClue.Enabled = false;
                cbBlitz.Enabled = false;

                
                #endregion
            }
            else 
            {
                if (lastChecked2.Name == cbThreeClue.Name)
                {
                    if (counterForThreeClue > 1)
                    {
                        try{
                            string aux = current.First();
                            lblHint.Text = string.Empty;
                            if (aux.Contains('#'))
                            {
                                Regex r1 = new Regex(@".+[#]");
                                string aux1 = r1.Match(aux).ToString();
                                aux1 = aux1.Remove(aux.IndexOf('#'), 1);
                                Regex r2 = new Regex(@"[#].+");
                                string aux2 = r2.Match(aux).ToString();
                                aux2 = aux2.Remove(0, 1);
                                lblPassword.Text = aux1;
                                lblHint.Text = aux2;
                                currentUsed.Add(aux1);
                                current.RemoveAt(0);
                            }
                            else
                            {
                                lblPassword.Text = aux;
                                currentUsed.Add(aux);
                                current.RemoveAt(0);
                            }
                        counterForThreeClue -= 1;
                        lblRemaining.Text = counterForThreeClue.ToString() + " passwords left"; ;
                         }
                        catch (Exception ex) { MessageBox.Show(ex.Message); btnNext.Enabled = false; btnNext.Visible = false; btnNext.Text = "Password"; }
                        btnNext.Focus();
                    }
                    else if(counterForThreeClue == 1)
                    {
                        try
                        {
                            string aux = current.First();
                            lblHint.Text = string.Empty;
                            if (aux.Contains('#'))
                            {
                                Regex r1 = new Regex(@".+[#]");
                                string aux1 = r1.Match(aux).ToString();
                                aux1 = aux1.Remove(aux.IndexOf('#'), 1);
                                Regex r2 = new Regex(@"[#].+");
                                string aux2 = r2.Match(aux).ToString();
                                aux2 = aux2.Remove(0, 1);
                                lblPassword.Text = aux1;
                                lblHint.Text = aux2;
                                currentUsed.Add(aux1);
                                current.RemoveAt(0);
                            }
                            else
                            {
                                lblPassword.Text = aux;
                                currentUsed.Add(aux);
                                current.RemoveAt(0);
                            }
                            counterForThreeClue -= 1;
                            lblRemaining.Text = counterForThreeClue.ToString() + " passwords left"; ;
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); btnNext.Enabled = false; btnNext.Visible = false; btnNext.Text = "Password"; }
                        btnNext.Text = "Password";
                        btnNext.Enabled = false;
                        btnNext.Visible = false;
                        btnEndRound.Focus();
                    }

                }
                else if (lastChecked2.Name == cbBlitz.Name)
                {
                    if (counterForBlitz > 0)
                    {
                        try{
                            string aux = current.First();
                            lblHint.Text = string.Empty;
                            if (aux.Contains('#'))
                            {
                                Regex r1 = new Regex(@".+[#]");
                                string aux1 = r1.Match(aux).ToString();
                                aux1 = aux1.Remove(aux.IndexOf('#'), 1);
                                Regex r2 = new Regex(@"[#].+");
                                string aux2 = r2.Match(aux).ToString();
                                aux2 = aux2.Remove(0, 1);
                                lblPassword.Text = aux1;
                                lblHint.Text = aux2;
                                currentUsed.Add(aux1);
                                current.RemoveAt(0);
                            }
                            else
                            {
                                lblPassword.Text = aux;
                                currentUsed.Add(aux);
                                current.RemoveAt(0);
                            }
                        counterForBlitz -= 1;
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); btnNext.Enabled = false; btnNext.Visible = false; btnNext.Text = "Password"; }
                        btnNext.Focus();
                    }
                    else
                    {
                        lblStatus.Text = "Too many passwords used";
                        btnNext.Text = "Password";
                        btnNext.Enabled = false;
                        btnNext.Visible = false;
                        btnEndRound.Focus();
                    }
                }
            }
        }

      

        #region Checkboxes
        private void cbBasic_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbBasic.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in basicUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else 
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbSport_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbSport.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in sportUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbWrite_Click(object sender, EventArgs e)
        {
                CheckBox activeCheckBox = sender as CheckBox;
                if ( panel2.Contains(activeCheckBox))
                {
                    if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                        lastChecked1.Checked = false;
                    lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
                }
                if (cbWrite.Checked)
                {
                    comboBox1.Items.Clear();
                    foreach (string s in writeUsed)
                    {
                        comboBox1.Items.Insert(0, s);
                    }
                }
                else
                {
                    comboBox1.Items.Clear();
                }

                if (lastChecked1 != null && lastChecked2 != null)
                {
                    lblPassword.Text = "Ready?";
                    btnNext.Visible = true;
                    btnNext.Enabled = true;
                }
                else
                {
                    lblPassword.Text = string.Empty;
                    btnNext.Visible = false;
                    btnNext.Enabled = false;
                }
        }

        private void cbMiddleEarth_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbMiddleEarth.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in middleearthUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbHard_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbHard.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in hardUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbStarWars_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbStarWars.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in starwarsUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbMovies_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbMovies.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in moviesUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbHero_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbHero.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in heroUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbVillain_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbVillain.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in villainUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbTech_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel2.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked1 && lastChecked1 != null)
                    lastChecked1.Checked = false;
                lastChecked1 = activeCheckBox.Checked ? activeCheckBox : null;
            }
            if (cbTech.Checked)
            {
                comboBox1.Items.Clear();
                foreach (string s in techUsed)
                {
                    comboBox1.Items.Insert(0, s);
                }
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbBlitz_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel1.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked2 && lastChecked2 != null)
                    lastChecked2.Checked = false;
                lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }

        }

        private void cbThreeClue_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel1.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked2 && lastChecked2 != null)
                    lastChecked2.Checked = false;
                lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbClassic_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel1.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked2 && lastChecked2 != null)
                    lastChecked2.Checked = false;
                lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbCharades_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel1.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked2 && lastChecked2 != null)
                    lastChecked2.Checked = false;
                lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }

        private void cbPictionary_Click(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (panel1.Contains(activeCheckBox))
            {
                if (activeCheckBox != lastChecked2 && lastChecked2 != null)
                    lastChecked2.Checked = false;
                lastChecked2 = activeCheckBox.Checked ? activeCheckBox : null;
            }

            if (lastChecked1 != null && lastChecked2 != null)
            {
                lblPassword.Text = "Ready?";
                btnNext.Visible = true;
                btnNext.Enabled = true;
            }
            else
            {
                lblPassword.Text = string.Empty;
                btnNext.Visible = false;
                btnNext.Enabled = false;
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lastChecked2.Name == cbClassic.Name)
                return;
            if (timeLeft > 10)
            {
                lblTimeLeft.ForeColor = System.Drawing.Color.Green;
                lblTimeLeft.Text = timeLeft.ToString();
                timeLeft -= 1;
            }
            else if (timeLeft > 0 && timeLeft <= 10)
            {
                lblTimeLeft.ForeColor = System.Drawing.Color.Red;
                lblTimeLeft.Text = timeLeft.ToString();
                timeLeft -= 1;    
            }
            else
            {
                if (lastChecked2.Name == cbThreeClue.Name || lastChecked2.Name == cbBlitz.Name)
                { lblStatus.Text = "time is up"; }

                lblTimeLeft.Text = string.Empty;
                timer1.Stop();
                btnNext.Enabled = false;
                btnNext.Visible = false;
                btnEndRound.Focus();
            }
        }

        private async void btnRandom_Click(object sender, EventArgs e)
        {
            lblPassword.Text = string.Empty;
            if (!RandomIsRunning)
            {
                RandomIsRunning = true;
                #region enabledFalse2
                cbBasic.Enabled = false;
                cbHard.Enabled = false;
                cbSport.Enabled = false;
                cbStarWars.Enabled = false;
                cbMiddleEarth.Enabled = false;
                cbMovies.Enabled = false;
                cbHero.Enabled = false;
                cbWrite.Enabled = false;
                cbVillain.Enabled = false;
                cbTech.Enabled = false;

                cbPictionary.Enabled = false;
                cbCharades.Enabled = false;
                cbClassic.Enabled = false;
                cbThreeClue.Enabled = false;
                cbBlitz.Enabled = false;


                #endregion
                if (lastChecked2 != null)
                {
                    lastChecked2.Checked = false;
                }
                btnNext.Enabled = false;
                btnNext.Visible = false;
                if (lastChecked1 != null && lastChecked1.Checked == true)
                    lastChecked1.Checked = false;

                var t = await Task.Run(() => Helper());
                dynamic c = cbBasic;
                
                do
                {
                
                    c = panel2.GetNextControl(c, true);
                    if (c is CheckBox)
                    {
                        if (c.Name == t.Name)
                        {
                            c.Checked = true;
                            lastChecked1 = c;
                            break;
                        }
                    }
                    

                } while (c.Name != cbBasic.Name);
                    //lastChecked1 = t;
                    //t.Checked = true;

                #region EnabledTrue

                cbBasic.Enabled = true;
                cbHard.Enabled = true;
                cbSport.Enabled = true;
                cbStarWars.Enabled = true;
                cbMiddleEarth.Enabled = true;
                cbMovies.Enabled = true;
                cbHero.Enabled = true;
                cbWrite.Enabled = true;
                cbVillain.Enabled = true;
                cbTech.Enabled = true;

                cbPictionary.Enabled = true;
                cbCharades.Enabled = true;
                cbClassic.Enabled = true;
                cbThreeClue.Enabled = true;
                cbBlitz.Enabled = true;
                #endregion
                RandomIsRunning = false;
            }
            
        }
        private CheckBox Helper()
        {
            dynamic c = cbBasic;
            do
            {
            label1:
                    c = panel2.GetNextControl(c, true);
                    if (c is CheckBox)
                    {
                        c.BackColor = System.Drawing.Color.Tomato;
                        Thread.Sleep(100);
                        c.BackColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        goto label1;
                    }
                    
            } while (c != cbBasic);
            do
            {
            label1:
                c = panel2.GetNextControl(c, true);
                if (c is CheckBox)
                {
                    c.BackColor = System.Drawing.Color.Tomato;
                    Thread.Sleep(100);
                    c.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    goto label1;
                }

            } while (c != cbBasic);
            Random random = new Random();
            int num = random.Next(1, 10);
            int counter = 0;
            while (counter != num)
            {
            label2:   
                c = panel2.GetNextControl(c, true);
            if (c is CheckBox)
            {
                c.BackColor = System.Drawing.Color.Tomato;
                Thread.Sleep(100);
                c.BackColor = System.Drawing.Color.White;
                counter++;
            }
            else
            {
                goto label2;
            }
            }

            CheckBox x = c;
            return x;
            //lastChecked1 = c;
            //c.Checked = true;
            
        }

       

      
    //   private void comboBox1_Click(object sender, EventArgs e)
    //    {
    //        comboBox1.Items.Clear();
    //        try
    //        {
    //            if (lastChecked1 != null)
    //            {
    //                comboBox1.Items.Clear();
    //                if (lastChecked1.Name == cbBasic.Name)
    //                {
    //                    foreach (string s in basicUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbHard.Name)
    //                {
    //                    foreach (string s in hardUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbSport.Name)
    //                {
    //                    foreach (string s in sportUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbMiddleEarth.Name)
    //                {
    //                    foreach (string s in middleearthUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbStarWars.Name)
    //                {
    //                    foreach (string s in starwarsUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbHero.Name)
    //                {
    //                    foreach (string s in heroUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbVillain.Name)
    //                {
    //                    foreach (string s in villainUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbMovies.Name)
    //                {
    //                    foreach (string s in moviesUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbTech.Name)
    //                {
    //                    foreach (string s in techUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //                else if (lastChecked1.Name == cbWrite.Name)
    //                {
    //                    foreach (string s in writeUsed)
    //                    {
    //                        comboBox1.Items.Add(s);
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex) { MessageBox.Show(ex.Message); }
    //    }
        
 }
    public static class Extensions
    {
        public static Regex regex = new Regex(@"[$?]", RegexOptions.IgnoreCase);
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static void FillWithWords(this IList<string> list, string path)
        {

            try
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!regex.IsMatch(line) && line != string.Empty)
                    {
                        list.Add(line.ToUpper());
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Oops!" + Environment.NewLine+ ex.Message); }
        }
       
    }
}
