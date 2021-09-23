using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCReceiptPrinter.Common.Const
{
    /// <summary>
    /// 小票中文本浮动方向
    /// </summary>
    internal static class TextAlign
    {
        static StringFormat _floatLeft = new StringFormat();
        static StringFormat _floatRigth = new StringFormat();
        static StringFormat _floatCenter = new StringFormat();

        static TextAlign() {
            _floatLeft.Alignment = StringAlignment.Near;
            _floatCenter.Alignment = StringAlignment.Center;
            _floatRigth.Alignment = StringAlignment.Far;
        }

        public static StringFormat Left { get=>_floatLeft;  }

        public static StringFormat Right { get => _floatRigth; }

        public static StringFormat Center { get => _floatCenter; }
    }
}
