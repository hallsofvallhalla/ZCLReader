using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZCLReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            String line;
            string FTString = "Frame Type" + Environment.NewLine; 
            string ClusterString = "Cluster" + Environment.NewLine; 
            string MCString = "Manufacturer Code?" + Environment.NewLine; 
            String DirectionString = "Direction" + Environment.NewLine; 
            String ResponseString = "Default Response" + Environment.NewLine; 
            string ifMCString = "Manufacturer Code" + Environment.NewLine; 
            string TransString = "Transaction" + Environment.NewLine; 
            string CommandString = "Command" + Environment.NewLine; 
            string PayloadString = "Payload" + Environment.NewLine; 
            Stream myStream = null;
            string ConvertedBinary = "";
            int counter = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "zcl files (*.zcl)|*.zcl";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (StreamReader sr = new StreamReader(myStream)) 
           
                        
               //////////////////////read each line from file
                while ((line = sr.ReadLine()) != null) 
                {
                    //////Count each line as a cluster
                    counter += 1;
                    ClusterString += counter + Environment.NewLine; ;
                    ////////////////////////Frame Control/////////////////////////
                    string FrameControl = line.Substring(0, 2);
                    ConvertedBinary = Convert.ToString(Convert.ToInt32(FrameControl, 16), 2).PadLeft(8,'0');
                    string ManufacturerType = ConvertedBinary.Substring(6, 2);
                    
                            /////////////////////////////Manufactor Type
                    switch (ManufacturerType)
                    {
                        case "00":
                            FTString += "Entire Profile" + Environment.NewLine;
                            break;
                        case "01":
                            FTString += "Cluster" + Environment.NewLine;
                            break;
                        case "10":
                            FTString += "Reserved" + Environment.NewLine;
                            break;
                        case "11":
                            FTString += "Reserved" + Environment.NewLine;
                            break;
                        default:
                            FTString += "error" + Environment.NewLine;
                            break;
                    }
                    
                        
                           ////////////////////Manufacturer Code
                    string isManufacturerCode = ConvertedBinary.Substring(5,1);
                        if (Convert.ToInt32(isManufacturerCode) == 0)
                        {
                            MCString += "No" + Environment.NewLine;;
                        }
                        else
                        {
                            MCString += "Yes " + Environment.NewLine;
                        }
                        ///////////////////////Direction
                     string MDirection = ConvertedBinary.Substring(4, 1);
                     switch(MDirection)
                    {
                        case "0":
                            DirectionString += "From Client" + Environment.NewLine;
                            break;
                        case "1":
                            DirectionString += "From Server" + Environment.NewLine;
                            break;
                        default:
                            DirectionString += "Error" + Environment.NewLine;;
                            break;
                    }
                            /////////////////Default Response
                    string DefaultResponse = ConvertedBinary.Substring(3, 1);
                     switch (DefaultResponse)
                     {
                         case "0":
                             ResponseString += "On" + Environment.NewLine;
                             break;
                         case "1":
                             ResponseString  += "Off" + Environment.NewLine;
                             break;
                         default:
                             ResponseString += "Error";
                             break;
                     }
                    ///////////////////////Manufacturer Code///////////////////
                     if (Convert.ToInt32(isManufacturerCode) == 1)
                     {
                         string MCode = line.Substring(2, 4);
                         ConvertedBinary = Convert.ToString(Convert.ToInt32(MCode, 16), 2).PadLeft(16, '0');
                         ifMCString += "Manufacturer Code: " + ConvertedBinary + Environment.NewLine;
                     }
                     else
                     {
                         ifMCString += Environment.NewLine;
                     }

                    /////////////////////////////Transaction Sequence Number////////////
                    string TransNumber = "";
                     if (Convert.ToInt32(isManufacturerCode) == 1)
                     {
                         TransNumber = line.Substring(6, 2);
                     }
                     else
                     {
                        TransNumber = line.Substring(2, 2);
                     }
                     TransString += TransNumber + Environment.NewLine; 

                    //////////////////////////////Command Identifier
                     string CommandIdentity = ""; 
                    if (Convert.ToInt32(isManufacturerCode) == 1)
                     {
                         CommandIdentity = line.Substring(8, 2);
                     }
                     else
                     {
                         CommandIdentity = line.Substring(4, 2);
                     }
                         switch (CommandIdentity)
                           {
                                case "00":
                             CommandString += "Read Attributes" + Environment.NewLine;
                             break;
                                case "01":
                             CommandString += "Read Attributes Responses" + Environment.NewLine;
                             break;
                                 case "02":
                             CommandString += "Write Attributes" + Environment.NewLine;
                             break;
                                 case "03":
                             CommandString += "Write Attributes Undivided" + Environment.NewLine;
                             break;
                                 case "04":
                             CommandString += "Write Attributes Response" + Environment.NewLine;
                             break;
                                 case "05":
                             CommandString += "Write Attributes No Response" + Environment.NewLine;
                             break;
                                 case "06":
                             CommandString += "Configure Reporting" + Environment.NewLine;
                             break;
                                 case "07":
                             CommandString += "Configure Reporting Response" + Environment.NewLine;
                             break;
                                 case "08":
                             CommandString += "Read Reporting Configuration" + Environment.NewLine;
                             break;
                                 case "09":
                             CommandString += "Read Reporting Configuration Response" + Environment.NewLine;
                             break;
                                 case "0A":
                             CommandString += "Report Attributes" + Environment.NewLine;
                             break;
                                 case "0B":
                             CommandString += "Deafault Response" + Environment.NewLine;
                             break;
                                 case "0C":
                             CommandString += "Discover Attributes" + Environment.NewLine;
                             break;
                                 case "0D":
                             CommandString += "Discover Attributes Response" + Environment.NewLine;
                             break;
                                 case "0E":
                             CommandString += "Read Attributes Structured" + Environment.NewLine;
                             break;
                                 case "0F":
                             CommandString += "Write Attributes Structured" + Environment.NewLine;
                             break;
                                 case "10":
                             CommandString += "Write Attributes Structured Response" + Environment.NewLine;
                             break;
                                default:
                             CommandString += "None Applicable" + Environment.NewLine;
                             break;
                           }

                            ////////////////Payload
                         string Payload = "";
                         if (Convert.ToInt32(isManufacturerCode) == 1)
                         {
                             //////////////////check to see if there is any payload and chop it off if so....
                             if (line.Length > 10)
                             {
                                 Payload = line.Remove(0, 9);
                             }
                             else
                             {
                                 Payload = "None";
                             }
                         }
                         else
                         {
                             if (line.Length > 6)
                             {
                                 Payload = line.Remove(0, 5);
                             }
                             else
                             {
                                 Payload = "None";
                             }
                             
                         }

                         PayloadString += "Payload: " + Payload + Environment.NewLine;
                        
                        
                        
                  }
                        ///////////////////add all parsed text to labels
                        ClusterLabel.Text = ClusterString;
                        FTLabel.Text = FTString;
                        MCLabel.Text = MCString;
                        DirectionLabel.Text = DirectionString;
                        ResponseLabel.Text = ResponseString;
                        IFMClabel.Text = ifMCString;
                        TransLabel.Text = TransString;
                        CommandLabel.Text = CommandString;
                        PayloadLabel.Text = PayloadString;
  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
