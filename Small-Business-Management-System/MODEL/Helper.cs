using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System.MODEL
{
    public static class Helper
    {
        public static bool IsInputLetter(KeyPressEventArgs e)
        {
            bool isLetter = false;
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr != 8 && !Char.IsWhiteSpace(chr))
            {
                e.Handled = true;
            }
            else
            {
                isLetter = true;
            }
            return isLetter;
        }
        public static bool IsInputDigit(KeyPressEventArgs e)
        {
            bool isDigit = false;
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
            else
            {
                isDigit = true;
            }
            return isDigit;
        }
        public static bool IsInputFloat(KeyPressEventArgs e)
        {
            bool isFloat = false;
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
            else
            {
                isFloat = true;
            }
            return isFloat;
        }
        public static bool IsInputLetterOrDigit(KeyPressEventArgs e)
        {
            bool isLetterOrDigit = false;
            Char chr = e.KeyChar;
            if (!Char.IsLetterOrDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
            else
            {
                isLetterOrDigit = true;
            }
            return isLetterOrDigit;
        }
    }
}
