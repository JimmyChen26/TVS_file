using System;
using System.Linq;

namespace TVS檔案格式讀取程式
{
    internal class WordItem
    {
        public string Word { get; set; } = "";
        public string Phonogram { get; set; } = "";
        public string SoundPath { get; set; } = "";
        public string Explain { get; set; } = "";

        /// <summary>
        /// 建構子：把 TSV 的一行資料轉成 WordItem 物件
        /// </summary>
        /// <param name="str">單行 TSV 資料</param>
        public WordItem(string str)
        {
            // TSV 是用 Tab 分隔欄位
            string[] strLists = str.Split('\t');

            if (strLists.Length >= 1)
                Word = strLists[0];

            if (strLists.Length >= 2)
                Phonogram = strLists[1];

            if (strLists.Length >= 3)
                SoundPath = strLists[2];

            if (strLists.Length >= 4)
                Explain = string.Join(Environment.NewLine, strLists.Skip(3));
        }

        /// <summary>
        /// 讓物件轉成字串時顯示單字
        /// </summary>
        public override string ToString()
        {
            return Word;
        }
    }
}