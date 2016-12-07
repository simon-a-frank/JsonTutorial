﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonBeispiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebClient.DownloadData(....
            string json = textBox1.Text;
            byte[] daten = Encoding.UTF8.GetBytes(json);
            MemoryStream ms = new MemoryStream(daten);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            Person p = ser.ReadObject(ms) as Person;

            //MessageBox.Show("Name: " + p.Vorname + " Familie: " + p.Familienname);
         }
    }
}
    