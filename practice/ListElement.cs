using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    /// <summary>
    /// 単方向リスト生成クラス
    /// </summary>
    public class ListElement
    {
        /// <summary>
        /// 要素の値
        /// </summary>
        public string CurrVal = string.Empty;

        /// <summary>
        /// 次の参照先
        /// </summary>
        public ListElement? NextNode = null;

        public ListElement()
        {
        }

        public ListElement(string qVal)
        {
            CurrVal = qVal;
        }
    }
}
