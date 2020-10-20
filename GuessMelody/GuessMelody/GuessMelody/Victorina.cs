﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastfolder = "";
        static public bool allDirectories = false;
        static public string answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastfolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_files);
            }
            catch
            {

            }
        }

        static string regKeyName = "Software\\Ku6epnecCompany\\GuessMelody";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastfolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("gameDuration", gameDuration);
                rk.SetValue("musicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastfolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}




