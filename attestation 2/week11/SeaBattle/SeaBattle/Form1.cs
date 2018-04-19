﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class Form1 : Form
    {
        Button[,] humanfield = new Button[10, 10];
        Button[,] cpufield = new Button[10, 10];
        Color[,] humanfieldcolor = new Color[10, 10];
        Color[,] cpufieldcolor = new Color[10, 10];
        int[,] humanfieldships = new int[10, 10];
        int[,] cpufieldships = new int[10, 10];
        bool[,] humanfieldcanset = new bool[10, 10];
        bool[,] cpufieldcanset = new bool[10, 10];
        Button[] shipchoice = new Button[6];
        Label[] shipnumber = new Label[4];
        Label[] sub = new Label[2];

        Point p1 = new Point();
        Point p2 = new Point();

        List<Point> listofpoints = new List<Point>();

        Thread thread;

        bool HumanCanSet;
        bool ComputerCanSet;
        bool HaveStriked = false;
        bool CPUCanMove = false;
        bool HumanMove = true;

        int cpukilled = 0;
        int humankilled = 0;
        int HowMuchStriked = 0;

        enum PLayMode
        { position, game, gameover };
        

        enum ShipType
        { x4, x3, x2, x1 };

        enum Direction
        { downward, rightward };

        PLayMode playmode = PLayMode.position;
        ShipType shiptype = new ShipType();
        Direction direction = Direction.rightward;

        public Form1()
        {
            InitializeComponent();
            CreateHumanfield();
            CreateCPUfield();
            ShowShipTypes();
            ComputerShipSetting();
        }

        public void CreateHumanfield()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = new Point(30 + 30 * i, 30 + 30 * j);
                    b.BackColor = Color.LightSeaGreen;
                    b.Click += new System.EventHandler(humanfield_Click);
                    b.MouseEnter += new System.EventHandler(humanfield_Enter);
                    b.MouseLeave += new System.EventHandler(humanfield_Leave);
                    Controls.Add(b);
                    humanfield[i, j] = b;
                    humanfieldcolor[i, j] = Color.LightSeaGreen;
                    humanfieldcanset[i, j] = true;
                }
            }
        }

        public void CreateCPUfield()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = new Point(500 + 30 * i, 30 + 30 * j);
                    b.BackColor = Color.Lavender;
                    b.Click += new System.EventHandler(GoGame);
                    Controls.Add(b);
                    cpufield[i, j] = b;
                    cpufieldcolor[i, j] = Color.LightSeaGreen;
                    cpufieldcanset[i, j] = true;
                }
            }
        }

        public void ForHumanField_Enter(int i, int j, int f)
        {
            int stop;
            if (shipchoice[4 - f].Enabled == false)
            {
                HumanCanSet = false;
            }

            if (direction == Direction.rightward)
            {
                stop = i + f;
                for (int k = i; k < stop; k++)
                {
                    if (k < 10)
                    {
                        if (humanfieldcanset[k, j] == false)
                        {
                            HumanCanSet = false;
                        }
                    }
                    else
                    {
                        stop = k;
                        HumanCanSet = false;
                        break;
                    }
                }
                for (int k = i; k < stop; k++)
                {
                    if (HumanCanSet == true) humanfield[k, j].BackColor = Color.LightGreen;
                    else humanfield[k, j].BackColor = Color.LightCoral;
                }
            }
            else
            {
                stop = j + f;
                for (int k = j; k < stop; k++)
                {
                    if (k < 10)
                    {
                        if (humanfieldcanset[i, k] == false)
                        {
                            HumanCanSet = false;
                        }
                    }
                    else
                    {
                        stop = k;
                        HumanCanSet = false;
                        break;
                    }
                }
                for (int k = j; k < stop; k++)
                {
                    if (HumanCanSet == true) humanfield[i, k].BackColor = Color.LightGreen;
                    else humanfield[i, k].BackColor = Color.LightCoral;
                }
            }
        }

        public void ForHumanField_Click(int i, int j, int f)
        {
            if (shipchoice[4 - f].Enabled == true && humanfield[i, j].BackColor == Color.LightGreen)
            {
                shipnumber[4 - f].Text = (int.Parse(shipnumber[4 - f].Text) - 1).ToString();
                if (shipnumber[4 - f].Text == "0") shipchoice[4 - f].Enabled = false;
            }
            for (int c = 0; c < 4; c++)
            {
                if (shipchoice[c].Enabled == true) break;
                if (c == 3) shipchoice[5].Enabled = true;
            }
            if (direction == Direction.rightward)
            {
                for (int k = i; k < i + f; k++)
                {
                    humanfieldcolor[k, j] = Color.Peru;
                    humanfield[k, j].BackColor = Color.LightCoral;
                    humanfieldships[k, j] = 1000 * i + 100 * j + 10 * f + 1;
                }
                for (int a = i - 1; a <= i + f; a++)
                {
                    for (int b = j - 1; b <= j + 1; b++)
                    {
                        if (a >= 0 && a <= 9 && b >= 0 && b <= 9) humanfieldcanset[a, b] = false;
                    }
                }
            }
            else
            {
                for (int k = j; k < j + f; k++)
                {
                    humanfieldcolor[i, k] = Color.Peru;
                    humanfield[i, k].BackColor = Color.LightCoral;
                    humanfieldships[i, k] = 1000 * i + 100 * j + 10 * f + 2;
                }
                for (int a = i - 1; a <= i + 1; a++)
                {
                    for (int b = j - 1; b <= j + f; b++)
                    {
                        if (a >= 0 && a <= 9 && b >= 0 && b <= 9) humanfieldcanset[a, b] = false;
                    }
                }
            }
        }

        public void ForHumanField_Leave(int i, int j, int f)
        {
            int stop;
            switch (direction)
            {
                case Direction.rightward:
                    if (i + f <= 10) stop = i + f;
                    else stop = 10;
                    for (int a = i; a < stop; a++)
                    {
                        humanfield[a, j].BackColor = humanfieldcolor[a, j];
                    }
                    break;
                case Direction.downward:
                    if (j + f <= 10) stop = j + f;
                    else stop = 10;
                    for (int a = j; a < stop; a++)
                    {
                        humanfield[i, a].BackColor = humanfieldcolor[i, a];
                    }
                    break;
            }
        }

        public void humanfield_Enter(object sender, EventArgs e)
        {
            HumanCanSet = true;
            Button b = sender as Button;
            int i = b.Location.X / 30 - 1;
            int j = b.Location.Y / 30 - 1;
            if (playmode == PLayMode.position)
            {
                switch (shiptype)
                {
                    case ShipType.x1:
                        ForHumanField_Enter(i, j, 1);
                        break;
                    case ShipType.x2:
                        ForHumanField_Enter(i, j, 2);
                        break;
                    case ShipType.x3:
                        ForHumanField_Enter(i, j, 3);
                        break;
                    case ShipType.x4:
                        ForHumanField_Enter(i, j, 4);
                        break;
                }
            }
        }

        public void humanfield_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = b.Location.X / 30 - 1;
            int j = b.Location.Y / 30 - 1;
            if (playmode == PLayMode.position && HumanCanSet == true)
            {
                switch (shiptype)
                {
                    case ShipType.x1:
                        ForHumanField_Click(i, j, 1);
                        break;
                    case ShipType.x2:
                        ForHumanField_Click(i, j, 2);
                        break;
                    case ShipType.x3:
                        ForHumanField_Click(i, j, 3);
                        break;
                    case ShipType.x4:
                        ForHumanField_Click(i, j, 4);
                        break;
                }
            }
        }

        public void humanfield_Leave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = b.Location.X / 30 - 1;
            int j = b.Location.Y / 30 - 1;
            if (playmode == PLayMode.position)
            {
                switch (shiptype)
                {
                    case ShipType.x1:
                        ForHumanField_Leave(i, j, 1);
                        break;
                    case ShipType.x2:
                        ForHumanField_Leave(i, j, 2);
                        break;
                    case ShipType.x3:
                        ForHumanField_Leave(i, j, 3);
                        break;
                    case ShipType.x4:
                        ForHumanField_Leave(i, j, 4);
                        break;
                }
            }
        }

        public void ShowShipTypes()
        {
            string[] shipname = {"carrier", "battleship", "cruiser", "destroyer", "rightward", "Ready!"};
            for (int i = 0; i < 6; i++)
            {
                Button b = new Button();
                b.Size = new Size(90, 30);
                b.Location = new Point(350, 30 + 30 * i);
                b.BackColor = Color.LightGray;
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.Text = shipname[i];
                if (i == 5) b.Enabled = false;
                b.Click += new System.EventHandler(ShipType_Click);
                Controls.Add(b);
                shipchoice[i] = b;
            }

            for (int i = 0; i < 4; i++)
            {
                Label l = new Label();
                l.Size = new Size(30, 30);
                l.Location = new Point(450, 30 + 30 * i);
                l.Text = (i + 1).ToString();
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.BackColor = Color.Transparent;
                Controls.Add(l);
                shipnumber[i] = l;
            }
        }

        public void ShipType_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            for (int i = 0; i < 6; i++)
            {
                if (b == shipchoice[i])
                {
                    switch (i)
                    {
                        case 0:
                            shiptype = ShipType.x4;
                            break;
                        case 1:
                            shiptype = ShipType.x3;
                            break;
                        case 2:
                            shiptype = ShipType.x2;
                            break;
                        case 3:
                            shiptype = ShipType.x1;
                            break;
                        case 4:
                            if (direction == Direction.downward)
                            {
                                direction = Direction.rightward;
                                b.Text = "rightward";
                            }
                            else
                            {
                                direction = Direction.downward;
                                b.Text = "downward";
                            }
                            break;
                        case 5:
                            playmode = PLayMode.game;
                            HideShipTypes();
                            for (int a = 0; a < 10; a++)
                            {
                                for (int c = 0; c < 10; c++)
                                {
                                    humanfield[a, c].BackColor = Color.Lavender;
                                }
                            }
                            CreateSubtitres();
                            break;
                    }
                }
            }
        }

        public void ForComputerShipSetting(int f)
        {
            int counter = 0;
            while(counter < 5 - f)
            {
                bool ComputerCanSet = true;
                Random k = new Random();
                int dir = k.Next(0, 9);
                int x, y;
                if (dir % 2 == 0)
                {
                    x = k.Next(0, 10 - f);
                    y = k.Next(0, 9);
                }
                else
                {
                    x = k.Next(0, 9);
                    y = k.Next(0, 10 - f);
                }
                if (cpufieldcanset[x, y] == false) continue;
                if (dir % 2 == 0)
                {
                    for (int i = x; i < x + f; i++)
                    {
                        if (cpufieldcanset[i, y] == false)
                        {
                            ComputerCanSet = false;
                            break;
                        }
                    }

                    if (ComputerCanSet == true)
                    {
                        for (int i = x; i < x + f; i++)
                        {
                            cpufieldcolor[i, y] = Color.Peru;
                            cpufieldships[i, y] = 1000 * x + 100 * y + 10 * f + 1;
                        }
                        for (int i = x - 1; i <= x + f; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                if (i >= 0 && i <= 9 && j >= 0 && j <= 9) cpufieldcanset[i, j] = false;
                            }
                        }
                        counter++;
                    }
                }
                if (dir % 2 == 1)
                {
                    for (int i = y; i < y + f; i++)
                    {
                        if (cpufieldcanset[x, i] == false)
                        {
                            ComputerCanSet = false;
                            break;
                        }
                    }

                    if (ComputerCanSet == true)
                    {
                        for (int i = y; i < y + f; i++)
                        {
                            cpufieldcolor[x, i] = Color.Peru;
                            cpufieldships[x, i] = 1000 * x + 100 * y + 10 * f + 2;
                        }
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + f; j++)
                            {
                                if (i >= 0 && i <= 9 && j >= 0 && j <= 9) cpufieldcanset[i, j] = false;
                            }
                        }
                        counter++;
                    }
                }
            }

            if (f - 1 >= 1) ForComputerShipSetting(f - 1);
        }

        public void ComputerShipSetting()
        {
            ForComputerShipSetting(4);
        }
        
        public void HideShipTypes()
        {
            for (int i = 0; i < 6; i++)
            {
                shipchoice[i].Hide();
            }
            for (int i = 0; i < 4; i++)
            {
                shipnumber[i].Hide();
            }
        }

        public void StrikingFuction(Button[,] but, Color[,] col, int[,] ships, int x, int y)
        {
            but[x, y].BackColor = Color.LightSalmon;
            int a = ships[x, y] / 1000;
            int b = ships[x, y] / 100 % 10;
            int c = ships[x, y] / 10 % 10;
            int d = ships[x, y] % 10;
            if (d == 1)
            {
                for (int i = a; i < a + c; i++)
                {
                    if (but[i, y].BackColor == Color.Lavender)
                    { 
                        sub[1].Text = "Human striked";
                        break;
                    }
                    if (i == a + c - 1)
                    {
                        IfKilledToRight(but, col, a, y, c);
                        sub[1].Text = "Human killed";
                        humankilled++;
                        if (humankilled == 10)
                        {
                            sub[1].Text = "Human wins";
                            sub[0].Text = "CPU lose";
                            sub[0].BackColor = Color.LightSalmon;
                            sub[1].BackColor = Color.LightGreen;
                            playmode = PLayMode.gameover;
                        }
                    }
                }
            }
            else
            {
                for (int i = b; i < b + c; i++)
                {
                    if (but[x, i].BackColor == Color.Lavender)
                    {
                        sub[1].Text = "Human striked";
                        break;
                    }
                    if (i == b + c - 1)
                    {
                        IfKilledToDown(but, col, b, x, c);
                        sub[1].Text = "Human killed";
                        humankilled++;
                        if (humankilled == 10)
                        {
                            sub[1].Text = "Human wins";
                            sub[0].Text = "CPU lose";
                            sub[0].BackColor = Color.LightSalmon;
                            sub[1].BackColor = Color.LightGreen;
                            CPUCanMove = false;
                        }
                    }
                }
            }
        }

        public void IfKilledToRight(Button[,] but, Color[,] col, int a, int y, int c)
        {
            for (int j = a; j < a + c; j++)
            {
                but[j, y].BackColor = col[j, y];
            }
            if (y - 1 >= 0)
            {
                for (int j = a; j < a + c; j++) but[j, y - 1].BackColor = col[j, y - 1];
                if (a - 1 >= 0)
                {
                    but[a - 1, y - 1].BackColor = col[a - 1, y - 1];
                    but[a - 1, y].BackColor = col[a - 1, y];
                }
                if (a + c <= 9)
                {
                    but[a + c, y - 1].BackColor = col[a + c, y - 1];
                    but[a + c, y].BackColor = col[a + c, y];
                }
            }
            if (y + 1 <= 9)
            {
                for (int j = a; j < a + c; j++) but[j, y + 1].BackColor = col[j, y + 1];
                if (a - 1 >= 0)
                {
                    but[a - 1, y + 1].BackColor = col[a - 1, y + 1];
                    but[a - 1, y].BackColor = col[a - 1, y];
                }
                if (a + c <= 9)
                {
                    but[a + c, y + 1].BackColor = col[a + c, y + 1];
                    but[a + c, y].BackColor = col[a + c, y];
                }
            }
        }

        public void IfKilledToDown(Button[,] but, Color[,] col, int b, int x, int c)
        {
            for (int j = b; j < b + c; j++)
            {
                but[x, j].BackColor = col[x, j];
            }
            if (x - 1 >= 0)
            {
                for (int j = b; j < b + c; j++) but[x - 1, j].BackColor = col[x - 1, j];
                if (b - 1 >= 0)
                {
                    but[x, b - 1].BackColor = col[x, b - 1];
                    but[x - 1, b - 1].BackColor = col[x - 1, b - 1];
                }
                if (b + c <= 9)
                {
                    but[x, b + c].BackColor = col[x, b + c];
                    but[x - 1, b + c].BackColor = col[x - 1, b + c];
                }
            }
            if (x + 1 <= 9)
            {
                for (int j = b; j < b + c; j++) but[x + 1, j].BackColor = col[x + 1, j];
                if (b - 1 >= 0)
                {
                    but[x, b - 1].BackColor = col[x, b - 1];
                    but[x + 1, b - 1].BackColor = col[x + 1, b - 1];
                }
                if (b + c <= 9)
                {
                    but[x, b + c].BackColor = col[x, b + c];
                    but[x + 1, b + c].BackColor = col[x + 1, b + c];
                }
            }
        }

        public void CPUStrikes()
        {
            timer1.Enabled = false;
            listofpoints.Clear();
            int q = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (humanfield[i, j].BackColor == Color.LightSalmon)
                    {
                        q++;
                        if (q == 1)
                        {
                            p1 = new Point(i, j);
                        }
                        else if (q > 1) p2 = new Point(i, j);
                    }
                }
            }
            if (HowMuchStriked == 0)
            {
                Random k = new Random();
                int x = k.Next(0, 9);
                int y = k.Next(0, 9);
                if (humanfield[x, y].BackColor != Color.Lavender)
                {
                    if (cpukilled >= 7)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (humanfield[i, j].BackColor == Color.Lavender)
                                {
                                    x = i;
                                    y = j;
                                    break;
                                }
                            }
                        }
                        if (humanfieldcolor[x, y] == Color.Peru)
                        {
                            if (humanfieldships[x, y] / 10 % 10 == 1)
                            {
                                humanfield[x, y].BackColor = humanfieldcolor[x, y];
                                IfKilledToRight(humanfield, humanfieldcolor, x, y, 1);
                                cpukilled++;
                                sub[0].Text = "CPU killed";
                            }
                            else
                            {
                                humanfield[x, y].BackColor = Color.LightSalmon;
                                HowMuchStriked++;
                                sub[0].Text = "CPU striked";
                            }
                            CPUCanMove = true;
                        }
                        else
                        {
                            humanfield[x, y].BackColor = Color.LightSeaGreen;
                            sub[0].Text = "CPU missed";
                            sub[0].BackColor = Color.White;
                            sub[1].BackColor = Color.LightGreen;
                            CPUCanMove = false;
                            HumanMove = true;
                        }
                    }
                }
                else
                {
                    if (humanfieldcolor[x, y] == Color.Peru)
                    {
                        if (humanfieldships[x, y] / 10 % 10 == 1)
                        {
                            humanfield[x, y].BackColor = humanfieldcolor[x, y];
                            IfKilledToRight(humanfield, humanfieldcolor, x, y, 1);
                            cpukilled++;
                            sub[0].Text = "CPU killed";
                        }
                        else
                        {
                            humanfield[x, y].BackColor = Color.LightSalmon;
                            HowMuchStriked++;
                            sub[0].Text = "CPU striked";
                        }
                        CPUCanMove = true;
                    }
                    else
                    {
                        humanfield[x, y].BackColor = Color.LightSeaGreen;
                        sub[0].Text = "CPU missed";
                        sub[0].BackColor = Color.White;
                        sub[1].BackColor = Color.LightGreen;
                        CPUCanMove = false;
                        HumanMove = true;
                    }
                }
            }
            else if (HowMuchStriked == 1)
            {
                if (p1.X - 1 >= 0)
                {
                    if (humanfield[p1.X - 1, p1.Y].BackColor == Color.Lavender)
                    {
                        listofpoints.Add(new Point(p1.X - 1, p1.Y));
                    }
                }
                if (p1.X + 1 <= 9)
                {
                    if (humanfield[p1.X + 1, p1.Y].BackColor == Color.Lavender)
                    {
                        listofpoints.Add(new Point(p1.X + 1, p1.Y));
                    }
                }
                if (p1.Y - 1 >= 0)
                {
                    if (humanfield[p1.X, p1.Y - 1].BackColor == Color.Lavender)
                    {
                        listofpoints.Add(new Point(p1.X, p1.Y - 1));
                    }
                }
                if (p1.Y + 1 <= 9)
                {
                    if (humanfield[p1.X, p1.Y + 1].BackColor == Color.Lavender)
                    {
                        listofpoints.Add(new Point(p1.X, p1.Y + 1));
                    }
                }
                Random k = new Random();
                int ran = k.Next(0, listofpoints.Count) % listofpoints.Count;
                if (humanfieldcolor[listofpoints[ran].X, listofpoints[ran].Y] == Color.Peru)
                {
                    if (humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10 == 2)
                    {
                        int a = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 1000;
                        int b = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 100 % 10;
                        int c = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10;
                        int d = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] % 10;
                        int x = listofpoints[ran].X;
                        int y = listofpoints[ran].Y;
                        if (d == 1)
                        {
                            IfKilledToRight(humanfield, humanfieldcolor, a, y, c);
                        }
                        if (d == 2)
                        {
                            IfKilledToDown(humanfield, humanfieldcolor, b, x, c);
                        }
                        HowMuchStriked = 0;
                        cpukilled++;
                        sub[0].Text = "CPU killed";
                    }
                    else
                    {
                        humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSalmon;
                        HowMuchStriked++;
                        sub[0].Text = "CPU striked";
                    }
                    CPUCanMove = true;
                }
                else
                {
                    humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSeaGreen;
                    sub[0].Text = "CPU missed";
                    sub[0].BackColor = Color.White;
                    sub[1].BackColor = Color.LightGreen;
                    CPUCanMove = false;
                    HumanMove = true;
                }
            }
            else if (HowMuchStriked > 1)
            {
                if (p1.Y == p2.Y)
                {
                    if (p1.X - 1 >= 0)
                    {
                        if (humanfield[p1.X - 1, p1.Y].BackColor == Color.Lavender)
                        {
                            listofpoints.Add(new Point(p1.X - 1, p1.Y));
                        }
                    }
                    if (p2.X + 1 <= 9)
                    {
                        if (humanfield[p2.X + 1, p1.Y].BackColor == Color.Lavender)
                        {
                            listofpoints.Add(new Point(p2.X + 1, p1.Y));
                        }
                    }
                    Random k = new Random();
                    int ran = k.Next(0, listofpoints.Count) % listofpoints.Count;
                    if (humanfieldcolor[listofpoints[ran].X, listofpoints[ran].Y] == Color.Peru)
                    {
                        if (humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10 == HowMuchStriked + 1)
                        {
                            int a = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 1000;
                            int b = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 100 % 10;
                            int c = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10;
                            int d = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] % 10;
                            int x = listofpoints[ran].X;
                            int y = listofpoints[ran].Y;
                            IfKilledToRight(humanfield, humanfieldcolor, a, y, c);
                            HowMuchStriked = 0;
                            cpukilled++;
                            sub[0].Text = "CPU killed";
                        }
                        else
                        {
                            humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSalmon;
                            HowMuchStriked++;
                            sub[0].Text = "CPU striked";
                        }
                        CPUCanMove = true;
                    }
                    else
                    {
                        humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSeaGreen;
                        sub[0].Text = "CPU missed";
                        sub[0].BackColor = Color.White;
                        sub[1].BackColor = Color.LightGreen;
                        CPUCanMove = false;
                        HumanMove = true;
                    }
                }
                else
                {
                    if (p1.Y - 1 >= 0)
                    {
                        if (humanfield[p1.X, p1.Y - 1].BackColor == Color.Lavender)
                        {
                            listofpoints.Add(new Point(p1.X, p1.Y - 1));
                        }
                    }
                    if (p2.Y + 1 <= 9)
                    {
                        if (humanfield[p1.X, p2.Y + 1].BackColor == Color.Lavender)
                        {
                            listofpoints.Add(new Point(p1.X, p2.Y + 1));
                        }
                    }
                    Random k = new Random();
                    int ran = k.Next(0, listofpoints.Count) % listofpoints.Count;
                    if (humanfieldcolor[listofpoints[ran].X, listofpoints[ran].Y] == Color.Peru)
                    {
                        if (humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10 == HowMuchStriked + 1)
                        {
                            int a = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 1000;
                            int b = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 100 % 10;
                            int c = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] / 10 % 10;
                            int d = humanfieldships[listofpoints[ran].X, listofpoints[ran].Y] % 10;
                            int x = listofpoints[ran].X;
                            int y = listofpoints[ran].Y;
                            IfKilledToDown(humanfield, humanfieldcolor, b, x, c);
                            HowMuchStriked = 0;
                            cpukilled++;
                            sub[0].Text = "CPU killed";
                        }
                        else
                        {
                            humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSalmon;
                            HowMuchStriked++;
                            sub[0].Text = "CPU striked";
                        }
                        CPUCanMove = true;
                    }
                    else
                    {
                        humanfield[listofpoints[ran].X, listofpoints[ran].Y].BackColor = Color.LightSeaGreen;
                        sub[0].Text = "CPU missed";
                        sub[0].BackColor = Color.White;
                        sub[1].BackColor = Color.LightGreen;
                        CPUCanMove = false;
                        HumanMove = true;
                    }
                }
            }
            if (cpukilled == 10)
            {
                sub[0].Text = "CPU wins";
                sub[1].Text = "Human lose";
                sub[0].BackColor = Color.LightGreen;
                sub[1].BackColor = Color.LightSalmon;
                playmode = PLayMode.gameover;
            }
            if (CPUCanMove == true) timer1.Enabled = true;
        }

        public void HumanStrikes(object sender, EventArgs e)
        {
            if (playmode == PLayMode.game)
            {
                Button btn = sender as Button;
                while (HumanMove == true)
                {
                    int x = (btn.Location.X - 500) / 30;
                    int y = (btn.Location.Y - 30) / 30;
                    if (cpufield[x, y].BackColor != Color.Lavender) break;
                    else
                    {
                        if (cpufieldcolor[x, y] == Color.LightSeaGreen)
                        {
                            cpufield[x, y].BackColor = cpufieldcolor[x, y];
                            HumanMove = false;
                            sub[1].Text = "Human missed";
                            sub[0].BackColor = Color.LightGreen;
                            sub[1].BackColor = Color.White;
                            CPUCanMove = true;
                            timer1.Enabled = true;
                        }
                        else
                        {
                            StrikingFuction(cpufield, cpufieldcolor, cpufieldships, x, y);
                        }
                    }
                }
            }
        }

        public void GoGame(object sender, EventArgs e)
        {
            if (playmode == PLayMode.game)
            {
                if (HumanMove == true)
                {
                    HumanStrikes(sender, e);
                }
            }
        }

        public void CreateSubtitres()
        {
            for (int i = 0; i < 2; i++)
            {
                Label l = new Label();
                l.Size = new Size(130, 30);
                l.Location = new Point(350, 150 + 30 * i);
                if (i == 0) l.BackColor = Color.White;
                else l.BackColor = Color.LightGreen;
                l.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(l);
                sub[i] = l;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CPUCanMove == true && playmode == PLayMode.game)
            {
                CPUStrikes();
            }
        }

    }
}
