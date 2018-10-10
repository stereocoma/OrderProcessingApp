namespace OrderProcessingApp
{
    public partial class OrderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderFormGroup = new System.Windows.Forms.GroupBox();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleTypePicker = new System.Windows.Forms.ComboBox();
            this.StartTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DistanceInput = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.WeightOfCargoInput = new System.Windows.Forms.TextBox();
            this.WeightOfCargoLabel = new System.Windows.Forms.Label();
            this.NumberOfChildrenInput = new System.Windows.Forms.TextBox();
            this.NumberOfChilrenLabel = new System.Windows.Forms.Label();
            this.NumberOfAdultsInput = new System.Windows.Forms.TextBox();
            this.NumberOfAdultsLabel = new System.Windows.Forms.Label();
            this.OrderConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.FuelLiterCostInput = new System.Windows.Forms.TextBox();
            this.FuelLiterCostLabel = new System.Windows.Forms.Label();
            this.DriverJobCostPerHourInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FuelConsumptionInput = new System.Windows.Forms.TextBox();
            this.FuelConsumptionLevel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ValidationErrorsLabel = new System.Windows.Forms.Label();
            this.OrderFormGroup.SuspendLayout();
            this.OrderConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormGroup
            // 
            this.OrderFormGroup.Controls.Add(this.VehicleTypeLabel);
            this.OrderFormGroup.Controls.Add(this.VehicleTypePicker);
            this.OrderFormGroup.Controls.Add(this.StartTimeDatePicker);
            this.OrderFormGroup.Controls.Add(this.StartDateLabel);
            this.OrderFormGroup.Controls.Add(this.DistanceInput);
            this.OrderFormGroup.Controls.Add(this.DistanceLabel);
            this.OrderFormGroup.Controls.Add(this.WeightOfCargoInput);
            this.OrderFormGroup.Controls.Add(this.WeightOfCargoLabel);
            this.OrderFormGroup.Controls.Add(this.NumberOfChildrenInput);
            this.OrderFormGroup.Controls.Add(this.NumberOfChilrenLabel);
            this.OrderFormGroup.Controls.Add(this.NumberOfAdultsInput);
            this.OrderFormGroup.Controls.Add(this.NumberOfAdultsLabel);
            this.OrderFormGroup.Location = new System.Drawing.Point(245, 12);
            this.OrderFormGroup.Name = "OrderFormGroup";
            this.OrderFormGroup.Size = new System.Drawing.Size(445, 191);
            this.OrderFormGroup.TabIndex = 0;
            this.OrderFormGroup.TabStop = false;
            this.OrderFormGroup.Text = "Заказ";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(13, 128);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(90, 13);
            this.VehicleTypeLabel.TabIndex = 11;
            this.VehicleTypeLabel.Text = "Тип транспорта:";
            // 
            // VehicleTypePicker
            // 
            this.VehicleTypePicker.FormattingEnabled = true;
            this.VehicleTypePicker.Items.AddRange(new object[] {
            "Автобус",
            "Газель",
            "Легковой автомобиль"});
            this.VehicleTypePicker.Location = new System.Drawing.Point(13, 146);
            this.VehicleTypePicker.Name = "VehicleTypePicker";
            this.VehicleTypePicker.Size = new System.Drawing.Size(121, 21);
            this.VehicleTypePicker.TabIndex = 10;
            this.VehicleTypePicker.SelectedIndexChanged += new System.EventHandler(this.VehicleTypePicker_SelectedIndexChanged);
            // 
            // StartTimeDatePicker
            // 
            this.StartTimeDatePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.StartTimeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimeDatePicker.Location = new System.Drawing.Point(155, 100);
            this.StartTimeDatePicker.Name = "StartTimeDatePicker";
            this.StartTimeDatePicker.Size = new System.Drawing.Size(201, 20);
            this.StartTimeDatePicker.TabIndex = 9;
            this.StartTimeDatePicker.ValueChanged += new System.EventHandler(this.StartTimeDatePicker_ValueChanged);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(152, 84);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(104, 13);
            this.StartDateLabel.TabIndex = 8;
            this.StartDateLabel.Text = "Дата отправления:";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(13, 101);
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(115, 20);
            this.DistanceInput.TabIndex = 7;
            this.DistanceInput.TextChanged += new System.EventHandler(this.DistanceInput_TextChanged);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(10, 84);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(102, 13);
            this.DistanceLabel.TabIndex = 6;
            this.DistanceLabel.Text = "Расстояние (в км.)";
            // 
            // WeightOfCargoInput
            // 
            this.WeightOfCargoInput.Location = new System.Drawing.Point(285, 36);
            this.WeightOfCargoInput.Name = "WeightOfCargoInput";
            this.WeightOfCargoInput.Size = new System.Drawing.Size(103, 20);
            this.WeightOfCargoInput.TabIndex = 5;
            this.WeightOfCargoInput.TextChanged += new System.EventHandler(this.WeightOfCargoInput_TextChanged);
            // 
            // WeightOfCargoLabel
            // 
            this.WeightOfCargoLabel.AutoSize = true;
            this.WeightOfCargoLabel.Location = new System.Drawing.Point(282, 20);
            this.WeightOfCargoLabel.Name = "WeightOfCargoLabel";
            this.WeightOfCargoLabel.Size = new System.Drawing.Size(74, 13);
            this.WeightOfCargoLabel.TabIndex = 4;
            this.WeightOfCargoLabel.Text = "Масса груза:";
            // 
            // NumberOfChildrenInput
            // 
            this.NumberOfChildrenInput.Location = new System.Drawing.Point(155, 37);
            this.NumberOfChildrenInput.Name = "NumberOfChildrenInput";
            this.NumberOfChildrenInput.Size = new System.Drawing.Size(108, 20);
            this.NumberOfChildrenInput.TabIndex = 3;
            this.NumberOfChildrenInput.TextChanged += new System.EventHandler(this.NumberOfChildrenInput_TextChanged);
            // 
            // NumberOfChilrenLabel
            // 
            this.NumberOfChilrenLabel.AutoSize = true;
            this.NumberOfChilrenLabel.Location = new System.Drawing.Point(152, 20);
            this.NumberOfChilrenLabel.Name = "NumberOfChilrenLabel";
            this.NumberOfChilrenLabel.Size = new System.Drawing.Size(101, 13);
            this.NumberOfChilrenLabel.TabIndex = 2;
            this.NumberOfChilrenLabel.Text = "Количество детей:";
            // 
            // NumberOfAdultsInput
            // 
            this.NumberOfAdultsInput.Location = new System.Drawing.Point(10, 37);
            this.NumberOfAdultsInput.Name = "NumberOfAdultsInput";
            this.NumberOfAdultsInput.Size = new System.Drawing.Size(118, 20);
            this.NumberOfAdultsInput.TabIndex = 1;
            this.NumberOfAdultsInput.TextChanged += new System.EventHandler(this.NumberOfAdultsInput_TextChanged);
            // 
            // NumberOfAdultsLabel
            // 
            this.NumberOfAdultsLabel.AutoSize = true;
            this.NumberOfAdultsLabel.Location = new System.Drawing.Point(7, 20);
            this.NumberOfAdultsLabel.Name = "NumberOfAdultsLabel";
            this.NumberOfAdultsLabel.Size = new System.Drawing.Size(121, 13);
            this.NumberOfAdultsLabel.TabIndex = 0;
            this.NumberOfAdultsLabel.Text = "Количество взрослых:";
            // 
            // OrderConfigurationGroupBox
            // 
            this.OrderConfigurationGroupBox.Controls.Add(this.FuelLiterCostInput);
            this.OrderConfigurationGroupBox.Controls.Add(this.FuelLiterCostLabel);
            this.OrderConfigurationGroupBox.Controls.Add(this.DriverJobCostPerHourInput);
            this.OrderConfigurationGroupBox.Controls.Add(this.label1);
            this.OrderConfigurationGroupBox.Controls.Add(this.FuelConsumptionInput);
            this.OrderConfigurationGroupBox.Controls.Add(this.FuelConsumptionLevel);
            this.OrderConfigurationGroupBox.Location = new System.Drawing.Point(255, 225);
            this.OrderConfigurationGroupBox.Name = "OrderConfigurationGroupBox";
            this.OrderConfigurationGroupBox.Size = new System.Drawing.Size(435, 121);
            this.OrderConfigurationGroupBox.TabIndex = 1;
            this.OrderConfigurationGroupBox.TabStop = false;
            this.OrderConfigurationGroupBox.Text = "Конфигурация заказа";
            // 
            // FuelLiterCostInput
            // 
            this.FuelLiterCostInput.Location = new System.Drawing.Point(16, 90);
            this.FuelLiterCostInput.Name = "FuelLiterCostInput";
            this.FuelLiterCostInput.Size = new System.Drawing.Size(140, 20);
            this.FuelLiterCostInput.TabIndex = 5;
            this.FuelLiterCostInput.TextChanged += new System.EventHandler(this.FuelLiterCostInput_TextChanged);
            // 
            // FuelLiterCostLabel
            // 
            this.FuelLiterCostLabel.AutoSize = true;
            this.FuelLiterCostLabel.Location = new System.Drawing.Point(13, 74);
            this.FuelLiterCostLabel.Name = "FuelLiterCostLabel";
            this.FuelLiterCostLabel.Size = new System.Drawing.Size(121, 13);
            this.FuelLiterCostLabel.TabIndex = 4;
            this.FuelLiterCostLabel.Text = "Цена 1 литра топлива:";
            // 
            // DriverJobCostPerHourInput
            // 
            this.DriverJobCostPerHourInput.Location = new System.Drawing.Point(174, 36);
            this.DriverJobCostPerHourInput.Name = "DriverJobCostPerHourInput";
            this.DriverJobCostPerHourInput.Size = new System.Drawing.Size(191, 20);
            this.DriverJobCostPerHourInput.TabIndex = 3;
            this.DriverJobCostPerHourInput.TextChanged += new System.EventHandler(this.DriverJobCostPerHourInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Почасовая оплата одного водителя:";
            // 
            // FuelConsumptionInput
            // 
            this.FuelConsumptionInput.Location = new System.Drawing.Point(13, 37);
            this.FuelConsumptionInput.Name = "FuelConsumptionInput";
            this.FuelConsumptionInput.Size = new System.Drawing.Size(143, 20);
            this.FuelConsumptionInput.TabIndex = 1;
            this.FuelConsumptionInput.TextChanged += new System.EventHandler(this.FuelConsumptionInput_TextChanged);
            // 
            // FuelConsumptionLevel
            // 
            this.FuelConsumptionLevel.AutoSize = true;
            this.FuelConsumptionLevel.Location = new System.Drawing.Point(13, 20);
            this.FuelConsumptionLevel.Name = "FuelConsumptionLevel";
            this.FuelConsumptionLevel.Size = new System.Drawing.Size(143, 13);
            this.FuelConsumptionLevel.TabIndex = 0;
            this.FuelConsumptionLevel.Text = "Расход топлива на 100 км:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(245, 366);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(263, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Расчитать дату прибытия и стоимость заказа";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ValidationErrorsLabel
            // 
            this.ValidationErrorsLabel.AutoSize = true;
            this.ValidationErrorsLabel.ForeColor = System.Drawing.Color.Red;
            this.ValidationErrorsLabel.Location = new System.Drawing.Point(255, 411);
            this.ValidationErrorsLabel.Name = "ValidationErrorsLabel";
            this.ValidationErrorsLabel.Size = new System.Drawing.Size(0, 13);
            this.ValidationErrorsLabel.TabIndex = 3;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.ValidationErrorsLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.OrderConfigurationGroupBox);
            this.Controls.Add(this.OrderFormGroup);
            this.Name = "OrderForm";
            this.Text = "Форма заказа";
            this.OrderFormGroup.ResumeLayout(false);
            this.OrderFormGroup.PerformLayout();
            this.OrderConfigurationGroupBox.ResumeLayout(false);
            this.OrderConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderFormGroup;
        private System.Windows.Forms.Label NumberOfAdultsLabel;
        private System.Windows.Forms.TextBox DistanceInput;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.TextBox WeightOfCargoInput;
        private System.Windows.Forms.Label WeightOfCargoLabel;
        private System.Windows.Forms.TextBox NumberOfChildrenInput;
        private System.Windows.Forms.Label NumberOfChilrenLabel;
        private System.Windows.Forms.TextBox NumberOfAdultsInput;
        private System.Windows.Forms.DateTimePicker StartTimeDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.ComboBox VehicleTypePicker;
        private System.Windows.Forms.GroupBox OrderConfigurationGroupBox;
        private System.Windows.Forms.TextBox DriverJobCostPerHourInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FuelConsumptionInput;
        private System.Windows.Forms.Label FuelConsumptionLevel;
        private System.Windows.Forms.TextBox FuelLiterCostInput;
        private System.Windows.Forms.Label FuelLiterCostLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ValidationErrorsLabel;
    }
}

