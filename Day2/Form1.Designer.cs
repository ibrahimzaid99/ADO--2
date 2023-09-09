namespace Day2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_topic = new DataGridView();
            label2 = new Label();
            txt_name = new TextBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_topic).BeginInit();
            SuspendLayout();
            // 
            // dgv_topic
            // 
            dgv_topic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topic.ImeMode = ImeMode.On;
            dgv_topic.Location = new Point(5, 217);
            dgv_topic.Name = "dgv_topic";
            dgv_topic.RowTemplate.Height = 25;
            dgv_topic.Size = new Size(796, 221);
            dgv_topic.TabIndex = 0;
            dgv_topic.MouseDoubleClick += dgv_topic_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(170, 73);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(128, 172);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(108, 23);
            btn_add.TabIndex = 4;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(422, 172);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(108, 23);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.AllowDrop = true;
            btn_update.Location = new Point(260, 172);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(108, 23);
            btn_update.TabIndex = 6;
            btn_update.Text = "UPdate";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(658, 172);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(108, 23);
            btn_save.TabIndex = 7;
            btn_save.Text = "Savechanges";
            btn_save.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(dgv_topic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_topic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_topic;
        private Label label2;
        private TextBox txt_name;
        public Button btn_add;
        public Button btn_delete;
        public Button btn_update;
        public Button btn_save;
    }
}