namespace WeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblFeelsLike;
        // Card Labels
        private System.Windows.Forms.Label lblUVValue;
        private System.Windows.Forms.Label lblHumidityValue;
        private System.Windows.Forms.Label lblPressureValue;
        private System.Windows.Forms.Label lblCloudValue;
        private System.Windows.Forms.Label lblWindValue;
        private System.Windows.Forms.Label lblPrecipValue;
        private System.Windows.Forms.Label lblAQValue;
        private System.Windows.Forms.Label lblPM25Value;
        private System.Windows.Forms.Label lblPM10Value;
        private System.Windows.Forms.Label lblCOValue;
        private System.Windows.Forms.Label lblO3Value;
        private System.Windows.Forms.Label lblStatus;

        // Forecast day panels
        private System.Windows.Forms.Panel panelDay1;
        private System.Windows.Forms.Panel panelDay2;
        private System.Windows.Forms.Panel panelDay3;

        // Forecast labels
        private System.Windows.Forms.Label lblDay1Date;
        private System.Windows.Forms.Label lblDay1Temp;
        private System.Windows.Forms.Label lblDay1Condition;

        private System.Windows.Forms.Label lblDay2Date;
        private System.Windows.Forms.Label lblDay2Temp;
        private System.Windows.Forms.Label lblDay2Condition;

        private System.Windows.Forms.Label lblDay3Date;
        private System.Windows.Forms.Label lblDay3Temp;
        private System.Windows.Forms.Label lblDay3Condition;

        // Panels for cards
        private System.Windows.Forms.Panel panelForecast;
        private System.Windows.Forms.Panel panelUV;
        private System.Windows.Forms.Panel panelHumidity;
        private System.Windows.Forms.Panel panelPressure;
        private System.Windows.Forms.Panel panelCloud;
        private System.Windows.Forms.Panel panelWind;
        private System.Windows.Forms.Panel panelPrecip;
        private System.Windows.Forms.Panel panelAirQuality;
        private System.Windows.Forms.Panel panelAirDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCity = new TextBox();
            btnSearch = new Button();
            lblTitle = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblTemp = new Label();
            lblCondition = new Label();
            lblFeelsLike = new Label();
            lblUVValue = new Label();
            lblHumidityValue = new Label();
            lblPressureValue = new Label();
            lblCloudValue = new Label();
            lblWindValue = new Label();
            lblPrecipValue = new Label();
            lblAQValue = new Label();
            lblPM25Value = new Label();
            lblPM10Value = new Label();
            lblCOValue = new Label();
            lblO3Value = new Label();
            lblStatus = new Label();
            panelDay1 = new Panel();
            lblDay1Date = new Label();
            lblDay1Temp = new Label();
            lblDay1Condition = new Label();
            panelDay2 = new Panel();
            lblDay2Date = new Label();
            lblDay2Temp = new Label();
            lblDay2Condition = new Label();
            panelDay3 = new Panel();
            lblDay3Date = new Label();
            lblDay3Temp = new Label();
            lblDay3Condition = new Label();
            panelForecast = new Panel();
            lblLastUpdate = new Label();
            panelUV = new Panel();
            picUV = new PictureBox();
            lblTitleUV = new Label();
            panelHumidity = new Panel();
            picHumidity = new PictureBox();
            lblTitleHumidity = new Label();
            panelPressure = new Panel();
            picPressure = new PictureBox();
            lblTitlePressure = new Label();
            panelCloud = new Panel();
            picCloud = new PictureBox();
            lblTitleCloud = new Label();
            panelWind = new Panel();
            picWind = new PictureBox();
            lblTitleWind = new Label();
            panelPrecip = new Panel();
            picPrecip = new PictureBox();
            lblTitlePrecip = new Label();
            panelAirQuality = new Panel();
            panelAirDetails = new Panel();
            panelDay1.SuspendLayout();
            panelDay2.SuspendLayout();
            panelDay3.SuspendLayout();
            panelForecast.SuspendLayout();
            panelUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUV).BeginInit();
            panelHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHumidity).BeginInit();
            panelPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPressure).BeginInit();
            panelCloud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCloud).BeginInit();
            panelWind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWind).BeginInit();
            panelPrecip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrecip).BeginInit();
            panelAirQuality.SuspendLayout();
            panelAirDetails.SuspendLayout();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F);
            txtCity.Location = new Point(29, 60);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(491, 34);
            txtCity.TabIndex = 1;
            txtCity.KeyPress += txtCity_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(526, 55);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(29, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WEATHER";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(197, 47);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 46);
            lblCity.TabIndex = 1;
            lblCity.Text = "-";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 11F);
            lblCountry.ForeColor = Color.FromArgb(220, 230, 240);
            lblCountry.Location = new Point(197, 93);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(20, 25);
            lblCountry.TabIndex = 2;
            lblCountry.Text = "-";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblTemp.ForeColor = Color.White;
            lblTemp.Location = new Point(183, 127);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(77, 106);
            lblTemp.TabIndex = 3;
            lblTemp.Text = "-";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCondition.ForeColor = Color.FromArgb(220, 230, 240);
            lblCondition.Location = new Point(447, 188);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(19, 25);
            lblCondition.TabIndex = 4;
            lblCondition.Text = "-";
            // 
            // lblFeelsLike
            // 
            lblFeelsLike.AutoSize = true;
            lblFeelsLike.Font = new Font("Segoe UI", 10F);
            lblFeelsLike.ForeColor = Color.FromArgb(200, 220, 230);
            lblFeelsLike.Location = new Point(197, 245);
            lblFeelsLike.Name = "lblFeelsLike";
            lblFeelsLike.Size = new Size(93, 23);
            lblFeelsLike.TabIndex = 5;
            lblFeelsLike.Text = "Feels like: -";
            // 
            // lblUVValue
            // 
            lblUVValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblUVValue.ForeColor = Color.White;
            lblUVValue.Location = new Point(0, 55);
            lblUVValue.Name = "lblUVValue";
            lblUVValue.Size = new Size(169, 67);
            lblUVValue.TabIndex = 1;
            lblUVValue.Text = "-";
            lblUVValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHumidityValue
            // 
            lblHumidityValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblHumidityValue.ForeColor = Color.White;
            lblHumidityValue.Location = new Point(0, 55);
            lblHumidityValue.Name = "lblHumidityValue";
            lblHumidityValue.Size = new Size(180, 67);
            lblHumidityValue.TabIndex = 1;
            lblHumidityValue.Text = "-";
            lblHumidityValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPressureValue
            // 
            lblPressureValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPressureValue.ForeColor = Color.White;
            lblPressureValue.Location = new Point(0, 67);
            lblPressureValue.Name = "lblPressureValue";
            lblPressureValue.Size = new Size(169, 67);
            lblPressureValue.TabIndex = 1;
            lblPressureValue.Text = "-";
            lblPressureValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCloudValue
            // 
            lblCloudValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCloudValue.ForeColor = Color.White;
            lblCloudValue.Location = new Point(0, 67);
            lblCloudValue.Name = "lblCloudValue";
            lblCloudValue.Size = new Size(180, 67);
            lblCloudValue.TabIndex = 1;
            lblCloudValue.Text = "-";
            lblCloudValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWindValue
            // 
            lblWindValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWindValue.ForeColor = Color.White;
            lblWindValue.Location = new Point(0, 55);
            lblWindValue.Name = "lblWindValue";
            lblWindValue.Size = new Size(169, 121);
            lblWindValue.TabIndex = 1;
            lblWindValue.Text = "-";
            // 
            // lblPrecipValue
            // 
            lblPrecipValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPrecipValue.ForeColor = Color.White;
            lblPrecipValue.Location = new Point(0, 55);
            lblPrecipValue.Name = "lblPrecipValue";
            lblPrecipValue.Size = new Size(180, 67);
            lblPrecipValue.TabIndex = 1;
            lblPrecipValue.Text = "-";
            lblPrecipValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAQValue
            // 
            lblAQValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAQValue.ForeColor = Color.White;
            lblAQValue.Location = new Point(23, 24);
            lblAQValue.Name = "lblAQValue";
            lblAQValue.Size = new Size(617, 95);
            lblAQValue.TabIndex = 1;
            lblAQValue.Text = "-";
            lblAQValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPM25Value
            // 
            lblPM25Value.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblPM25Value.ForeColor = Color.FromArgb(200, 220, 240);
            lblPM25Value.Location = new Point(23, 16);
            lblPM25Value.Name = "lblPM25Value";
            lblPM25Value.Size = new Size(617, 33);
            lblPM25Value.TabIndex = 0;
            lblPM25Value.Text = "PM 2.5: -";
            lblPM25Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPM10Value
            // 
            lblPM10Value.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblPM10Value.ForeColor = Color.FromArgb(200, 220, 240);
            lblPM10Value.Location = new Point(23, 49);
            lblPM10Value.Name = "lblPM10Value";
            lblPM10Value.Size = new Size(617, 33);
            lblPM10Value.TabIndex = 1;
            lblPM10Value.Text = "PM10: -";
            lblPM10Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCOValue
            // 
            lblCOValue.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblCOValue.ForeColor = Color.FromArgb(200, 220, 240);
            lblCOValue.Location = new Point(23, 82);
            lblCOValue.Name = "lblCOValue";
            lblCOValue.Size = new Size(617, 33);
            lblCOValue.TabIndex = 2;
            lblCOValue.Text = "CO: -";
            lblCOValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblO3Value
            // 
            lblO3Value.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblO3Value.ForeColor = Color.FromArgb(200, 220, 240);
            lblO3Value.Location = new Point(23, 115);
            lblO3Value.Name = "lblO3Value";
            lblO3Value.Size = new Size(617, 33);
            lblO3Value.TabIndex = 3;
            lblO3Value.Text = "O3: -";
            lblO3Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(20, 1750);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(226, 20);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Enter city name and press Search";
            // 
            // panelDay1
            // 
            panelDay1.BackColor = Color.Transparent;
            panelDay1.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelDay1.BackgroundImageLayout = ImageLayout.Stretch;
            panelDay1.Controls.Add(lblDay1Date);
            panelDay1.Controls.Add(lblDay1Temp);
            panelDay1.Controls.Add(lblDay1Condition);
            panelDay1.ForeColor = Color.FromArgb(220, 220, 220);
            panelDay1.Location = new Point(20, 442);
            panelDay1.Margin = new Padding(3, 4, 3, 4);
            panelDay1.Name = "panelDay1";
            panelDay1.Size = new Size(217, 213);
            panelDay1.TabIndex = 5;
            // 
            // lblDay1Date
            // 
            lblDay1Date.BackColor = Color.Transparent;
            lblDay1Date.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDay1Date.ForeColor = Color.White;
            lblDay1Date.Location = new Point(6, 13);
            lblDay1Date.Name = "lblDay1Date";
            lblDay1Date.Size = new Size(208, 27);
            lblDay1Date.TabIndex = 0;
            lblDay1Date.Text = "N/A";
            lblDay1Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay1Temp
            // 
            lblDay1Temp.BackColor = Color.Transparent;
            lblDay1Temp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDay1Temp.ForeColor = Color.White;
            lblDay1Temp.Location = new Point(6, 133);
            lblDay1Temp.Name = "lblDay1Temp";
            lblDay1Temp.Size = new Size(208, 33);
            lblDay1Temp.TabIndex = 1;
            lblDay1Temp.Text = "N/A";
            lblDay1Temp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay1Condition
            // 
            lblDay1Condition.BackColor = Color.Transparent;
            lblDay1Condition.Font = new Font("Segoe UI", 8F);
            lblDay1Condition.ForeColor = Color.FromArgb(220, 230, 240);
            lblDay1Condition.Location = new Point(6, 173);
            lblDay1Condition.Name = "lblDay1Condition";
            lblDay1Condition.Size = new Size(208, 33);
            lblDay1Condition.TabIndex = 2;
            lblDay1Condition.Text = " N/A";
            lblDay1Condition.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDay2
            // 
            panelDay2.BackColor = Color.Transparent;
            panelDay2.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelDay2.BackgroundImageLayout = ImageLayout.Stretch;
            panelDay2.Controls.Add(lblDay2Date);
            panelDay2.Controls.Add(lblDay2Temp);
            panelDay2.Controls.Add(lblDay2Condition);
            panelDay2.ForeColor = Color.FromArgb(220, 220, 220);
            panelDay2.Location = new Point(243, 442);
            panelDay2.Margin = new Padding(3, 4, 3, 4);
            panelDay2.Name = "panelDay2";
            panelDay2.Size = new Size(217, 213);
            panelDay2.TabIndex = 6;
            // 
            // lblDay2Date
            // 
            lblDay2Date.BackColor = Color.Transparent;
            lblDay2Date.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDay2Date.ForeColor = Color.White;
            lblDay2Date.Location = new Point(6, 13);
            lblDay2Date.Name = "lblDay2Date";
            lblDay2Date.Size = new Size(208, 27);
            lblDay2Date.TabIndex = 0;
            lblDay2Date.Text = "N/A";
            lblDay2Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay2Temp
            // 
            lblDay2Temp.BackColor = Color.Transparent;
            lblDay2Temp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDay2Temp.ForeColor = Color.White;
            lblDay2Temp.Location = new Point(6, 133);
            lblDay2Temp.Name = "lblDay2Temp";
            lblDay2Temp.Size = new Size(208, 33);
            lblDay2Temp.TabIndex = 1;
            lblDay2Temp.Text = "N/A";
            lblDay2Temp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay2Condition
            // 
            lblDay2Condition.BackColor = Color.Transparent;
            lblDay2Condition.Font = new Font("Segoe UI", 8F);
            lblDay2Condition.ForeColor = Color.FromArgb(220, 230, 240);
            lblDay2Condition.Location = new Point(6, 173);
            lblDay2Condition.Name = "lblDay2Condition";
            lblDay2Condition.Size = new Size(208, 33);
            lblDay2Condition.TabIndex = 2;
            lblDay2Condition.Text = "N/A";
            lblDay2Condition.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDay3
            // 
            panelDay3.BackColor = Color.Transparent;
            panelDay3.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelDay3.BackgroundImageLayout = ImageLayout.Stretch;
            panelDay3.Controls.Add(lblDay3Date);
            panelDay3.Controls.Add(lblDay3Temp);
            panelDay3.Controls.Add(lblDay3Condition);
            panelDay3.ForeColor = Color.FromArgb(220, 220, 220);
            panelDay3.Location = new Point(466, 442);
            panelDay3.Margin = new Padding(3, 4, 3, 4);
            panelDay3.Name = "panelDay3";
            panelDay3.Size = new Size(217, 213);
            panelDay3.TabIndex = 7;
            // 
            // lblDay3Date
            // 
            lblDay3Date.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDay3Date.ForeColor = Color.White;
            lblDay3Date.Location = new Point(6, 13);
            lblDay3Date.Name = "lblDay3Date";
            lblDay3Date.Size = new Size(208, 27);
            lblDay3Date.TabIndex = 0;
            lblDay3Date.Text = "N/A";
            lblDay3Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay3Temp
            // 
            lblDay3Temp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDay3Temp.ForeColor = Color.White;
            lblDay3Temp.Location = new Point(6, 133);
            lblDay3Temp.Name = "lblDay3Temp";
            lblDay3Temp.Size = new Size(208, 33);
            lblDay3Temp.TabIndex = 1;
            lblDay3Temp.Text = "N/A";
            lblDay3Temp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay3Condition
            // 
            lblDay3Condition.Font = new Font("Segoe UI", 8F);
            lblDay3Condition.ForeColor = Color.FromArgb(220, 230, 240);
            lblDay3Condition.Location = new Point(6, 173);
            lblDay3Condition.Name = "lblDay3Condition";
            lblDay3Condition.Size = new Size(208, 33);
            lblDay3Condition.TabIndex = 2;
            lblDay3Condition.Text = "N/A";
            lblDay3Condition.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelForecast
            // 
            panelForecast.BackColor = Color.Transparent;
            panelForecast.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelForecast.BackgroundImageLayout = ImageLayout.Stretch;
            panelForecast.Controls.Add(lblLastUpdate);
            panelForecast.Controls.Add(lblCity);
            panelForecast.Controls.Add(lblCountry);
            panelForecast.Controls.Add(lblTemp);
            panelForecast.Controls.Add(lblCondition);
            panelForecast.Controls.Add(lblFeelsLike);
            panelForecast.ForeColor = Color.White;
            panelForecast.Location = new Point(20, 123);
            panelForecast.Margin = new Padding(3, 4, 3, 4);
            panelForecast.Name = "panelForecast";
            panelForecast.Size = new Size(663, 293);
            panelForecast.TabIndex = 4;
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.AutoSize = true;
            lblLastUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastUpdate.ForeColor = Color.FromArgb(220, 230, 240);
            lblLastUpdate.Location = new Point(447, 229);
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(17, 23);
            lblLastUpdate.TabIndex = 6;
            lblLastUpdate.Text = "-";
            // 
            // panelUV
            // 
            panelUV.BackColor = Color.Transparent;
            panelUV.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelUV.BackgroundImageLayout = ImageLayout.Stretch;
            panelUV.Controls.Add(picUV);
            panelUV.Controls.Add(lblTitleUV);
            panelUV.Controls.Add(lblUVValue);
            panelUV.ForeColor = Color.FromArgb(220, 220, 220);
            panelUV.Location = new Point(20, 688);
            panelUV.Margin = new Padding(3, 4, 3, 4);
            panelUV.Name = "panelUV";
            panelUV.Size = new Size(320, 213);
            panelUV.TabIndex = 10;
            // 
            // picUV
            // 
            picUV.BackgroundImageLayout = ImageLayout.Zoom;
            picUV.ErrorImage = null;
            picUV.InitialImage = null;
            picUV.Location = new Point(144, 3);
            picUV.Name = "picUV";
            picUV.Size = new Size(173, 207);
            picUV.SizeMode = PictureBoxSizeMode.Zoom;
            picUV.TabIndex = 8;
            picUV.TabStop = false;
            // 
            // lblTitleUV
            // 
            lblTitleUV.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleUV.ForeColor = Color.Transparent;
            lblTitleUV.Location = new Point(0, 0);
            lblTitleUV.Name = "lblTitleUV";
            lblTitleUV.Size = new Size(61, 55);
            lblTitleUV.TabIndex = 2;
            lblTitleUV.Text = "UV";
            lblTitleUV.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelHumidity
            // 
            panelHumidity.BackColor = Color.Transparent;
            panelHumidity.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelHumidity.BackgroundImageLayout = ImageLayout.Stretch;
            panelHumidity.Controls.Add(picHumidity);
            panelHumidity.Controls.Add(lblTitleHumidity);
            panelHumidity.Controls.Add(lblHumidityValue);
            panelHumidity.ForeColor = Color.FromArgb(220, 220, 220);
            panelHumidity.Location = new Point(363, 688);
            panelHumidity.Margin = new Padding(3, 4, 3, 4);
            panelHumidity.Name = "panelHumidity";
            panelHumidity.Size = new Size(320, 213);
            panelHumidity.TabIndex = 11;
            // 
            // picHumidity
            // 
            picHumidity.BackColor = Color.Transparent;
            picHumidity.BackgroundImageLayout = ImageLayout.Zoom;
            picHumidity.ErrorImage = null;
            picHumidity.InitialImage = null;
            picHumidity.Location = new Point(148, 3);
            picHumidity.Name = "picHumidity";
            picHumidity.Size = new Size(172, 207);
            picHumidity.SizeMode = PictureBoxSizeMode.Zoom;
            picHumidity.TabIndex = 9;
            picHumidity.TabStop = false;
            // 
            // lblTitleHumidity
            // 
            lblTitleHumidity.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleHumidity.ForeColor = Color.Transparent;
            lblTitleHumidity.Location = new Point(0, 0);
            lblTitleHumidity.Name = "lblTitleHumidity";
            lblTitleHumidity.Size = new Size(155, 55);
            lblTitleHumidity.TabIndex = 3;
            lblTitleHumidity.Text = "Humidity";
            lblTitleHumidity.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelPressure
            // 
            panelPressure.BackColor = Color.Transparent;
            panelPressure.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelPressure.BackgroundImageLayout = ImageLayout.Stretch;
            panelPressure.Controls.Add(picPressure);
            panelPressure.Controls.Add(lblTitlePressure);
            panelPressure.Controls.Add(lblPressureValue);
            panelPressure.ForeColor = Color.FromArgb(220, 220, 220);
            panelPressure.Location = new Point(20, 928);
            panelPressure.Margin = new Padding(3, 4, 3, 4);
            panelPressure.Name = "panelPressure";
            panelPressure.Size = new Size(320, 213);
            panelPressure.TabIndex = 12;
            // 
            // picPressure
            // 
            picPressure.BackgroundImageLayout = ImageLayout.Stretch;
            picPressure.ErrorImage = null;
            picPressure.InitialImage = null;
            picPressure.Location = new Point(144, 3);
            picPressure.Name = "picPressure";
            picPressure.Size = new Size(173, 207);
            picPressure.SizeMode = PictureBoxSizeMode.Zoom;
            picPressure.TabIndex = 9;
            picPressure.TabStop = false;
            // 
            // lblTitlePressure
            // 
            lblTitlePressure.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlePressure.ForeColor = Color.Transparent;
            lblTitlePressure.Location = new Point(0, 0);
            lblTitlePressure.Name = "lblTitlePressure";
            lblTitlePressure.Size = new Size(155, 55);
            lblTitlePressure.TabIndex = 4;
            lblTitlePressure.Text = "Pressure";
            lblTitlePressure.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelCloud
            // 
            panelCloud.BackColor = Color.Transparent;
            panelCloud.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelCloud.BackgroundImageLayout = ImageLayout.Stretch;
            panelCloud.Controls.Add(picCloud);
            panelCloud.Controls.Add(lblTitleCloud);
            panelCloud.Controls.Add(lblCloudValue);
            panelCloud.ForeColor = Color.FromArgb(220, 220, 220);
            panelCloud.Location = new Point(363, 928);
            panelCloud.Margin = new Padding(3, 4, 3, 4);
            panelCloud.Name = "panelCloud";
            panelCloud.Size = new Size(320, 213);
            panelCloud.TabIndex = 13;
            // 
            // picCloud
            // 
            picCloud.BackgroundImageLayout = ImageLayout.Zoom;
            picCloud.ErrorImage = null;
            picCloud.InitialImage = null;
            picCloud.Location = new Point(148, 3);
            picCloud.Name = "picCloud";
            picCloud.Size = new Size(169, 207);
            picCloud.SizeMode = PictureBoxSizeMode.Zoom;
            picCloud.TabIndex = 9;
            picCloud.TabStop = false;
            // 
            // lblTitleCloud
            // 
            lblTitleCloud.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCloud.ForeColor = Color.Transparent;
            lblTitleCloud.Location = new Point(0, 0);
            lblTitleCloud.Name = "lblTitleCloud";
            lblTitleCloud.Size = new Size(155, 55);
            lblTitleCloud.TabIndex = 4;
            lblTitleCloud.Text = "Cloud";
            lblTitleCloud.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelWind
            // 
            panelWind.BackColor = Color.Transparent;
            panelWind.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelWind.BackgroundImageLayout = ImageLayout.Stretch;
            panelWind.Controls.Add(picWind);
            panelWind.Controls.Add(lblTitleWind);
            panelWind.Controls.Add(lblWindValue);
            panelWind.ForeColor = Color.FromArgb(220, 220, 220);
            panelWind.Location = new Point(20, 1168);
            panelWind.Margin = new Padding(3, 4, 3, 4);
            panelWind.Name = "panelWind";
            panelWind.Size = new Size(320, 213);
            panelWind.TabIndex = 14;
            // 
            // picWind
            // 
            picWind.BackgroundImageLayout = ImageLayout.Zoom;
            picWind.ErrorImage = null;
            picWind.InitialImage = null;
            picWind.Location = new Point(161, 3);
            picWind.Name = "picWind";
            picWind.Size = new Size(156, 207);
            picWind.SizeMode = PictureBoxSizeMode.Zoom;
            picWind.TabIndex = 9;
            picWind.TabStop = false;
            // 
            // lblTitleWind
            // 
            lblTitleWind.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleWind.ForeColor = Color.Transparent;
            lblTitleWind.Location = new Point(0, 0);
            lblTitleWind.Name = "lblTitleWind";
            lblTitleWind.Size = new Size(155, 55);
            lblTitleWind.TabIndex = 4;
            lblTitleWind.Text = "Wind";
            lblTitleWind.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelPrecip
            // 
            panelPrecip.BackColor = Color.Transparent;
            panelPrecip.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelPrecip.BackgroundImageLayout = ImageLayout.Stretch;
            panelPrecip.Controls.Add(picPrecip);
            panelPrecip.Controls.Add(lblTitlePrecip);
            panelPrecip.Controls.Add(lblPrecipValue);
            panelPrecip.ForeColor = Color.FromArgb(220, 220, 220);
            panelPrecip.Location = new Point(363, 1168);
            panelPrecip.Margin = new Padding(3, 4, 3, 4);
            panelPrecip.Name = "panelPrecip";
            panelPrecip.Size = new Size(320, 213);
            panelPrecip.TabIndex = 15;
            // 
            // picPrecip
            // 
            picPrecip.BackgroundImageLayout = ImageLayout.Zoom;
            picPrecip.ErrorImage = null;
            picPrecip.InitialImage = null;
            picPrecip.Location = new Point(148, 55);
            picPrecip.Name = "picPrecip";
            picPrecip.Size = new Size(172, 155);
            picPrecip.SizeMode = PictureBoxSizeMode.Zoom;
            picPrecip.TabIndex = 9;
            picPrecip.TabStop = false;
            // 
            // lblTitlePrecip
            // 
            lblTitlePrecip.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitlePrecip.ForeColor = Color.Transparent;
            lblTitlePrecip.Location = new Point(0, 0);
            lblTitlePrecip.Name = "lblTitlePrecip";
            lblTitlePrecip.Size = new Size(204, 55);
            lblTitlePrecip.TabIndex = 4;
            lblTitlePrecip.Text = "Precipitation ";
            lblTitlePrecip.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelAirQuality
            // 
            panelAirQuality.BackColor = Color.Transparent;
            panelAirQuality.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelAirQuality.BackgroundImageLayout = ImageLayout.Stretch;
            panelAirQuality.Controls.Add(lblAQValue);
            panelAirQuality.ForeColor = Color.FromArgb(220, 220, 220);
            panelAirQuality.Location = new Point(20, 1404);
            panelAirQuality.Margin = new Padding(3, 4, 3, 4);
            panelAirQuality.Name = "panelAirQuality";
            panelAirQuality.Size = new Size(663, 133);
            panelAirQuality.TabIndex = 16;
            // 
            // panelAirDetails
            // 
            panelAirDetails.BackColor = Color.Transparent;
            panelAirDetails.BackgroundImage = ProjectAkhir.Properties.Resources.Untitled_design__3_;
            panelAirDetails.BackgroundImageLayout = ImageLayout.Stretch;
            panelAirDetails.Controls.Add(lblPM25Value);
            panelAirDetails.Controls.Add(lblPM10Value);
            panelAirDetails.Controls.Add(lblCOValue);
            panelAirDetails.Controls.Add(lblO3Value);
            panelAirDetails.ForeColor = Color.FromArgb(220, 220, 220);
            panelAirDetails.Location = new Point(20, 1557);
            panelAirDetails.Margin = new Padding(3, 4, 3, 4);
            panelAirDetails.Name = "panelAirDetails";
            panelAirDetails.Size = new Size(663, 173);
            panelAirDetails.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(52, 108, 160);
            BackgroundImage = ProjectAkhir.Resources.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(718, 1049);
            Controls.Add(lblStatus);
            Controls.Add(panelAirDetails);
            Controls.Add(panelAirQuality);
            Controls.Add(panelPrecip);
            Controls.Add(panelWind);
            Controls.Add(panelCloud);
            Controls.Add(panelPressure);
            Controls.Add(panelHumidity);
            Controls.Add(panelUV);
            Controls.Add(panelDay3);
            Controls.Add(panelDay2);
            Controls.Add(panelDay1);
            Controls.Add(panelForecast);
            Controls.Add(btnSearch);
            Controls.Add(txtCity);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather";
            Load += Form1_Load;
            panelDay1.ResumeLayout(false);
            panelDay2.ResumeLayout(false);
            panelDay3.ResumeLayout(false);
            panelForecast.ResumeLayout(false);
            panelForecast.PerformLayout();
            panelUV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUV).EndInit();
            panelHumidity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHumidity).EndInit();
            panelPressure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPressure).EndInit();
            panelCloud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCloud).EndInit();
            panelWind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWind).EndInit();
            panelPrecip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrecip).EndInit();
            panelAirQuality.ResumeLayout(false);
            panelAirDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label CreateCardLabel(string text, int top, int width)
        {
            var label = new System.Windows.Forms.Label();
            label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.FromArgb(100, 130, 160);
            label.Location = new System.Drawing.Point((280 - width) / 2, top);
            label.Name = "lbl" + text + "Title";
            label.Size = new System.Drawing.Size(width, 25);
            label.TabIndex = 0;
            label.Text = text.ToUpper();
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return label;
        }
        private Label lblTitleUV;
        private Label lblTitleHumidity;
        private Label lblTitlePressure;
        private Label lblTitleCloud;
        private Label lblTitleWind;
        private Label lblTitlePrecip;
        private Label lblLastUpdate;
        private PictureBox picUV;
        private PictureBox picHumidity;
        private PictureBox picPressure;
        private PictureBox picCloud;
        private PictureBox picWind;
        private PictureBox picPrecip;
    }
}