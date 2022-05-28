using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IdanLalezari326643269.FORMS
{
    public partial class sendAssignmentForm : Form
    {
        //File f;
        string path;
        public sendAssignmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename_lbl.Text = openFileDialog1.SafeFileName;
                //create a file object and set the path to the file
                
                path = openFileDialog1.FileName;
            }
        }

        private void sendAssignmentForm_Load(object sender, EventArgs e)
        {
            filename_lbl.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(path.Length > 0))
            {
                LOGGER.Logger.PrintLog("error in sendAssignmentForm.cs (line 43) : path length < or = to 0", ENUM.Enums.LogType.Error);
                MessageBox.Show("error in sendAssignmentForm.cs (line 43) : path length < or = to 0");
                return;
            }
            try
            {
                string dir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "assignments");

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                if (Directory.Exists(dir))
                {
                    //MessageBox.Show($"yay :) - {dir}");
                    if (CLASS.SharedHashTable.dict.ContainsKey("AssignmentIDForSend"))
                    {
                        string assignmentDir = Path.Combine(dir, CLASS.SharedHashTable.dict["AssignmentIDForSend"].ToString());
                        if (!Directory.Exists(assignmentDir))
                        {
                            Directory.CreateDirectory(assignmentDir);
                        }
                        if (Directory.Exists(assignmentDir))
                        {
                            //save file to assignment dir in the form of the student id 
                            string fileNameToSave = CLASS.SharedHashTable.dict["StudentID"].ToString() + /*the f type*/ Path.GetExtension(path);
                            string filePathToSave = Path.Combine(assignmentDir, fileNameToSave);
                            //copy f to filePathToSave
                            File.Copy(path, filePathToSave);
                            MessageBox.Show("File sent successfully");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
            }

            this.Close();
        }
    }
}
