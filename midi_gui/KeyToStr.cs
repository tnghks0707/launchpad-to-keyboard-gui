using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midi_gui
{
    class KeyToStr
    {
		public static string KeyToString(Keys key)
		{
			string returnstr;
			switch (key)
			{
				case 0:
					returnstr = "";
					break;
				case Keys.Back:
					returnstr = "back";
					break;
				case Keys.Tab:
					returnstr = "tab";
					break;
				case Keys.Return:
					returnstr = "Enter";
					break;
				case Keys.ControlKey:
					returnstr = "Control";
					break;
				case Keys.RControlKey:
					returnstr = "Right Control";
					break;
				case Keys.LControlKey:
					returnstr = "Left Control";
					break;
				case Keys.ShiftKey:
					returnstr = "Shift";
					break;
				case Keys.RShiftKey:
					returnstr = "Right Shift";
					break;
				case Keys.LShiftKey:
					returnstr = "Left Shift";
					break;
				case Keys.Menu:
					returnstr = "Alt";
					break;
				case Keys.RMenu:
					returnstr = "Right Alt";
					break;
				case Keys.LMenu:
					returnstr = "Left Alt";
					break;
				case Keys.Capital:
					returnstr = "Caps Lock";
					break;
				case Keys.HangulMode:
					returnstr = "Hangul";
					break;
				case Keys.Escape:
					returnstr = "Esc";
					break;
				case Keys.Space:
					returnstr = "Space";
					break;
				case Keys.Prior:
					returnstr = "Page up";
					break;
				case Keys.Next:
					returnstr = "Page down";
					break;
				case Keys.End:
					returnstr = "End";
					break;
				case Keys.Home:
					returnstr = "Home";
					break;
				case Keys.Left:
					returnstr = "←";
					break;
				case Keys.Right:
					returnstr = "→";
					break;
				case Keys.Up:
					returnstr = "↑";
					break;
				case Keys.Down:
					returnstr = "↓";
					break;
				case Keys.Select:
					returnstr = "Select";
					break;
				case Keys.Print:
					returnstr = "Print";
					break;
				case Keys.Snapshot:
					returnstr = "Print Screen";
					break;
				case Keys.Insert:
					returnstr = "Insert";
					break;
				case Keys.Delete:
					returnstr = "Delete";
					break;
				case Keys.Help:
					returnstr = "Help";
					break;
				case Keys.D0:
					returnstr = "0";
					break;
				case Keys.D1:
					returnstr = "1";
					break;
				case Keys.D2:
					returnstr = "2";
					break;
				case Keys.D3:
					returnstr = "3";
					break;
				case Keys.D4:
					returnstr = "4";
					break;
				case Keys.D5:
					returnstr = "5";
					break;
				case Keys.D6:
					returnstr = "6";
					break;
				case Keys.D7:
					returnstr = "7";
					break;
				case Keys.D8:
					returnstr = "8";
					break;
				case Keys.D9:
					returnstr = "9";
					break;
				case Keys.A:
					returnstr = "a";
					break;
				case Keys.B:
					returnstr = "b";
					break;
				case Keys.C:
					returnstr = "c";
					break;
				case Keys.D:
					returnstr = "d";
					break;
				case Keys.E:
					returnstr = "e";
					break;
				case Keys.F:
					returnstr = "f";
					break;
				case Keys.G:
					returnstr = "g";
					break;
				case Keys.H:
					returnstr = "h";
					break;
				case Keys.I:
					returnstr = "i";
					break;
				case Keys.J:
					returnstr = "j";
					break;
				case Keys.K:
					returnstr = "k";
					break;
				case Keys.L:
					returnstr = "l";
					break;
				case Keys.M:
					returnstr = "m";
					break;
				case Keys.N:
					returnstr = "n";
					break;
				case Keys.O:
					returnstr = "o";
					break;
				case Keys.P:
					returnstr = "p";
					break;
				case Keys.Q:
					returnstr = "q";
					break;
				case Keys.R:
					returnstr = "r";
					break;
				case Keys.S:
					returnstr = "s";
					break;
				case Keys.T:
					returnstr = "t";
					break;
				case Keys.U:
					returnstr = "u";
					break;
				case Keys.V:
					returnstr = "v";
					break;
				case Keys.W:
					returnstr = "w";
					break;
				case Keys.X:
					returnstr = "x";
					break;
				case Keys.Y:
					returnstr = "y";
					break;
				case Keys.Z:
					returnstr = "z";
					break;
				case Keys.LWin:
					returnstr = "Left Windows";
					break;
				case Keys.RWin:
					returnstr = "Right Windows";
					break;
				case Keys.NumPad0:
					returnstr = "Num0";
					break;
				case Keys.NumPad1:
					returnstr = "Num1";
					break;
				case Keys.NumPad2:
					returnstr = "Num2";
					break;
				case Keys.NumPad3:
					returnstr = "Num3";
					break;
				case Keys.NumPad4:
					returnstr = "Num4";
					break;
				case Keys.NumPad5:
					returnstr = "Num5";
					break;
				case Keys.NumPad6:
					returnstr = "Num6";
					break;
				case Keys.NumPad7:
					returnstr = "Num7";
					break;
				case Keys.NumPad8:
					returnstr = "Num8";
					break;
				case Keys.NumPad9:
					returnstr = "Num9";
					break;
				case Keys.Multiply:
					returnstr = "Num*";
					break;
				case Keys.Add:
					returnstr = "Num+";
					break;
				case Keys.Separator:
					returnstr = "Num Enter";
					break;
				case Keys.Subtract:
					returnstr = "Num-";
					break;
				case Keys.Decimal:
					returnstr = "Num.";
					break;
				case Keys.Divide:
					returnstr = " /";
					break;
				case Keys.F1:
					returnstr = "F1";
					break;
				case Keys.F2:
					returnstr = "F2";
					break;
				case Keys.F3:
					returnstr = "F3";
					break;
				case Keys.F4:
					returnstr = "F4";
					break;
				case Keys.F5:
					returnstr = "F5";
					break;
				case Keys.F6:
					returnstr = "F6";
					break;
				case Keys.F7:
					returnstr = "F7";
					break;
				case Keys.F8:
					returnstr = "F8";
					break;
				case Keys.F9:
					returnstr = "F9";
					break;
				case Keys.F10:
					returnstr = "F10";
					break;
				case Keys.F11:
					returnstr = "F11";
					break;
				case Keys.F12:
					returnstr = "F12";
					break;
				case Keys.NumLock:
					returnstr = "Num Lock";
					break;
				case Keys.Scroll:
					returnstr = "Scroll Lock";
					break;
				case Keys.Oem1:
					returnstr = " ;";
					break;
				case Keys.Oem2:
					returnstr = " /";
					break;
				case Keys.Oem3:
					returnstr = " `";
					break;
				case Keys.Oem4:
					returnstr = " [";
					break;
				case Keys.Oem5:
					returnstr = " \\";
					break;
				case Keys.Oem6:
					returnstr = "]";
					break;
				case Keys.Oem7:
					returnstr = "'";
					break;
				case Keys.Oemplus:
					returnstr = "=";
					break;
				case Keys.Oemcomma:
					returnstr = ",";
					break;
				case Keys.OemMinus:
					returnstr = "-";
					break;
				case Keys.OemPeriod:
					returnstr = ".";
					break;
				default:
					returnstr = "";
					break;
			}
			return returnstr;
		}
    }
}
