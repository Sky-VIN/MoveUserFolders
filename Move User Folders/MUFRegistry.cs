using Microsoft.Win32;


public class MUFRegistry
{
    public struct FolderKeys
    {
        public const string DESKTOP = "Desktop";
        public const string DOCS = "Personal";
        public const string VIDEOS = "My Video";
        public const string MUSIC = "My Music";
        public const string PICTURES = "My Pictures";
        public const string DOWNLOADS = "{374DE290-123F-4565-9164-39C4925E467B}";
    }

    private const string SHELL_FOLDERS = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\";
    private const string USER_SHELL_FOLDERS = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders\";


    public static string[] GetFolderValue(string key)
    { return new string[] { key, Registry.GetValue(SHELL_FOLDERS, key, null) as string }; }


    public static void SetFolderValue(string key, string path)
    {
        Registry.SetValue(SHELL_FOLDERS, key, path, RegistryValueKind.String);
        Registry.SetValue(USER_SHELL_FOLDERS, key, path, RegistryValueKind.ExpandString);
    }
}
