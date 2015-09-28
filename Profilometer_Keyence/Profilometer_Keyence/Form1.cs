using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Profilometer_Keyence.Datas;
using System.Runtime.InteropServices;
using System.Threading;

namespace Profilometer_Keyence
{
    public partial class Form1 : Form
    {

        #region Enum

        /// <summary>
        /// Send command definition
        /// </summary>
        /// <remark>Defined for separate return code distinction</remark>
        public enum SendCommand
        {
            /// <summary>None</summary>
            None,
            /// <summary>Restart</summary>
            RebootController,
            /// <summary>Trigger</summary>
            Trigger,
            /// <summary>Start measurement</summary>
            StartMeasure,
            /// <summary>Stop measurement</summary>
            StopMeasure,
            /// <summary>Auto zero</summary>
            AutoZero,
            /// <summary>Timing</summary>
            Timing,
            /// <summary>Reset</summary>
            Reset,
            /// <summary>Program switch</summary>
            ChangeActiveProgram,
            /// <summary>Get measurement results</summary>
            GetMeasurementValue,
            /// <summary>Get profiles</summary>
            GetProfile,
            /// <summary>Get batch profiles (operation mode "high-speed (profile only)")</summary>
            GetBatchProfile,
            /// <summary>Get profiles (operation mode "advanced (with OUT measurement)")</summary>
            GetProfileAdvance,
            /// <summary>Get batch profiles (operation mode "advanced (with OUT measurement)").</summary>
            GetBatchProfileAdvance,
            /// <summary>Start storage</summary>
            StartStorage,
            /// <summary>Stop storage</summary>
            StopStorage,
            /// <summary>Get storage status</summary>
            GetStorageStatus,
            /// <summary>Manual storage request</summary>
            RequestStorage,
            /// <summary>Get storage data</summary>
            GetStorageData,
            /// <summary>Get profile storage data</summary>
            GetStorageProfile,
            /// <summary>Get batch profile storage data.</summary>
            GetStorageBatchProfile,
            /// <summary>Initialize USB high-speed data communication</summary>
            HighSpeedDataUsbCommunicationInitalize,
            /// <summary>Initialize Ethernet high-speed data communication</summary>
            HighSpeedDataEthernetCommunicationInitalize,
            /// <summary>Request preparation before starting high-speed data communication</summary>
            PreStartHighSpeedDataCommunication,
            /// <summary>Start high-speed data communication</summary>
            StartHighSpeedDataCommunication,
        }

        #endregion

        #region Field

        //Ethernet configuration to assign ip address and port of the sensor to connect
        private LJV7IF_ETHERNET_CONFIG _ethernetConfig;
        //String variable holds the file name chosen using save file dialog
        private string fileName = string.Empty;
        //String variable holds the file name appended with date time with timezone offset
        private string fileNameNew = string.Empty;
        //String variable to hold the file name with path
        private string filePath = string.Empty;
        //Boolean variable holds status whether file name is chosen
        private bool fileStatus = false;
        //Streamwriter variable to write data into file
        private StreamWriter streamWriter = null;
        //Streamwriter variable to write log into log file
        private StreamWriter streamLogWriter = null;
        //Timer variable to execute date time limit feature
        private System.Threading.Timer myTimer = null;
        //Boolean variable holds the status whether size of the file crossed the size limit
        private bool fileSizeStatus = false;
        //FileInfo variable to fetch the length of the file
        private FileInfo fileInfo = null;
        //Stringbuilder variable to hold the header of the file
        private StringBuilder measurementValue1 = null;
        //Stringbuilder variable to hold the data fetched from the sensor
        private StringBuilder measurementValue2 = null;
        //Boolean variable to hold status new file has header or not
        private bool headerWritten = false;
        #endregion

        #region Methods

