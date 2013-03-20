using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Sugar
    {
        private int sweetness;
        public int Sweetness
        {
            get
            {
                return this.sweetness;
            }
            set
            {
                this.sweetness = value;
                OnPropertyChange(this, new PropertyChangeEventArgs(value));
            }
        }

        // Delegate
        public delegate void PropertyChangeHandler(object sender, PropertyChangeEventArgs data);

        // The event
        public event PropertyChangeHandler PropertyChange;

        // The method which fires the Event
        public void OnPropertyChange(object sender, PropertyChangeEventArgs data)
        {
            // Check if there are any Subscribers
            if (PropertyChange != null)
            {
                // Call the Event
                PropertyChange(this, data);
            }
        }

        public static void AddSweet(int size, List<string> sweet)
        {
            for (int i = size; i <= size; i++)
            {
                if (size != 6)
                {
                    sweet.Add(Convert.ToString(size) + new string('+', size));
                }
            }

            for (int i = 0; i < sweet.Count; i++)
            {
                if (i == 5)
                {
                    sweet.RemoveAt(i);
                }
            }

            foreach (var a in sweet)
            {
                Console.WriteLine(a);
            }
        }

        public static void DellSweet(int size, List<string> sweet)
        {
            if (sweet.Count == 1)
            {
                sweet.RemoveAt(0);
            }
            else if (sweet.Count > 1)
            {
                sweet.RemoveAt(size);
            }

            foreach (var a in sweet)
            {
                Console.WriteLine(a);
            }
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void PropertyHasChanged(object sender, PropertyChangeEventArgs data)
        {
            Console.SetWindowSize(10, 7);
            if (data.NewValue > 0 && data.NewValue < 5)
            {
                Console.Beep();
                Console.Clear();
            }
            else if (data.NewValue > 5)
            {
                Console.Beep(700, 500);
                Console.Clear();
                Program.Product.Sweetness = 5;
            }
            else if (data.NewValue < 0)
            {
                Console.Beep(700, 500);
                Console.Clear();
                Program.Product.Sweetness = 0;
            }
            else if (data.NewValue == 0 || data.NewValue == 5)
            {
                Console.Clear();
            }
        }
    }
}
