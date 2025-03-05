using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ERP_CL
{
    public class ERP_TextBox:   KryptonTextBox
    {
        /// <summary>
        /// 清空文本框内容按钮
        /// </summary>
        private ButtonSpecAny btnClear = new ButtonSpecAny();

        /// <summary>
        /// 构造函数
        /// </summary>
        public ERP_TextBox()
        {
            // btnClear 清除内容按钮的属性设置
            btnClear.Image = global::ERP_CL.Properties.Resources.bin_closed;
            btnClear.Style = PaletteButtonStyle.ListItem;
            btnClear.Type = PaletteButtonSpecStyle.Close;
            // 窗体属性设置
            Anchor = System.Windows.Forms.AnchorStyles.Left;
            ButtonSpecs.AddRange(new ButtonSpecAny[] {this.btnClear});

            StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            //StateCommon.Border.Color2 = System.Drawing.Color.MistyRose;
            StateCommon.Border.DrawBorders = (
                ((((PaletteDrawBorders.Top | PaletteDrawBorders.Bottom)
                | PaletteDrawBorders.Left)| PaletteDrawBorders.Right)));
            StateCommon.Content.Padding = new Padding(4);
            // 事件绑定
            btnClear.Click += new System.EventHandler(this.btnClear_Click);
        }

        /// <summary>
        /// 触发清空文本框内容按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Text = String.Empty;
            this.Focus();
        }
    }
}
