#pragma once
#include <Windows.h>
#pragma comment(lib, "user32.lib")

namespace Keyboard {
	public ref class Sender {
	public:
		//키보드 입력을 발생시킵니다.
		static void PressInput(int vkey) {
			INPUT keyinput;
			keyinput.type = INPUT_KEYBOARD;
			if (vkey == 0) return;
			keyinput.ki.wScan = MapVirtualKey(vkey, MAPVK_VK_TO_VSC);
			keyinput.ki.wVk = vkey;
			keyinput.ki.dwFlags = 0;
			SendInput(1, &keyinput, sizeof(INPUT));
		}
		//키보드 때기 입력을 발생시킵니다.
		static void UnpressInput(int vkey) {
			INPUT keyinput;
			keyinput.type = INPUT_KEYBOARD;
			if (vkey == 0) return;
			keyinput.ki.wScan = MapVirtualKey(vkey, MAPVK_VK_TO_VSC);
			keyinput.ki.wVk = vkey;
			keyinput.ki.dwFlags = KEYEVENTF_KEYUP;
			SendInput(1, &keyinput, sizeof(INPUT));
		}
	};
}