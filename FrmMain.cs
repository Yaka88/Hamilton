using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamilton
{
    public partial class FrmMain : Form
    {
        bool[,] bMatrix;
        int[] intHC;
        int[] intDeg;
        bool[] bVertexUsed;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            StringBuilder strRow = new StringBuilder();
            Random r = new Random();
            int intVertex = int.Parse(txtVertex.Text);
            int intLimite = Math.Min(int.Parse(txtEdge.Text), intVertex * (intVertex-1)>>1);
            bMatrix = new bool[intVertex, intVertex];
            intDeg = new int[intVertex];
            for (int i =0; i < intLimite;)
            {
                int intRow = r.Next(intVertex);
                int intCol = r.Next(intVertex);
                if (intRow != intCol && (!bMatrix[intRow, intCol]))
                {
                    bMatrix[intRow, intCol] = true;
                    bMatrix[intCol, intRow] = true;
                    intDeg[intRow]++;
                    intDeg[intCol]++;
                    i++;
                }
            }
            for (int i = 0; i < intVertex; i++)
            {
                strRow.Append(i.ToString("00"));
                for (int j = 0; j < intVertex; j++)
                {
                    strRow.Append((bMatrix[i, j]?"  1":"  0"));
                }
                strRow.Append("\r\n");
            }
            txtMatrix.Text = strRow.ToString();
        }

        private bool DecideHC()  
        {
            DateTime dtStart = DateTime.Now;
            int intIndex = 0, intCol = 0;
label1:     if (intIndex < 0)
                return false;
            if((DateTime.Now - dtStart).Minutes > 0)
            {
                return false; //time out
            }
label2:     while (intCol < intHC.Length)  //
            {
                if (bVertexUsed[intCol])
                    intCol++;
                else
                    break;
            }
 Label3:    if (intCol == intHC.Length)
            {
                bVertexUsed[intHC[intIndex]] = false;
                intCol = ++intHC[intIndex--];
                goto label1;
                //return IsPath(--intIndex, intNewCol);
            }
            if (bMatrix[intHC[intIndex], intCol])
            {
                intHC[++intIndex] = intCol;
                bVertexUsed[intCol] = true;
                if (intIndex == intHC.Length - 1)
                {
                    if (bMatrix[intHC[intIndex], intHC[0]])
                        return true;
                    else
                    {
                        intCol = intHC.Length;
                        goto Label3;
                    }
                }
                else
                {
                    intCol = 0;
                    goto label2;
                }
                //return IsPath(intIndex, intIndex == intHC.Length -1 ? 0: 1);
            }
            else
            {
                ++intCol;
                goto label2;
                //return IsPath(intIndex, ++intCol);
            }
        }
        private void btnDecide_Click(object sender, EventArgs e)
        {
            int intVertex = int.Parse(txtVertex.Text);
            StringBuilder strHC = new StringBuilder();
            int intMinDeg = 0;
            bool bIsHC = false;
            for (int i = 1; i < intVertex; i++)
            {
                if (intDeg[i] < intDeg[intMinDeg])
                    intMinDeg = i;
            }
            if (intDeg[intMinDeg] > 1)
            {
                intHC = new int[intVertex];
                intHC[0] = intMinDeg;
                bVertexUsed = new bool[intVertex]; //true mean used
                bVertexUsed[intMinDeg] = true;
                DateTime dtStart = DateTime.Now;
                bIsHC = DecideHC();
                txtTime.Text = (DateTime.Now - dtStart).TotalMilliseconds.ToString("N4");
            }
            else
                txtTime.Text = "0";
            if (bIsHC)
            {
                for (int i = 0; i < intVertex; i++)
                {
                    strHC.Append(intHC[i].ToString("  00"));
                }
                txtHC.Text = strHC.ToString();
            }
            else
                txtHC.Text = string.Format("G({0},{1}) NOT HC!",intVertex,txtEdge.Text);
        }
    }
}
