namespace FormsApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.classificationBox = new System.Windows.Forms.ComboBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.interactionLabel = new System.Windows.Forms.Label();
            this.assetLabel = new System.Windows.Forms.Label();
            this.machineLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.copyUsernameButton = new System.Windows.Forms.Button();
            this.copyPhoneButton = new System.Windows.Forms.Button();
            this.copyInteractionButton = new System.Windows.Forms.Button();
            this.copyAssetButton = new System.Windows.Forms.Button();
            this.copyMachineButton = new System.Windows.Forms.Button();
            this.copyInfoButton = new System.Windows.Forms.Button();
            this.pingButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.copyClassificationButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.totalCountLabel = new System.Windows.Forms.Label();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.interactionField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.assetField = new System.Windows.Forms.TextBox();
            this.machineField = new System.Windows.Forms.TextBox();
            this.recordNumberLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleField = new System.Windows.Forms.TextBox();
            this.copyTitleButton = new System.Windows.Forms.Button();
            this.copyButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.checklistButton = new System.Windows.Forms.Button();
            this.continuousPingTip = new System.Windows.Forms.ToolTip(this.components);
            this.copyAllTip = new System.Windows.Forms.ToolTip(this.components);
            this.phoneFormatButton = new System.Windows.Forms.Button();
            this.formatPhoneNumberTip = new System.Windows.Forms.ToolTip(this.components);
            this.msraButton = new System.Windows.Forms.Button();
            this.rdcButton = new System.Windows.Forms.Button();
            this.uncButton = new System.Windows.Forms.Button();
            this.msraTip = new System.Windows.Forms.ToolTip(this.components);
            this.rdcTip = new System.Windows.Forms.ToolTip(this.components);
            this.uncTip = new System.Windows.Forms.ToolTip(this.components);
            this.checklistTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(92, 10);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 17);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Username:";
            // 
            // classificationBox
            // 
            this.classificationBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classificationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classificationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classificationBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationBox.FormattingEnabled = true;
            this.classificationBox.Items.AddRange(new object[] {
            "",
            "Unclassified",
            "Unclassified NNPI",
            "Classified",
            "Classified NNPI"});
            this.classificationBox.Location = new System.Drawing.Point(181, 35);
            this.classificationBox.Name = "classificationBox";
            this.classificationBox.Size = new System.Drawing.Size(200, 25);
            this.classificationBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(83, 95);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(98, 17);
            this.phoneLabel.TabIndex = 36;
            this.phoneLabel.Text = "Telephone:";
            // 
            // interactionLabel
            // 
            this.interactionLabel.AutoSize = true;
            this.interactionLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactionLabel.Location = new System.Drawing.Point(65, 67);
            this.interactionLabel.Name = "interactionLabel";
            this.interactionLabel.Size = new System.Drawing.Size(116, 17);
            this.interactionLabel.TabIndex = 35;
            this.interactionLabel.Text = "Interaction:";
            // 
            // assetLabel
            // 
            this.assetLabel.AutoSize = true;
            this.assetLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetLabel.Location = new System.Drawing.Point(119, 124);
            this.assetLabel.Name = "assetLabel";
            this.assetLabel.Size = new System.Drawing.Size(62, 17);
            this.assetLabel.TabIndex = 37;
            this.assetLabel.Text = "Asset:";
            // 
            // machineLabel
            // 
            this.machineLabel.AutoSize = true;
            this.machineLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineLabel.Location = new System.Drawing.Point(101, 150);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(80, 17);
            this.machineLabel.TabIndex = 38;
            this.machineLabel.Text = "Machine:";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.Location = new System.Drawing.Point(38, 38);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(143, 17);
            this.classificationLabel.TabIndex = 34;
            this.classificationLabel.Text = "Classification:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(19, 268);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(107, 17);
            this.descriptionLabel.TabIndex = 40;
            this.descriptionLabel.Text = "Description";
            // 
            // copyAllButton
            // 
            this.copyAllButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyAllButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAllButton.Location = new System.Drawing.Point(203, 872);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(259, 28);
            this.copyAllButton.TabIndex = 8;
            this.copyAllButton.Text = "Send All to Clipboard";
            this.copyAllTip.SetToolTip(this.copyAllButton, "Send All Information on this Record to Clipboard.\r\nIt does not include the Title." +
        " Copy the Title separately.");
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.copyAllButton_Click);
            // 
            // copyUsernameButton
            // 
            this.copyUsernameButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyUsernameButton.Location = new System.Drawing.Point(385, 7);
            this.copyUsernameButton.Name = "copyUsernameButton";
            this.copyUsernameButton.Size = new System.Drawing.Size(22, 22);
            this.copyUsernameButton.TabIndex = 9;
            this.copyUsernameButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyUsernameButton, "Send to Clipboard");
            this.copyUsernameButton.UseVisualStyleBackColor = true;
            this.copyUsernameButton.Click += new System.EventHandler(this.copyUsernameButton_Click);
            // 
            // copyPhoneButton
            // 
            this.copyPhoneButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPhoneButton.Location = new System.Drawing.Point(385, 95);
            this.copyPhoneButton.Name = "copyPhoneButton";
            this.copyPhoneButton.Size = new System.Drawing.Size(22, 22);
            this.copyPhoneButton.TabIndex = 12;
            this.copyPhoneButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyPhoneButton, "Send to Clipboard");
            this.copyPhoneButton.UseVisualStyleBackColor = true;
            this.copyPhoneButton.Click += new System.EventHandler(this.copyPhoneButton_Click);
            // 
            // copyInteractionButton
            // 
            this.copyInteractionButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyInteractionButton.Location = new System.Drawing.Point(385, 67);
            this.copyInteractionButton.Name = "copyInteractionButton";
            this.copyInteractionButton.Size = new System.Drawing.Size(22, 22);
            this.copyInteractionButton.TabIndex = 11;
            this.copyInteractionButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyInteractionButton, "Send to Clipboard");
            this.copyInteractionButton.UseVisualStyleBackColor = true;
            this.copyInteractionButton.Click += new System.EventHandler(this.copyInteractionButton_Click);
            // 
            // copyAssetButton
            // 
            this.copyAssetButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAssetButton.Location = new System.Drawing.Point(385, 123);
            this.copyAssetButton.Name = "copyAssetButton";
            this.copyAssetButton.Size = new System.Drawing.Size(22, 22);
            this.copyAssetButton.TabIndex = 13;
            this.copyAssetButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyAssetButton, "Send to Clipboard");
            this.copyAssetButton.UseVisualStyleBackColor = true;
            this.copyAssetButton.Click += new System.EventHandler(this.copyAssetButton_Click);
            // 
            // copyMachineButton
            // 
            this.copyMachineButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyMachineButton.Location = new System.Drawing.Point(385, 151);
            this.copyMachineButton.Name = "copyMachineButton";
            this.copyMachineButton.Size = new System.Drawing.Size(22, 22);
            this.copyMachineButton.TabIndex = 14;
            this.copyMachineButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyMachineButton, "Send to Clipboard");
            this.copyMachineButton.UseVisualStyleBackColor = true;
            this.copyMachineButton.Click += new System.EventHandler(this.copyMachineButton_Click);
            // 
            // copyInfoButton
            // 
            this.copyInfoButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyInfoButton.Location = new System.Drawing.Point(142, 268);
            this.copyInfoButton.Name = "copyInfoButton";
            this.copyInfoButton.Size = new System.Drawing.Size(22, 22);
            this.copyInfoButton.TabIndex = 16;
            this.copyInfoButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyInfoButton, "Send to Clipboard");
            this.copyInfoButton.UseVisualStyleBackColor = true;
            this.copyInfoButton.Click += new System.EventHandler(this.copyInfoButton_Click);
            // 
            // pingButton
            // 
            this.pingButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingButton.Location = new System.Drawing.Point(206, 179);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(22, 22);
            this.pingButton.TabIndex = 18;
            this.pingButton.Text = "P";
            this.continuousPingTip.SetToolTip(this.pingButton, "Click to Continuously Ping this Machine or IP Address");
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(485, 64);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(146, 30);
            this.newButton.TabIndex = 26;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(485, 101);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 30);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // descriptionField
            // 
            this.descriptionField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionField.Location = new System.Drawing.Point(23, 295);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionField.Size = new System.Drawing.Size(634, 560);
            this.descriptionField.TabIndex = 7;
            this.descriptionField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descriptionField_KeyDown);
            // 
            // copyClassificationButton
            // 
            this.copyClassificationButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyClassificationButton.Location = new System.Drawing.Point(385, 38);
            this.copyClassificationButton.Name = "copyClassificationButton";
            this.copyClassificationButton.Size = new System.Drawing.Size(22, 22);
            this.copyClassificationButton.TabIndex = 10;
            this.copyClassificationButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyClassificationButton, "Send to Clipboard");
            this.copyClassificationButton.UseVisualStyleBackColor = true;
            this.copyClassificationButton.Click += new System.EventHandler(this.copyClassificationButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(485, 139);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 30);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevButton.Location = new System.Drawing.Point(485, 11);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(35, 35);
            this.prevButton.TabIndex = 23;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(596, 11);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(35, 35);
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Location = new System.Drawing.Point(566, 22);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(13, 13);
            this.totalCountLabel.TabIndex = 31;
            this.totalCountLabel.Text = "1";
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(527, 19);
            this.indexBox.MaxLength = 4;
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(30, 20);
            this.indexBox.TabIndex = 29;
            this.indexBox.Text = "1";
            this.indexBox.TextChanged += new System.EventHandler(this.indexBox_TextChanged);
            this.indexBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.indexBox_KeyDown);
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(181, 7);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(200, 24);
            this.usernameField.TabIndex = 0;
            // 
            // interactionField
            // 
            this.interactionField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.interactionField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactionField.Location = new System.Drawing.Point(181, 64);
            this.interactionField.Name = "interactionField";
            this.interactionField.Size = new System.Drawing.Size(200, 24);
            this.interactionField.TabIndex = 2;
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneField.Location = new System.Drawing.Point(181, 92);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(200, 24);
            this.phoneField.TabIndex = 3;
            // 
            // assetField
            // 
            this.assetField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetField.Location = new System.Drawing.Point(181, 121);
            this.assetField.Name = "assetField";
            this.assetField.Size = new System.Drawing.Size(200, 24);
            this.assetField.TabIndex = 4;
            // 
            // machineField
            // 
            this.machineField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.machineField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineField.Location = new System.Drawing.Point(181, 149);
            this.machineField.Name = "machineField";
            this.machineField.Size = new System.Drawing.Size(200, 24);
            this.machineField.TabIndex = 5;
            // 
            // recordNumberLabel
            // 
            this.recordNumberLabel.AutoSize = true;
            this.recordNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordNumberLabel.Location = new System.Drawing.Point(2, 2);
            this.recordNumberLabel.Name = "recordNumberLabel";
            this.recordNumberLabel.Size = new System.Drawing.Size(27, 20);
            this.recordNumberLabel.TabIndex = 32;
            this.recordNumberLabel.Text = "#1";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(557, 22);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 13);
            this.slashLabel.TabIndex = 30;
            this.slashLabel.Text = "/";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 224);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 17);
            this.titleLabel.TabIndex = 39;
            this.titleLabel.Text = "Title";
            // 
            // titleField
            // 
            this.titleField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleField.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleField.Location = new System.Drawing.Point(109, 221);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(539, 24);
            this.titleField.TabIndex = 6;
            this.titleField.Enter += new System.EventHandler(this.titleField_Enter);
            // 
            // copyTitleButton
            // 
            this.copyTitleButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyTitleButton.Location = new System.Drawing.Point(79, 221);
            this.copyTitleButton.Name = "copyTitleButton";
            this.copyTitleButton.Size = new System.Drawing.Size(22, 22);
            this.copyTitleButton.TabIndex = 15;
            this.copyTitleButton.Text = "C";
            this.copyButtonTip.SetToolTip(this.copyTitleButton, "Send to Clipboard");
            this.copyTitleButton.UseVisualStyleBackColor = true;
            this.copyTitleButton.Click += new System.EventHandler(this.copyTitleButton_Click);
            // 
            // copyButtonTip
            // 
            this.copyButtonTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.copyButtonTip.ToolTipTitle = "Copy this Text Field";
            // 
            // checklistButton
            // 
            this.checklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checklistButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklistButton.Location = new System.Drawing.Point(622, 268);
            this.checklistButton.Name = "checklistButton";
            this.checklistButton.Size = new System.Drawing.Size(35, 22);
            this.checklistButton.TabIndex = 22;
            this.checklistButton.Text = "CL";
            this.copyButtonTip.SetToolTip(this.checklistButton, "Send to Clipboard");
            this.checklistTip.SetToolTip(this.checklistButton, "Add and Manage Checklists");
            this.checklistButton.UseVisualStyleBackColor = true;
            this.checklistButton.Click += new System.EventHandler(this.checklistButton_Click);
            // 
            // continuousPingTip
            // 
            this.continuousPingTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.continuousPingTip.ToolTipTitle = "Continous Ping";
            // 
            // copyAllTip
            // 
            this.copyAllTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.copyAllTip.ToolTipTitle = "Copy All Information";
            // 
            // phoneFormatButton
            // 
            this.phoneFormatButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFormatButton.Location = new System.Drawing.Point(413, 95);
            this.phoneFormatButton.Name = "phoneFormatButton";
            this.phoneFormatButton.Size = new System.Drawing.Size(22, 22);
            this.phoneFormatButton.TabIndex = 17;
            this.phoneFormatButton.Text = "F";
            this.formatPhoneNumberTip.SetToolTip(this.phoneFormatButton, "Add Parentheses and a Dash.\r\n(xxx)xxx-xxxx");
            this.phoneFormatButton.UseVisualStyleBackColor = true;
            this.phoneFormatButton.Click += new System.EventHandler(this.phoneFormatButton_Click);
            // 
            // formatPhoneNumberTip
            // 
            this.formatPhoneNumberTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.formatPhoneNumberTip.ToolTipTitle = "Format Telephone Number";
            // 
            // msraButton
            // 
            this.msraButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msraButton.Location = new System.Drawing.Point(247, 179);
            this.msraButton.Name = "msraButton";
            this.msraButton.Size = new System.Drawing.Size(22, 22);
            this.msraButton.TabIndex = 19;
            this.msraButton.Text = "M";
            this.msraTip.SetToolTip(this.msraButton, "This application must run as Administrator to perform this action\r\nConnect to the" +
        " machine or IP address with MSRA");
            this.msraButton.UseVisualStyleBackColor = true;
            this.msraButton.Click += new System.EventHandler(this.msraButton_Click);
            // 
            // rdcButton
            // 
            this.rdcButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcButton.Location = new System.Drawing.Point(290, 179);
            this.rdcButton.Name = "rdcButton";
            this.rdcButton.Size = new System.Drawing.Size(22, 22);
            this.rdcButton.TabIndex = 20;
            this.rdcButton.Text = "R";
            this.rdcTip.SetToolTip(this.rdcButton, "Connect to the machine or IP address with RDC");
            this.rdcButton.UseVisualStyleBackColor = true;
            this.rdcButton.Click += new System.EventHandler(this.rdcButton_Click);
            // 
            // uncButton
            // 
            this.uncButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uncButton.Location = new System.Drawing.Point(332, 179);
            this.uncButton.Name = "uncButton";
            this.uncButton.Size = new System.Drawing.Size(22, 22);
            this.uncButton.TabIndex = 21;
            this.uncButton.Text = "U";
            this.uncTip.SetToolTip(this.uncButton, "This application must run as Administrator to perform this action\r\nConnect to mac" +
        "hine or IP address with UNC. The drive will be mapped\r\nto Z:");
            this.uncButton.UseVisualStyleBackColor = true;
            this.uncButton.Click += new System.EventHandler(this.uncButton_Click);
            // 
            // msraTip
            // 
            this.msraTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.msraTip.ToolTipTitle = "Connect to Host with Microsoft Remote Assistance";
            // 
            // rdcTip
            // 
            this.rdcTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.rdcTip.ToolTipTitle = "Connect to Host with Remote Desktop Connection";
            // 
            // uncTip
            // 
            this.uncTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.uncTip.ToolTipTitle = "Connect to Host with Universal Naming Convention";
            // 
            // checklistTip
            // 
            this.checklistTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.checklistTip.ToolTipTitle = "Click here to add a Checklist";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(674, 912);
            this.Controls.Add(this.uncButton);
            this.Controls.Add(this.rdcButton);
            this.Controls.Add(this.msraButton);
            this.Controls.Add(this.checklistButton);
            this.Controls.Add(this.phoneFormatButton);
            this.Controls.Add(this.copyTitleButton);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.recordNumberLabel);
            this.Controls.Add(this.machineField);
            this.Controls.Add(this.assetField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.interactionField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.totalCountLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.copyClassificationButton);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.copyInfoButton);
            this.Controls.Add(this.copyMachineButton);
            this.Controls.Add(this.copyAssetButton);
            this.Controls.Add(this.copyInteractionButton);
            this.Controls.Add(this.copyPhoneButton);
            this.Controls.Add(this.copyUsernameButton);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.machineLabel);
            this.Controls.Add(this.assetLabel);
            this.Controls.Add(this.interactionLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.classificationBox);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 100);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ComboBox classificationBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label interactionLabel;
        private System.Windows.Forms.Label assetLabel;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button copyUsernameButton;
        private System.Windows.Forms.Button copyPhoneButton;
        private System.Windows.Forms.Button copyInteractionButton;
        private System.Windows.Forms.Button copyAssetButton;
        private System.Windows.Forms.Button copyMachineButton;
        private System.Windows.Forms.Button copyInfoButton;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Button copyClassificationButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox interactionField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox assetField;
        private System.Windows.Forms.TextBox machineField;
        private System.Windows.Forms.Label recordNumberLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.Button copyTitleButton;
        private System.Windows.Forms.ToolTip copyButtonTip;
        private System.Windows.Forms.ToolTip continuousPingTip;
        private System.Windows.Forms.ToolTip copyAllTip;
        private System.Windows.Forms.Button phoneFormatButton;
        private System.Windows.Forms.ToolTip formatPhoneNumberTip;
        private System.Windows.Forms.Button checklistButton;
        private System.Windows.Forms.Button msraButton;
        private System.Windows.Forms.Button rdcButton;
        private System.Windows.Forms.Button uncButton;
        private System.Windows.Forms.ToolTip msraTip;
        private System.Windows.Forms.ToolTip rdcTip;
        private System.Windows.Forms.ToolTip uncTip;
        private System.Windows.Forms.ToolTip checklistTip;
    }
}

