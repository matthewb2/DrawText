using ConsoleDraw.Inputs;
using ConsoleDraw.Windows.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw.Windows
{
    public class Confirm : PopupWindow
    {
        private static int textLength = 46;
        
        private Button okBtn;
        private Button cancelBtn;
        //private DialogResult dr;

        //public DialogResult Result { get; set; }

        public Confirm(Window parentWindow, String Message, String Title = "Confirm")
            : base(Title, 6, (Console.WindowWidth / 2) - 25, 50, 5 + (int)Math.Ceiling(((Double)Message.Count() / textLength)), parentWindow)
        {
            Create(Message, parentWindow);
        }

        public Confirm(String Message, Window parentWindow, ConsoleColor backgroundColour, String Title = "Message")
            : base(Title, 6, (Console.WindowWidth / 2) - 25, 50, 5 + (int)Math.Ceiling(((Double)Message.Count() / textLength)), parentWindow)
        {
            BackgroundColour = backgroundColour;

            Create(Message, parentWindow);
        }

        private void Create(String Message, Window parentWindow)
        {
            var count = 0;
            while ((count * 45) < Message.Count())
            {
                var splitMessage = Message.PadRight(textLength * (count + 1), ' ').Substring((count * textLength), textLength);
                var messageLabel = new Label(splitMessage, PostionX + 2 + count, PostionY + 2, "messageLabel", this);
                Inputs.Add(messageLabel);

                count++;
            }

            okBtn = new Button(PostionX + Height - 2, PostionY + 2, "OK", "OkBtn", this);
            //okBtn.Action = delegate() { ExitWindow(); dr = DialogResult.OK; };

            cancelBtn = new Button(PostionX + Height - 2, PostionY + 8, "Cancel", "cancelBtn", this);
            //cancelBtn.Action = delegate() { ExitWindow(); dr = DialogResult.Cancel; };

            Inputs.Add(okBtn);
            Inputs.Add(cancelBtn);

            CurrentlySelected = okBtn;
        }
        /*
        public DialogResult ShowDialog()
        {
            Draw();
            MainLoop();

            return dr;
        }
        */

    }
}
