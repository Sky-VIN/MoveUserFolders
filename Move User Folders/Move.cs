using System.IO;
using Microsoft.VisualBasic.FileIO;

public class Move
{
    private const string desktopIni = "\\desktop.ini";


    public Move(string key, string sourcePath, string targetPath, bool content)
    {
        /* apply entry in registry */
        MUFRegistry.SetFolderValue(key, targetPath);

        /* set source folder normal attr to be deleted */
        File.SetAttributes(sourcePath, FileAttributes.Normal);

        /* set target folder read-only to display folder name from desktop.ini */
        File.SetAttributes(targetPath, FileAttributes.ReadOnly);

        /* move desktop.ini if it exists */
        if (File.Exists(sourcePath + desktopIni))
            FileSystem.MoveFile(sourcePath + desktopIni, targetPath + desktopIni, true);

        /* move content if necessary */
        if (content)
            FileSystem.MoveDirectory(sourcePath, targetPath, UIOption.AllDialogs, UICancelOption.DoNothing);
    }
}
