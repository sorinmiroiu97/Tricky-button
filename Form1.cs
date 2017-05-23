using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Copyright 2017 Sorin Miroiu
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void b_Mouse(object sender, MouseEventArgs e)
        {
            ok = false;
        }

        void b_MouseMove(object sender, MouseEventArgs e)
        {
            pozMouseFormX = pozActButtonX + e.Location.X;
            pozMouseFormY = pozActButtonY + e.Location.Y;
            if (ok == true) MutaButton();
        }

        void MutaButton()
        {
            b.Location=new System.Drawing.Point(pozMouseFormX-pozMouseButtonX, pozMouseFormY-pozMouseButtonY);
            pozActButtonX=b.Location.X;
            pozActButtonY=b.Location.Y;
        }

        void b_MouseDown(object sender, MouseEventArgs e)
        {
            pozMouseButtonX = e.Location.X;
            pozMouseButtonY = e.Location.Y;
            ok = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Button();
            b
            b.Top = 500;
            b.Left = 500;
            b.Height = 50;
            b.Width = 100;
            b.Text="move me";
            b.AllowDrop=true;
            b.MouseDown+=new MouseEventHandler(b_MouseDown);
            b.MouseUp+= new MouseEventHandler(b_Mouse);
            b.MouseMove+= new MouseEventHandler(b_MouseMove);
            this.Controls.Add(b);
            pozActButtonX=b.Location.X;
            pozActButtonY=b.Location.Y;

        }
    }
}
