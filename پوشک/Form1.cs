using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace پوشک
{
    public partial class Form1 : Form
    {
        HTuple dict, hv_AcqHandle, hv_directory, drawID, drawParams;
        Boolean whileStart;
        HObject hImage, WriteDictionary, hImagetrain;
        Thread acthinthread;
        string dir, dirr, MyModel, colorRec = "#ff000040";
        HTuple hv_Dictionary, hv_DictionaryResult;
        HObject PadROI;
        HTuple row1 = 250, col1 = 350, row2 = 400, col2 = 1000;


        private void btnSaveModel(object sender, EventArgs e)
        {
            btntrain.Enabled = true;
            button1.Enabled = false;
            ///////////////hello word on the licens !!
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Halcon Dictionary Files (*.hdict)|*.hdict|All Files (*.*)|*.*";
                saveDialog.Title = "Save Dictionary File";
                saveDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Models";
                saveDialog.FileName = "default_model_name.hdict";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;
                    try
                    {
                        HTuple emptyTuple = new HTuple();
                        HOperatorSet.WriteDict(hv_DictionaryResult, filePath, emptyTuple, emptyTuple);

                        MessageBox.Show("The model was successfully saved", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (HOperatorException ex)
                    {
                        MessageBox.Show("Error saving dictionary: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        HOperatorSet.ClearDrawingObject(drawID);
                        HOperatorSet.ClearWindow(hwhalcon.HalconWindow);
                    }
                }
            }
        }

        private void btnClearForm1_Click(object sender, EventArgs e)
        {
            HOperatorSet.ClearWindow(hwhalcon.HalconWindow);
            MyModel = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acthinthread != null && acthinthread.IsAlive)
            {
                var result = MessageBox.Show(
                    "The program is still running. Do you want to stop it and close the application?",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    e.Cancel = true;
                    whileStart = false;

                    btnStart.Enabled = true;
                    btnstop.Enabled = false;
                }
            }
        }

        private void txtlocathointrain_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtlocathointrain.Text))
            {
                tramaxthertrain.Enabled = true;
                traminthertrain.Enabled = true;
                btntrain.Enabled = true;
            }
            else
            {
                tramaxthertrain.Enabled = false;
                traminthertrain.Enabled = false;
                btntrain.Enabled = false;
            }
        }

        private void hwhalconTrain_HMouseUp(object sender, HMouseEventArgs e)
        {

            if (drawID != null)
            {
                try
                {
                    HOperatorSet.DetachDrawingObjectFromWindow(hwhalconTrain.HalconWindow, drawID);

                    HOperatorSet.GetDrawingObjectParams(drawID, new HTuple("row1", "column1", "row2", "column2"), out drawParams);
                    row1 = drawParams.TupleSelect(0);
                    col1 = drawParams.TupleSelect(1);
                    row2 = drawParams.TupleSelect(2);
                    col2 = drawParams.TupleSelect(3);

                    ExecuteTrainingProcedure();
                }
                catch (HOperatorException ex)
                {
                    MessageBox.Show($"Error while filling rectangle: {ex.Message}", "Rectangle Filling Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrowstrain_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Image";
                openFileDialog.ShowDialog();
                openFileDialog.Filter = "JPEG Image (*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
                                        "PNG Image (*.png)|*.png|" +
                                        "GIF Image (*.gif)|*.gif|" +
                                        "Bitmap Image (*.bmp)|*.bmp|" +
                                        "TIFF Image (*.tiff;*.tif)|*.tiff;*.tif|" +
                                        "WEBP Image (*.webp)|*.webp|" +
                                        "SVG Image (*.svg)|*.svg|" +
                                        "RAW Image (*.raw)|*.raw|" +
                                        "HEIF/HEIC Image (*.heif;*.heic)|*.heif;*.heic|" +
                                        "All Files (*.*)|*.*";
                txtlocathointrain.Text = openFileDialog.FileName;

                HOperatorSet.ReadImage(out hImagetrain, openFileDialog.FileName);
                hwhalconTrain.HalconWindow.ClearWindow();
                HOperatorSet.DispObj(hImagetrain, hwhalconTrain.HalconWindow);
            }
        }

        private void btnmodels_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openmodel = new OpenFileDialog())
            {
                openmodel.InitialDirectory = Directory.GetCurrentDirectory() + "\\Models";
                openmodel.Filter = "Halcon Dictionary Files (*.hdict)|*.hdict|All Files (*.*)|*.*";
                openmodel.Title = "Select a Model File";

                openmodel.ShowDialog();
                MyModel = openmodel.FileName;
            }
        }

        private void traminthertrain_Scroll(object sender, EventArgs e)
        {
            if (traminthertrain.Value > tramaxthertrain.Value)
                traminthertrain.Value = tramaxthertrain.Value;

            HOperatorSet.SetDictTuple(dict, "min_threshold", traminthertrain.Value);
            HOperatorSet.SetDictTuple(dict, "max_threshold", tramaxthertrain.Value);

            lblmintrain.Text = "Min Threshold: " + traminthertrain.Value;
            lblmaxtrain.Text = "Max Threshold: " + tramaxthertrain.Value;

            int difference = tramaxthertrain.Value - traminthertrain.Value;

            if (difference >= 255)
            {
                colorRec = "red";
            }

            else if (difference >= 192)
            {
                colorRec = "#ff0000c0";
            }

            else if (difference >= 128)
            {
                colorRec = "#ff000080";
            }

            else if (difference >= 64)
            {
                colorRec = "#ff000040";
            }

            else
            {
                colorRec = "#ff000040";
            }

            ExecuteTrainingProcedure();
        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (hwhalconTrain != null && hwhalconTrain.HalconWindow.IsInitialized())
                {
                    hwhalconTrain.HalconWindow.ClearWindow();
                    HOperatorSet.ClearDrawingObject(drawID);
                    HOperatorSet.ClearObj(PadROI);
                }
            }
            catch (HalconDotNet.HOperatorException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (btntrain.Enabled == false)
            {
                button1.Enabled = false;
                txtlocathointrain.Text = "";
            }
        }

        private void ExecuteTrainingProcedure()
        {
            HTuple hichi = new HTuple();
            button1.Enabled = true;
            btntrain.Enabled = false;

            hwhalconTrain.HalconWindow.ClearWindow();
            HOperatorSet.DispObj(hImagetrain, hwhalconTrain.HalconWindow);
            HOperatorSet.SetColor(hwhalconTrain.HalconWindow, colorRec);
            HOperatorSet.CreateDrawingObjectRectangle1(row1, col1, row2, col2, out drawID);
            HOperatorSet.AttachDrawingObjectToWindow(hwhalconTrain.HalconWindow, drawID);
            HOperatorSet.DispText(hwhalconTrain.HalconWindow, "Please Select the Area", "window", "top", "left", "black", hichi, hichi);

            HDevProcedure hProctrain = null;
            HDevProcedureCall hProccalltrain = null;

            try
            {
                hProctrain = new HDevProcedure();
                hProctrain.LoadProcedure(Directory.GetCurrentDirectory() + "\\Pad.hdev", "train");
                hProccalltrain = new HDevProcedureCall(hProctrain);

                HTuple emptyTuple = new HTuple();
                HOperatorSet.CreateDict(out hv_Dictionary);
                HOperatorSet.SetDictTuple(hv_Dictionary, "DrawID", drawID);
                HOperatorSet.SetDictTuple(hv_Dictionary, "min_th", traminthertrain.Value);
                HOperatorSet.SetDictTuple(hv_Dictionary, "max_th", tramaxthertrain.Value);

                hProccalltrain.SetInputCtrlParamTuple("di", hv_Dictionary);
                hProccalltrain.SetInputIconicParamObject("Image", hImagetrain);
                hProccalltrain.Execute();

                hv_DictionaryResult = hProccalltrain.GetOutputCtrlParamTuple("do");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (hProctrain != null)
                {
                    hProctrain.Dispose();
                }
                if (hProccalltrain != null)
                {
                    hProccalltrain.Dispose();
                }
            }
        }


        private void btntrain_Click(object sender, EventArgs e)
        {
            ExecuteTrainingProcedure();
        }
        private void action()
        {
            HDevProcedure hProc = new HDevProcedure();
            HDevProcedureCall hProcCall;

            //start

            hv_directory = txtadress.Text;
            try
            {
                dir = Directory.GetCurrentDirectory() + "\\Pad.hdev";
                hProc.LoadProcedure(dir, "run");
                hProcCall = new HDevProcedureCall(hProc); ;
            }
            catch (Exception)
            {
                MessageBox.Show("'Unable to load the procedur'");
                throw;
            }

            try
            {
                dirr = Directory.GetCurrentDirectory() + "\\Image";
                HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default",
                    -1, "false", dirr, "", 1, -1, out hv_AcqHandle);
            }
            catch (Exception)
            {
                MessageBox.Show("'There is no model'");
                throw;
            }

            HTuple empty = new HTuple();
            HOperatorSet.ReadDict(MyModel, empty, empty, out dict);
            HOperatorSet.SetDictTuple(dict, "sensitivity", Convert.ToDouble(trasensitivity.Value) / 10);

            while (whileStart)
            {
                HOperatorSet.GrabImage(out hImage, hv_AcqHandle);
                hProcCall.SetInputCtrlParamTuple("di", dict);
                hProcCall.SetInputCtrlParamTuple("WindowHandle", hwhalcon.HalconWindow);
                hProcCall.SetInputIconicParamObject("Image", hImage);
                hProcCall.Execute();
                HOperatorSet.WaitSeconds(1);
            }
            HOperatorSet.CloseFramegrabber(hv_AcqHandle);
            hv_AcqHandle.Dispose();
            acthinthread = null;

            //end

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MyModel))
            {
                MessageBox.Show("Please select a model before starting the program.", "Model Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            whileStart = true;
            btnClearForm1.Enabled = false;
            btnstop.Enabled = true;
            btnStart.Enabled = false;
            acthinthread = new Thread(action);
            acthinthread.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            whileStart = false;
            btnClearForm1.Enabled = true;
            btnStart.Enabled = true;
            btnstop.Enabled = false;
        }

        HDevEngine engine = new HDevEngine();
        HDevEngine enginetrain = new HDevEngine();
        private void Form1_Load(object sender, EventArgs e)
        {
            TrackBar.CheckForIllegalCrossThreadCalls = false;
            HOperatorSet.SetSystem("clip_region", "false");
            engine.SetHDevOperators(new HDevOpMultiWindowImpl(hwhalcon.HalconWindow));
            enginetrain.SetHDevOperators(new HDevOpMultiWindowImpl(hwhalconTrain.HalconWindow));
            HOperatorSet.CreateDict(out dict);
            HOperatorSet.SetDictTuple(dict, "min_th", traminthertrain.Value);
            HOperatorSet.SetDictTuple(dict, "max_th", tramaxthertrain.Value);
            HOperatorSet.SetDictTuple(dict, "sensitivity", Convert.ToDouble(trasensitivity.Value) / 10);
            txtadress.Text = Directory.GetCurrentDirectory() + "\\Image";
        }

        private void trasensitivity_Scroll(object sender, EventArgs e)
        {
            HOperatorSet.SetDictTuple(dict, "sensitivity", Convert.ToDouble(trasensitivity.Value) / 10);

            lblsensitivity.Text = "Sensitivity: " + Convert.ToDouble(trasensitivity.Value) / 10;
        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {

                    txtadress.Text = folderDialog.SelectedPath;

                }

            }
        }
    }
}
