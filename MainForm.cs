using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis_part2
{
    public partial class MainForm : Form
    {
        private Interaction interaction;
        public MainForm()
        {
            InitializeComponent();
            interaction = new Interaction(InputPanel, 5, 8);
            CountBox.Text = interaction.GetCount().ToString();
        }

        public void Computing()
        {
            InputData inputData = new InputData(interaction.GetData());
            var R = inputData.GetRight();
            var A = inputData.GetAdjacencyMatrix();
            var L = inputData.GetLeft();

            var ReachabilityMatrix = inputData.GetReachabilityMatrix();

            var subsystems = inputData.GetSubsystem();

            var res = inputData.GetResult(subsystems);

            for (int i = 0; i < res.Count; i++)
            {
                res[i] = res[i].ToList().Distinct().ToArray();
            }

            SubsystemsBox.Text = "";


            for (int i = 0; i < subsystems.Count; i++)
            {
                SubsystemsBox.Text += "V" + (i + 1).ToString() + " = { ";
                for (int j = 0; j < subsystems[i].Length; j++)
                {
                    SubsystemsBox.Text += (subsystems[i][j] + 1).ToString() + "; ";
                }
                SubsystemsBox.Text += " }" + Environment.NewLine;
            }

            OutBox.Text = "";

            for (int i = 0; i < res.Count; i++)
            {
                OutBox.Text += "G (V" + (i + 1).ToString() + ") = { ";
                for (int j = 0; j < res[i].Length; j++)
                {
                    if (res[i][j] == i)
                    {
                        OutBox.Text = OutBox.Text;
                    }
                    else
                    {
                        OutBox.Text += (res[i][j] + 1).ToString() + "; ";
                    }

                }

                OutBox.Text += " }" + Environment.NewLine;
            }
        }
        public void Clear()
        {
            foreach (var item in interaction.GetDataBox())
            {
                item.Clear();
            }

            SubsystemsBox.Clear();
            OutBox.Clear();
        }

        private void ComputingButton_Click(object sender, EventArgs e)
        {
            Computing();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            VScrollProperties scroll = InputPanel.VerticalScroll;
            scroll.Value = 0;
            interaction.AddInputRow();
            CountBox.Text = interaction.GetCount().ToString();
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            VScrollProperties scroll = InputPanel.VerticalScroll;
            scroll.Value = 0;
            interaction.RemoveInputRow();
            CountBox.Text = interaction.GetCount().ToString();
        }
    }
}
