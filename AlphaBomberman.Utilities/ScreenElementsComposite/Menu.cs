﻿namespace AlphaBomberman.Utilities.ScreenElementsComposite
{
    using System;
    using Ennumetation;
    using ScreenElements;

    /// <summary>
    /// The Menu class can be used for all menus in the game.
    /// A menu is a list of label is a list of MenuItems that
    /// tracks which item is active and displays it as active
    /// on the screen.
    /// </summary>
    /// <remarks>
    /// To add new elements use the Add() method.
    /// </remarks>
    public class Menu : ScreenGroup
    {
        private int _selected;

        public void Add(int x, int y, string content, Command command)
        {
            var item = new MenuItem(x, y, content, command);
            _elements.Add(item);
        }

        public void MoveUp()
        {
            if (_selected > 0)
            {
                _selected--;
            }
        }

        public void MoveDown()
        {
            if (_selected < Elements.Count - 1)
            {
                _selected++;
            }
        }

        public MenuItem GetSelected()
        {
            return (MenuItem)Elements[_selected];
        }

        /// <summary>
        /// Prints the set of elements on the screen.
        /// </summary>
        public override void Print()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (i == _selected)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Elements[i].Print();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Elements[i].Print();
                }

            }
        }
    }
}
