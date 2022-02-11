using Huffman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA
{
    public partial class ad : Form
    {
        public ad()
        {
            InitializeComponent();
        }

        adaptive AD = null;
        int totalNodes = 0, maxTreeHeight = 0;
        node the_tree = null;
        private Pen blackPen;
        private SolidBrush blackBrush;
        Dictionary<string, node> char_connect_node = new Dictionary<string, node>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ad_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.SizeChanged += new EventHandler(panel1_SizeChanged);
            panel1.Font = new Font("SansSerif", 9.0f, FontStyle.Bold);
            blackPen = new Pen(Color.FromArgb(4, 195, 147));
            blackBrush = new SolidBrush(Color.FromArgb(4, 195, 147));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (the_tree != null)
                DrawTree(the_tree, e.Graphics);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void txtAD_TextChanged(object sender, EventArgs e)
        {
            label2.Text = txtAD.Text.Length.ToString();
            if (label2.Text == 0.ToString())
            {
                label2.Text = "size";
            }
        }

        private void AD_Decode_Click(object sender, EventArgs e)
        {
            if (txtAD_result.Visible == false)
            {
                txtAD_result.Visible = true;
            }
            txtAD_result.Clear();

            var tree = new HuffTree();
            string decoded = tree.Decode(encoded);
            txtAD_result.Text = "The decoded string: " + decoded.ToString();
        }

        string encoded;

        private void txtAD_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void AD_Encode_Click(object sender, EventArgs e)
        {
            if (txtAD_result.Visible == false)
            {
                txtAD_result.Visible = true;
            }
            txtAD_result.Clear();

            string a = txtAD.Text;
            var tree = new HuffTree(); 
            encoded = tree.Encode(a);
            txtAD_result.Text = "The encoded string: " + encoded.ToString() + Environment.NewLine;
        }


        public static double logtwo(double num)
        {
            return Math.Log(num) / Math.Log(2);
        }
        private void AD_Entropy_Click(object sender, EventArgs e)
        {
            if (txtAD_result.Visible == false)
            {
                txtAD_result.Visible = true;
            }
            txtAD_result.Clear();
            string input = txtAD.Text;
            double infoC = 0;
            Dictionary<char, double> table = new Dictionary<char, double>();


            foreach (char c in input)
            {
                if (table.ContainsKey(c))
                    table[c]++;
                else
                    table.Add(c, 1);

            }
            double freq;
            foreach (KeyValuePair<char, double> letter in table)
            {
                freq = letter.Value / input.Length;
                infoC += freq * logtwo(freq);
            }
            infoC *= -1;
            txtAD_result.Text = "The entropy of " + input.ToString() + " is " + infoC.ToString();
        }

        private void InorderTraversal(node t, int depth)
        {
            if (t != null)
            {
                InorderTraversal(t.Left, depth + 1); //add 1 to depth (y coordinate) 
                t.Xpos = totalNodes++ + 1; //x coord is node number in inorder traversal
                t.Ypos = depth - 1; // mark y coord as depth
                InorderTraversal(t.Right, depth + 1);
            }
        }

        private int TreeHeight(node t)
        {
            if (t == null) return -1;
            else return 1 + Math.Max(TreeHeight(t.Left), TreeHeight(t.Right));
        }


        public void DrawTree(node root, Graphics g)
        {
            try
            {
                panel1.Width = ClientSize.Width - 50;
                panel1.Height = ClientSize.Height - 20;

                int Width = panel1.Width;
                int Height = panel1.Height;
                int dx = 0, dy = 0, dx2 = 0, dy2 = 0, ys = 20;
                int XSCALE, YSCALE;
                int treeHeight = TreeHeight(root);

                XSCALE = (int)(Width / totalNodes); //scale x by total nodes in tree
                YSCALE = (int)((Height - ys) / (maxTreeHeight + 1)); //scale y by tree height

                if (root != null)
                {
                    // inorder traversal to draw each node
                    DrawTree(root.Left, g); // do left side of inorder traversal 
                    dx = root.Xpos * XSCALE; // get x,y coords., and scale them 
                    dy = root.Ypos * YSCALE;
                    string s = root.sympol.ToString() + "(" + root.c.ToString() + ")"; //get the word at this node
                    g.DrawString(s, panel1.Font, blackBrush, new PointF(dx - ys - 30, dy));
                    // this draws the lines from a node to its children, if any
                    if (root.Left != null)
                    {
                        //draws the line to left child if it exists
                        dx2 = root.Left.Xpos * XSCALE;
                        dy2 = root.Left.Ypos * YSCALE;
                        g.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    if (root.Right != null)
                    {
                        //draws the line to right child if it exists
                        dx2 = root.Right.Xpos * XSCALE;//get right child x,y scaled position
                        dy2 = root.Right.Ypos * YSCALE;
                        g.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    DrawTree(root.Right, g); //now do right side of inorder traversal 
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void AD_Tree_Click(object sender, EventArgs e)
        {
            close.Show();
            panel1.Show();
            AD = null;
            for (int i = 0; i < txtAD.TextLength; i++)
            {
                if (AD == null)
                {
                    AD = new adaptive(txtAD.Text[i]);
                }
                else
                {
                    AD.insertnew(txtAD.Text[i]); 
                }
                int depth = 1;
                totalNodes = 0;
                the_tree = AD.root;
                InorderTraversal(the_tree, depth);
                maxTreeHeight = TreeHeight(the_tree);
                panel1.Invalidate();
            }
        }

        


    }
}
