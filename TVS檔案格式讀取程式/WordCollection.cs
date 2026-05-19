using System.Collections.ObjectModel;

namespace TVS檔案格式讀取程式
{
    internal class WordCollection : Collection<WordItem>
    {
        /// <summary>
        /// 從字串陣列載入資料
        /// </summary>
        public void LoadFromStringArray(string[] lines)
        {
            this.Clear();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                WordItem item = new WordItem(line);
                this.Add(item);
            }
        }
    }
}