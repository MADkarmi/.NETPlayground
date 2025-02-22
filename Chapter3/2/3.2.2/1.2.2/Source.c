﻿#include <windows.h>

HKEY hkSoftware, hkSettings;
DWORD dwDisposition;
DWORD width = 0;
DWORD height = 0;

LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);

char szClassName[] = "hjmjt6uhjfthujsdf";

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance, LPSTR lpszArgument, int nFunsterStil)
{
  HWND hwnd;
  MSG messages;
  WNDCLASSEX wincl;

  wincl.hInstance = hThisInstance;
  wincl.lpszClassName = szClassName;
  wincl.lpfnWndProc = WindowProcedure;

  wincl.style = CS_DBLCLKS;
  wincl.cbSize = sizeof(WNDCLASSEX);

  wincl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
  wincl.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
  wincl.hCursor = LoadCursor(NULL, IDC_ARROW);
  wincl.lpszMenuName = NULL;
  wincl.cbClsExtra = 0;
  wincl.cbWndExtra = 0;

  wincl.hbrBackground = (HBRUSH)GetStockObject(LTGRAY_BRUSH);

  if (!RegisterClassEx(&wincl)) return 0;

  LONG ret = RegOpenKeyEx(HKEY_CURRENT_USER, TEXT("Software"), 0, KEY_ALL_ACCESS, &hkSoftware);

  /*
  WCHAR * buf;
  buf = LocalAlloc(NULL, 512);
  FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, 0, ret, MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT), buf, 512, NULL);
  //The system could not find the file specified
  MessageBox(0, buf, 0, 0);
  LocalFree(buf);
  */

  RegCreateKeyEx(hkSoftware, TEXT("Programowanie pod Windows"), 0, NULL, REG_OPTION_NON_VOLATILE, KEY_ALL_ACCESS, NULL, &hkSettings, &dwDisposition);

  if (dwDisposition == REG_CREATED_NEW_KEY)
  {
    width = 200;
    height = 200;
    RegSetValueEx(hkSettings, TEXT("Width"), 0, REG_DWORD, (BYTE *)&width, sizeof(width));
    RegSetValueEx(hkSettings, TEXT("Height"), 0, REG_DWORD, (BYTE *)&height, sizeof(height));
  }

  DWORD dwSize = sizeof(DWORD);
  RegQueryValueEx(hkSettings, TEXT("Width"), NULL, NULL, (LPBYTE)&width, &dwSize);
  RegQueryValueEx(hkSettings, TEXT("Height"), NULL, NULL, (LPBYTE)&height, &dwSize);

  hwnd = CreateWindowEx(
    0,
    szClassName,
    TEXT("3.2.2"),
    WS_OVERLAPPEDWINDOW,
    CW_USEDEFAULT,
    CW_USEDEFAULT,
    width,
    height,
    HWND_DESKTOP,
    NULL,
    hThisInstance,
    NULL
    );

  ShowWindow(hwnd, nFunsterStil);
  while (GetMessage(&messages, NULL, 0, 0))
  {
    TranslateMessage(&messages);
    DispatchMessage(&messages);
  }

  return messages.wParam;
}

LRESULT CALLBACK WindowProcedure(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
  switch (message)
  {
  case WM_SIZE:
    width = LOWORD(lParam);
    height = HIWORD(lParam);
    RegSetValueEx(hkSettings, TEXT("Width"), 0, REG_DWORD, (BYTE *)&width, sizeof(width));
    RegSetValueEx(hkSettings, TEXT("Height"), 0, REG_DWORD, (BYTE *)&height, sizeof(height));
    break;
  case WM_DESTROY:
    PostQuitMessage(0);
    break;
  default:
    return DefWindowProc(hwnd, message, wParam, lParam);
  }
  return 0;
}
