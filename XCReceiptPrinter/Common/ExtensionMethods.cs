using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCReceiptPrinter.Common
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// 计算文本尺寸
        /// </summary>
        /// <param name="content">文本内容</param>
        /// <param name="contentFont">文本字体</param>
        /// <param name="width">宽度</param>
        /// <param name="graphics">画布</param>
        /// <returns></returns>
        public static SizeF CalculationGDISize(this string content,Font contentFont,int width, Graphics graphics = null) {
            if (graphics == null)
            {
                graphics = Graphics.FromImage(new Bitmap(1, 1));
            }
            var sizeF = graphics.MeasureString(content, contentFont, width);
            return sizeF;
        }
    }
}
