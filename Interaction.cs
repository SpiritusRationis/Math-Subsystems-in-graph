using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis_part2
{
    internal class Interaction
    {
        private Panel JobPanel;
        private int Count;
        private int X;
        private int Y;

        /*Данные параметры задаются в классе*/
        private static int widthLabel = 40;
        private static int heightLabel = 20;
        private static int widthTextBox = 100;
        private static int heightTextBox = 20;
        private static int delta = widthLabel;
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private List<Label> Names;
        private List<TextBox> Data;

        public Interaction(Panel jobPanel, int startCount, int indent)
        {
            JobPanel = jobPanel;
            Count = 0;
            X = indent;
            Y = indent;

            Names = new List<Label>();
            Data = new List<TextBox>();

            for (int i = 0; i < startCount; i++)
            {
                AddInputRow();
            }
        }

        public int GetCount() { return Count; }

        public void AddInputRow()
        {
            Count++;

            Names.Add(CreateLabel(Names.Count));
            Data.Add(CreateTextBox());

            JobPanel.Controls.Add(Names[Names.Count - 1]);
            JobPanel.Controls.Add(Data[Data.Count - 1]);
            Y += heightLabel + heightTextBox;
        }

        public void RemoveInputRow()
        {
            if(Count > 1)
            {
                Count--;
                JobPanel.Controls.Remove(Names[Names.Count - 1]);
                JobPanel.Controls.Remove(Data[Data.Count - 1]);
                Names.Remove(Names[Names.Count - 1]);
                Data.Remove(Data[Data.Count -1]);
                Y -= heightLabel + heightTextBox;
            }
            else
            {
                throw new Exception("");
            }
        }

        public List<string>GetData()
        {
           List<string> data = new List<string>();

            foreach (TextBox txt in Data)
            {
                data.Add(txt.Text);
            }

            return data;
        }

        public List<TextBox> GetDataBox()
        {
            return Data;
        }

        private Label CreateLabel(int index)
        {
            return new Label()
            {
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Text = "G (" + (index + 1).ToString() + ")",
                Location = new System.Drawing.Point(X, Y),
                Width = widthLabel,
                Height = heightLabel
            };
           
        }

        private TextBox CreateTextBox()
        {
            return new TextBox()
            {
                TextAlign = HorizontalAlignment.Left,
                Location = new System.Drawing.Point(X + delta, Y),
                Width = widthTextBox,
                Height = heightTextBox
            };
        }
    }
}
