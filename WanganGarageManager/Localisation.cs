﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WanganGarageManager
{
    public static class Localisation
    {
        static string defaultLang = "en-US";
        //static string defaultLang = "ja-JP";

        static Dictionary<string, string[]> languageTableMain = new Dictionary<string, string[]>();
        static Dictionary<string, string[]> languageTableEditor = new Dictionary<string, string[]>();

        public static void InitMain()
        {
            string[] english = new string[] { "Select car", "Exit", "Settings", "No cars have been created.\nPerform a race in a car of your choice for it to show up here.", "Settings", "Back", "Garage view type:", "Use Power/Handling instead of HP" };
            languageTableMain.Add("en-US", english);
            //languageTableMain.Add("en-GB", english);
            string[] japanese = new string[] { "車を選択してください", "出口", "設定", "車は作成されていません。\nここに表示されるように、選択した車でレースを実行します。", "設定", "バック", "ガレージビュータイプ：", "HPの代わりに電源/処理を使用する" };
            languageTableMain.Add("ja-JP", japanese);
        }

        public static void InitEditor()
        {
            string[] english = new string[] { "Car editor", "Back", "Save", "Aero", "Wing", "Rims", "Stickers", "Colour", "Trunk", "Mirrors", "Hood", "Neons", "Plate Frame", "Tuning", "License Plate", "Power", "Handling", "Tuning stage", "Change colour" };
            languageTableEditor.Add("en-US", english);
            //languageTableEditor.Add("en-GB", english);
            string[] japanese = new string[] { "車のエディタ", "バック", "セーブ", "エアロ", "ウイング", "リム", "ステッカー", "カラー", "トランク", "ミラー", "フード", "ネオン", "プレートフレーム", "チューニング", "ナンバープレート", "力", "取り扱い", "チューニングステージ"
                , "色を変える" };
            languageTableEditor.Add("ja-JP", japanese);
        }

        public static void UpdateMain(frmMain frm, string language)
        {
            if (!languageTableMain.ContainsKey(language))
            {
                language = defaultLang;
            }
            string[] texts = languageTableMain[language];
            frm.lblSelectCar.Text = texts[0];
            frm.btnGarageExit.Text = texts[1];
            frm.btnSettings.Text = texts[2];
            frm.lblNoCars.Text = texts[3];
            frm.lblSettings.Text = texts[4];
            frm.btnBack.Text = texts[5];
            frm.lblGarageView.Text = texts[6];
            frm.chkPowerHandling.Text = texts[7];

            Console.WriteLine("Updated main display language to {0}", language);
        }

        public static void UpdateEditor(frmEditor frm, string language)
        {
            if (!languageTableEditor.ContainsKey(language))
            {
                language = defaultLang;
            }
            string[] texts = languageTableEditor[language];
            frm.lblCarEditor.Text = texts[0];
            frm.btnEditorBack.Text = texts[1];
            frm.btnEditorSave.Text = texts[2];
            frm.tabAero.Text = texts[3];
            frm.tabWing.Text = texts[4];
            frm.tabRims.Text = texts[5];
            frm.tabStickers.Text = texts[6];
            frm.tabColour.Text = texts[7];
            frm.tabTrunk.Text = texts[8];
            frm.tabMirrors.Text = texts[9];
            frm.tabHood.Text = texts[10];
            frm.tabNeons.Text = texts[11];
            frm.tabPlateFrame.Text = texts[12];
            frm.tabTuning.Text = texts[13];
            frm.tabLicensePlate.Text = texts[14];
            frm.lblPower.Text = texts[15];
            frm.lblHandling.Text = texts[16];
            frm.lblTuningStage.Text = texts[17];
            frm.lblChangeColour.Text = texts[18];

            Console.WriteLine("Updated editor display language to {0}", language);
        }
    }
}
