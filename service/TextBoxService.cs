using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system.forms
{
    internal class TextBoxService
    {
        public TextBoxService() { }

        public static void AdjustTextOnCursorExited(
            TextBox textBox,
            string text
        ) {
            if (textBox.Text.Equals(""))
            {
                textBox.Text = text;
                textBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            }
        }

        public static void SetText(TextBox textBox, string text)
        {
            textBox.Text = text;
            textBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
        }

        public static void AdjustTextBoxOnTyping(TextBox textBox)
        {
            textBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox.ForeColor = System.Drawing.Color.FromArgb(1, 0, 0, 0);
        }

        public static void AdjustTextBoxOnMouseClick(
            TextBox textBox,
            string text
        ) {
            if (textBox.Text.Equals(text))
            {
                textBox.Text = "";
            }
        }
    }
}
