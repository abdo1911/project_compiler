using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        List<Syntax> Identifier = new List<Syntax>();
        List<Syntax> Symbol = new List<Syntax>();
        List<Syntax> Reserved = new List<Syntax>();
        public Form1()
        {
            InitializeComponent();
            richTextBox2.ReadOnly = true;
            Identifier.Add(new Syntax("Identifier", "int"));
            Identifier.Add(new Syntax("Identifier", "float"));
            Identifier.Add(new Syntax("Identifier", "string"));
            Identifier.Add(new Syntax("Identifier", "double"));
            Identifier.Add(new Syntax("Identifier", "bool"));
            Identifier.Add(new Syntax("Identifier", "char"));
            Symbol.Add(new Syntax("Operators", "+"));
            Symbol.Add(new Syntax("Operators", "-"));
            Symbol.Add(new Syntax("Operators", "/"));
            Symbol.Add(new Syntax("Operators", "*"));
            Symbol.Add(new Syntax("Operators", "%"));
            Symbol.Add(new Syntax("open_bracket", "("));
            Symbol.Add(new Syntax("closed_bracket", ")"));
            Symbol.Add(new Syntax("open_curly_bracket", "{"));
            Symbol.Add(new Syntax("closed_curly_bracket", "}"));
            Symbol.Add(new Syntax("comma", ","));
            Symbol.Add(new Syntax("semicolon", ";"));
            Symbol.Add(new Syntax("and", "&&"));
            Symbol.Add(new Syntax("or", "||"));
            Symbol.Add(new Syntax("less_than", "<"));
            Symbol.Add(new Syntax("greater_than", ">"));
            Symbol.Add(new Syntax("equal", "="));
            Symbol.Add(new Syntax("not_equal", "!="));
            Reserved.Add(new Syntax("Reserved", "for"));
            Reserved.Add(new Syntax("Reserved", "while"));
            Reserved.Add(new Syntax("Reserved", "if"));
            Reserved.Add(new Syntax("Reserved", "do"));
            Reserved.Add(new Syntax("Reserved", "return"));
            Reserved.Add(new Syntax("Reserved", "break"));
            Reserved.Add(new Syntax("Reserved", "continue"));
            Reserved.Add(new Syntax("Reserved", "end"));

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Scanner();
            // richTextBox1.Clear();
        }

        private void Scanner()
        {

            string match = ("");
            List<string> input = new List<string>();
            List<string> input2 = new List<string>();
            input.AddRange(richTextBox1.Text.Split('\n'));
            foreach (var line in input)
            {
                foreach (var c in line)
                {
                    
                    if (c == ' ')
                    {
                        if (match != "")
                            input2.Add(match);
                        match = "";
                        continue;
                    }

                    if (c == ';')
                    {
                        if (match != "")
                            input2.Add(match);
                        input2.Add("" + c);
                        match = "";
                        continue;
                    }
                    if (c == '\n')
                    {
                        if (match != "")
                            input2.Add(match);
                        match = "";
                        continue;
                    }

                    match += c;

                }
            }

            if (match != "")
            {
                input2.Add(match);
            }

            int notVariable = 0;

            foreach ( string match2 in input2)
            {
                notVariable = 0;
                match = match2;

                if (match == "int")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "float")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "string")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "double")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "bool")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "char")
                {
                    richTextBox2.Text += String.Format("\nthis is Identifier:\t{0}", match);
                    continue;
                }
                if (match == "+")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type operator :\t{0}", match);
                    continue;
                }
                if (match == "-")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type operator :\t{0}", match);
                    continue;
                }
                if (match == "/")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type operator :\t{0}", match);
                    continue;
                }
                if (match == "*")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type operator :\t{0}", match);
                    continue;
                }
                if (match == "%")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type operator :\t{0}", match);
                    continue;
                }
                if (match == "(")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type open_brackets :\t{0}", match);
                    continue;
                }
                if (match == ")")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type closed_brackets :\t{0}", match);
                    continue;
                }
                if (match == "{")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type open_curly_brackets :\t{0}", match);
                    continue;
                }
                if (match == "}")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type closed_curly_brackets :\t{0}", match);
                    continue;
                }
                if (match == ",")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type comma :\t{0}", match);
                    continue;
                }
                if (match == ";")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type semicolon :\t{0}", match);
                    continue;
                }
                if (match == "&&")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type and :\t{0}", match);
                    continue;
                }
                if (match == "||")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type or :\t{0}", match);
                    continue;
                }
                if (match == "<")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type less_than :\t{0}", match);
                    continue;
                }
                if (match == ">")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type greater_than :\t{0}", match);
                    continue;
                }
                if (match == "!=")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type not_equal :\t{0}", match);
                    continue;
                }
                if (match == "=")
                {
                    richTextBox2.Text += String.Format("\nthis is Symbol of type equal :\t{0}", match);
                    continue;
                }
                if (match == "for")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "while")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "do")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "return")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "break")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "continue")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                if (match == "end")
                {
                    richTextBox2.Text += String.Format("\nthis is reserved_word  :\t{0}", match);
                    continue;
                }
                for(char a='0';a<='9';a++)
                {
                    if (match[0] ==a)
                    {
                        if(match.Length>1)
                        {
                            richTextBox2.Text += String.Format("\nthis is number :\t{0}", match);
                        }
                        else
                        {
                            richTextBox2.Text += String.Format("\nthis is digit {1} :\t{0}", match, "" + a);

                        }
                        notVariable = 1;
                        break;
                    }
                }
                if (notVariable==1)
                {
                    continue;
                }
          
                if(match!="")
                {
                    richTextBox2.Text += String.Format("\nthis is variable  :\t{0}", match);
                }

            }

            richTextBox2.Text += "\nDone!";

        }
    }

    /// <summary>
    /// How this work <c> name </c>
    /// </summary>
    /// 

    internal class Syntax
    {
        string name;
        string value;

        public Syntax(string n, string v)
        {
            name = n;
            value = v;
        }
    }
}