        /// <summary>
        /// Method executes when text box got focus
        /// </summary>
        /// <param name="Sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void OnFocusIPAddress1(object Sender, EventArgs e)
        {
            if (Sender.Equals(textbox_ipaddress1))
            {
                textbox_ipaddress1.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress2))
            {
                textbox_ipaddress2.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress3))
            {
                textbox_ipaddress3.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress4))
            {
                textbox_ipaddress4.Text = "";
            }
            if (Sender.Equals(textbox_commandport))
            {
                textbox_commandport.Text = "";
            }
            if (Sender.Equals(textbox_frequency))
            {
                textbox_frequency.Text = "";
            }
            if (Sender.Equals(textbox_size))
            {
                textbox_size.Text = "";
            }
        }

        /// <summary>
        /// Method executes when text box lost focus
        /// </summary>
        /// <param name="Sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void OnLostFocusIPAddress1(object Sender, EventArgs e)
        {
            if (Sender.Equals(textbox_ipaddress1))
            {
                if (textbox_ipaddress1.Text.Equals(""))
                {
                    textbox_ipaddress1.Text = "10";
                }
                else if (Convert.ToInt32(textbox_ipaddress1.Text) > 255)
                {
                    textbox_ipaddress1.Text = "10";
                }
            }
            if (Sender.Equals(textbox_ipaddress2))
            {
                if (textbox_ipaddress2.Text.Equals(""))
                {
                    textbox_ipaddress2.Text = "134";
                }
                else if (Convert.ToInt32(textbox_ipaddress2.Text) > 255)
                {
                    textbox_ipaddress2.Text = "134";
                }
            }
            if (Sender.Equals(textbox_ipaddress3))
            {
                if (textbox_ipaddress3.Text.Equals(""))
                {
                    textbox_ipaddress3.Text = "47";
                }
                else if (Convert.ToInt32(textbox_ipaddress3.Text) > 255)
                {
                    textbox_ipaddress3.Text = "47";
                }
            }
            if (Sender.Equals(textbox_ipaddress4))
            {
                if (textbox_ipaddress4.Text.Equals(""))
                {
                    textbox_ipaddress4.Text = "46";
                }
                else if (Convert.ToInt32(textbox_ipaddress4.Text) > 255)
                {
                    textbox_ipaddress4.Text = "46";
                }
            }
            if (Sender.Equals(textbox_commandport))
            {
                if (textbox_commandport.Text.Equals(""))
                {
                    textbox_commandport.Text = "24691";
                }
                else if (Convert.ToInt32(textbox_commandport.Text) > 65535)
                {
                    textbox_commandport.Text = "24691";
                }
            }
            if (Sender.Equals(textbox_frequency))
            {
                if (textbox_frequency.Text.Equals(""))
                {
                    textbox_frequency.Text = "500";
                }
                else if (Convert.ToInt32(textbox_frequency.Text) < 100)
                {
                    textbox_frequency.Text = "500";
                }
            }
            if (Sender.Equals(textbox_size))
            {
                if (textbox_size.Text.Equals(""))
                {
                    textbox_size.Text = "50";
                }
                else if (Convert.ToInt32(textbox_size.Text) < 1)
                {
                    textbox_frequency.Text = "50";
                }
            }
        }

        /// <summary>
        /// A default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            textbox_frequency.Text = "500";
            textbox_commandport.Text = "24691";
            textbox_ipaddress1.Text = "10";
            textbox_ipaddress2.Text = "134";
            textbox_ipaddress3.Text = "47";
            textbox_ipaddress4.Text = "46";
            textbox_size.Text = "50";
            textbox_ipaddress1.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress1.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress2.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress2.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress3.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress3.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress4.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress4.LostFocus += OnLostFocusIPAddress1;
            textbox_commandport.GotFocus += OnFocusIPAddress1;
            textbox_commandport.LostFocus += OnLostFocusIPAddress1;
            textbox_frequency.GotFocus += OnFocusIPAddress1;
            textbox_frequency.LostFocus += OnLostFocusIPAddress1;
            textbox_size.GotFocus += OnFocusIPAddress1;
            textbox_size.LostFocus += OnLostFocusIPAddress1;
        }

        /// <summary>
        /// Method executes when form load event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textbox_filename.Enabled = false;
            button_connect.Enabled = false;
            button_disconnect.Enabled = false;
            checkbox_datetimelimit.Enabled = false;
            checkbox_sizelimit.Enabled = false;
            textbox_size.Enabled = false;
            radiobutton_individual.Checked = true;
        }
        /// <summary>
        /// Method to parse time zone into Tz*** format
        /// </summary>
        /// <param name="timeZone">Current Time Zone</param>
        /// <returns>Parsed Time Zone</returns>
        private string convertTimeZone(string timeZone)
        {
            string timeZoneParsed = string.Empty;
            if (!timeZone.Trim().Equals(string.Empty))
            {
                string[] timeZones = timeZone.Split(':');
                timeZoneParsed += Convert.ToInt64(timeZones[0]);
                if (Convert.ToInt64(timeZones[1]) > 0)
                {
                    timeZoneParsed += Convert.ToInt64(timeZones[1]);
                }
            }
            return DateTime.UtcNow.ToString("yyyyMMddHHmmssfff") + "Tz" +timeZoneParsed.Trim();
        }

        /// <summary>
        /// Enables connect button after file name has beem chosen
        /// </summary>
        private void EnableButton()
        {
            if (fileStatus)
            {
                button_connect.Enabled = true;
            }
            else
            {
                button_connect.Enabled = false;
            }
        }

        /// <summary>
        /// Enables connect and disables disconnect button
        /// </summary>
        private void EnableConnect()
        {
            button_connect.Enabled = true;
            button_disconnect.Enabled = false;
        }

        /// <summary>
        /// Enables disconnect and disables connect button
        /// </summary>
        private void EnableDisconnect()
        {
            button_connect.Enabled =false;
            button_disconnect.Enabled = true;
        }

        /// <summary>
        /// Delegate to write status into text box
        /// </summary>
        /// <param name="status">Status</param>
        private delegate void WriteTextBoxStatusDelegate(string status);

        /// <summary>
        /// Method executes to write status into text box
        /// </summary>
        /// <param name="status">Status</param>
        private void WriteTextBoxStatus(string status)
        {
            textBox_status.AppendText(status);
        }

        /// <summary>
        /// Method executes when browse button clicked event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void button_browse_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;
            fileName = string.Empty;
            fileNameNew = string.Empty;
            textbox_filename.Text = string.Empty;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Enter File Name...";
            saveFileDialog1.Filter = "Comma Separated Values (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = saveFileDialog1.FileName;
                fileName = Path.GetFileNameWithoutExtension(filePath);
                fileNameNew = fileName + "_" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                //CreateFile(filePath);
                textBox_status.AppendText("Data will be written to " + filePath + "\n");
                textbox_filename.Text = filePath.ToString();
                fileStatus = true;
                EnableButton();
            }
            else
            {
                fileStatus = false;
                EnableButton();
                return;
            }
        }
        
        /// <summary>
        /// Method executes when connect button clicked event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void button_connect_Click(object sender, EventArgs e)
        {
                Rc rc2;
                try
                {
                    if (checkbox_datetimelimit.Checked)
                    {
                        //initializes date time limit timer 
                        SetTimerValue();
                        WriteLog("Date Time Monitor Started..." + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                        WriteText("Date Time Monitor Started...\n");
                    }
                    if (radiobutton_combined.Checked)
                    {
                        filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                        headerWritten = false;
                        WriteLog("Date will be written to " + filePath + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                        if (checkbox_sizelimit.Checked)
                        {
                            timerSizeLimit.Interval = 1000;
                            if (timerSizeLimit.Enabled)
                                timerSizeLimit.Stop();
                            timerSizeLimit.Start();
                            WriteLog("Size Limit Monitor Started..." + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                            WriteText("Size Limit Monitor Started...\n");
                        }
                    }
                    //initilizes dll 
                    rc2 = (Rc)NativeMethods.LJV7IF_Initialize();
                    if (rc2 != Rc.Ok)
                    {
                        textBox_status.AppendText("Initialization Failed...\n");
                        EnableConnect();
                        return;
                    }
                    _ethernetConfig.abyIpAddress = new byte[] {
						Convert.ToByte(textbox_ipaddress1.Text),
						Convert.ToByte(textbox_ipaddress2.Text),
						Convert.ToByte(textbox_ipaddress3.Text),
						Convert.ToByte(textbox_ipaddress4.Text)
					};
                    _ethernetConfig.wPortNo = Convert.ToUInt16(textbox_commandport.Text);
                    //establishes ethernet communication to the sensor 
                    rc2 = (Rc)NativeMethods.LJV7IF_EthernetOpen(Define.DEVICE_ID, ref _ethernetConfig);
                    if (rc2 != Rc.Ok)
                    {
                        textBox_status.AppendText("Ethernet Initialization Failed...\n");
                        EnableConnect();
                        return;
                    }
                    EnableDisconnect();
                    timer.Interval = Convert.ToInt32(textbox_frequency.Text);
                    timer.Start();
                }
                catch (FormatException ex)
                {
                    if (timer.Enabled)
                        timer.Stop();
                    if (timerSizeLimit.Enabled)
                        timerSizeLimit.Stop();
                    timerSizeLimit.Stop();
                    WriteLog(ex.ToString() + Environment.NewLine + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                    textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                    EnableConnect();
                    return;
                }
                catch (OverflowException ex)
                {
                    WriteLog(ex.ToString() + Environment.NewLine + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                    textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                    EnableConnect();
                    return;
                }
       }
       
       /// <summary>
       /// Method executes when disconnect button clicked event occurs
       /// </summary>
       /// <param name="sender">An Event Object</param>
       /// <param name="e">Event Args</param>
        private void button_disconnect_Click(object sender, EventArgs e)
        {
                if(timer.Enabled)
                    timer.Stop();
                if (timerSizeLimit.Enabled)
                    timerSizeLimit.Stop();
                Rc rc = (Rc)NativeMethods.LJV7IF_CommClose(Define.DEVICE_ID);
                if (rc != Rc.Ok)
                {
                    textBox_status.Text = "Cannot Stop High Speed Data Communication...";
                    EnableDisconnect();
                    return;
                }
                rc = (Rc)NativeMethods.LJV7IF_Finalize();
                if (rc != Rc.Ok)
                {
                    textBox_status.Text = "Cannot Finalize High Speed Data Communication...";
                    EnableDisconnect();
                    return;
                }
                EnableConnect();
        }

        /// <summary>
        /// Method creates empth data file to write data
        /// </summary>
        /// <param name="filePath">File Name with Path</param>
        private void CreateFile(string filePath)
        {
            getWriter(filePath);
        }

        /// <summary>
        /// Method instantiate the streamwriter object to write data into data file
        /// </summary>
        /// <param name="filePath">File Name with Path</param>
        /// <returns>StreamWriter Object</returns>
        private StreamWriter getWriter(string filePath)
        {
            //Checks whether object is null
            if (streamWriter == null)
            {
                streamWriter = new StreamWriter(filePath, true);
            }
            //Checks whether writer is closed
            if (streamWriter.BaseStream == null)
            {
                streamWriter = null;
                streamWriter = new StreamWriter(filePath, true);
            }
            return streamWriter;
        }
        /// <summary>
        /// Method to write data into data file
        /// </summary>
        /// <param name="data">Barcode Data</param>
        /// <param name="date">Date Time with TimeZone</param>
        private void WriteData(string data)
        {
            getWriter(filePath).WriteLine(string.Format("{0}", data));
            getWriter(filePath).Flush();
            CloseData();
        }

        /// <summary>
        /// Method to write data into data file
        /// </summary>
        /// <param name="measureData">Measure Data</param>
        /// <param name="profileData">Profile Data List</param>
        /// <param name="date">Date Time with Timezone Offset</param>
        private void WriteData(MeasureData measureData, List<ProfileData> profileData, string date)
        {
            measurementValue1 = new StringBuilder();
            measurementValue2 = new StringBuilder();
            measurementValue1.Append("Measurement Count,");
            measurementValue2.Append(NativeMethods.MeasurementDataCount.ToString() + ",");
            for (int i = 0; i < NativeMethods.MeasurementDataCount; i++)
            {
                string temp = string.Format("OUT {0:d2}:{1,0:f4}", (i + 1), measureData.Data[i].fValue);
                string[] temparray = temp.Split(':');
                measurementValue1.Append(temparray[0] + ",");
                measurementValue2.Append(temparray[1] + ",");
            }
            measurementValue1.Append(string.Format("{0},{1},", "Profile Count", "Profile Info"));
            measurementValue2.Append(string.Format("{0},{1},", profileData.Count, profileData[0].ProfInfo));
            foreach (ProfileData profile in profileData)
            {
                //gets start of the profile
                int x = profile.ProfInfo.lXStart;
                for (int i = 0; i < profile.ProfDatas.Length; i++)
                {
                    measurementValue1.AppendFormat("{0},", x);
                    measurementValue2.AppendFormat("{0},", profile.ProfDatas[i]);
                    //every time while looping decrements x by pitch
                    x = x + profile.ProfInfo.lXPitch;
                }
            }
            measurementValue1.Append(string.Format("{0}", "Timestamp"));
            measurementValue2.Append(string.Format("{0}", convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString())));
            if (radiobutton_individual.Checked)
            {
                fileNameNew = fileName.Trim() + "_" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
                filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                WriteData(measurementValue1.ToString());
                WriteLog("Date will be written to " + filePath + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                WriteText("New File Name is " + filePath + "...\n");
            }
            if (radiobutton_combined.Checked)
            {
                if (!headerWritten)
                {
                    WriteData(measurementValue1.ToString());
                    headerWritten = true;
                    WriteText("New File Name is " + filePath + "...\n");
                }
                if (checkbox_sizelimit.Checked)
                {
                    if (fileSizeStatus)
                    {
                        fileNameNew = fileName.Trim() + "_" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
                        filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
                        headerWritten = false;
                        if (!headerWritten)
                        {
                            WriteData(measurementValue1.ToString());
                            headerWritten = true;
                            WriteText("New File Name is " + filePath + "...\n");
                        }

                        WriteLog("Date will be written to " + filePath + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                        fileSizeStatus = false;
                    }
                }
            }
            //writes data into data file
            WriteData(measurementValue2.ToString());
        }
        /// <summary>
        /// Method to close file writer
        /// </summary>
        private void CloseData()
        {
            getWriter(filePath).Close();
        }

        /// <summary>
        /// Method writes status into text box
        /// </summary>
        /// <param name="status">Status</param>
        private void WriteText(string status)
        {
            textBox_status.Invoke(new WriteTextBoxStatusDelegate(WriteTextBoxStatus),status);
        }
        /// <summary>
        /// Method to create a StreamWriter object to write log data
        /// </summary>
        /// <param name="filePath">Location of the file</param>
        /// <returns></returns>
        private StreamWriter getLogWriter(string filePath)
        {
            //Checks whether object is null
            if (streamLogWriter == null)
            {
                streamLogWriter = new StreamWriter(filePath, true);
            }
            //Checks whether writer is closed
            if (streamLogWriter.BaseStream == null)
            {
                streamLogWriter = null;
                streamLogWriter = new StreamWriter(filePath, true);
            }
            return streamLogWriter;
        }
        /// <summary>
        /// Method to write logs into log file
        /// </summary>
        /// <param name="status">Log Details</param>
        private void WriteLog(string status)
        {
            getLogWriter("log.log").WriteLine(status);
            getLogWriter("log.log").Flush();
        }

        /// <summary>
        /// Method close the logs writer 
        /// </summary>
        private void CloseLog()
        {
            getLogWriter("log.log").Close();
        }
    
        /// <summary>
        /// Method executes when radio button checked changed event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void radiobutton_combined_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_combined.Checked)
            {
                checkbox_datetimelimit.Enabled = true;
                checkbox_sizelimit.Enabled = true;
                checkbox_datetimelimit.Checked = false;
                checkbox_sizelimit.Checked = false;
                textbox_size.Enabled = true;
            }
            else
            {
                checkbox_datetimelimit.Checked = false;
                checkbox_sizelimit.Checked = false;
                checkbox_datetimelimit.Enabled = false;
                checkbox_sizelimit.Enabled = false;
                textbox_size.Enabled = false;
            }
        }

        /// <summary>
        /// Method executes timer tick event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                LJV7IF_PROFILE_INFO profileInfo = new LJV7IF_PROFILE_INFO();
                LJV7IF_MEASURE_DATA[] measureData = new LJV7IF_MEASURE_DATA[NativeMethods.MeasurementDataCount];
                int profileDataSize = Define.MAX_PROFILE_COUNT +
                    (Marshal.SizeOf(typeof(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(typeof(LJV7IF_PROFILE_FOOTER))) / Marshal.SizeOf(typeof(int));
                int[] receiveBuffer = new int[profileDataSize];	 // 3,207 (total of the header, the footer, and the 3,200 data entries)
                using (PinnedObject pin = new PinnedObject(receiveBuffer))
                {
                    Rc rc = (Rc)NativeMethods.LJV7IF_GetProfileAdvance(Define.DEVICE_ID, ref profileInfo, pin.Pointer,
                    (uint)(receiveBuffer.Length * Marshal.SizeOf(typeof(int))), measureData);
                    if (rc != Rc.Ok)
                        throw new Exception("Cannot Read Profile Advance Data");
                }
                List<ProfileData> profileData = new List<ProfileData>();
                profileData.Add(new ProfileData(receiveBuffer, 0, profileInfo));
                string date = convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString());
                WriteData(new MeasureData(measureData), profileData, date);
            }
            catch (Exception ex)
            {
                if (timer.Enabled)
                    timer.Stop();
                WriteLog(ex.ToString() + Environment.NewLine + "   at " + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + "\n");
                WriteText("Exception Occured. Please refer log file." + "\n");
                EnableConnect();
                return;
            }
        }

        /// <summary>
        /// Method to execute Day Time Limit feature needed
        /// </summary>
        private void SetTimerValue()
        {
            DateTime requiredTime = DateTime.Today.AddHours(00).AddMinutes(00);
            if (DateTime.Now > requiredTime)
            {
                requiredTime = requiredTime.AddDays(1);
            }
            myTimer = new System.Threading.Timer(new TimerCallback(TimerAction));
            myTimer.Change((int)(requiredTime - DateTime.Now).TotalMilliseconds, Timeout.Infinite);
        }
        /// <summary>
        /// Method executes when timer expires to create new file name and reinitializes date time limit timer
        /// </summary>
        /// <param name="e">A Event Object</param>
        private void TimerAction(object e)
        {
            fileNameNew = fileName + "_" + convertTimeZone(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).ToString()) + ".csv";
            filePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameNew);
            headerWritten = false;
            WriteText("New File Name is " + filePath + "...\n");
            SetTimerValue();
        }

        /// <summary>
        /// method executes when size limit timer tick event occurs
        /// </summary>
        /// <param name="sender">An Event Object</param>
        /// <param name="e">Event Args</param>
        private void timerSizeLimit_Tick(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                fileInfo = new FileInfo(filePath);
                long bytes = fileInfo.Length;
                long kbytes = bytes / 1024;
                long mbytes = kbytes / 1024;
                if (mbytes >= Convert.ToInt32(textbox_size.Text))
                {
                    fileSizeStatus = true;
                }
            }
        }
        #endregion
    }
}
