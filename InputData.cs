using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysis_part2
{
    internal class InputData
    {
        private List<string> Data;
        private List<int[]> Right;
        private List<int[]> Left;
        private int[][] AdjacencyMatrix;
        private int[][] ReachabilityMatrix;
        public InputData(List<string> data)
        {
            Data = data;
            Parse();
            ToAdjacencyMatrix();
            ToLeft();
            InitReachabilityMatrix();
        }
        public List<int[]> GetRight() { return Right; }
        public List<int[]> GetLeft() { return Left; }
        public int[][] GetAdjacencyMatrix() { return AdjacencyMatrix; }
        public int[][] GetReachabilityMatrix()
        {
            for (int k = 0; k < ReachabilityMatrix.Length; k++)
            {
                for (int i = 0; i < ReachabilityMatrix.Length; i++)
                {
                    for (int j = 0; j < ReachabilityMatrix.Length; j++)
                    {
                        if (ReachabilityMatrix[i][j] == 0)
                        {
                            if (ReachabilityMatrix[k][j] == 1 && ReachabilityMatrix[i][k] == 1)
                            {
                                ReachabilityMatrix[i][j] = 1;
                            }
                        }
                    }
                }
            }

            return ReachabilityMatrix;
        }
        public List<int[]> GetSubsystem()
        {
            List<int> free = new List<int>();
            List<int[]> res = new List<int[]>();

            for (int i = 0; i < AdjacencyMatrix.Length; i++)
                free.Add(i);

            while(free.Count != 0)
            {
                var tmp = Intersection(free[0]);
                res.Add(tmp);
                
                foreach (int i in tmp)
                    free.Remove(i);
            }

            return res;
        }
        public List<int[]> GetSLeft(List<int[]> Subsystems)
        {
           Dictionary<int, int[]> keyValues = new Dictionary<int, int[]>();
            for (int i = 0; i < Subsystems.Count; i++)
            {
                keyValues.Add(i + 1, Subsystems[i]); 
            }

            return null;
        }

        public List<int[]> GetResult(List<int[]> Subsystems)
        {
            List<int> tmp = new List<int>();
            List<int[]> res = new List<int[]>();

            for (int i = 0; i < Subsystems.Count; i++)
            {
                for (int j = 0; j < Subsystems[i].Length; j++)
                {
                    tmp.AddRange(Left[Subsystems[i][j]]);
                }

                for (int j = 0; j < tmp.Count; j++)
                {
                    tmp[j] = GetSubsystemNumber(tmp[j] - 1, Subsystems);
                }

                res.Add(tmp.ToArray());
                tmp.Clear();
            }

            return res;
        }
        private void Parse()
        {
            List<int[]> parse = new List<int[]>();

            for (int i = 0; i < Data.Count; i++)
            {
                parse.Add(StringParse(Data[i]));
            }

            Right = parse;
        }
        private int[] StringParse(string p)
        {
            if(p.Length == 0)
            {
                return new int[0];
            }
            else
            {
                string[] cNums = p.Split(';');

                int[] Nums = new int[cNums.Length];

                for (int i = 0; i < cNums.Length; i++)
                {
                    try
                    {
                        Nums[i] = Convert.ToInt32(cNums[i]);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Not a Number!");
                    }

                }

                return Nums;
            }
        }
        private void ToAdjacencyMatrix()
        {
            InitAdjacencyMatrix();

            for (int i = 0; i < Data.Count; i++)
            {
                for (int j = 0; j < Right[i].Length; j++)
                {
                    AdjacencyMatrix[i][Right[i][j] - 1] = 1;
                }
            }
        }
        private void ToLeft()
        {
            Left = new List<int[]>(AdjacencyMatrix.Count());
            List<int> tmp = new List<int>();

            for (int i = 0;i < AdjacencyMatrix.Count(); i++)
            {
                for (int j = 0; j < AdjacencyMatrix[i].Count(); j++)
                {
                    if(AdjacencyMatrix[j][i] == 1)
                    {
                        tmp.Add(j + 1);
                    }
                }

                Left.Add(tmp.ToArray());
                tmp.Clear();
            }
        }
        private void InitAdjacencyMatrix()
        {
            AdjacencyMatrix = new int[Data.Count][];

            for (int i = 0; i < Data.Count; i++)
            {
                AdjacencyMatrix[i] = new int[Data.Count];
            }

            for (int i = 0;i < Data.Count; i++)
            {
                for (int j = 0; j < Data.Count; j++)
                {
                    AdjacencyMatrix[i][j] = 0;
                }
            }
        }
        private void InitReachabilityMatrix()
        {
            ReachabilityMatrix = AdjacencyMatrix;

            for (int i = 0; i < ReachabilityMatrix.Length; i++)
            {
                ReachabilityMatrix[i][i] = 1;
            }
        }
        private int[] Intersection(int index)
        {
            List<int> intersection = new List<int>();

            for (int i = 0; i < ReachabilityMatrix.Length; i++)
            {
                if(ReachabilityMatrix[index][i] == 1 && ReachabilityMatrix[i][index] == 1)
                {
                    intersection.Add(i);
                }
            }
            return intersection.ToArray();
        }
        private int GetSubsystemNumber(int V, List<int[]> Subsystems)
        {
            int result = -1;

            for (int i = 0; i < Subsystems.Count; i++)
            {
                for (int j = 0; j < Subsystems[i].Length; j++)
                {
                    if (Subsystems[i][j] == V)
                        result = i;
                }
            }
            return result;
        }
       
    }
}