﻿using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;

namespace CSharpClassLibrary
{
    public class Class1
    {
        // функция инициализации (выполняется при загрузке плагина)
        public void Initialize()
        {
            MessageBox.Show("Hello!");
        }

        // функция, выполняемая при выгрузке плагина
        public void Terminate()
        {
            MessageBox.Show("Goodbye!");
        }

        // эта функция будет вызываться при выполнении в AutoCAD команды «TestCommand»
        [CommandMethod("TestCom")]
        public void MyCommand()
        {
            MessageBox.Show("RUN TestCommand!");
        }
    }
}