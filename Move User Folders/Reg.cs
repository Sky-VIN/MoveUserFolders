using System;
using Microsoft.Win32;

public class Reg
{
    private string ShellFolders = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders";
    private string UserShellFolders = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders";

    // Чтение значения из реестра по заданному имени
    public string GetItem(string name)
    {
        return Registry.GetValue(ShellFolders, name, "(unknown)").ToString();
    }

    // Присваивание значения в реестр
    public void SetItem(string name, string path)
    {
        Registry.SetValue(ShellFolders, name, path, RegistryValueKind.String); // Запись в Shell Folders
        Registry.SetValue(UserShellFolders, name, path, RegistryValueKind.ExpandString); // Запись в User Shell Folders
    }
}
