namespace Iti.Pl
{
    partial class TopicForm
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
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            txt_name = new TextBox();
            label2 = new Label();
            dgv_topic = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_topic).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.AllowDrop = true;
            btn_update.Location = new Point(245, 115);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(89, 31);
            btn_update.TabIndex = 13;
            btn_update.Text = "UPdate";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(429, 115);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(89, 31);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(93, 115);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(89, 31);
            btn_add.TabIndex = 11;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(125, 48);
            txt_name.Margin = new Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 27);
            txt_name.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // dgv_topic
            // 
            dgv_topic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topic.Location = new Point(14, 153);
            dgv_topic.Margin = new Padding(3, 4, 3, 4);
            dgv_topic.Name = "dgv_topic";
            dgv_topic.RowHeadersWidth = 51;
            dgv_topic.RowTemplate.Height = 25;
            dgv_topic.Size = new Size(792, 295);
            dgv_topic.TabIndex = 8;
            dgv_topic.RowHeaderMouseDoubleClick += dgv_topic_RowHeaderMouseDoubleClick;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(dgv_topic);
            Name = "TopicForm";
            Text = "FormTopic";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_topic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btn_update;
        public Button btn_delete;
        public Button btn_add;
        private TextBox txt_name;
        private Label label2;
        private DataGridView dgv_topic;
    }
}