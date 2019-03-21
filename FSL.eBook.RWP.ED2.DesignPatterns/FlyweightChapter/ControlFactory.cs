using System.Collections.Generic;
using System.Web;

namespace FSL.eBook.RWP.ED2.DesignPatterns.FlyweightChapter
{
    public class ControlFactory
    {
        private readonly Dictionary<Tags, Control> Controls;

        public ControlFactory()
        {
            Controls = new Dictionary<Tags, Control>();
        }

        public Control GetControl(Tags tag)
        {
            if (!Controls.ContainsKey(tag))
            {
                HttpContext.Current.Response.Write($"<span style='color:red;'>Object created {tag} </span></br>");
                switch (tag)
                {
                    case Tags.Text:
                        Controls.Add(tag, new Text());
                        break;
                    case Tags.Radio:
                        Controls.Add(tag, new Radio());
                        break;
                    case Tags.Button:
                        Controls.Add(tag, new Button());
                        break;
                }
            }

            return Controls[tag];
        }
    }
}