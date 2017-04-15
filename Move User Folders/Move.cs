using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualBasic.FileIO;

public class Move
{
    public Move(string keyName, string sourcePath, string destinationPath)
    {
        if (!destinationPath.Equals(sourcePath)) // Если исходная и конечная папка не одна и таже
        {
            new Reg().SetItem(keyName, destinationPath); // Запись в реестр значений

            File.SetAttributes(sourcePath, FileAttributes.Normal); // Установка обычного аттрибута исходной папки. Без этого аттрибута, папка не удалится
            File.SetAttributes(destinationPath, FileAttributes.ReadOnly); // Установка аттрибута ReadOnly конечной поапки. Без этого аттрибута, не будет отображаться имя из desktop.ini
            FileSystem.MoveDirectory(sourcePath, destinationPath, UIOption.AllDialogs, UICancelOption.DoNothing); // Собственно, само перемещение...
        }
    }
}
